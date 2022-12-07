using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using Server.Helper;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x02000098 RID: 152
	public partial class FormRegValueEditWord : Form
	{
		// Token: 0x06000496 RID: 1174 RVA: 0x00033144 File Offset: 0x00031344
		public FormRegValueEditWord(RegistrySeeker.RegValueData value)
		{
			this._value = value;
			this.InitializeComponent();
			this.valueNameTxtBox.Text = value.Name;
			if (value.Kind == RegistryValueKind.DWord)
			{
				this.Text = "Edit DWORD (32-bit) Value";
				this.valueDataTxtBox.Type = WordTextBox.WordType.DWORD;
				this.valueDataTxtBox.Text = Server.Helper.ByteConverter.ToUInt32(value.Data).ToString("x");
				return;
			}
			this.Text = "Edit QWORD (64-bit) Value";
			this.valueDataTxtBox.Type = WordTextBox.WordType.QWORD;
			this.valueDataTxtBox.Text = Server.Helper.ByteConverter.ToUInt64(value.Data).ToString("x");
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000331F4 File Offset: 0x000313F4
		private void radioHex_CheckboxChanged(object sender, EventArgs e)
		{
			if (this.valueDataTxtBox.IsHexNumber == this.radioHexa.Checked)
			{
				return;
			}
			if (this.valueDataTxtBox.IsConversionValid() || this.IsOverridePossible())
			{
				this.valueDataTxtBox.IsHexNumber = this.radioHexa.Checked;
				return;
			}
			this.radioDecimal.Checked = true;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00033254 File Offset: 0x00031454
		private void okButton_Click(object sender, EventArgs e)
		{
			if (this.valueDataTxtBox.IsConversionValid() || this.IsOverridePossible())
			{
				this._value.Data = ((this._value.Kind == RegistryValueKind.DWord) ? Server.Helper.ByteConverter.GetBytes(this.valueDataTxtBox.UIntValue) : Server.Helper.ByteConverter.GetBytes(this.valueDataTxtBox.ULongValue));
				base.Tag = this._value;
				base.DialogResult = DialogResult.OK;
			}
			else
			{
				base.DialogResult = DialogResult.None;
			}
			base.Close();
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000046BA File Offset: 0x000028BA
		private DialogResult ShowWarning(string msg, string caption)
		{
			return MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000332D4 File Offset: 0x000314D4
		private bool IsOverridePossible()
		{
			string msg = (this._value.Kind == RegistryValueKind.DWord) ? "The decimal value entered is greater than the maximum value of a DWORD (32-bit number). Should the value be truncated in order to continue?" : "The decimal value entered is greater than the maximum value of a QWORD (64-bit number). Should the value be truncated in order to continue?";
			return this.ShowWarning(msg, "Overflow") == DialogResult.Yes;
		}

		// Token: 0x04000398 RID: 920
		private readonly RegistrySeeker.RegValueData _value;

		// Token: 0x04000399 RID: 921
		private const string DWORD_WARNING = "The decimal value entered is greater than the maximum value of a DWORD (32-bit number). Should the value be truncated in order to continue?";

		// Token: 0x0400039A RID: 922
		private const string QWORD_WARNING = "The decimal value entered is greater than the maximum value of a QWORD (64-bit number). Should the value be truncated in order to continue?";
	}
}
