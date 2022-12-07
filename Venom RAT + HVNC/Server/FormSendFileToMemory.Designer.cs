namespace Server
{
	// Token: 0x02000030 RID: 48
	public partial class FormSendFileToMemory : global::System.Windows.Forms.Form
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x00002CC5 File Offset: 0x00000EC5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001D0B4 File Offset: 0x0001B2B4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.FormSendFileToMemory));
			this.button3 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.button1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.comboBox2 = new global::Siticone.Desktop.UI.WinForms.SiticoneComboBox();
			this.comboBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneComboBox();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.button2 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGroupBox3 = new global::Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.panel1.SuspendLayout();
			this.siticoneGroupBox3.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.button3.Animated = true;
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.button3.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.button3.BorderRadius = 1;
			this.button3.BorderThickness = 1;
			this.button3.CheckedState.Parent = this.button3;
			this.button3.CustomImages.Parent = this.button3;
			this.button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.button3.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.button3.DisabledState.Parent = this.button3;
			this.button3.FillColor = global::System.Drawing.Color.Transparent;
			this.button3.FillColor2 = global::System.Drawing.Color.Transparent;
			this.button3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.button3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.button3.HoverState.Parent = this.button3;
			this.button3.Location = new global::System.Drawing.Point(247, 262);
			this.button3.Name = "button3";
			this.button3.ShadowDecoration.Parent = this.button3;
			this.button3.Size = new global::System.Drawing.Size(131, 31);
			this.button3.TabIndex = 67;
			this.button3.Text = "Cancel";
			this.button1.Animated = true;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.button1.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.button1.BorderRadius = 1;
			this.button1.BorderThickness = 1;
			this.button1.CheckedState.Parent = this.button1;
			this.button1.CustomImages.Parent = this.button1;
			this.button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.button1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.button1.DisabledState.Parent = this.button1;
			this.button1.FillColor = global::System.Drawing.Color.Transparent;
			this.button1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.button1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.button1.HoverState.Parent = this.button1;
			this.button1.Location = new global::System.Drawing.Point(211, 129);
			this.button1.Name = "button1";
			this.button1.ShadowDecoration.Parent = this.button1;
			this.button1.Size = new global::System.Drawing.Size(167, 31);
			this.button1.TabIndex = 67;
			this.button1.Text = "Select";
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.comboBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.comboBox2.BorderColor = global::System.Drawing.Color.FromArgb(27, 58, 38);
			this.comboBox2.BorderRadius = 1;
			this.comboBox2.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.comboBox2.FocusedColor = global::System.Drawing.Color.FromArgb(27, 58, 38);
			this.comboBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 58, 38);
			this.comboBox2.FocusedState.Parent = this.comboBox2;
			this.comboBox2.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.comboBox2.ForeColor = global::System.Drawing.Color.DarkGray;
			this.comboBox2.HoverState.Parent = this.comboBox2;
			this.comboBox2.ItemHeight = 30;
			this.comboBox2.Items.AddRange(new object[]
			{
				"aspnet_compiler.exe",
				"RegAsm.exe",
				"MSBuild.exe",
				"RegSvcs.exe",
				"vbc.exe"
			});
			this.comboBox2.ItemsAppearance.Parent = this.comboBox2;
			this.comboBox2.Location = new global::System.Drawing.Point(211, 166);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.ShadowDecoration.Parent = this.comboBox2;
			this.comboBox2.Size = new global::System.Drawing.Size(167, 36);
			this.comboBox2.TabIndex = 160;
			this.comboBox2.Visible = false;
			this.comboBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.comboBox1.BorderColor = global::System.Drawing.Color.FromArgb(27, 58, 38);
			this.comboBox1.BorderRadius = 1;
			this.comboBox1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.comboBox1.FocusedColor = global::System.Drawing.Color.FromArgb(27, 58, 38);
			this.comboBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 58, 38);
			this.comboBox1.FocusedState.Parent = this.comboBox1;
			this.comboBox1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.comboBox1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.comboBox1.HoverState.Parent = this.comboBox1;
			this.comboBox1.ItemHeight = 30;
			this.comboBox1.Items.AddRange(new object[]
			{
				"Reflection",
				"RunPE"
			});
			this.comboBox1.ItemsAppearance.Parent = this.comboBox1;
			this.comboBox1.Location = new global::System.Drawing.Point(211, 87);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.ShadowDecoration.Parent = this.comboBox1;
			this.comboBox1.Size = new global::System.Drawing.Size(167, 36);
			this.comboBox1.TabIndex = 160;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(501, 34);
			this.panel1.TabIndex = 170;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(474, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(3, 8);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(69, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Injection";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Animated = true;
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.button2.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.button2.BorderRadius = 1;
			this.button2.BorderThickness = 1;
			this.button2.CheckedState.Parent = this.button2;
			this.button2.CustomImages.Parent = this.button2;
			this.button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.button2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.button2.DisabledState.Parent = this.button2;
			this.button2.FillColor = global::System.Drawing.Color.Transparent;
			this.button2.FillColor2 = global::System.Drawing.Color.Transparent;
			this.button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.button2.ForeColor = global::System.Drawing.Color.DarkGray;
			this.button2.HoverState.Parent = this.button2;
			this.button2.Location = new global::System.Drawing.Point(32, 262);
			this.button2.Name = "button2";
			this.button2.ShadowDecoration.Parent = this.button2;
			this.button2.Size = new global::System.Drawing.Size(131, 31);
			this.button2.TabIndex = 67;
			this.button2.Text = "OK";
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.siticoneGroupBox3.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGroupBox3.Controls.Add(this.button3);
			this.siticoneGroupBox3.Controls.Add(this.button1);
			this.siticoneGroupBox3.Controls.Add(this.comboBox2);
			this.siticoneGroupBox3.Controls.Add(this.button2);
			this.siticoneGroupBox3.Controls.Add(this.comboBox1);
			this.siticoneGroupBox3.Controls.Add(this.label1);
			this.siticoneGroupBox3.Controls.Add(this.label2);
			this.siticoneGroupBox3.Controls.Add(this.label3);
			this.siticoneGroupBox3.CustomBorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGroupBox3.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGroupBox3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneGroupBox3.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneGroupBox3.Location = new global::System.Drawing.Point(12, 85);
			this.siticoneGroupBox3.Name = "siticoneGroupBox3";
			this.siticoneGroupBox3.ShadowDecoration.Parent = this.siticoneGroupBox3;
			this.siticoneGroupBox3.Size = new global::System.Drawing.Size(476, 329);
			this.siticoneGroupBox3.TabIndex = 171;
			this.siticoneGroupBox3.Text = "Inject";
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label1.Location = new global::System.Drawing.Point(28, 89);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(47, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Type:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label2.Location = new global::System.Drawing.Point(28, 132);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(38, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "File:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label3.Location = new global::System.Drawing.Point(28, 171);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(59, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Target:";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripStatusLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.toolStripStatusLabel1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(16, 17);
			this.toolStripStatusLabel1.Text = "...";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(501, 31);
			this.siticoneGradientPanel4.TabIndex = 169;
			this.statusStrip1.BackColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.statusStrip1.Size = new global::System.Drawing.Size(501, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 168;
			this.statusStrip1.Text = "statusStrip1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			base.ClientSize = new global::System.Drawing.Size(501, 450);
			base.Controls.Add(this.siticoneGroupBox3);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.statusStrip1);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(501, 450);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(501, 450);
			base.Name = "FormSendFileToMemory";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Injection";
			base.Load += new global::System.EventHandler(this.SendFileToMemory_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.siticoneGroupBox3.ResumeLayout(false);
			this.siticoneGroupBox3.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001A0 RID: 416
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001A1 RID: 417
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton button3;

		// Token: 0x040001A2 RID: 418
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton button1;

		// Token: 0x040001A3 RID: 419
		public global::Siticone.Desktop.UI.WinForms.SiticoneComboBox comboBox2;

		// Token: 0x040001A4 RID: 420
		public global::Siticone.Desktop.UI.WinForms.SiticoneComboBox comboBox1;

		// Token: 0x040001A5 RID: 421
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x040001A6 RID: 422
		private global::Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox3;

		// Token: 0x040001A7 RID: 423
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton button2;

		// Token: 0x040001A8 RID: 424
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001A9 RID: 425
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001AA RID: 426
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001AB RID: 427
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040001AD RID: 429
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x040001B0 RID: 432
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x040001B1 RID: 433
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
	}
}
