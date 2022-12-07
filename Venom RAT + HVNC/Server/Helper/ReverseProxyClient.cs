using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Server.Connection;

namespace Server.Helper
{
	// Token: 0x0200005E RID: 94
	public class ReverseProxyClient
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000039C9 File Offset: 0x00001BC9
		// (set) Token: 0x0600030F RID: 783 RVA: 0x000039D1 File Offset: 0x00001BD1
		public Socket Handle { get; private set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000039DA File Offset: 0x00001BDA
		// (set) Token: 0x06000311 RID: 785 RVA: 0x000039E2 File Offset: 0x00001BE2
		public Clients Client { get; private set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000039EB File Offset: 0x00001BEB
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000039F3 File Offset: 0x00001BF3
		public long PacketsReceived { get; private set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000039FC File Offset: 0x00001BFC
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00003A04 File Offset: 0x00001C04
		public long PacketsSended { get; private set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00003A0D File Offset: 0x00001C0D
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00003A15 File Offset: 0x00001C15
		public long LengthReceived { get; private set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00003A1E File Offset: 0x00001C1E
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00003A26 File Offset: 0x00001C26
		public long LengthSent { get; private set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00021A84 File Offset: 0x0001FC84
		public int ConnectionId
		{
			get
			{
				return this.Handle.Handle.ToInt32();
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00003A2F File Offset: 0x00001C2F
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00003A37 File Offset: 0x00001C37
		public string TargetServer { get; private set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00003A40 File Offset: 0x00001C40
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003A48 File Offset: 0x00001C48
		public ushort TargetPort { get; private set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00003A51 File Offset: 0x00001C51
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00003A59 File Offset: 0x00001C59
		public bool IsConnected { get; private set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00003A62 File Offset: 0x00001C62
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00003A6A File Offset: 0x00001C6A
		public ReverseProxyClient.ProxyType Type { get; private set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00003A73 File Offset: 0x00001C73
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00003A7B File Offset: 0x00001C7B
		public string HostName { get; private set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00003A84 File Offset: 0x00001C84
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00003A8C File Offset: 0x00001C8C
		public bool ProxySuccessful { get; private set; }

		// Token: 0x06000327 RID: 807 RVA: 0x00021AA4 File Offset: 0x0001FCA4
		public ReverseProxyClient(Clients client, Socket socket, ReverseProxyServer server)
		{
			this.Handle = socket;
			this.Client = client;
			this._handshakeStream = new MemoryStream();
			this._buffer = new byte[8192];
			this.IsConnected = true;
			this.TargetServer = "";
			this.Type = ReverseProxyClient.ProxyType.Unknown;
			this.Server = server;
			try
			{
				socket.BeginReceive(this._buffer, 0, this._buffer.Length, SocketFlags.None, new AsyncCallback(this.AsyncReceive), null);
			}
			catch
			{
				this.Disconnect();
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00021B40 File Offset: 0x0001FD40
		private void AsyncReceive(IAsyncResult ar)
		{
			try
			{
				int num = this.Handle.EndReceive(ar);
				if (num <= 0)
				{
					this.Disconnect();
					return;
				}
				if (num > 5000 || this._handshakeStream.Length + (long)num > 5000L)
				{
					this.Disconnect();
					return;
				}
				this.LengthReceived += (long)num;
				this._handshakeStream.Write(this._buffer, 0, num);
			}
			catch
			{
				this.Disconnect();
				return;
			}
			byte[] array = this._handshakeStream.ToArray();
			long packetsReceived = this.PacketsReceived;
			if (packetsReceived != 0L)
			{
				if (packetsReceived == 1L)
				{
					int num2 = 6;
					if (array.Length >= num2)
					{
						if (!this.CheckProxyVersion(array))
						{
							return;
						}
						this._isConnectCommand = (array[1] == 1);
						this._isBindCommand = (array[1] == 2);
						this._isUdpCommand = (array[1] == 3);
						this._isIpType = (array[3] == 1);
						this._isDomainNameType = (array[3] == 3);
						this._isIPv6NameType = (array[3] == 4);
						Array.Reverse(array, array.Length - 2, 2);
						this.TargetPort = BitConverter.ToUInt16(array, array.Length - 2);
						if (this._isConnectCommand)
						{
							if (this._isIpType)
							{
								this.TargetServer = string.Concat(new string[]
								{
									array[4].ToString(),
									".",
									array[5].ToString(),
									".",
									array[6].ToString(),
									".",
									array[7].ToString()
								});
							}
							else if (this._isDomainNameType)
							{
								int num3 = (int)array[4];
								if (num2 + num3 < array.Length)
								{
									this.TargetServer = Encoding.ASCII.GetString(array, 5, num3);
								}
							}
							if (this.TargetServer.Length > 0)
							{
							}
							this.Server.CallonUpdateConnection(this);
							return;
						}
						this.SendFailToClient();
						return;
					}
				}
			}
			else if (array.Length >= 3)
			{
				string @string = Encoding.ASCII.GetString(array);
				if (array[0] == 5)
				{
					this.Type = ReverseProxyClient.ProxyType.SOCKS5;
				}
				else
				{
					if (!@string.StartsWith("CONNECT") || !@string.Contains(":"))
					{
						goto IL_31F;
					}
					this.Type = ReverseProxyClient.ProxyType.HTTPS;
					using (StreamReader streamReader = new StreamReader(new MemoryStream(array)))
					{
						string text = streamReader.ReadLine();
						if (text == null)
						{
							goto IL_31F;
						}
						string[] array2 = text.Split(new string[]
						{
							" "
						}, StringSplitOptions.RemoveEmptyEntries);
						if (array2.Length != 0)
						{
							try
							{
								string text2 = array2[1];
								this.TargetServer = text2.Split(new char[]
								{
									':'
								})[0];
								this.TargetPort = ushort.Parse(text2.Split(new char[]
								{
									':'
								})[1]);
								this._isConnectCommand = true;
								this._isDomainNameType = true;
								this.Server.CallonConnectionEstablished(this);
								return;
							}
							catch
							{
								this.Disconnect();
							}
						}
					}
				}
				if (this.CheckProxyVersion(array))
				{
					this.SendSuccessToClient();
					long packetsReceived2 = this.PacketsReceived;
					this.PacketsReceived = packetsReceived2 + 1L;
					this._handshakeStream.SetLength(0L);
					this.Server.CallonConnectionEstablished(this);
				}
			}
			IL_31F:
			try
			{
				this.Handle.BeginReceive(this._buffer, 0, this._buffer.Length, SocketFlags.None, new AsyncCallback(this.AsyncReceive), null);
			}
			catch
			{
				this.Disconnect();
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00021ED8 File Offset: 0x000200D8
		public void Disconnect()
		{
			if (!this._disconnectIsSend)
			{
				this._disconnectIsSend = true;
			}
			try
			{
				this.Handle.Close();
			}
			catch
			{
			}
			this.IsConnected = false;
			this.Server.CallonUpdateConnection(this);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00021F28 File Offset: 0x00020128
		public void SendToClient(byte[] payload)
		{
			Socket handle = this.Handle;
			lock (handle)
			{
				try
				{
					this.LengthSent += (long)payload.Length;
					this.Handle.Send(payload);
				}
				catch
				{
					this.Disconnect();
				}
			}
			this.Server.CallonUpdateConnection(this);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00003A95 File Offset: 0x00001C95
		private void SendFailToClient()
		{
			if (this.Type == ReverseProxyClient.ProxyType.HTTPS)
			{
				this.Disconnect();
			}
			if (this.Type == ReverseProxyClient.ProxyType.SOCKS5)
			{
				this.SendToClient(new byte[]
				{
					5,
					byte.MaxValue
				});
				this.Disconnect();
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003ACD File Offset: 0x00001CCD
		private void SendSuccessToClient()
		{
			if (this.Type == ReverseProxyClient.ProxyType.SOCKS5)
			{
				byte[] array = new byte[2];
				array[0] = 5;
				this.SendToClient(array);
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003AE8 File Offset: 0x00001CE8
		private bool CheckProxyVersion(byte[] payload)
		{
			if (this.Type == ReverseProxyClient.ProxyType.HTTPS)
			{
				return true;
			}
			if (payload.Length != 0 && payload[0] != 5)
			{
				this.SendFailToClient();
				this.Disconnect();
				return false;
			}
			return true;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00021FA4 File Offset: 0x000201A4
		private void AsyncReceiveProxy(IAsyncResult ar)
		{
			long num2;
			try
			{
				int num = this.Handle.EndReceive(ar);
				if (num <= 0)
				{
					this.Disconnect();
					return;
				}
				this.LengthReceived += (long)num;
				byte[] array = new byte[num];
				Array.Copy(this._buffer, array, num);
				this.LengthSent += (long)array.Length;
				num2 = this.PacketsSended;
				this.PacketsSended = num2 + 1L;
			}
			catch
			{
				this.Disconnect();
				return;
			}
			num2 = this.PacketsReceived;
			this.PacketsReceived = num2 + 1L;
			this.Server.CallonUpdateConnection(this);
			try
			{
				this.Handle.BeginReceive(this._buffer, 0, this._buffer.Length, SocketFlags.None, new AsyncCallback(this.AsyncReceiveProxy), null);
			}
			catch
			{
			}
		}

		// Token: 0x04000256 RID: 598
		public const int SOCKS5_DEFAULT_PORT = 3218;

		// Token: 0x04000257 RID: 599
		public const byte SOCKS5_VERSION_NUMBER = 5;

		// Token: 0x04000258 RID: 600
		public const byte SOCKS5_RESERVED = 0;

		// Token: 0x04000259 RID: 601
		public const byte SOCKS5_AUTH_NUMBER_OF_AUTH_METHODS_SUPPORTED = 2;

		// Token: 0x0400025A RID: 602
		public const byte SOCKS5_AUTH_METHOD_NO_AUTHENTICATION_REQUIRED = 0;

		// Token: 0x0400025B RID: 603
		public const byte SOCKS5_AUTH_METHOD_GSSAPI = 1;

		// Token: 0x0400025C RID: 604
		public const byte SOCKS5_AUTH_METHOD_USERNAME_PASSWORD = 2;

		// Token: 0x0400025D RID: 605
		public const byte SOCKS5_AUTH_METHOD_IANA_ASSIGNED_RANGE_BEGIN = 3;

		// Token: 0x0400025E RID: 606
		public const byte SOCKS5_AUTH_METHOD_IANA_ASSIGNED_RANGE_END = 127;

		// Token: 0x0400025F RID: 607
		public const byte SOCKS5_AUTH_METHOD_RESERVED_RANGE_BEGIN = 128;

		// Token: 0x04000260 RID: 608
		public const byte SOCKS5_AUTH_METHOD_RESERVED_RANGE_END = 254;

		// Token: 0x04000261 RID: 609
		public const byte SOCKS5_AUTH_METHOD_REPLY_NO_ACCEPTABLE_METHODS = 255;

		// Token: 0x04000262 RID: 610
		public const byte SOCKS5_CMD_REPLY_SUCCEEDED = 0;

		// Token: 0x04000263 RID: 611
		public const byte SOCKS5_CMD_REPLY_GENERAL_SOCKS_SERVER_FAILURE = 1;

		// Token: 0x04000264 RID: 612
		public const byte SOCKS5_CMD_REPLY_CONNECTION_NOT_ALLOWED_BY_RULESET = 2;

		// Token: 0x04000265 RID: 613
		public const byte SOCKS5_CMD_REPLY_NETWORK_UNREACHABLE = 3;

		// Token: 0x04000266 RID: 614
		public const byte SOCKS5_CMD_REPLY_HOST_UNREACHABLE = 4;

		// Token: 0x04000267 RID: 615
		public const byte SOCKS5_CMD_REPLY_CONNECTION_REFUSED = 5;

		// Token: 0x04000268 RID: 616
		public const byte SOCKS5_CMD_REPLY_TTL_EXPIRED = 6;

		// Token: 0x04000269 RID: 617
		public const byte SOCKS5_CMD_REPLY_COMMAND_NOT_SUPPORTED = 7;

		// Token: 0x0400026A RID: 618
		public const byte SOCKS5_CMD_REPLY_ADDRESS_TYPE_NOT_SUPPORTED = 8;

		// Token: 0x0400026B RID: 619
		public const byte SOCKS5_ADDRTYPE_IPV4 = 1;

		// Token: 0x0400026C RID: 620
		public const byte SOCKS5_ADDRTYPE_DOMAIN_NAME = 3;

		// Token: 0x0400026D RID: 621
		public const byte SOCKS5_ADDRTYPE_IPV6 = 4;

		// Token: 0x0400026E RID: 622
		public const int BUFFER_SIZE = 8192;

		// Token: 0x04000271 RID: 625
		private bool _receivedConnResponse;

		// Token: 0x04000272 RID: 626
		private MemoryStream _handshakeStream;

		// Token: 0x04000277 RID: 631
		private byte[] _buffer;

		// Token: 0x0400027B RID: 635
		private bool _isBindCommand;

		// Token: 0x0400027C RID: 636
		private bool _isUdpCommand;

		// Token: 0x0400027D RID: 637
		private bool _isConnectCommand;

		// Token: 0x0400027E RID: 638
		private bool _isIpType;

		// Token: 0x0400027F RID: 639
		private bool _isIPv6NameType;

		// Token: 0x04000280 RID: 640
		private bool _isDomainNameType;

		// Token: 0x04000281 RID: 641
		private bool _disconnectIsSend;

		// Token: 0x04000283 RID: 643
		private ReverseProxyServer Server;

		// Token: 0x0200005F RID: 95
		public enum ProxyType
		{
			// Token: 0x04000287 RID: 647
			Unknown,
			// Token: 0x04000288 RID: 648
			SOCKS5,
			// Token: 0x04000289 RID: 649
			HTTPS
		}
	}
}
