namespace Server.Forms
{
	// Token: 0x02000091 RID: 145
	public partial class FormLogin : global::System.Windows.Forms.Form
	{
		// Token: 0x06000473 RID: 1139 RVA: 0x0000452B File Offset: 0x0000272B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0002DB5C File Offset: 0x0002BD5C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormLogin));
			this.registerPanel = new global::System.Windows.Forms.Panel();
			this.loginBtn = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.regUsernamebox = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.regPasswordbox = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.regKeybox = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.siticoneGradientButton1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.BtnResetHWID = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneDragControl2 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.usernameBox = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.passwordBox = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.siticoneRoundedButton6 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneRoundedButton1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneRoundedButton2 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.BtnSavedLogin = new global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
			this.registerPanel.SuspendLayout();
			this.siticoneGradientPanel4.SuspendLayout();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.registerPanel.Controls.Add(this.loginBtn);
			this.registerPanel.Controls.Add(this.regUsernamebox);
			this.registerPanel.Controls.Add(this.regPasswordbox);
			this.registerPanel.Controls.Add(this.regKeybox);
			this.registerPanel.Controls.Add(this.siticoneGradientButton1);
			this.registerPanel.Location = new global::System.Drawing.Point(61, 187);
			this.registerPanel.Name = "registerPanel";
			this.registerPanel.Size = new global::System.Drawing.Size(428, 194);
			this.registerPanel.TabIndex = 10;
			this.registerPanel.Visible = false;
			this.loginBtn.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.loginBtn.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.loginBtn.BorderRadius = 1;
			this.loginBtn.BorderThickness = 1;
			this.loginBtn.CheckedState.Parent = this.loginBtn;
			this.loginBtn.CustomImages.Parent = this.loginBtn;
			this.loginBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.loginBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.loginBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.loginBtn.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.loginBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.loginBtn.DisabledState.Parent = this.loginBtn;
			this.loginBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.loginBtn.FillColor2 = global::System.Drawing.Color.Transparent;
			this.loginBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.loginBtn.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.loginBtn.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.loginBtn.HoverState.Parent = this.loginBtn;
			this.loginBtn.Location = new global::System.Drawing.Point(3, 150);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
			this.loginBtn.Size = new global::System.Drawing.Size(177, 30);
			this.loginBtn.TabIndex = 158;
			this.loginBtn.Text = "Return";
			this.loginBtn.Click += new global::System.EventHandler(this.siticoneRoundedButton3_Click);
			this.regUsernamebox.Animated = true;
			this.regUsernamebox.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.regUsernamebox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.regUsernamebox.DefaultText = "";
			this.regUsernamebox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.regUsernamebox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.regUsernamebox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.regUsernamebox.DisabledState.Parent = this.regUsernamebox;
			this.regUsernamebox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.regUsernamebox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.regUsernamebox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.regUsernamebox.FocusedState.Parent = this.regUsernamebox;
			this.regUsernamebox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.regUsernamebox.ForeColor = global::System.Drawing.Color.DarkGray;
			this.regUsernamebox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.regUsernamebox.HoverState.Parent = this.regUsernamebox;
			this.regUsernamebox.Location = new global::System.Drawing.Point(3, 22);
			this.regUsernamebox.Name = "regUsernamebox";
			this.regUsernamebox.PasswordChar = '\0';
			this.regUsernamebox.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.regUsernamebox.PlaceholderText = "Username";
			this.regUsernamebox.SelectedText = "";
			this.regUsernamebox.ShadowDecoration.Parent = this.regUsernamebox;
			this.regUsernamebox.Size = new global::System.Drawing.Size(422, 30);
			this.regUsernamebox.TabIndex = 0;
			this.regPasswordbox.Animated = true;
			this.regPasswordbox.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.regPasswordbox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.regPasswordbox.DefaultText = "";
			this.regPasswordbox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.regPasswordbox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.regPasswordbox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.regPasswordbox.DisabledState.Parent = this.regPasswordbox;
			this.regPasswordbox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.regPasswordbox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.regPasswordbox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.regPasswordbox.FocusedState.Parent = this.regPasswordbox;
			this.regPasswordbox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.regPasswordbox.ForeColor = global::System.Drawing.Color.DarkGray;
			this.regPasswordbox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.regPasswordbox.HoverState.Parent = this.regPasswordbox;
			this.regPasswordbox.Location = new global::System.Drawing.Point(3, 58);
			this.regPasswordbox.Name = "regPasswordbox";
			this.regPasswordbox.PasswordChar = '\0';
			this.regPasswordbox.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.regPasswordbox.PlaceholderText = "Password";
			this.regPasswordbox.SelectedText = "";
			this.regPasswordbox.ShadowDecoration.Parent = this.regPasswordbox;
			this.regPasswordbox.Size = new global::System.Drawing.Size(422, 30);
			this.regPasswordbox.TabIndex = 1;
			this.regKeybox.Animated = true;
			this.regKeybox.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.regKeybox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.regKeybox.DefaultText = "";
			this.regKeybox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.regKeybox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.regKeybox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.regKeybox.DisabledState.Parent = this.regKeybox;
			this.regKeybox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.regKeybox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.regKeybox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.regKeybox.FocusedState.Parent = this.regKeybox;
			this.regKeybox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.regKeybox.ForeColor = global::System.Drawing.Color.DarkGray;
			this.regKeybox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.regKeybox.HoverState.Parent = this.regKeybox;
			this.regKeybox.Location = new global::System.Drawing.Point(3, 94);
			this.regKeybox.Name = "regKeybox";
			this.regKeybox.PasswordChar = '\0';
			this.regKeybox.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.regKeybox.PlaceholderText = "Key";
			this.regKeybox.SelectedText = "";
			this.regKeybox.ShadowDecoration.Parent = this.regKeybox;
			this.regKeybox.Size = new global::System.Drawing.Size(422, 30);
			this.regKeybox.TabIndex = 4;
			this.siticoneGradientButton1.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneGradientButton1.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientButton1.BorderRadius = 1;
			this.siticoneGradientButton1.BorderThickness = 1;
			this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneGradientButton1.DisabledState.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneGradientButton1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneGradientButton1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneGradientButton1.HoverState.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.Location = new global::System.Drawing.Point(248, 150);
			this.siticoneGradientButton1.Name = "siticoneGradientButton1";
			this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.Size = new global::System.Drawing.Size(177, 30);
			this.siticoneGradientButton1.TabIndex = 158;
			this.siticoneGradientButton1.Text = "Register";
			this.siticoneGradientButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton4_Click);
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Controls.Add(this.BtnResetHWID);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(544, 31);
			this.siticoneGradientPanel4.TabIndex = 168;
			this.BtnResetHWID.Animated = true;
			this.BtnResetHWID.BackColor = global::System.Drawing.Color.Transparent;
			this.BtnResetHWID.BorderColor = global::System.Drawing.Color.Transparent;
			this.BtnResetHWID.BorderRadius = 1;
			this.BtnResetHWID.BorderThickness = 1;
			this.BtnResetHWID.CheckedState.Parent = this.BtnResetHWID;
			this.BtnResetHWID.CustomImages.Parent = this.BtnResetHWID;
			this.BtnResetHWID.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.BtnResetHWID.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.BtnResetHWID.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtnResetHWID.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtnResetHWID.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.BtnResetHWID.DisabledState.Parent = this.BtnResetHWID;
			this.BtnResetHWID.FillColor = global::System.Drawing.Color.Transparent;
			this.BtnResetHWID.FillColor2 = global::System.Drawing.Color.Transparent;
			this.BtnResetHWID.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BtnResetHWID.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.BtnResetHWID.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.BtnResetHWID.HoverState.Parent = this.BtnResetHWID;
			this.BtnResetHWID.Location = new global::System.Drawing.Point(395, 1);
			this.BtnResetHWID.Name = "BtnResetHWID";
			this.BtnResetHWID.ShadowDecoration.Parent = this.BtnResetHWID;
			this.BtnResetHWID.Size = new global::System.Drawing.Size(146, 30);
			this.BtnResetHWID.TabIndex = 172;
			this.BtnResetHWID.Text = "Cracked by Alkaisa";
			this.BtnResetHWID.Click += new global::System.EventHandler(this.BtnResetHWID_LinkClicked);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(544, 34);
			this.panel1.TabIndex = 169;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(517, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(44, 18);
			this.label1.TabIndex = 129;
			this.label1.Text = "Login";
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneDragControl2.TargetControl = this.panel1;
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 85);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(545, 75);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 170;
			this.pictureBox1.TabStop = false;
			this.usernameBox.Animated = true;
			this.usernameBox.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.usernameBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.usernameBox.DefaultText = "";
			this.usernameBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.usernameBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.usernameBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.usernameBox.DisabledState.Parent = this.usernameBox;
			this.usernameBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.usernameBox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.usernameBox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.usernameBox.FocusedState.Parent = this.usernameBox;
			this.usernameBox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.usernameBox.ForeColor = global::System.Drawing.Color.DarkGray;
			this.usernameBox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.usernameBox.HoverState.Parent = this.usernameBox;
			this.usernameBox.Location = new global::System.Drawing.Point(61, 209);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.PasswordChar = '\0';
			this.usernameBox.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.usernameBox.PlaceholderText = "Username";
			this.usernameBox.SelectedText = "";
			this.usernameBox.ShadowDecoration.Parent = this.usernameBox;
			this.usernameBox.Size = new global::System.Drawing.Size(425, 30);
			this.usernameBox.TabIndex = 1;
			this.passwordBox.Animated = true;
			this.passwordBox.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.passwordBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.passwordBox.DefaultText = "";
			this.passwordBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.passwordBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.passwordBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.passwordBox.DisabledState.Parent = this.passwordBox;
			this.passwordBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.passwordBox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.passwordBox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.passwordBox.FocusedState.Parent = this.passwordBox;
			this.passwordBox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.passwordBox.ForeColor = global::System.Drawing.Color.DarkGray;
			this.passwordBox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.passwordBox.HoverState.Parent = this.passwordBox;
			this.passwordBox.Location = new global::System.Drawing.Point(61, 245);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.passwordBox.PlaceholderText = "Password";
			this.passwordBox.SelectedText = "";
			this.passwordBox.ShadowDecoration.Parent = this.passwordBox;
			this.passwordBox.Size = new global::System.Drawing.Size(425, 30);
			this.passwordBox.TabIndex = 2;
			this.siticoneRoundedButton6.Animated = true;
			this.siticoneRoundedButton6.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneRoundedButton6.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneRoundedButton6.BorderRadius = 1;
			this.siticoneRoundedButton6.BorderThickness = 1;
			this.siticoneRoundedButton6.CheckedState.Parent = this.siticoneRoundedButton6;
			this.siticoneRoundedButton6.CustomImages.Parent = this.siticoneRoundedButton6;
			this.siticoneRoundedButton6.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneRoundedButton6.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneRoundedButton6.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneRoundedButton6.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneRoundedButton6.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneRoundedButton6.DisabledState.Parent = this.siticoneRoundedButton6;
			this.siticoneRoundedButton6.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton6.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton6.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneRoundedButton6.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneRoundedButton6.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneRoundedButton6.HoverState.Parent = this.siticoneRoundedButton6;
			this.siticoneRoundedButton6.Location = new global::System.Drawing.Point(61, 337);
			this.siticoneRoundedButton6.Name = "siticoneRoundedButton6";
			this.siticoneRoundedButton6.ShadowDecoration.Parent = this.siticoneRoundedButton6;
			this.siticoneRoundedButton6.Size = new global::System.Drawing.Size(425, 30);
			this.siticoneRoundedButton6.TabIndex = 172;
			this.siticoneRoundedButton6.Text = "Close";
			this.siticoneRoundedButton6.Click += new global::System.EventHandler(this.siticoneRoundedButton6_Click);
			this.siticoneRoundedButton1.Animated = true;
			this.siticoneRoundedButton1.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneRoundedButton1.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneRoundedButton1.BorderRadius = 1;
			this.siticoneRoundedButton1.BorderThickness = 1;
			this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneRoundedButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneRoundedButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneRoundedButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneRoundedButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneRoundedButton1.DisabledState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneRoundedButton1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneRoundedButton1.HoverState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(61, 301);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(200, 30);
			this.siticoneRoundedButton1.TabIndex = 3;
			this.siticoneRoundedButton1.Text = "Login";
			this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
			this.siticoneRoundedButton2.Animated = true;
			this.siticoneRoundedButton2.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneRoundedButton2.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneRoundedButton2.BorderRadius = 1;
			this.siticoneRoundedButton2.BorderThickness = 1;
			this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneRoundedButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneRoundedButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneRoundedButton2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneRoundedButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneRoundedButton2.DisabledState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton2.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneRoundedButton2.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneRoundedButton2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneRoundedButton2.HoverState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(286, 301);
			this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
			this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(200, 30);
			this.siticoneRoundedButton2.TabIndex = 4;
			this.siticoneRoundedButton2.Text = "Register";
			this.siticoneRoundedButton2.Click += new global::System.EventHandler(this.siticoneRoundedButton2_Click);
			this.BtnSavedLogin.AutoSize = true;
			this.BtnSavedLogin.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.BtnSavedLogin.CheckedState.BorderRadius = 0;
			this.BtnSavedLogin.CheckedState.BorderThickness = 0;
			this.BtnSavedLogin.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.BtnSavedLogin.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.BtnSavedLogin.Location = new global::System.Drawing.Point(61, 383);
			this.BtnSavedLogin.Name = "BtnSavedLogin";
			this.BtnSavedLogin.Size = new global::System.Drawing.Size(80, 17);
			this.BtnSavedLogin.TabIndex = 176;
			this.BtnSavedLogin.Text = "Save Login";
			this.BtnSavedLogin.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.BtnSavedLogin.UncheckedState.BorderRadius = 0;
			this.BtnSavedLogin.UncheckedState.BorderThickness = 0;
			this.BtnSavedLogin.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(544, 426);
			base.Controls.Add(this.BtnSavedLogin);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.registerPanel);
			base.Controls.Add(this.siticoneRoundedButton2);
			base.Controls.Add(this.siticoneRoundedButton1);
			base.Controls.Add(this.siticoneRoundedButton6);
			base.Controls.Add(this.passwordBox);
			base.Controls.Add(this.usernameBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(544, 426);
			this.MinimumSize = new global::System.Drawing.Size(544, 426);
			base.Name = "FormLogin";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cracked by Alkaisa";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
			base.Load += new global::System.EventHandler(this.LoginForm_Load);
			this.registerPanel.ResumeLayout(false);
			this.siticoneGradientPanel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400033D RID: 829
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400033E RID: 830
		private global::System.Windows.Forms.Panel registerPanel;

		// Token: 0x0400033F RID: 831
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000341 RID: 833
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000343 RID: 835
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x04000344 RID: 836
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl2;

		// Token: 0x04000345 RID: 837
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000346 RID: 838
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;

		// Token: 0x04000347 RID: 839
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton loginBtn;

		// Token: 0x04000348 RID: 840
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox regUsernamebox;

		// Token: 0x04000349 RID: 841
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox regPasswordbox;

		// Token: 0x0400034A RID: 842
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox regKeybox;

		// Token: 0x0400034B RID: 843
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneRoundedButton2;

		// Token: 0x0400034C RID: 844
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneRoundedButton1;

		// Token: 0x0400034D RID: 845
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneRoundedButton6;

		// Token: 0x0400034E RID: 846
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox passwordBox;

		// Token: 0x0400034F RID: 847
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox usernameBox;

		// Token: 0x04000350 RID: 848
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnResetHWID;

		// Token: 0x04000351 RID: 849
		private global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox BtnSavedLogin;
	}
}
