namespace HVNC
{
	// Token: 0x0200001C RID: 28
	public partial class FrmMassUpdate : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CB RID: 203 RVA: 0x000025E4 File Offset: 0x000007E4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000C3C4 File Offset: 0x0000A5C4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HVNC.FrmMassUpdate));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.Urlbox = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.StartHiddenURLbtn = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(549, 34);
			this.panel1.TabIndex = 164;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(522, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 146;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.label18.AutoSize = true;
			this.label18.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label18.Location = new global::System.Drawing.Point(34, 8);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(109, 20);
			this.label18.TabIndex = 2;
			this.label18.Text = "Mass Execute";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(549, 31);
			this.siticoneGradientPanel4.TabIndex = 167;
			this.Urlbox.Animated = true;
			this.Urlbox.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.Urlbox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Urlbox.DefaultText = "yourdomain.com/payload.exe";
			this.Urlbox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Urlbox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Urlbox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Urlbox.DisabledState.Parent = this.Urlbox;
			this.Urlbox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Urlbox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Urlbox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.Urlbox.FocusedState.Parent = this.Urlbox;
			this.Urlbox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Urlbox.ForeColor = global::System.Drawing.Color.DarkGray;
			this.Urlbox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.Urlbox.HoverState.Parent = this.Urlbox;
			this.Urlbox.Location = new global::System.Drawing.Point(60, 136);
			this.Urlbox.Name = "Urlbox";
			this.Urlbox.PasswordChar = '\0';
			this.Urlbox.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.Urlbox.PlaceholderText = "";
			this.Urlbox.SelectedText = "";
			this.Urlbox.SelectionStart = 26;
			this.Urlbox.ShadowDecoration.Parent = this.Urlbox;
			this.Urlbox.Size = new global::System.Drawing.Size(273, 30);
			this.Urlbox.TabIndex = 166;
			this.Urlbox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.StartHiddenURLbtn.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.StartHiddenURLbtn.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.StartHiddenURLbtn.BorderRadius = 1;
			this.StartHiddenURLbtn.BorderThickness = 1;
			this.StartHiddenURLbtn.CheckedState.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.CustomImages.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.StartHiddenURLbtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.StartHiddenURLbtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.StartHiddenURLbtn.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.StartHiddenURLbtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.StartHiddenURLbtn.DisabledState.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.FillColor = global::System.Drawing.Color.Transparent;
			this.StartHiddenURLbtn.FillColor2 = global::System.Drawing.Color.Transparent;
			this.StartHiddenURLbtn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.StartHiddenURLbtn.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.StartHiddenURLbtn.HoverState.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.Location = new global::System.Drawing.Point(366, 136);
			this.StartHiddenURLbtn.Name = "StartHiddenURLbtn";
			this.StartHiddenURLbtn.ShadowDecoration.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.Size = new global::System.Drawing.Size(106, 30);
			this.StartHiddenURLbtn.TabIndex = 165;
			this.StartHiddenURLbtn.Text = "Execute";
			this.StartHiddenURLbtn.Click += new global::System.EventHandler(this.StartHiddenURLbtn_Click);
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(549, 252);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.Urlbox);
			base.Controls.Add(this.StartHiddenURLbtn);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(549, 252);
			this.MinimumSize = new global::System.Drawing.Size(549, 252);
			base.Name = "FrmMassUpdate";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmURL";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000085 RID: 133
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000086 RID: 134
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000087 RID: 135
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox Urlbox;

		// Token: 0x04000088 RID: 136
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton StartHiddenURLbtn;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400008A RID: 138
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label label18;

		// Token: 0x0400008D RID: 141
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400008E RID: 142
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
