using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x020000A1 RID: 161
	public partial class FormFileSearcher : Form
	{
		// Token: 0x060004F3 RID: 1267 RVA: 0x0000493F File Offset: 0x00002B3F
		public FormFileSearcher()
		{
			this.InitializeComponent();
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000494D File Offset: 0x00002B4D
		private void btnOk_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.txtExtnsions.Text) && this.numericUpDown1.Value > 0m)
			{
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
