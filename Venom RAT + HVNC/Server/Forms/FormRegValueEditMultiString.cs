using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Helper;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x02000096 RID: 150
	public partial class FormRegValueEditMultiString : Form
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x000313F0 File Offset: 0x0002F5F0
		public FormRegValueEditMultiString(RegistrySeeker.RegValueData value)
		{
			this._value = value;
			this.InitializeComponent();
			this.valueNameTxtBox.Text = value.Name;
			this.valueDataTxtBox.Text = string.Join("\r\n", Server.Helper.ByteConverter.ToStringArray(value.Data));
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00031444 File Offset: 0x0002F644
		private void okButton_Click(object sender, EventArgs e)
		{
			this._value.Data = Server.Helper.ByteConverter.GetBytes(this.valueDataTxtBox.Text.Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.RemoveEmptyEntries));
			base.Tag = this._value;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0400037C RID: 892
		private readonly RegistrySeeker.RegValueData _value;
	}
}
