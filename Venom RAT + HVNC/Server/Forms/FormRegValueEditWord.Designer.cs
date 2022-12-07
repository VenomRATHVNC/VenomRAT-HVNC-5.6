namespace Server.Forms
{
	// Token: 0x02000098 RID: 152
	public partial class FormRegValueEditWord : global::System.Windows.Forms.Form
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x000046C6 File Offset: 0x000028C6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0003330C File Offset: 0x0003150C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormRegValueEditWord));
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.valueNameTxtBox = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneGroupBox6 = new global::Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
			this.radioDecimal = new global::Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
			this.radioHexa = new global::Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
			this.valueDataTxtBox = new global::Server.Helper.WordTextBox();
			this.cancelButton = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.okButton = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.siticoneGroupBox6.SuspendLayout();
			base.SuspendLayout();
			this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 149);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(61, 13);
			this.label2.TabIndex = 174;
			this.label2.Text = "Value data:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 104);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(66, 13);
			this.label1.TabIndex = 175;
			this.label1.Text = "Value name:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.panel2.Controls.Add(this.valueNameTxtBox);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new global::System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(408, 320);
			this.panel2.TabIndex = 182;
			this.valueNameTxtBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.valueNameTxtBox.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.valueNameTxtBox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.valueNameTxtBox.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.valueNameTxtBox.Location = new global::System.Drawing.Point(15, 120);
			this.valueNameTxtBox.Name = "valueNameTxtBox";
			this.valueNameTxtBox.ReadOnly = true;
			this.valueNameTxtBox.Size = new global::System.Drawing.Size(334, 13);
			this.valueNameTxtBox.TabIndex = 14;
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(3, 6);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(158, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Reg Value Edit Word";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(408, 31);
			this.siticoneGradientPanel4.TabIndex = 177;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(408, 34);
			this.panel1.TabIndex = 178;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(381, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneGroupBox6.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGroupBox6.Controls.Add(this.radioDecimal);
			this.siticoneGroupBox6.Controls.Add(this.radioHexa);
			this.siticoneGroupBox6.CustomBorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGroupBox6.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGroupBox6.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneGroupBox6.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneGroupBox6.Location = new global::System.Drawing.Point(204, 149);
			this.siticoneGroupBox6.Name = "siticoneGroupBox6";
			this.siticoneGroupBox6.ShadowDecoration.Parent = this.siticoneGroupBox6;
			this.siticoneGroupBox6.Size = new global::System.Drawing.Size(144, 115);
			this.siticoneGroupBox6.TabIndex = 179;
			this.siticoneGroupBox6.Text = "Base";
			this.radioDecimal.AutoSize = true;
			this.radioDecimal.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.radioDecimal.CheckedState.BorderThickness = 0;
			this.radioDecimal.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.radioDecimal.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.radioDecimal.CheckedState.InnerOffset = -4;
			this.radioDecimal.Location = new global::System.Drawing.Point(19, 79);
			this.radioDecimal.Name = "radioDecimal";
			this.radioDecimal.Size = new global::System.Drawing.Size(68, 19);
			this.radioDecimal.TabIndex = 168;
			this.radioDecimal.Text = "Decimal";
			this.radioDecimal.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.radioDecimal.UncheckedState.BorderThickness = 2;
			this.radioDecimal.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.radioDecimal.UncheckedState.InnerColor = global::System.Drawing.Color.Transparent;
			this.radioHexa.AutoSize = true;
			this.radioHexa.Checked = true;
			this.radioHexa.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.radioHexa.CheckedState.BorderThickness = 0;
			this.radioHexa.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.radioHexa.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.radioHexa.CheckedState.InnerOffset = -4;
			this.radioHexa.Location = new global::System.Drawing.Point(19, 56);
			this.radioHexa.Name = "radioHexa";
			this.radioHexa.Size = new global::System.Drawing.Size(94, 19);
			this.radioHexa.TabIndex = 168;
			this.radioHexa.TabStop = true;
			this.radioHexa.Text = "Hexadecimal";
			this.radioHexa.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.radioHexa.UncheckedState.BorderThickness = 2;
			this.radioHexa.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.radioHexa.UncheckedState.InnerColor = global::System.Drawing.Color.Transparent;
			this.valueDataTxtBox.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.valueDataTxtBox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.valueDataTxtBox.IsHexNumber = false;
			this.valueDataTxtBox.Location = new global::System.Drawing.Point(15, 167);
			this.valueDataTxtBox.MaxLength = 8;
			this.valueDataTxtBox.Name = "valueDataTxtBox";
			this.valueDataTxtBox.Size = new global::System.Drawing.Size(171, 13);
			this.valueDataTxtBox.TabIndex = 176;
			this.valueDataTxtBox.Type = global::Server.Helper.WordTextBox.WordType.DWORD;
			this.cancelButton.Animated = true;
			this.cancelButton.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.cancelButton.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.cancelButton.BorderRadius = 1;
			this.cancelButton.BorderThickness = 1;
			this.cancelButton.CheckedState.Parent = this.cancelButton;
			this.cancelButton.CustomImages.Parent = this.cancelButton;
			this.cancelButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.cancelButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.cancelButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.cancelButton.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.cancelButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.cancelButton.DisabledState.Parent = this.cancelButton;
			this.cancelButton.FillColor = global::System.Drawing.Color.Transparent;
			this.cancelButton.FillColor2 = global::System.Drawing.Color.Transparent;
			this.cancelButton.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.cancelButton.ForeColor = global::System.Drawing.Color.DarkGray;
			this.cancelButton.HoverState.Parent = this.cancelButton;
			this.cancelButton.Location = new global::System.Drawing.Point(109, 216);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
			this.cancelButton.Size = new global::System.Drawing.Size(77, 31);
			this.cancelButton.TabIndex = 180;
			this.cancelButton.Text = "Cancel";
			this.okButton.Animated = true;
			this.okButton.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.okButton.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.okButton.BorderRadius = 1;
			this.okButton.BorderThickness = 1;
			this.okButton.CheckedState.Parent = this.okButton;
			this.okButton.CustomImages.Parent = this.okButton;
			this.okButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.okButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.okButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.okButton.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.okButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.okButton.DisabledState.Parent = this.okButton;
			this.okButton.FillColor = global::System.Drawing.Color.Transparent;
			this.okButton.FillColor2 = global::System.Drawing.Color.Transparent;
			this.okButton.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.okButton.ForeColor = global::System.Drawing.Color.DarkGray;
			this.okButton.HoverState.Parent = this.okButton;
			this.okButton.Location = new global::System.Drawing.Point(15, 216);
			this.okButton.Name = "okButton";
			this.okButton.ShadowDecoration.Parent = this.okButton;
			this.okButton.Size = new global::System.Drawing.Size(77, 31);
			this.okButton.TabIndex = 181;
			this.okButton.Text = "OK";
			this.okButton.Click += new global::System.EventHandler(this.okButton_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(408, 320);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.siticoneGroupBox6);
			base.Controls.Add(this.valueDataTxtBox);
			base.Controls.Add(this.cancelButton);
			base.Controls.Add(this.okButton);
			base.Controls.Add(this.panel2);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(408, 320);
			this.MinimumSize = new global::System.Drawing.Size(408, 320);
			base.Name = "FormRegValueEditWord";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.siticoneGroupBox6.ResumeLayout(false);
			this.siticoneGroupBox6.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400039B RID: 923
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400039C RID: 924
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400039D RID: 925
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400039E RID: 926
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400039F RID: 927
		private global::System.Windows.Forms.TextBox valueNameTxtBox;

		// Token: 0x040003A0 RID: 928
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040003A1 RID: 929
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x040003A2 RID: 930
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040003A3 RID: 931
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040003A4 RID: 932
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x040003A5 RID: 933
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x040003A6 RID: 934
		private global::Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox6;

		// Token: 0x040003A7 RID: 935
		private global::Siticone.Desktop.UI.WinForms.SiticoneRadioButton radioDecimal;

		// Token: 0x040003A8 RID: 936
		private global::Siticone.Desktop.UI.WinForms.SiticoneRadioButton radioHexa;

		// Token: 0x040003A9 RID: 937
		private global::Server.Helper.WordTextBox valueDataTxtBox;

		// Token: 0x040003AA RID: 938
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton cancelButton;

		// Token: 0x040003AB RID: 939
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton okButton;
	}
}
