using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Net.Sockets;
using System.Windows.Forms;
using Server.Connection;
using Server.Helper;
using Server.Properties;

namespace Quasar.Server.Forms
{
	// Token: 0x02000024 RID: 36
	public partial class FrmReverseProxy : Form
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00002A1E File Offset: 0x00000C1E
		public FrmReverseProxy(Clients[] clients)
		{
			this._clients = clients;
			this.RegisterMessageHandler();
			this.InitializeComponent();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000024F0 File Offset: 0x000006F0
		private void RegisterMessageHandler()
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000024F0 File Offset: 0x000006F0
		private void UnregisterMessageHandler()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002A39 File Offset: 0x00000C39
		private void ClientDisconnected(Clients client, bool connected)
		{
			if (!connected)
			{
				base.Invoke(new MethodInvoker(base.Close));
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		private void FrmReverseProxy_Load(object sender, EventArgs e)
		{
			if (this._clients.Length > 1)
			{
				this.Text = "Reverse Proxy [Load-Balancer is active]";
				this.lblLoadBalance.Text = "The Load Balancer is active, " + this._clients.Length.ToString() + " clients will be used as proxy\r\nKeep refreshing at www.ipchicken.com to see if your ip address will keep changing, if so, it works";
			}
			else if (this._clients.Length == 1)
			{
				this.lblLoadBalance.Text = "The Load Balancer is not active, only 1 client is used, select multiple clients to activate the load balancer";
			}
			this.nudServerPort.Value = Settings.Default.ReverseProxyPort;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002A51 File Offset: 0x00000C51
		private void FrmReverseProxy_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.ReverseProxyPort = this.GetPortSafe();
			this.UnregisterMessageHandler();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000024F0 File Offset: 0x000006F0
		private void ConnectionChanged(object sender, ReverseProxyClient[] proxyClients)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00010E34 File Offset: 0x0000F034
		private void btnStart_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.GetPortSafe() == 0)
				{
					MessageBox.Show("Please enter a valid port > 0.", "Please enter a valid port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					this.ToggleConfigurationButtons(true);
				}
			}
			catch (SocketException ex)
			{
				if (ex.ErrorCode == 10048)
				{
					MessageBox.Show("The port is already in use.", "Listen Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					MessageBox.Show(string.Format("An unexpected socket error occurred: {0}\n\nError Code: {1}", ex.Message, ex.ErrorCode), "Unexpected Listen Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("An unexpected error occurred: " + ex2.Message, "Unexpected Listen Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00010EF4 File Offset: 0x0000F0F4
		private ushort GetPortSafe()
		{
			ushort result;
			if (ushort.TryParse(this.nudServerPort.Value.ToString(CultureInfo.InvariantCulture), out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002A6E File Offset: 0x00000C6E
		private void ToggleConfigurationButtons(bool started)
		{
			this.btnStart.Enabled = !started;
			this.nudServerPort.Enabled = !started;
			this.btnStop.Enabled = started;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002A9A File Offset: 0x00000C9A
		private void btnStop_Click(object sender, EventArgs e)
		{
			this.ToggleConfigurationButtons(false);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002AA3 File Offset: 0x00000CA3
		private void nudServerPort_ValueChanged(object sender, EventArgs e)
		{
			this.lblProxyInfo.Text = string.Format("Connect to this SOCKS5 Proxy: 127.0.0.1:{0} (no user/pass)", this.nudServerPort.Value);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000024F0 File Offset: 0x000006F0
		private void LvConnections_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00010F28 File Offset: 0x0000F128
		public static string GetHumanReadableFileSize(long size)
		{
			double num = (double)size;
			int num2 = 0;
			while (num >= 1024.0 && num2 + 1 < FrmReverseProxy.Sizes.Length)
			{
				num2++;
				num /= 1024.0;
			}
			return string.Format("{0:0.##} {1}", num, FrmReverseProxy.Sizes[num2]);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000024F0 File Offset: 0x000006F0
		private void killConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040000D9 RID: 217
		private readonly Clients[] _clients;

		// Token: 0x040000DA RID: 218
		private ReverseProxyClient[] _openConnections;

		// Token: 0x040000DB RID: 219
		private static readonly string[] Sizes = new string[]
		{
			"B",
			"KB",
			"MB",
			"GB",
			"TB",
			"PB"
		};
	}
}
