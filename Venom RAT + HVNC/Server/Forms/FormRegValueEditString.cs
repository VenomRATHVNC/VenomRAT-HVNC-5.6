using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Helper;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x02000097 RID: 151
	public partial class FormRegValueEditString : Form
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x000322D4 File Offset: 0x000304D4
		public FormRegValueEditString(RegistrySeeker.RegValueData value)
		{
			this._value = value;
			this.InitializeComponent();
			this.valueNameTxtBox.Text = RegValueHelper.GetName(value.Name);
			this.valueDataTxtBox.Text = Server.Helper.ByteConverter.ToString(value.Data);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00004665 File Offset: 0x00002865
		private void okButton_Click(object sender, EventArgs e)
		{
			this._value.Data = Server.Helper.ByteConverter.GetBytes(this.valueDataTxtBox.Text);
			base.Tag = this._value;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0400038A RID: 906
		private readonly RegistrySeeker.RegValueData _value;
	}
}
