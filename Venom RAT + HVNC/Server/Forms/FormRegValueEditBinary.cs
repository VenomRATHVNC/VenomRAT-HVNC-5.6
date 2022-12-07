using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Helper;
using Server.Helper.HexEditor;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x02000092 RID: 146
	public partial class FormRegValueEditBinary : Form
	{
		// Token: 0x06000476 RID: 1142 RVA: 0x0000454A File Offset: 0x0000274A
		public FormRegValueEditBinary(RegistrySeeker.RegValueData value)
		{
			this._value = value;
			this.InitializeComponent();
			this.valueNameTxtBox.Text = RegValueHelper.GetName(value.Name);
			this.hexEditor.HexTable = value.Data;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0002FBC4 File Offset: 0x0002DDC4
		private void okButton_Click(object sender, EventArgs e)
		{
			byte[] hexTable = this.hexEditor.HexTable;
			if (hexTable != null)
			{
				try
				{
					this._value.Data = hexTable;
					base.DialogResult = DialogResult.OK;
					base.Tag = this._value;
				}
				catch
				{
					this.ShowWarning("The binary value was invalid and could not be converted correctly.", "Warning");
					base.DialogResult = DialogResult.None;
				}
			}
			base.Close();
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00004586 File Offset: 0x00002786
		private void ShowWarning(string msg, string caption)
		{
			MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x04000352 RID: 850
		private readonly RegistrySeeker.RegValueData _value;

		// Token: 0x04000353 RID: 851
		private const string INVALID_BINARY_ERROR = "The binary value was invalid and could not be converted correctly.";
	}
}
