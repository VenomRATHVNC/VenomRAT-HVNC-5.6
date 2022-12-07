namespace Server.Forms
{
	// Token: 0x02000097 RID: 151
	public partial class FormRegValueEditString : global::System.Windows.Forms.Form
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x0000469B File Offset: 0x0000289B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00032320 File Offset: 0x00030520
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormRegValueEditString));
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.cancelButton = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.okButton = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.valueDataTxtBox = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.valueNameTxtBox = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(9, 141);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(61, 13);
			this.label2.TabIndex = 171;
			this.label2.Text = "Value data:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(9, 89);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(66, 13);
			this.label1.TabIndex = 172;
			this.label1.Text = "Value name:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(1, 7);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(199, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Reg Value Edit Multi String";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(469, 31);
			this.siticoneGradientPanel4.TabIndex = 173;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(469, 34);
			this.panel1.TabIndex = 174;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(442, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
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
			this.cancelButton.Location = new global::System.Drawing.Point(325, 194);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
			this.cancelButton.Size = new global::System.Drawing.Size(131, 31);
			this.cancelButton.TabIndex = 177;
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
			this.okButton.Location = new global::System.Drawing.Point(12, 194);
			this.okButton.Name = "okButton";
			this.okButton.ShadowDecoration.Parent = this.okButton;
			this.okButton.Size = new global::System.Drawing.Size(131, 31);
			this.okButton.TabIndex = 178;
			this.okButton.Text = "OK";
			this.okButton.Click += new global::System.EventHandler(this.okButton_Click);
			this.valueDataTxtBox.Animated = true;
			this.valueDataTxtBox.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.valueDataTxtBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.valueDataTxtBox.DefaultText = "";
			this.valueDataTxtBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.valueDataTxtBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.valueDataTxtBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.valueDataTxtBox.DisabledState.Parent = this.valueDataTxtBox;
			this.valueDataTxtBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.valueDataTxtBox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.valueDataTxtBox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.valueDataTxtBox.FocusedState.Parent = this.valueDataTxtBox;
			this.valueDataTxtBox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.valueDataTxtBox.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.valueDataTxtBox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.valueDataTxtBox.HoverState.Parent = this.valueDataTxtBox;
			this.valueDataTxtBox.Location = new global::System.Drawing.Point(12, 157);
			this.valueDataTxtBox.Name = "valueDataTxtBox";
			this.valueDataTxtBox.PasswordChar = '\0';
			this.valueDataTxtBox.PlaceholderText = "";
			this.valueDataTxtBox.SelectedText = "";
			this.valueDataTxtBox.ShadowDecoration.Parent = this.valueDataTxtBox;
			this.valueDataTxtBox.Size = new global::System.Drawing.Size(444, 25);
			this.valueDataTxtBox.TabIndex = 176;
			this.valueNameTxtBox.Animated = true;
			this.valueNameTxtBox.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.valueNameTxtBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.valueNameTxtBox.DefaultText = "";
			this.valueNameTxtBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.valueNameTxtBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.valueNameTxtBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.valueNameTxtBox.DisabledState.Parent = this.valueNameTxtBox;
			this.valueNameTxtBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.valueNameTxtBox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.valueNameTxtBox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.valueNameTxtBox.FocusedState.Parent = this.valueNameTxtBox;
			this.valueNameTxtBox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.valueNameTxtBox.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.valueNameTxtBox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.valueNameTxtBox.HoverState.Parent = this.valueNameTxtBox;
			this.valueNameTxtBox.Location = new global::System.Drawing.Point(12, 105);
			this.valueNameTxtBox.Name = "valueNameTxtBox";
			this.valueNameTxtBox.PasswordChar = '\0';
			this.valueNameTxtBox.PlaceholderText = "";
			this.valueNameTxtBox.SelectedText = "";
			this.valueNameTxtBox.ShadowDecoration.Parent = this.valueNameTxtBox;
			this.valueNameTxtBox.Size = new global::System.Drawing.Size(444, 25);
			this.valueNameTxtBox.TabIndex = 175;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(469, 231);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.cancelButton);
			base.Controls.Add(this.okButton);
			base.Controls.Add(this.valueDataTxtBox);
			base.Controls.Add(this.valueNameTxtBox);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(469, 231);
			this.MinimumSize = new global::System.Drawing.Size(469, 231);
			base.Name = "FormRegValueEditString";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400038B RID: 907
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400038C RID: 908
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400038D RID: 909
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400038E RID: 910
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400038F RID: 911
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000390 RID: 912
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000391 RID: 913
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000392 RID: 914
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000393 RID: 915
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x04000394 RID: 916
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton cancelButton;

		// Token: 0x04000395 RID: 917
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton okButton;

		// Token: 0x04000396 RID: 918
		public global::Siticone.Desktop.UI.WinForms.SiticoneTextBox valueDataTxtBox;

		// Token: 0x04000397 RID: 919
		public global::Siticone.Desktop.UI.WinForms.SiticoneTextBox valueNameTxtBox;
	}
}
