using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace HVNC
{
	// Token: 0x0200001E RID: 30
	public partial class FrmURL : Form
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x0000266A File Offset: 0x0000086A
		public FrmURL()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000CFA0 File Offset: 0x0000B1A0
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
					FrmMain.saveurl = this.Urlbox.Text;
					FrmMain.ispressed = true;
					base.Close();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An Error Has Occured When Trying To Execute HiddenURL");
				base.Close();
			}
		}

		// Token: 0x04000094 RID: 148
		public int count;
	}
}
