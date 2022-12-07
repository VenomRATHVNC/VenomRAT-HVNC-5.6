using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Server.Handle_Packet;

namespace Server.Connection
{
	// Token: 0x02000033 RID: 51
	internal class Listener
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002DF0 File Offset: 0x00000FF0
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002DF8 File Offset: 0x00000FF8
		private Socket Server { get; set; }

		// Token: 0x060001F5 RID: 501 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
		public void Connect(object port)
		{
			try
			{
				IPEndPoint localEP = new IPEndPoint(IPAddress.Any, Convert.ToInt32(port));
				this.Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
				{
					SendBufferSize = 51200,
					ReceiveBufferSize = 51200
				};
				this.Server.Bind(localEP);
				this.Server.Listen(500);
				new HandleLogs().Addmsg(string.Format("Listenning to: {0}", port), Color.Green);
				this.Server.BeginAccept(new AsyncCallback(this.EndAccept), null);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(0);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0001ED68 File Offset: 0x0001CF68
		private void EndAccept(IAsyncResult ar)
		{
			try
			{
				new Clients(this.Server.EndAccept(ar));
			}
			catch
			{
			}
			finally
			{
				this.Server.BeginAccept(new AsyncCallback(this.EndAccept), null);
			}
		}
	}
}
