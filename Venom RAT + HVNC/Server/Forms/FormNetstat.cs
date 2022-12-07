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
	// Token: 0x02000093 RID: 147
	public partial class FormNetstat : Form
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000045B2 File Offset: 0x000027B2
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x000045BA File Offset: 0x000027BA
		public FormMain F { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x000045C3 File Offset: 0x000027C3
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x000045CB File Offset: 0x000027CB
		internal Clients Client { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x000045D4 File Offset: 0x000027D4
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x000045DC File Offset: 0x000027DC
		internal Clients ParentClient { get; set; }

		// Token: 0x06000481 RID: 1153 RVA: 0x000045E5 File Offset: 0x000027E5
		public FormNetstat()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00030974 File Offset: 0x0002EB74
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

		// Token: 0x06000483 RID: 1155 RVA: 0x000309C8 File Offset: 0x0002EBC8
		private void killToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormNetstat.<killToolStripMenuItem_Click>d__14 <killToolStripMenuItem_Click>d__;
			<killToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<killToolStripMenuItem_Click>d__.<>4__this = this;
			<killToolStripMenuItem_Click>d__.<>1__state = -1;
			<killToolStripMenuItem_Click>d__.<>t__builder.Start<FormNetstat.<killToolStripMenuItem_Click>d__14>(ref <killToolStripMenuItem_Click>d__);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000045F3 File Offset: 0x000027F3
		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "Netstat";
				msgPack.ForcePathObject("Option").AsString = "List";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			});
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00030A00 File Offset: 0x0002EC00
		private void FormNetstat_FormClosed(object sender, FormClosedEventArgs e)
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
