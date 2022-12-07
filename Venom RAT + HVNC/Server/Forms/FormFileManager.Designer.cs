namespace Server.Forms
{
	// Token: 0x0200009F RID: 159
	public partial class FormFileManager : global::System.Windows.Forms.Form
	{
		// Token: 0x060004EE RID: 1262 RVA: 0x0000490E File Offset: 0x00002B0E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0003ECEC File Offset: 0x0003CEEC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormFileManager));
			global::System.Windows.Forms.ListViewGroup listViewGroup = new global::System.Windows.Forms.ListViewGroup("Folders", global::System.Windows.Forms.HorizontalAlignment.Left);
			global::System.Windows.Forms.ListViewGroup listViewGroup2 = new global::System.Windows.Forms.ListViewGroup("File", global::System.Windows.Forms.HorizontalAlignment.Left);
			this.pasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dELETEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.sevenZiplStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.installToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.zipToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator16 = new global::System.Windows.Forms.ToolStripSeparator();
			this.unzipToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.createFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.openClientFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.guna2Button2 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.guna2Button1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientPanel1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.siticoneResizeBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox();
			this.toolStripStatusLabel3 = new global::System.Windows.Forms.Label();
			this.toolStripStatusLabel2 = new global::System.Windows.Forms.Label();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.Label();
			this.toolStripSeparator15 = new global::System.Windows.Forms.ToolStripSeparator();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.toolStripSeparator14 = new global::System.Windows.Forms.ToolStripSeparator();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.backToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.rEFRESHToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new global::System.Windows.Forms.ToolStripSeparator();
			this.gOTOToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dESKTOPToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator17 = new global::System.Windows.Forms.ToolStripSeparator();
			this.aPPDATAToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator18 = new global::System.Windows.Forms.ToolStripSeparator();
			this.userProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.driversListsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.downloadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new global::System.Windows.Forms.ToolStripSeparator();
			this.uPLOADToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new global::System.Windows.Forms.ToolStripSeparator();
			this.eXECUTEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator11 = new global::System.Windows.Forms.ToolStripSeparator();
			this.renameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator12 = new global::System.Windows.Forms.ToolStripSeparator();
			this.copyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator13 = new global::System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.panel1.SuspendLayout();
			this.siticoneGradientPanel4.SuspendLayout();
			this.siticoneGradientPanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.pasteToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.pasteToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.pasteToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pasteToolStripMenuItem.Image");
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new global::System.EventHandler(this.PasteToolStripMenuItem_Click_1);
			this.dELETEToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dELETEToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.dELETEToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("dELETEToolStripMenuItem.Image");
			this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
			this.dELETEToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.dELETEToolStripMenuItem.Text = "Delete";
			this.dELETEToolStripMenuItem.Click += new global::System.EventHandler(this.dELETEToolStripMenuItem_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(187, 6);
			this.sevenZiplStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.installToolStripMenuItem,
				this.toolStripSeparator6,
				this.zipToolStripMenuItem,
				this.toolStripSeparator16,
				this.unzipToolStripMenuItem
			});
			this.sevenZiplStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sevenZiplStripMenuItem1.ForeColor = global::System.Drawing.Color.Black;
			this.sevenZiplStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("sevenZiplStripMenuItem1.Image");
			this.sevenZiplStripMenuItem1.Name = "sevenZiplStripMenuItem1";
			this.sevenZiplStripMenuItem1.Size = new global::System.Drawing.Size(190, 30);
			this.sevenZiplStripMenuItem1.Text = "7-Zip";
			this.installToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("installToolStripMenuItem.Image");
			this.installToolStripMenuItem.Name = "installToolStripMenuItem";
			this.installToolStripMenuItem.Size = new global::System.Drawing.Size(109, 22);
			this.installToolStripMenuItem.Text = "Install";
			this.installToolStripMenuItem.Click += new global::System.EventHandler(this.InstallToolStripMenuItem_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(106, 6);
			this.zipToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("zipToolStripMenuItem.Image");
			this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
			this.zipToolStripMenuItem.Size = new global::System.Drawing.Size(109, 22);
			this.zipToolStripMenuItem.Text = "Zip";
			this.zipToolStripMenuItem.Click += new global::System.EventHandler(this.ZipToolStripMenuItem_Click);
			this.toolStripSeparator16.Name = "toolStripSeparator16";
			this.toolStripSeparator16.Size = new global::System.Drawing.Size(106, 6);
			this.unzipToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("unzipToolStripMenuItem.Image");
			this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
			this.unzipToolStripMenuItem.Size = new global::System.Drawing.Size(109, 22);
			this.unzipToolStripMenuItem.Text = "Unzip";
			this.unzipToolStripMenuItem.Click += new global::System.EventHandler(this.UnzipToolStripMenuItem_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(187, 6);
			this.createFolderToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.createFolderToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.createFolderToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("createFolderToolStripMenuItem.Image");
			this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
			this.createFolderToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.createFolderToolStripMenuItem.Text = "New Folder";
			this.createFolderToolStripMenuItem.Click += new global::System.EventHandler(this.CreateFolderToolStripMenuItem_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(187, 6);
			this.openClientFolderToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.openClientFolderToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.openClientFolderToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("openClientFolderToolStripMenuItem.Image");
			this.openClientFolderToolStripMenuItem.Name = "openClientFolderToolStripMenuItem";
			this.openClientFolderToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.openClientFolderToolStripMenuItem.Text = "Open Client folder";
			this.openClientFolderToolStripMenuItem.Click += new global::System.EventHandler(this.OpenClientFolderToolStripMenuItem_Click);
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.White;
			this.imageList1.Images.SetKeyName(0, "AsyncFolder.ico");
			this.imageList1.Images.SetKeyName(1, "icons8_hdd.ico");
			this.imageList1.Images.SetKeyName(2, "icons8_usb_memory_stick_256.png");
			this.timer1.Interval = 1000;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(5, 8);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(101, 20);
			this.label1.TabIndex = 130;
			this.label1.Text = "File Manager";
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(977, 36);
			this.panel1.TabIndex = 137;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(941, 3);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(33, 28);
			this.siticoneControlBox1.TabIndex = 131;
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Controls.Add(this.guna2Button2);
			this.siticoneGradientPanel4.Controls.Add(this.guna2Button1);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 36);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(977, 31);
			this.siticoneGradientPanel4.TabIndex = 138;
			this.guna2Button2.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.guna2Button2.Animated = true;
			this.guna2Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.BorderColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.BorderRadius = 1;
			this.guna2Button2.BorderThickness = 1;
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.DisabledState.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.FillColor2 = global::System.Drawing.Color.Transparent;
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Location = new global::System.Drawing.Point(3, 0);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new global::System.Drawing.Size(106, 31);
			this.guna2Button2.TabIndex = 67;
			this.guna2Button2.Text = "Back";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.guna2Button1.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.guna2Button1.Animated = true;
			this.guna2Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 1;
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.DisabledState.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(868, 1);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(106, 28);
			this.guna2Button1.TabIndex = 67;
			this.guna2Button1.Text = "Desktop";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click_1);
			this.siticoneGradientPanel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.Controls.Add(this.siticoneResizeBox1);
			this.siticoneGradientPanel1.Controls.Add(this.toolStripStatusLabel3);
			this.siticoneGradientPanel1.Controls.Add(this.toolStripStatusLabel2);
			this.siticoneGradientPanel1.Controls.Add(this.toolStripStatusLabel1);
			this.siticoneGradientPanel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel1.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.Location = new global::System.Drawing.Point(0, 585);
			this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
			this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
			this.siticoneGradientPanel1.Size = new global::System.Drawing.Size(977, 28);
			this.siticoneGradientPanel1.TabIndex = 139;
			this.siticoneResizeBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneResizeBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneResizeBox1.FillColor = global::System.Drawing.Color.Gainsboro;
			this.siticoneResizeBox1.ForeColor = global::System.Drawing.Color.Black;
			this.siticoneResizeBox1.Location = new global::System.Drawing.Point(953, 6);
			this.siticoneResizeBox1.Name = "siticoneResizeBox1";
			this.siticoneResizeBox1.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneResizeBox1.TabIndex = 1;
			this.siticoneResizeBox1.TargetControl = this;
			this.toolStripStatusLabel3.AutoSize = true;
			this.toolStripStatusLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.toolStripStatusLabel3.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel3.Location = new global::System.Drawing.Point(29, 7);
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new global::System.Drawing.Size(13, 13);
			this.toolStripStatusLabel3.TabIndex = 0;
			this.toolStripStatusLabel3.Text = "..";
			this.toolStripStatusLabel2.AutoSize = true;
			this.toolStripStatusLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.toolStripStatusLabel2.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel2.Location = new global::System.Drawing.Point(16, 7);
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new global::System.Drawing.Size(13, 13);
			this.toolStripStatusLabel2.TabIndex = 0;
			this.toolStripStatusLabel2.Text = "..";
			this.toolStripStatusLabel1.AutoSize = true;
			this.toolStripStatusLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.toolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel1.Location = new global::System.Drawing.Point(3, 7);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 13);
			this.toolStripStatusLabel1.TabIndex = 0;
			this.toolStripStatusLabel1.Text = "..";
			this.toolStripSeparator15.Name = "toolStripSeparator15";
			this.toolStripSeparator15.Size = new global::System.Drawing.Size(187, 6);
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new global::System.Drawing.Size(187, 6);
			this.listView1.AllowColumnReorder = true;
			this.listView1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader2
			});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView1.ForeColor = global::System.Drawing.Color.Gainsboro;
			listViewGroup.Header = "Folders";
			listViewGroup.Name = "Folders";
			listViewGroup2.Header = "File";
			listViewGroup2.Name = "File";
			this.listView1.Groups.AddRange(new global::System.Windows.Forms.ListViewGroup[]
			{
				listViewGroup,
				listViewGroup2
			});
			this.listView1.HideSelection = false;
			this.listView1.LargeImageList = this.imageList1;
			this.listView1.Location = new global::System.Drawing.Point(0, 67);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(2);
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new global::System.Drawing.Size(977, 518);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 136;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Tile;
			this.listView1.DoubleClick += new global::System.EventHandler(this.listView1_DoubleClick);
			this.contextMenuStrip1.BackColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.backToolStripMenuItem,
				this.toolStripSeparator7,
				this.rEFRESHToolStripMenuItem,
				this.toolStripSeparator8,
				this.gOTOToolStripMenuItem,
				this.toolStripSeparator1,
				this.downloadToolStripMenuItem,
				this.toolStripSeparator9,
				this.uPLOADToolStripMenuItem,
				this.toolStripSeparator10,
				this.eXECUTEToolStripMenuItem,
				this.toolStripSeparator11,
				this.renameToolStripMenuItem,
				this.toolStripSeparator12,
				this.copyToolStripMenuItem,
				this.toolStripSeparator13,
				this.cutToolStripMenuItem1,
				this.toolStripSeparator14,
				this.pasteToolStripMenuItem,
				this.toolStripSeparator15,
				this.dELETEToolStripMenuItem,
				this.toolStripSeparator4,
				this.sevenZiplStripMenuItem1,
				this.toolStripSeparator5,
				this.createFolderToolStripMenuItem,
				this.toolStripSeparator3,
				this.openClientFolderToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(191, 502);
			this.backToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.backToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.backToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("backToolStripMenuItem.Image");
			this.backToolStripMenuItem.Name = "backToolStripMenuItem";
			this.backToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.backToolStripMenuItem.Text = "Back";
			this.backToolStripMenuItem.Click += new global::System.EventHandler(this.backToolStripMenuItem_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new global::System.Drawing.Size(187, 6);
			this.rEFRESHToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rEFRESHToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.rEFRESHToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rEFRESHToolStripMenuItem.Image");
			this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
			this.rEFRESHToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.rEFRESHToolStripMenuItem.Text = "Refresh";
			this.rEFRESHToolStripMenuItem.Click += new global::System.EventHandler(this.rEFRESHToolStripMenuItem_Click);
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new global::System.Drawing.Size(187, 6);
			this.gOTOToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.dESKTOPToolStripMenuItem,
				this.toolStripSeparator17,
				this.aPPDATAToolStripMenuItem,
				this.toolStripSeparator18,
				this.userProfileToolStripMenuItem,
				this.toolStripSeparator2,
				this.driversListsToolStripMenuItem
			});
			this.gOTOToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.gOTOToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.gOTOToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("gOTOToolStripMenuItem.Image");
			this.gOTOToolStripMenuItem.Name = "gOTOToolStripMenuItem";
			this.gOTOToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.gOTOToolStripMenuItem.Text = "Go to";
			this.dESKTOPToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("dESKTOPToolStripMenuItem.Image");
			this.dESKTOPToolStripMenuItem.Name = "dESKTOPToolStripMenuItem";
			this.dESKTOPToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.dESKTOPToolStripMenuItem.Text = "Desktop";
			this.dESKTOPToolStripMenuItem.Click += new global::System.EventHandler(this.DESKTOPToolStripMenuItem_Click);
			this.toolStripSeparator17.Name = "toolStripSeparator17";
			this.toolStripSeparator17.Size = new global::System.Drawing.Size(141, 6);
			this.aPPDATAToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("aPPDATAToolStripMenuItem.Image");
			this.aPPDATAToolStripMenuItem.Name = "aPPDATAToolStripMenuItem";
			this.aPPDATAToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.aPPDATAToolStripMenuItem.Text = "AppData";
			this.aPPDATAToolStripMenuItem.Click += new global::System.EventHandler(this.APPDATAToolStripMenuItem_Click);
			this.toolStripSeparator18.Name = "toolStripSeparator18";
			this.toolStripSeparator18.Size = new global::System.Drawing.Size(141, 6);
			this.userProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("userProfileToolStripMenuItem.Image");
			this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
			this.userProfileToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.userProfileToolStripMenuItem.Text = "User Profile";
			this.userProfileToolStripMenuItem.Click += new global::System.EventHandler(this.UserProfileToolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(141, 6);
			this.driversListsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("driversListsToolStripMenuItem.Image");
			this.driversListsToolStripMenuItem.Name = "driversListsToolStripMenuItem";
			this.driversListsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.driversListsToolStripMenuItem.Text = "Drivers";
			this.driversListsToolStripMenuItem.Click += new global::System.EventHandler(this.DriversListsToolStripMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(187, 6);
			this.downloadToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.downloadToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.downloadToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("downloadToolStripMenuItem.Image");
			this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
			this.downloadToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.downloadToolStripMenuItem.Text = "Download";
			this.downloadToolStripMenuItem.Click += new global::System.EventHandler(this.downloadToolStripMenuItem_Click);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new global::System.Drawing.Size(187, 6);
			this.uPLOADToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.uPLOADToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.uPLOADToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("uPLOADToolStripMenuItem.Image");
			this.uPLOADToolStripMenuItem.Name = "uPLOADToolStripMenuItem";
			this.uPLOADToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.uPLOADToolStripMenuItem.Text = "Upload";
			this.uPLOADToolStripMenuItem.Click += new global::System.EventHandler(this.uPLOADToolStripMenuItem_Click);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new global::System.Drawing.Size(187, 6);
			this.eXECUTEToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.eXECUTEToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.eXECUTEToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("eXECUTEToolStripMenuItem.Image");
			this.eXECUTEToolStripMenuItem.Name = "eXECUTEToolStripMenuItem";
			this.eXECUTEToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.eXECUTEToolStripMenuItem.Text = "Execute";
			this.eXECUTEToolStripMenuItem.Click += new global::System.EventHandler(this.eXECUTEToolStripMenuItem_Click);
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new global::System.Drawing.Size(187, 6);
			this.renameToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.renameToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.renameToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("renameToolStripMenuItem.Image");
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new global::System.EventHandler(this.RenameToolStripMenuItem_Click);
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new global::System.Drawing.Size(187, 6);
			this.copyToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.copyToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.copyToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("copyToolStripMenuItem.Image");
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new global::System.EventHandler(this.CopyToolStripMenuItem_Click);
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new global::System.Drawing.Size(187, 6);
			this.cutToolStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cutToolStripMenuItem1.ForeColor = global::System.Drawing.Color.Black;
			this.cutToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cutToolStripMenuItem1.Image");
			this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
			this.cutToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 30);
			this.cutToolStripMenuItem1.Text = "Cut";
			this.cutToolStripMenuItem1.Click += new global::System.EventHandler(this.CutToolStripMenuItem1_Click);
			this.siticoneDragControl1.TargetControl = this.panel1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(39, 39, 39);
			base.ClientSize = new global::System.Drawing.Size(977, 613);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.siticoneGradientPanel1);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormFileManager";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "File Manager";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormFileManager_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.siticoneGradientPanel4.ResumeLayout(false);
			this.siticoneGradientPanel1.ResumeLayout(false);
			this.siticoneGradientPanel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400041D RID: 1053
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400041E RID: 1054
		private global::System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

		// Token: 0x0400041F RID: 1055
		private global::System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;

		// Token: 0x04000420 RID: 1056
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000421 RID: 1057
		private global::System.Windows.Forms.ToolStripMenuItem sevenZiplStripMenuItem1;

		// Token: 0x04000422 RID: 1058
		private global::System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;

		// Token: 0x04000423 RID: 1059
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x04000424 RID: 1060
		private global::System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;

		// Token: 0x04000425 RID: 1061
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator16;

		// Token: 0x04000426 RID: 1062
		private global::System.Windows.Forms.ToolStripMenuItem unzipToolStripMenuItem;

		// Token: 0x04000427 RID: 1063
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000428 RID: 1064
		private global::System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;

		// Token: 0x04000429 RID: 1065
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x0400042A RID: 1066
		private global::System.Windows.Forms.ToolStripMenuItem openClientFolderToolStripMenuItem;

		// Token: 0x0400042B RID: 1067
		public global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x0400042C RID: 1068
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400042D RID: 1069
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400042E RID: 1070
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400042F RID: 1071
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000430 RID: 1072
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000431 RID: 1073
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton guna2Button2;

		// Token: 0x04000432 RID: 1074
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton guna2Button1;

		// Token: 0x04000433 RID: 1075
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;

		// Token: 0x04000434 RID: 1076
		private global::Siticone.Desktop.UI.WinForms.SiticoneResizeBox siticoneResizeBox1;

		// Token: 0x04000435 RID: 1077
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000436 RID: 1078
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000437 RID: 1079
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x04000438 RID: 1080
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000439 RID: 1081
		private global::System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;

		// Token: 0x0400043A RID: 1082
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x0400043B RID: 1083
		private global::System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;

		// Token: 0x0400043C RID: 1084
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

		// Token: 0x0400043D RID: 1085
		private global::System.Windows.Forms.ToolStripMenuItem gOTOToolStripMenuItem;

		// Token: 0x0400043E RID: 1086
		private global::System.Windows.Forms.ToolStripMenuItem dESKTOPToolStripMenuItem;

		// Token: 0x0400043F RID: 1087
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator17;

		// Token: 0x04000440 RID: 1088
		private global::System.Windows.Forms.ToolStripMenuItem aPPDATAToolStripMenuItem;

		// Token: 0x04000441 RID: 1089
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator18;

		// Token: 0x04000442 RID: 1090
		private global::System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;

		// Token: 0x04000443 RID: 1091
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000444 RID: 1092
		private global::System.Windows.Forms.ToolStripMenuItem driversListsToolStripMenuItem;

		// Token: 0x04000445 RID: 1093
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000446 RID: 1094
		private global::System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;

		// Token: 0x04000447 RID: 1095
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator9;

		// Token: 0x04000448 RID: 1096
		private global::System.Windows.Forms.ToolStripMenuItem uPLOADToolStripMenuItem;

		// Token: 0x04000449 RID: 1097
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator10;

		// Token: 0x0400044A RID: 1098
		private global::System.Windows.Forms.ToolStripMenuItem eXECUTEToolStripMenuItem;

		// Token: 0x0400044B RID: 1099
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator11;

		// Token: 0x0400044C RID: 1100
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;

		// Token: 0x0400044D RID: 1101
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator12;

		// Token: 0x0400044E RID: 1102
		private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x0400044F RID: 1103
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator13;

		// Token: 0x04000450 RID: 1104
		private global::System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;

		// Token: 0x04000451 RID: 1105
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator14;

		// Token: 0x04000452 RID: 1106
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator15;

		// Token: 0x04000453 RID: 1107
		public global::System.Windows.Forms.Label toolStripStatusLabel3;

		// Token: 0x04000454 RID: 1108
		public global::System.Windows.Forms.Label toolStripStatusLabel2;

		// Token: 0x04000455 RID: 1109
		public global::System.Windows.Forms.Label toolStripStatusLabel1;

		// Token: 0x04000456 RID: 1110
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x04000457 RID: 1111
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
	}
}
