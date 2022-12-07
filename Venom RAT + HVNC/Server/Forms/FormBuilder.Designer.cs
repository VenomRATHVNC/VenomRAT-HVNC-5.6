namespace Server.Forms
{
	// Token: 0x0200009A RID: 154
	public partial class FormBuilder : global::System.Windows.Forms.Form
	{
		// Token: 0x060004C0 RID: 1216 RVA: 0x00004835 File Offset: 0x00002A35
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000364A0 File Offset: 0x000346A0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormBuilder));
			this.directoryEntry1 = new global::System.DirectoryServices.DirectoryEntry();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.toolTip2 = new global::System.Windows.Forms.ToolTip(this.components);
			this.comboBoxFolder = new global::Siticone.Desktop.UI.WinForms.SiticoneComboBox();
			this.btnIcon = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.label11 = new global::System.Windows.Forms.Label();
			this.directoryEntry2 = new global::System.DirectoryServices.DirectoryEntry();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.siticoneGradientButton3 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientButton5 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.siticoneGradientPanel1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.chkPaste_bin = new global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.btnRemovePort = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientButton4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.label5 = new global::System.Windows.Forms.Label();
			this.btnAddPort = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.btnRemoveIP = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientButton2 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientButton1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.btnAddIP = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.textIP = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtMutex = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtGroup = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtPaste_bin = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.textPort = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.YourListIPs = new global::System.Windows.Forms.ListBox();
			this.YourListPorts = new global::System.Windows.Forms.ListBox();
			this.siticoneGradientPanel5 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.btnBuild = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.textFilename = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.siticoneGradientPanel3 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.numDelay = new global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
			this.chkAnti = new global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
			this.chkAntiProcess = new global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
			this.checkBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
			this.chkBsod = new global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.siticoneTabControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneTabControl();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.siticoneGradientPanel2 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.label12 = new global::System.Windows.Forms.Label();
			this.btnAssembly = new global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
			this.chkIcon = new global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
			this.btnClone = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.txtIcon = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtCopyright = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtFileVersion = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtCompany = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtProductVersion = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtOriginalFilename = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtDescription = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtTrademarks = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.txtProduct = new global::Siticone.Desktop.UI.WinForms.SiticoneTextBox();
			this.picIcon = new global::System.Windows.Forms.PictureBox();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.tabPage2.SuspendLayout();
			this.siticoneGradientPanel1.SuspendLayout();
			this.siticoneGradientPanel5.SuspendLayout();
			this.siticoneGradientPanel3.SuspendLayout();
			this.numDelay.BeginInit();
			this.siticoneTabControl1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.siticoneGradientPanel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picIcon).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.comboBoxFolder.BackColor = global::System.Drawing.Color.Transparent;
			this.comboBoxFolder.BorderColor = global::System.Drawing.Color.FromArgb(27, 58, 38);
			this.comboBoxFolder.BorderRadius = 1;
			this.comboBoxFolder.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBoxFolder.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFolder.Enabled = false;
			this.comboBoxFolder.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.comboBoxFolder.FocusedColor = global::System.Drawing.Color.FromArgb(27, 58, 38);
			this.comboBoxFolder.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 58, 38);
			this.comboBoxFolder.FocusedState.Parent = this.comboBoxFolder;
			this.comboBoxFolder.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.comboBoxFolder.ForeColor = global::System.Drawing.Color.DarkGray;
			this.comboBoxFolder.HoverState.Parent = this.comboBoxFolder;
			this.comboBoxFolder.ItemHeight = 30;
			this.comboBoxFolder.Items.AddRange(new object[]
			{
				"%AppData%",
				"%Temp%"
			});
			this.comboBoxFolder.ItemsAppearance.Parent = this.comboBoxFolder;
			this.comboBoxFolder.Location = new global::System.Drawing.Point(316, 178);
			this.comboBoxFolder.Name = "comboBoxFolder";
			this.comboBoxFolder.ShadowDecoration.Parent = this.comboBoxFolder;
			this.comboBoxFolder.Size = new global::System.Drawing.Size(279, 36);
			this.comboBoxFolder.TabIndex = 159;
			this.toolTip2.SetToolTip(this.comboBoxFolder, "Select Startup path");
			this.btnIcon.Animated = true;
			this.btnIcon.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnIcon.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnIcon.BorderRadius = 1;
			this.btnIcon.BorderThickness = 1;
			this.btnIcon.CheckedState.Parent = this.btnIcon;
			this.btnIcon.CustomImages.Parent = this.btnIcon;
			this.btnIcon.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnIcon.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnIcon.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnIcon.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnIcon.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnIcon.DisabledState.Parent = this.btnIcon;
			this.btnIcon.Enabled = false;
			this.btnIcon.FillColor = global::System.Drawing.Color.Transparent;
			this.btnIcon.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnIcon.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnIcon.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnIcon.HoverState.Parent = this.btnIcon;
			this.btnIcon.Location = new global::System.Drawing.Point(545, 83);
			this.btnIcon.Name = "btnIcon";
			this.btnIcon.ShadowDecoration.Parent = this.btnIcon;
			this.btnIcon.Size = new global::System.Drawing.Size(242, 31);
			this.btnIcon.TabIndex = 10;
			this.btnIcon.Tag = "";
			this.btnIcon.Text = "Select icon";
			this.toolTip2.SetToolTip(this.btnIcon, "Select a FUD ico");
			this.btnIcon.Click += new global::System.EventHandler(this.BtnIcon_Click);
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label11.Location = new global::System.Drawing.Point(13, 397);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(446, 30);
			this.label11.TabIndex = 160;
			this.label11.Text = "if you are thinking to crypt the Client.exe please do not use any settings from here.\r\nI would suggest you to use the crypter settings for best results.\r\n";
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label13.Location = new global::System.Drawing.Point(107, 397);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(342, 15);
			this.label13.TabIndex = 110;
			this.label13.Text = "Before you ask me anything, check my videos first, how to use.";
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label10.Location = new global::System.Drawing.Point(107, 59);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(197, 15);
			this.label10.TabIndex = 110;
			this.label10.Text = "2 - Check if your port listening here.";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label9.Location = new global::System.Drawing.Point(107, 26);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(245, 15);
			this.label9.TabIndex = 110;
			this.label9.Text = "1 - Before you build turn off the firewall here.";
			this.siticoneGradientButton3.Animated = true;
			this.siticoneGradientButton3.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneGradientButton3.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientButton3.BorderRadius = 1;
			this.siticoneGradientButton3.BorderThickness = 1;
			this.siticoneGradientButton3.CheckedState.Parent = this.siticoneGradientButton3;
			this.siticoneGradientButton3.CustomImages.Parent = this.siticoneGradientButton3;
			this.siticoneGradientButton3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton3.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneGradientButton3.DisabledState.Parent = this.siticoneGradientButton3;
			this.siticoneGradientButton3.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton3.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneGradientButton3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton3.HoverState.Parent = this.siticoneGradientButton3;
			this.siticoneGradientButton3.Location = new global::System.Drawing.Point(437, 26);
			this.siticoneGradientButton3.Name = "siticoneGradientButton3";
			this.siticoneGradientButton3.ShadowDecoration.Parent = this.siticoneGradientButton3;
			this.siticoneGradientButton3.Size = new global::System.Drawing.Size(116, 17);
			this.siticoneGradientButton3.TabIndex = 66;
			this.siticoneGradientButton3.Text = "Disable Firewall";
			this.siticoneGradientButton3.Click += new global::System.EventHandler(this.siticoneGradientButton3_Click);
			this.siticoneGradientButton5.Animated = true;
			this.siticoneGradientButton5.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneGradientButton5.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientButton5.BorderRadius = 1;
			this.siticoneGradientButton5.BorderThickness = 1;
			this.siticoneGradientButton5.CheckedState.Parent = this.siticoneGradientButton5;
			this.siticoneGradientButton5.CustomImages.Parent = this.siticoneGradientButton5;
			this.siticoneGradientButton5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton5.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneGradientButton5.DisabledState.Parent = this.siticoneGradientButton5;
			this.siticoneGradientButton5.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton5.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton5.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneGradientButton5.ForeColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton5.HoverState.Parent = this.siticoneGradientButton5;
			this.siticoneGradientButton5.Location = new global::System.Drawing.Point(612, 395);
			this.siticoneGradientButton5.Name = "siticoneGradientButton5";
			this.siticoneGradientButton5.ShadowDecoration.Parent = this.siticoneGradientButton5;
			this.siticoneGradientButton5.Size = new global::System.Drawing.Size(106, 20);
			this.siticoneGradientButton5.TabIndex = 66;
			this.siticoneGradientButton5.Text = "Videos";
			this.siticoneGradientButton5.Click += new global::System.EventHandler(this.siticoneGradientButton5_Click);
			this.tabPage2.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.tabPage2.Controls.Add(this.siticoneGradientPanel1);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(930, 499);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "IP/DNS";
			this.siticoneGradientPanel1.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneGradientPanel1.BorderRadius = 2;
			this.siticoneGradientPanel1.BorderThickness = 5;
			this.siticoneGradientPanel1.Controls.Add(this.label13);
			this.siticoneGradientPanel1.Controls.Add(this.label10);
			this.siticoneGradientPanel1.Controls.Add(this.label9);
			this.siticoneGradientPanel1.Controls.Add(this.chkPaste_bin);
			this.siticoneGradientPanel1.Controls.Add(this.label17);
			this.siticoneGradientPanel1.Controls.Add(this.btnRemovePort);
			this.siticoneGradientPanel1.Controls.Add(this.siticoneGradientButton4);
			this.siticoneGradientPanel1.Controls.Add(this.label5);
			this.siticoneGradientPanel1.Controls.Add(this.btnAddPort);
			this.siticoneGradientPanel1.Controls.Add(this.btnRemoveIP);
			this.siticoneGradientPanel1.Controls.Add(this.siticoneGradientButton2);
			this.siticoneGradientPanel1.Controls.Add(this.siticoneGradientButton3);
			this.siticoneGradientPanel1.Controls.Add(this.siticoneGradientButton5);
			this.siticoneGradientPanel1.Controls.Add(this.siticoneGradientButton1);
			this.siticoneGradientPanel1.Controls.Add(this.btnAddIP);
			this.siticoneGradientPanel1.Controls.Add(this.textIP);
			this.siticoneGradientPanel1.Controls.Add(this.txtMutex);
			this.siticoneGradientPanel1.Controls.Add(this.txtGroup);
			this.siticoneGradientPanel1.Controls.Add(this.txtPaste_bin);
			this.siticoneGradientPanel1.Controls.Add(this.textPort);
			this.siticoneGradientPanel1.Controls.Add(this.YourListIPs);
			this.siticoneGradientPanel1.Controls.Add(this.YourListPorts);
			this.siticoneGradientPanel1.FillColor = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.siticoneGradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.siticoneGradientPanel1.Location = new global::System.Drawing.Point(23, 19);
			this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
			this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
			this.siticoneGradientPanel1.Size = new global::System.Drawing.Size(884, 438);
			this.siticoneGradientPanel1.TabIndex = 11;
			this.chkPaste_bin.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkPaste_bin.CheckedState.BorderRadius = 2;
			this.chkPaste_bin.CheckedState.BorderThickness = 1;
			this.chkPaste_bin.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkPaste_bin.CheckedState.Parent = this.chkPaste_bin;
			this.chkPaste_bin.Location = new global::System.Drawing.Point(110, 290);
			this.chkPaste_bin.Name = "chkPaste_bin";
			this.chkPaste_bin.ShadowDecoration.Parent = this.chkPaste_bin;
			this.chkPaste_bin.Size = new global::System.Drawing.Size(25, 25);
			this.chkPaste_bin.TabIndex = 93;
			this.chkPaste_bin.Text = "siticoneCustomCheckBox1";
			this.chkPaste_bin.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkPaste_bin.UncheckedState.BorderRadius = 2;
			this.chkPaste_bin.UncheckedState.BorderThickness = 0;
			this.chkPaste_bin.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkPaste_bin.UncheckedState.Parent = this.chkPaste_bin;
			this.chkPaste_bin.CheckedChanged += new global::System.EventHandler(this.CheckBox2_CheckedChanged);
			this.label17.AutoSize = true;
			this.label17.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label17.Location = new global::System.Drawing.Point(441, 257);
			this.label17.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(103, 13);
			this.label17.TabIndex = 109;
			this.label17.Text = "Venom Group Name";
			this.btnRemovePort.Animated = true;
			this.btnRemovePort.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnRemovePort.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnRemovePort.BorderRadius = 1;
			this.btnRemovePort.BorderThickness = 1;
			this.btnRemovePort.CheckedState.Parent = this.btnRemovePort;
			this.btnRemovePort.CustomImages.Parent = this.btnRemovePort;
			this.btnRemovePort.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnRemovePort.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnRemovePort.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnRemovePort.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnRemovePort.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRemovePort.DisabledState.Parent = this.btnRemovePort;
			this.btnRemovePort.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRemovePort.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnRemovePort.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRemovePort.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnRemovePort.HoverState.Parent = this.btnRemovePort;
			this.btnRemovePort.Location = new global::System.Drawing.Point(612, 114);
			this.btnRemovePort.Name = "btnRemovePort";
			this.btnRemovePort.ShadowDecoration.Parent = this.btnRemovePort;
			this.btnRemovePort.Size = new global::System.Drawing.Size(106, 31);
			this.btnRemovePort.TabIndex = 66;
			this.btnRemovePort.Text = "Remove";
			this.btnRemovePort.Click += new global::System.EventHandler(this.BtnRemovePort_Click);
			this.siticoneGradientButton4.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneGradientButton4.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton4.BorderRadius = 1;
			this.siticoneGradientButton4.BorderThickness = 1;
			this.siticoneGradientButton4.CheckedState.Parent = this.siticoneGradientButton4;
			this.siticoneGradientButton4.CustomImages.Parent = this.siticoneGradientButton4;
			this.siticoneGradientButton4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton4.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneGradientButton4.DisabledState.Parent = this.siticoneGradientButton4;
			this.siticoneGradientButton4.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton4.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneGradientButton4.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneGradientButton4.HoverState.Parent = this.siticoneGradientButton4;
			this.siticoneGradientButton4.Location = new global::System.Drawing.Point(612, 114);
			this.siticoneGradientButton4.Name = "siticoneGradientButton4";
			this.siticoneGradientButton4.ShadowDecoration.Parent = this.siticoneGradientButton4;
			this.siticoneGradientButton4.Size = new global::System.Drawing.Size(106, 31);
			this.siticoneGradientButton4.TabIndex = 66;
			this.siticoneGradientButton4.Text = "HVNC Panel";
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label5.Location = new global::System.Drawing.Point(441, 304);
			this.label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(74, 13);
			this.label5.TabIndex = 103;
			this.label5.Text = "Custom Mutex";
			this.btnAddPort.Animated = true;
			this.btnAddPort.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnAddPort.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnAddPort.BorderRadius = 1;
			this.btnAddPort.BorderThickness = 1;
			this.btnAddPort.CheckedState.Parent = this.btnAddPort;
			this.btnAddPort.CustomImages.Parent = this.btnAddPort;
			this.btnAddPort.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnAddPort.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnAddPort.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnAddPort.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnAddPort.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddPort.DisabledState.Parent = this.btnAddPort;
			this.btnAddPort.FillColor = global::System.Drawing.Color.Transparent;
			this.btnAddPort.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnAddPort.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddPort.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnAddPort.HoverState.Parent = this.btnAddPort;
			this.btnAddPort.Location = new global::System.Drawing.Point(439, 114);
			this.btnAddPort.Name = "btnAddPort";
			this.btnAddPort.ShadowDecoration.Parent = this.btnAddPort;
			this.btnAddPort.Size = new global::System.Drawing.Size(106, 31);
			this.btnAddPort.TabIndex = 66;
			this.btnAddPort.Text = "Add";
			this.btnAddPort.Click += new global::System.EventHandler(this.BtnAddPort_Click);
			this.btnRemoveIP.Animated = true;
			this.btnRemoveIP.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnRemoveIP.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnRemoveIP.BorderRadius = 1;
			this.btnRemoveIP.BorderThickness = 1;
			this.btnRemoveIP.CheckedState.Parent = this.btnRemoveIP;
			this.btnRemoveIP.CustomImages.Parent = this.btnRemoveIP;
			this.btnRemoveIP.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnRemoveIP.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnRemoveIP.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnRemoveIP.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnRemoveIP.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRemoveIP.DisabledState.Parent = this.btnRemoveIP;
			this.btnRemoveIP.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRemoveIP.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnRemoveIP.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRemoveIP.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnRemoveIP.HoverState.Parent = this.btnRemoveIP;
			this.btnRemoveIP.Location = new global::System.Drawing.Point(283, 114);
			this.btnRemoveIP.Name = "btnRemoveIP";
			this.btnRemoveIP.ShadowDecoration.Parent = this.btnRemoveIP;
			this.btnRemoveIP.Size = new global::System.Drawing.Size(106, 31);
			this.btnRemoveIP.TabIndex = 66;
			this.btnRemoveIP.Text = "Remove";
			this.btnRemoveIP.Click += new global::System.EventHandler(this.BtnRemoveIP_Click);
			this.siticoneGradientButton2.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneGradientButton2.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton2.BorderRadius = 1;
			this.siticoneGradientButton2.BorderThickness = 1;
			this.siticoneGradientButton2.CheckedState.Parent = this.siticoneGradientButton2;
			this.siticoneGradientButton2.CustomImages.Parent = this.siticoneGradientButton2;
			this.siticoneGradientButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneGradientButton2.DisabledState.Parent = this.siticoneGradientButton2;
			this.siticoneGradientButton2.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton2.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneGradientButton2.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneGradientButton2.HoverState.Parent = this.siticoneGradientButton2;
			this.siticoneGradientButton2.Location = new global::System.Drawing.Point(439, 114);
			this.siticoneGradientButton2.Name = "siticoneGradientButton2";
			this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
			this.siticoneGradientButton2.Size = new global::System.Drawing.Size(106, 31);
			this.siticoneGradientButton2.TabIndex = 66;
			this.siticoneGradientButton2.Text = "HVNC Panel";
			this.siticoneGradientButton1.Animated = true;
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
			this.siticoneGradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneGradientButton1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton1.HoverState.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.Location = new global::System.Drawing.Point(437, 59);
			this.siticoneGradientButton1.Name = "siticoneGradientButton1";
			this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.Size = new global::System.Drawing.Size(116, 17);
			this.siticoneGradientButton1.TabIndex = 66;
			this.siticoneGradientButton1.Text = "Check port";
			this.siticoneGradientButton1.Click += new global::System.EventHandler(this.siticoneGradientButton1_Click);
			this.btnAddIP.Animated = true;
			this.btnAddIP.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnAddIP.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnAddIP.BorderRadius = 1;
			this.btnAddIP.BorderThickness = 1;
			this.btnAddIP.CheckedState.Parent = this.btnAddIP;
			this.btnAddIP.CustomImages.Parent = this.btnAddIP;
			this.btnAddIP.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnAddIP.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnAddIP.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnAddIP.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnAddIP.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddIP.DisabledState.Parent = this.btnAddIP;
			this.btnAddIP.FillColor = global::System.Drawing.Color.Transparent;
			this.btnAddIP.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnAddIP.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddIP.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnAddIP.HoverState.Parent = this.btnAddIP;
			this.btnAddIP.Location = new global::System.Drawing.Point(110, 114);
			this.btnAddIP.Name = "btnAddIP";
			this.btnAddIP.ShadowDecoration.Parent = this.btnAddIP;
			this.btnAddIP.Size = new global::System.Drawing.Size(106, 31);
			this.btnAddIP.TabIndex = 66;
			this.btnAddIP.Text = "Add";
			this.btnAddIP.Click += new global::System.EventHandler(this.BtnAddIP_Click);
			this.textIP.Animated = true;
			this.textIP.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.textIP.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textIP.DefaultText = "";
			this.textIP.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textIP.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textIP.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textIP.DisabledState.Parent = this.textIP;
			this.textIP.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textIP.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.textIP.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textIP.FocusedState.Parent = this.textIP;
			this.textIP.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textIP.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.textIP.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textIP.HoverState.Parent = this.textIP;
			this.textIP.Location = new global::System.Drawing.Point(110, 168);
			this.textIP.Name = "textIP";
			this.textIP.PasswordChar = '\0';
			this.textIP.PlaceholderText = "";
			this.textIP.SelectedText = "";
			this.textIP.ShadowDecoration.Parent = this.textIP;
			this.textIP.Size = new global::System.Drawing.Size(279, 28);
			this.textIP.TabIndex = 1;
			this.txtMutex.Animated = true;
			this.txtMutex.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtMutex.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtMutex.DefaultText = "Venom_RAT_HVNC_Mutex_Venom RAT_HVNC";
			this.txtMutex.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtMutex.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtMutex.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMutex.DisabledState.Parent = this.txtMutex;
			this.txtMutex.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMutex.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtMutex.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtMutex.FocusedState.Parent = this.txtMutex;
			this.txtMutex.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtMutex.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtMutex.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtMutex.HoverState.Parent = this.txtMutex;
			this.txtMutex.Location = new global::System.Drawing.Point(439, 318);
			this.txtMutex.Name = "txtMutex";
			this.txtMutex.PasswordChar = '\0';
			this.txtMutex.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtMutex.PlaceholderText = "";
			this.txtMutex.SelectedText = "";
			this.txtMutex.SelectionStart = 35;
			this.txtMutex.ShadowDecoration.Parent = this.txtMutex;
			this.txtMutex.Size = new global::System.Drawing.Size(279, 28);
			this.txtMutex.TabIndex = 1;
			this.txtGroup.Animated = true;
			this.txtGroup.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtGroup.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtGroup.DefaultText = "Venom Clients";
			this.txtGroup.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtGroup.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtGroup.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtGroup.DisabledState.Parent = this.txtGroup;
			this.txtGroup.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtGroup.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtGroup.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtGroup.FocusedState.Parent = this.txtGroup;
			this.txtGroup.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGroup.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtGroup.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtGroup.HoverState.Parent = this.txtGroup;
			this.txtGroup.Location = new global::System.Drawing.Point(439, 273);
			this.txtGroup.Name = "txtGroup";
			this.txtGroup.PasswordChar = '\0';
			this.txtGroup.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtGroup.PlaceholderText = "";
			this.txtGroup.SelectedText = "";
			this.txtGroup.SelectionStart = 13;
			this.txtGroup.ShadowDecoration.Parent = this.txtGroup;
			this.txtGroup.Size = new global::System.Drawing.Size(279, 28);
			this.txtGroup.TabIndex = 1;
			this.txtPaste_bin.Animated = true;
			this.txtPaste_bin.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtPaste_bin.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPaste_bin.DefaultText = "Paste DNS/IP URL";
			this.txtPaste_bin.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtPaste_bin.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtPaste_bin.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPaste_bin.DisabledState.Parent = this.txtPaste_bin;
			this.txtPaste_bin.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPaste_bin.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtPaste_bin.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtPaste_bin.FocusedState.Parent = this.txtPaste_bin;
			this.txtPaste_bin.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPaste_bin.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtPaste_bin.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtPaste_bin.HoverState.Parent = this.txtPaste_bin;
			this.txtPaste_bin.Location = new global::System.Drawing.Point(110, 318);
			this.txtPaste_bin.Name = "txtPaste_bin";
			this.txtPaste_bin.PasswordChar = '\0';
			this.txtPaste_bin.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtPaste_bin.PlaceholderText = "";
			this.txtPaste_bin.SelectedText = "";
			this.txtPaste_bin.SelectionStart = 16;
			this.txtPaste_bin.ShadowDecoration.Parent = this.txtPaste_bin;
			this.txtPaste_bin.Size = new global::System.Drawing.Size(279, 28);
			this.txtPaste_bin.TabIndex = 1;
			this.textPort.Animated = true;
			this.textPort.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.textPort.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textPort.DefaultText = "";
			this.textPort.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textPort.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textPort.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textPort.DisabledState.Parent = this.textPort;
			this.textPort.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textPort.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.textPort.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textPort.FocusedState.Parent = this.textPort;
			this.textPort.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textPort.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.textPort.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textPort.HoverState.Parent = this.textPort;
			this.textPort.Location = new global::System.Drawing.Point(439, 168);
			this.textPort.Name = "textPort";
			this.textPort.PasswordChar = '\0';
			this.textPort.PlaceholderText = "";
			this.textPort.SelectedText = "";
			this.textPort.ShadowDecoration.Parent = this.textPort;
			this.textPort.Size = new global::System.Drawing.Size(279, 28);
			this.textPort.TabIndex = 1;
			this.YourListIPs.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.YourListIPs.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.YourListIPs.ForeColor = global::System.Drawing.Color.DarkGray;
			this.YourListIPs.FormattingEnabled = true;
			this.YourListIPs.Location = new global::System.Drawing.Point(110, 205);
			this.YourListIPs.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 2);
			this.YourListIPs.Name = "YourListIPs";
			this.YourListIPs.Size = new global::System.Drawing.Size(279, 26);
			this.YourListIPs.TabIndex = 65;
			this.YourListPorts.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.YourListPorts.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.YourListPorts.ForeColor = global::System.Drawing.Color.DarkGray;
			this.YourListPorts.FormattingEnabled = true;
			this.YourListPorts.Location = new global::System.Drawing.Point(439, 205);
			this.YourListPorts.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 2);
			this.YourListPorts.Name = "YourListPorts";
			this.YourListPorts.Size = new global::System.Drawing.Size(279, 26);
			this.YourListPorts.TabIndex = 65;
			this.siticoneGradientPanel5.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel5.Controls.Add(this.btnBuild);
			this.siticoneGradientPanel5.Controls.Add(this.siticoneControlBox1);
			this.siticoneGradientPanel5.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel5.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel5.FillColor2 = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel5.Location = new global::System.Drawing.Point(0, 591);
			this.siticoneGradientPanel5.Name = "siticoneGradientPanel5";
			this.siticoneGradientPanel5.ShadowDecoration.Parent = this.siticoneGradientPanel5;
			this.siticoneGradientPanel5.Size = new global::System.Drawing.Size(938, 31);
			this.siticoneGradientPanel5.TabIndex = 128;
			this.btnBuild.Animated = true;
			this.btnBuild.AnimatedGIF = true;
			this.btnBuild.BackColor = global::System.Drawing.Color.Transparent;
			this.btnBuild.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnBuild.BorderRadius = 1;
			this.btnBuild.BorderThickness = 1;
			this.btnBuild.CheckedState.Parent = this.btnBuild;
			this.btnBuild.CustomImages.Parent = this.btnBuild;
			this.btnBuild.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnBuild.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnBuild.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnBuild.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnBuild.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnBuild.DisabledState.Parent = this.btnBuild;
			this.btnBuild.FillColor = global::System.Drawing.Color.Transparent;
			this.btnBuild.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnBuild.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnBuild.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnBuild.HoverState.Parent = this.btnBuild;
			this.btnBuild.Location = new global::System.Drawing.Point(786, 0);
			this.btnBuild.Name = "btnBuild";
			this.btnBuild.ShadowDecoration.Parent = this.btnBuild;
			this.btnBuild.Size = new global::System.Drawing.Size(106, 31);
			this.btnBuild.TabIndex = 117;
			this.btnBuild.Text = "Build .exe";
			this.btnBuild.Click += new global::System.EventHandler(this.BtnBuild_Click);
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(908, 0);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(30, 30);
			this.siticoneControlBox1.TabIndex = 8;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.textFilename.Animated = true;
			this.textFilename.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.textFilename.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textFilename.DefaultText = "";
			this.textFilename.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textFilename.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textFilename.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textFilename.DisabledState.Parent = this.textFilename;
			this.textFilename.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textFilename.Enabled = false;
			this.textFilename.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.textFilename.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textFilename.FocusedState.Parent = this.textFilename;
			this.textFilename.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textFilename.ForeColor = global::System.Drawing.Color.DarkGray;
			this.textFilename.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.textFilename.HoverState.Parent = this.textFilename;
			this.textFilename.Location = new global::System.Drawing.Point(316, 139);
			this.textFilename.Name = "textFilename";
			this.textFilename.PasswordChar = '\0';
			this.textFilename.PlaceholderText = "";
			this.textFilename.SelectedText = "";
			this.textFilename.ShadowDecoration.Parent = this.textFilename;
			this.textFilename.Size = new global::System.Drawing.Size(279, 28);
			this.textFilename.TabIndex = 158;
			this.siticoneGradientPanel3.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneGradientPanel3.BorderRadius = 2;
			this.siticoneGradientPanel3.BorderThickness = 5;
			this.siticoneGradientPanel3.Controls.Add(this.numDelay);
			this.siticoneGradientPanel3.Controls.Add(this.label11);
			this.siticoneGradientPanel3.Controls.Add(this.comboBoxFolder);
			this.siticoneGradientPanel3.Controls.Add(this.textFilename);
			this.siticoneGradientPanel3.Controls.Add(this.chkAnti);
			this.siticoneGradientPanel3.Controls.Add(this.chkAntiProcess);
			this.siticoneGradientPanel3.Controls.Add(this.checkBox1);
			this.siticoneGradientPanel3.Controls.Add(this.chkBsod);
			this.siticoneGradientPanel3.Controls.Add(this.label2);
			this.siticoneGradientPanel3.Controls.Add(this.label6);
			this.siticoneGradientPanel3.Controls.Add(this.label7);
			this.siticoneGradientPanel3.Controls.Add(this.label8);
			this.siticoneGradientPanel3.Controls.Add(this.label4);
			this.siticoneGradientPanel3.Controls.Add(this.label3);
			this.siticoneGradientPanel3.Controls.Add(this.label16);
			this.siticoneGradientPanel3.FillColor = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.siticoneGradientPanel3.FillColor2 = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.siticoneGradientPanel3.Location = new global::System.Drawing.Point(23, 19);
			this.siticoneGradientPanel3.Name = "siticoneGradientPanel3";
			this.siticoneGradientPanel3.ShadowDecoration.Parent = this.siticoneGradientPanel3;
			this.siticoneGradientPanel3.Size = new global::System.Drawing.Size(884, 438);
			this.siticoneGradientPanel3.TabIndex = 11;
			this.numDelay.BackColor = global::System.Drawing.Color.Transparent;
			this.numDelay.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.numDelay.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.numDelay.DisabledState.Parent = this.numDelay;
			this.numDelay.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.numDelay.FocusedState.Parent = this.numDelay;
			this.numDelay.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.numDelay.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.numDelay.Location = new global::System.Drawing.Point(316, 222);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown = this.numDelay;
			int[] array = new int[4];
			array[0] = 65535;
			siticoneNumericUpDown.Maximum = new decimal(array);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown2 = this.numDelay;
			int[] array2 = new int[4];
			array2[0] = 1;
			siticoneNumericUpDown2.Minimum = new decimal(array2);
			this.numDelay.Name = "numDelay";
			this.numDelay.ShadowDecoration.Parent = this.numDelay;
			this.numDelay.Size = new global::System.Drawing.Size(100, 26);
			this.numDelay.TabIndex = 161;
			this.numDelay.UpDownButtonFillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.numDelay.UpDownButtonForeColor = global::System.Drawing.Color.FromArgb(80, 0, 0, 0);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown3 = this.numDelay;
			int[] array3 = new int[4];
			array3[0] = 1;
			siticoneNumericUpDown3.Value = new decimal(array3);
			this.chkAnti.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkAnti.CheckedState.BorderRadius = 2;
			this.chkAnti.CheckedState.BorderThickness = 1;
			this.chkAnti.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkAnti.CheckedState.Parent = this.chkAnti;
			this.chkAnti.Location = new global::System.Drawing.Point(485, 223);
			this.chkAnti.Name = "chkAnti";
			this.chkAnti.ShadowDecoration.Parent = this.chkAnti;
			this.chkAnti.Size = new global::System.Drawing.Size(25, 25);
			this.chkAnti.TabIndex = 113;
			this.chkAnti.Text = "siticoneCustomCheckBox1";
			this.chkAnti.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkAnti.UncheckedState.BorderRadius = 2;
			this.chkAnti.UncheckedState.BorderThickness = 0;
			this.chkAnti.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkAnti.UncheckedState.Parent = this.chkAnti;
			this.chkAntiProcess.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkAntiProcess.CheckedState.BorderRadius = 2;
			this.chkAntiProcess.CheckedState.BorderThickness = 1;
			this.chkAntiProcess.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkAntiProcess.CheckedState.Parent = this.chkAntiProcess;
			this.chkAntiProcess.Location = new global::System.Drawing.Point(316, 264);
			this.chkAntiProcess.Name = "chkAntiProcess";
			this.chkAntiProcess.ShadowDecoration.Parent = this.chkAntiProcess;
			this.chkAntiProcess.Size = new global::System.Drawing.Size(25, 25);
			this.chkAntiProcess.TabIndex = 113;
			this.chkAntiProcess.Text = "siticoneCustomCheckBox1";
			this.chkAntiProcess.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkAntiProcess.UncheckedState.BorderRadius = 2;
			this.chkAntiProcess.UncheckedState.BorderThickness = 0;
			this.chkAntiProcess.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkAntiProcess.UncheckedState.Parent = this.chkAntiProcess;
			this.checkBox1.Animated = true;
			this.checkBox1.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.checkBox1.CheckedState.BorderRadius = 2;
			this.checkBox1.CheckedState.BorderThickness = 1;
			this.checkBox1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.checkBox1.CheckedState.Parent = this.checkBox1;
			this.checkBox1.Location = new global::System.Drawing.Point(316, 103);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.ShadowDecoration.Parent = this.checkBox1;
			this.checkBox1.Size = new global::System.Drawing.Size(25, 25);
			this.checkBox1.TabIndex = 113;
			this.checkBox1.Text = "siticoneCustomCheckBox1";
			this.checkBox1.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.checkBox1.UncheckedState.BorderRadius = 2;
			this.checkBox1.UncheckedState.BorderThickness = 0;
			this.checkBox1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.checkBox1.UncheckedState.Parent = this.checkBox1;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.chkBsod.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkBsod.CheckedState.BorderRadius = 2;
			this.chkBsod.CheckedState.BorderThickness = 1;
			this.chkBsod.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkBsod.CheckedState.Parent = this.chkBsod;
			this.chkBsod.Location = new global::System.Drawing.Point(485, 264);
			this.chkBsod.Name = "chkBsod";
			this.chkBsod.ShadowDecoration.Parent = this.chkBsod;
			this.chkBsod.Size = new global::System.Drawing.Size(25, 25);
			this.chkBsod.TabIndex = 113;
			this.chkBsod.Text = "siticoneCustomCheckBox1";
			this.chkBsod.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkBsod.UncheckedState.BorderRadius = 2;
			this.chkBsod.UncheckedState.BorderThickness = 0;
			this.chkBsod.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkBsod.UncheckedState.Parent = this.chkBsod;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label2.Location = new global::System.Drawing.Point(517, 266);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(83, 15);
			this.label2.TabIndex = 98;
			this.label2.Text = "Enable BSOD";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label6.Location = new global::System.Drawing.Point(263, 104);
			this.label6.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(49, 15);
			this.label6.TabIndex = 98;
			this.label6.Text = "Startup:";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label7.Location = new global::System.Drawing.Point(348, 267);
			this.label7.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(100, 15);
			this.label7.TabIndex = 98;
			this.label7.Text = "Disable Taskmgr";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label8.Location = new global::System.Drawing.Point(517, 227);
			this.label8.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(78, 15);
			this.label8.TabIndex = 98;
			this.label8.Text = "Blocked VMs";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label4.Location = new global::System.Drawing.Point(235, 145);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(77, 15);
			this.label4.TabIndex = 98;
			this.label4.Text = "Install name:";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label3.Location = new global::System.Drawing.Point(243, 186);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(69, 15);
			this.label3.TabIndex = 97;
			this.label3.Text = "Install path:";
			this.label16.AutoSize = true;
			this.label16.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label16.Location = new global::System.Drawing.Point(244, 227);
			this.label16.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(68, 15);
			this.label16.TabIndex = 107;
			this.label16.Text = "Delay time:";
			this.siticoneTabControl1.Controls.Add(this.tabPage2);
			this.siticoneTabControl1.Controls.Add(this.tabPage3);
			this.siticoneTabControl1.Controls.Add(this.tabPage1);
			this.siticoneTabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.siticoneTabControl1.ItemSize = new global::System.Drawing.Size(311, 40);
			this.siticoneTabControl1.Location = new global::System.Drawing.Point(0, 75);
			this.siticoneTabControl1.Name = "siticoneTabControl1";
			this.siticoneTabControl1.SelectedIndex = 0;
			this.siticoneTabControl1.Size = new global::System.Drawing.Size(938, 547);
			this.siticoneTabControl1.TabButtonHoverState.BorderColor = global::System.Drawing.Color.Empty;
			this.siticoneTabControl1.TabButtonHoverState.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTabControl1.TabButtonHoverState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.siticoneTabControl1.TabButtonHoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneTabControl1.TabButtonHoverState.InnerColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTabControl1.TabButtonIdleState.BorderColor = global::System.Drawing.Color.Empty;
			this.siticoneTabControl1.TabButtonIdleState.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTabControl1.TabButtonIdleState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.siticoneTabControl1.TabButtonIdleState.ForeColor = global::System.Drawing.Color.FromArgb(156, 160, 167);
			this.siticoneTabControl1.TabButtonIdleState.InnerColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTabControl1.TabButtonSelectedState.BorderColor = global::System.Drawing.Color.Empty;
			this.siticoneTabControl1.TabButtonSelectedState.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTabControl1.TabButtonSelectedState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.siticoneTabControl1.TabButtonSelectedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneTabControl1.TabButtonSelectedState.InnerColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneTabControl1.TabButtonSize = new global::System.Drawing.Size(311, 40);
			this.siticoneTabControl1.TabIndex = 125;
			this.siticoneTabControl1.TabMenuBackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTabControl1.TabMenuOrientation = 0;
			this.tabPage3.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.tabPage3.Controls.Add(this.siticoneGradientPanel3);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new global::System.Drawing.Size(930, 499);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Startup";
			this.tabPage1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.tabPage1.Controls.Add(this.siticoneGradientPanel2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(930, 499);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Assembly";
			this.siticoneGradientPanel2.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneGradientPanel2.BorderRadius = 2;
			this.siticoneGradientPanel2.BorderThickness = 5;
			this.siticoneGradientPanel2.Controls.Add(this.label12);
			this.siticoneGradientPanel2.Controls.Add(this.btnAssembly);
			this.siticoneGradientPanel2.Controls.Add(this.chkIcon);
			this.siticoneGradientPanel2.Controls.Add(this.btnIcon);
			this.siticoneGradientPanel2.Controls.Add(this.btnClone);
			this.siticoneGradientPanel2.Controls.Add(this.txtIcon);
			this.siticoneGradientPanel2.Controls.Add(this.txtCopyright);
			this.siticoneGradientPanel2.Controls.Add(this.txtFileVersion);
			this.siticoneGradientPanel2.Controls.Add(this.txtCompany);
			this.siticoneGradientPanel2.Controls.Add(this.txtProductVersion);
			this.siticoneGradientPanel2.Controls.Add(this.txtOriginalFilename);
			this.siticoneGradientPanel2.Controls.Add(this.txtDescription);
			this.siticoneGradientPanel2.Controls.Add(this.txtTrademarks);
			this.siticoneGradientPanel2.Controls.Add(this.txtProduct);
			this.siticoneGradientPanel2.Controls.Add(this.picIcon);
			this.siticoneGradientPanel2.FillColor = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.siticoneGradientPanel2.FillColor2 = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.siticoneGradientPanel2.Location = new global::System.Drawing.Point(23, 19);
			this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
			this.siticoneGradientPanel2.ShadowDecoration.Parent = this.siticoneGradientPanel2;
			this.siticoneGradientPanel2.Size = new global::System.Drawing.Size(884, 438);
			this.siticoneGradientPanel2.TabIndex = 10;
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label12.Location = new global::System.Drawing.Point(12, 397);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(446, 30);
			this.label12.TabIndex = 161;
			this.label12.Text = "if you are thinking to crypt the Client.exe please do not use any settings from here.\r\nI would suggest you to use the crypter settings for best results.\r\n";
			this.btnAssembly.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnAssembly.CheckedState.BorderRadius = 2;
			this.btnAssembly.CheckedState.BorderThickness = 1;
			this.btnAssembly.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.btnAssembly.CheckedState.Parent = this.btnAssembly;
			this.btnAssembly.Location = new global::System.Drawing.Point(326, 83);
			this.btnAssembly.Name = "btnAssembly";
			this.btnAssembly.ShadowDecoration.Parent = this.btnAssembly;
			this.btnAssembly.Size = new global::System.Drawing.Size(25, 25);
			this.btnAssembly.TabIndex = 92;
			this.btnAssembly.Text = "siticoneCustomCheckBox1";
			this.btnAssembly.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnAssembly.UncheckedState.BorderRadius = 2;
			this.btnAssembly.UncheckedState.BorderThickness = 0;
			this.btnAssembly.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnAssembly.UncheckedState.Parent = this.btnAssembly;
			this.btnAssembly.CheckedChanged += new global::System.EventHandler(this.BtnAssembly_CheckedChanged);
			this.chkIcon.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkIcon.CheckedState.BorderRadius = 2;
			this.chkIcon.CheckedState.BorderThickness = 1;
			this.chkIcon.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.chkIcon.CheckedState.Parent = this.chkIcon;
			this.chkIcon.Location = new global::System.Drawing.Point(508, 83);
			this.chkIcon.Name = "chkIcon";
			this.chkIcon.ShadowDecoration.Parent = this.chkIcon;
			this.chkIcon.Size = new global::System.Drawing.Size(25, 25);
			this.chkIcon.TabIndex = 92;
			this.chkIcon.Text = "siticoneCustomCheckBox1";
			this.chkIcon.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkIcon.UncheckedState.BorderRadius = 2;
			this.chkIcon.UncheckedState.BorderThickness = 0;
			this.chkIcon.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.chkIcon.UncheckedState.Parent = this.chkIcon;
			this.chkIcon.CheckedChanged += new global::System.EventHandler(this.ChkIcon_CheckedChanged);
			this.btnClone.Animated = true;
			this.btnClone.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnClone.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnClone.BorderRadius = 1;
			this.btnClone.BorderThickness = 1;
			this.btnClone.CheckedState.Parent = this.btnClone;
			this.btnClone.CustomImages.Parent = this.btnClone;
			this.btnClone.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnClone.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnClone.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnClone.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnClone.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnClone.DisabledState.Parent = this.btnClone;
			this.btnClone.Enabled = false;
			this.btnClone.FillColor = global::System.Drawing.Color.Transparent;
			this.btnClone.FillColor2 = global::System.Drawing.Color.Transparent;
			this.btnClone.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnClone.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnClone.HoverState.Parent = this.btnClone;
			this.btnClone.Location = new global::System.Drawing.Point(104, 83);
			this.btnClone.Name = "btnClone";
			this.btnClone.ShadowDecoration.Parent = this.btnClone;
			this.btnClone.Size = new global::System.Drawing.Size(204, 31);
			this.btnClone.TabIndex = 10;
			this.btnClone.Text = "Clone Assembly";
			this.btnClone.Click += new global::System.EventHandler(this.BtnClone_Click);
			this.txtIcon.Animated = true;
			this.txtIcon.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtIcon.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtIcon.DefaultText = "";
			this.txtIcon.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtIcon.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtIcon.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtIcon.DisabledState.Parent = this.txtIcon;
			this.txtIcon.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtIcon.Enabled = false;
			this.txtIcon.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtIcon.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtIcon.FocusedState.Parent = this.txtIcon;
			this.txtIcon.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtIcon.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtIcon.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtIcon.HoverState.Parent = this.txtIcon;
			this.txtIcon.Location = new global::System.Drawing.Point(508, 328);
			this.txtIcon.Name = "txtIcon";
			this.txtIcon.PasswordChar = '\0';
			this.txtIcon.PlaceholderText = "";
			this.txtIcon.SelectedText = "";
			this.txtIcon.ShadowDecoration.Parent = this.txtIcon;
			this.txtIcon.Size = new global::System.Drawing.Size(279, 28);
			this.txtIcon.TabIndex = 0;
			this.txtCopyright.Animated = true;
			this.txtCopyright.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtCopyright.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCopyright.DefaultText = "";
			this.txtCopyright.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtCopyright.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtCopyright.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCopyright.DisabledState.Parent = this.txtCopyright;
			this.txtCopyright.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCopyright.Enabled = false;
			this.txtCopyright.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtCopyright.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtCopyright.FocusedState.Parent = this.txtCopyright;
			this.txtCopyright.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCopyright.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtCopyright.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtCopyright.HoverState.Parent = this.txtCopyright;
			this.txtCopyright.Location = new global::System.Drawing.Point(104, 212);
			this.txtCopyright.Name = "txtCopyright";
			this.txtCopyright.PasswordChar = '\0';
			this.txtCopyright.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtCopyright.PlaceholderText = "Copyright";
			this.txtCopyright.SelectedText = "";
			this.txtCopyright.ShadowDecoration.Parent = this.txtCopyright;
			this.txtCopyright.Size = new global::System.Drawing.Size(242, 28);
			this.txtCopyright.TabIndex = 0;
			this.txtFileVersion.Animated = true;
			this.txtFileVersion.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtFileVersion.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtFileVersion.DefaultText = "";
			this.txtFileVersion.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtFileVersion.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtFileVersion.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFileVersion.DisabledState.Parent = this.txtFileVersion;
			this.txtFileVersion.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFileVersion.Enabled = false;
			this.txtFileVersion.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtFileVersion.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtFileVersion.FocusedState.Parent = this.txtFileVersion;
			this.txtFileVersion.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtFileVersion.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtFileVersion.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtFileVersion.HoverState.Parent = this.txtFileVersion;
			this.txtFileVersion.Location = new global::System.Drawing.Point(104, 328);
			this.txtFileVersion.Name = "txtFileVersion";
			this.txtFileVersion.PasswordChar = '\0';
			this.txtFileVersion.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtFileVersion.PlaceholderText = "File Version: 0.0.0.0";
			this.txtFileVersion.SelectedText = "";
			this.txtFileVersion.ShadowDecoration.Parent = this.txtFileVersion;
			this.txtFileVersion.Size = new global::System.Drawing.Size(242, 28);
			this.txtFileVersion.TabIndex = 0;
			this.txtCompany.Animated = true;
			this.txtCompany.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtCompany.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCompany.DefaultText = "";
			this.txtCompany.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtCompany.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtCompany.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCompany.DisabledState.Parent = this.txtCompany;
			this.txtCompany.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCompany.Enabled = false;
			this.txtCompany.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtCompany.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtCompany.FocusedState.Parent = this.txtCompany;
			this.txtCompany.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCompany.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtCompany.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtCompany.HoverState.Parent = this.txtCompany;
			this.txtCompany.Location = new global::System.Drawing.Point(104, 183);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.PasswordChar = '\0';
			this.txtCompany.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtCompany.PlaceholderText = "Company";
			this.txtCompany.SelectedText = "";
			this.txtCompany.ShadowDecoration.Parent = this.txtCompany;
			this.txtCompany.Size = new global::System.Drawing.Size(242, 28);
			this.txtCompany.TabIndex = 0;
			this.txtProductVersion.Animated = true;
			this.txtProductVersion.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtProductVersion.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtProductVersion.DefaultText = "";
			this.txtProductVersion.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtProductVersion.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtProductVersion.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtProductVersion.DisabledState.Parent = this.txtProductVersion;
			this.txtProductVersion.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtProductVersion.Enabled = false;
			this.txtProductVersion.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtProductVersion.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtProductVersion.FocusedState.Parent = this.txtProductVersion;
			this.txtProductVersion.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtProductVersion.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtProductVersion.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtProductVersion.HoverState.Parent = this.txtProductVersion;
			this.txtProductVersion.Location = new global::System.Drawing.Point(104, 299);
			this.txtProductVersion.Name = "txtProductVersion";
			this.txtProductVersion.PasswordChar = '\0';
			this.txtProductVersion.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtProductVersion.PlaceholderText = "Product Version: 0.0.0.0";
			this.txtProductVersion.SelectedText = "";
			this.txtProductVersion.ShadowDecoration.Parent = this.txtProductVersion;
			this.txtProductVersion.Size = new global::System.Drawing.Size(242, 28);
			this.txtProductVersion.TabIndex = 0;
			this.txtOriginalFilename.Animated = true;
			this.txtOriginalFilename.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtOriginalFilename.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtOriginalFilename.DefaultText = "";
			this.txtOriginalFilename.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtOriginalFilename.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtOriginalFilename.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtOriginalFilename.DisabledState.Parent = this.txtOriginalFilename;
			this.txtOriginalFilename.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtOriginalFilename.Enabled = false;
			this.txtOriginalFilename.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtOriginalFilename.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtOriginalFilename.FocusedState.Parent = this.txtOriginalFilename;
			this.txtOriginalFilename.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtOriginalFilename.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtOriginalFilename.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtOriginalFilename.HoverState.Parent = this.txtOriginalFilename;
			this.txtOriginalFilename.Location = new global::System.Drawing.Point(104, 270);
			this.txtOriginalFilename.Name = "txtOriginalFilename";
			this.txtOriginalFilename.PasswordChar = '\0';
			this.txtOriginalFilename.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtOriginalFilename.PlaceholderText = "Original Filename";
			this.txtOriginalFilename.SelectedText = "";
			this.txtOriginalFilename.ShadowDecoration.Parent = this.txtOriginalFilename;
			this.txtOriginalFilename.Size = new global::System.Drawing.Size(242, 28);
			this.txtOriginalFilename.TabIndex = 0;
			this.txtDescription.Animated = true;
			this.txtDescription.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtDescription.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtDescription.DefaultText = "";
			this.txtDescription.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtDescription.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtDescription.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtDescription.DisabledState.Parent = this.txtDescription;
			this.txtDescription.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtDescription.Enabled = false;
			this.txtDescription.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtDescription.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtDescription.FocusedState.Parent = this.txtDescription;
			this.txtDescription.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtDescription.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtDescription.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtDescription.HoverState.Parent = this.txtDescription;
			this.txtDescription.Location = new global::System.Drawing.Point(104, 154);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.PasswordChar = '\0';
			this.txtDescription.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtDescription.PlaceholderText = "Description";
			this.txtDescription.SelectedText = "";
			this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
			this.txtDescription.Size = new global::System.Drawing.Size(242, 28);
			this.txtDescription.TabIndex = 0;
			this.txtTrademarks.Animated = true;
			this.txtTrademarks.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtTrademarks.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtTrademarks.DefaultText = "";
			this.txtTrademarks.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtTrademarks.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtTrademarks.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtTrademarks.DisabledState.Parent = this.txtTrademarks;
			this.txtTrademarks.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtTrademarks.Enabled = false;
			this.txtTrademarks.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtTrademarks.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtTrademarks.FocusedState.Parent = this.txtTrademarks;
			this.txtTrademarks.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtTrademarks.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtTrademarks.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtTrademarks.HoverState.Parent = this.txtTrademarks;
			this.txtTrademarks.Location = new global::System.Drawing.Point(104, 241);
			this.txtTrademarks.Name = "txtTrademarks";
			this.txtTrademarks.PasswordChar = '\0';
			this.txtTrademarks.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtTrademarks.PlaceholderText = "Trademarks";
			this.txtTrademarks.SelectedText = "";
			this.txtTrademarks.ShadowDecoration.Parent = this.txtTrademarks;
			this.txtTrademarks.Size = new global::System.Drawing.Size(242, 28);
			this.txtTrademarks.TabIndex = 0;
			this.txtProduct.Animated = true;
			this.txtProduct.BorderColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.txtProduct.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtProduct.DefaultText = "";
			this.txtProduct.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtProduct.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtProduct.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtProduct.DisabledState.Parent = this.txtProduct;
			this.txtProduct.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtProduct.Enabled = false;
			this.txtProduct.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.txtProduct.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtProduct.FocusedState.Parent = this.txtProduct;
			this.txtProduct.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtProduct.ForeColor = global::System.Drawing.Color.DarkGray;
			this.txtProduct.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.txtProduct.HoverState.Parent = this.txtProduct;
			this.txtProduct.Location = new global::System.Drawing.Point(104, 125);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.PasswordChar = '\0';
			this.txtProduct.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtProduct.PlaceholderText = "Product";
			this.txtProduct.SelectedText = "";
			this.txtProduct.ShadowDecoration.Parent = this.txtProduct;
			this.txtProduct.Size = new global::System.Drawing.Size(242, 28);
			this.txtProduct.TabIndex = 0;
			this.picIcon.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIcon.Enabled = false;
			this.picIcon.ErrorImage = null;
			this.picIcon.InitialImage = null;
			this.picIcon.Location = new global::System.Drawing.Point(617, 139);
			this.picIcon.Margin = new global::System.Windows.Forms.Padding(2);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new global::System.Drawing.Size(170, 170);
			this.picIcon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIcon.TabIndex = 91;
			this.picIcon.TabStop = false;
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 44);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(938, 31);
			this.siticoneGradientPanel4.TabIndex = 127;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(938, 44);
			this.panel1.TabIndex = 126;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Silver;
			this.label1.Location = new global::System.Drawing.Point(51, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(113, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Venom Builder";
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new global::System.Drawing.Point(4, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(41, 41);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.siticoneDragControl1.TargetControl = this.panel1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(938, 622);
			base.Controls.Add(this.siticoneGradientPanel5);
			base.Controls.Add(this.siticoneTabControl1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormBuilder";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Builder";
			base.Load += new global::System.EventHandler(this.Builder_Load);
			this.tabPage2.ResumeLayout(false);
			this.siticoneGradientPanel1.ResumeLayout(false);
			this.siticoneGradientPanel1.PerformLayout();
			this.siticoneGradientPanel5.ResumeLayout(false);
			this.siticoneGradientPanel3.ResumeLayout(false);
			this.siticoneGradientPanel3.PerformLayout();
			this.numDelay.EndInit();
			this.siticoneTabControl1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.siticoneGradientPanel2.ResumeLayout(false);
			this.siticoneGradientPanel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picIcon).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040003BE RID: 958
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003BF RID: 959
		private global::System.DirectoryServices.DirectoryEntry directoryEntry1;

		// Token: 0x040003C0 RID: 960
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040003C1 RID: 961
		private global::System.Windows.Forms.ToolTip toolTip2;

		// Token: 0x040003C2 RID: 962
		private global::Siticone.Desktop.UI.WinForms.SiticoneComboBox comboBoxFolder;

		// Token: 0x040003C3 RID: 963
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnIcon;

		// Token: 0x040003C4 RID: 964
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040003C5 RID: 965
		private global::System.DirectoryServices.DirectoryEntry directoryEntry2;

		// Token: 0x040003C6 RID: 966
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040003C7 RID: 967
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040003C8 RID: 968
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040003C9 RID: 969
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton3;

		// Token: 0x040003CA RID: 970
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton5;

		// Token: 0x040003CB RID: 971
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x040003CC RID: 972
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;

		// Token: 0x040003CD RID: 973
		private global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox chkPaste_bin;

		// Token: 0x040003CE RID: 974
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040003CF RID: 975
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnRemovePort;

		// Token: 0x040003D0 RID: 976
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton4;

		// Token: 0x040003D1 RID: 977
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040003D2 RID: 978
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnAddPort;

		// Token: 0x040003D3 RID: 979
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnRemoveIP;

		// Token: 0x040003D4 RID: 980
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;

		// Token: 0x040003D5 RID: 981
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;

		// Token: 0x040003D6 RID: 982
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnAddIP;

		// Token: 0x040003D7 RID: 983
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox textIP;

		// Token: 0x040003D8 RID: 984
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMutex;

		// Token: 0x040003D9 RID: 985
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGroup;

		// Token: 0x040003DA RID: 986
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPaste_bin;

		// Token: 0x040003DB RID: 987
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox textPort;

		// Token: 0x040003DC RID: 988
		private global::System.Windows.Forms.ListBox YourListIPs;

		// Token: 0x040003DD RID: 989
		private global::System.Windows.Forms.ListBox YourListPorts;

		// Token: 0x040003DE RID: 990
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel5;

		// Token: 0x040003DF RID: 991
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnBuild;

		// Token: 0x040003E0 RID: 992
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040003E1 RID: 993
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x040003E2 RID: 994
		public global::Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;

		// Token: 0x040003E3 RID: 995
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x040003E4 RID: 996
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel3;

		// Token: 0x040003E5 RID: 997
		public global::Siticone.Desktop.UI.WinForms.SiticoneTextBox textFilename;

		// Token: 0x040003E6 RID: 998
		public global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox chkAnti;

		// Token: 0x040003E7 RID: 999
		public global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox chkAntiProcess;

		// Token: 0x040003E8 RID: 1000
		public global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox checkBox1;

		// Token: 0x040003E9 RID: 1001
		public global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox chkBsod;

		// Token: 0x040003EA RID: 1002
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040003EB RID: 1003
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040003EC RID: 1004
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040003ED RID: 1005
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040003EE RID: 1006
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040003EF RID: 1007
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040003F0 RID: 1008
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040003F1 RID: 1009
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040003F2 RID: 1010
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;

		// Token: 0x040003F3 RID: 1011
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040003F4 RID: 1012
		private global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox btnAssembly;

		// Token: 0x040003F5 RID: 1013
		private global::Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox chkIcon;

		// Token: 0x040003F6 RID: 1014
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnClone;

		// Token: 0x040003F7 RID: 1015
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtIcon;

		// Token: 0x040003F8 RID: 1016
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCopyright;

		// Token: 0x040003F9 RID: 1017
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtFileVersion;

		// Token: 0x040003FA RID: 1018
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCompany;

		// Token: 0x040003FB RID: 1019
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtProductVersion;

		// Token: 0x040003FC RID: 1020
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtOriginalFilename;

		// Token: 0x040003FD RID: 1021
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDescription;

		// Token: 0x040003FE RID: 1022
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTrademarks;

		// Token: 0x040003FF RID: 1023
		private global::Siticone.Desktop.UI.WinForms.SiticoneTextBox txtProduct;

		// Token: 0x04000400 RID: 1024
		private global::System.Windows.Forms.PictureBox picIcon;

		// Token: 0x04000401 RID: 1025
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000402 RID: 1026
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000403 RID: 1027
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000404 RID: 1028
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000405 RID: 1029
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000406 RID: 1030
		private global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numDelay;
	}
}
