using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x020000A4 RID: 164
	public partial class FormProcessManager : Form
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00004A91 File Offset: 0x00002C91
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00004A99 File Offset: 0x00002C99
		public FormMain F { get; set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00004AA2 File Offset: 0x00002CA2
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00004AAA File Offset: 0x00002CAA
		internal Clients Client { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00004AB3 File Offset: 0x00002CB3
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00004ABB File Offset: 0x00002CBB
		internal Clients ParentClient { get; set; }

		// Token: 0x06000513 RID: 1299 RVA: 0x00004AC4 File Offset: 0x00002CC4
		public FormProcessManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0004335C File Offset: 0x0004155C
		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.Client.TcpClient.Connected || !this.ParentClient.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000433B0 File Offset: 0x000415B0
		private void killToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormProcessManager.<killToolStripMenuItem_Click>d__14 <killToolStripMenuItem_Click>d__;
			<killToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<killToolStripMenuItem_Click>d__.<>4__this = this;
			<killToolStripMenuItem_Click>d__.<>1__state = -1;
			<killToolStripMenuItem_Click>d__.<>t__builder.Start<FormProcessManager.<killToolStripMenuItem_Click>d__14>(ref <killToolStripMenuItem_Click>d__);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00004AD2 File Offset: 0x00002CD2
		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "processManager";
				msgPack.ForcePathObject("Option").AsString = "List";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			});
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000433E8 File Offset: 0x000415E8
		private void FormProcessManager_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					Clients client = this.Client;
					if (client == null)
					{
						return;
					}
					client.Disconnected();
				});
			}
			catch
			{
			}
		}
	}
}
