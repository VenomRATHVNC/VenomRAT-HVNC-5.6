namespace Server.Forms
{
	// Token: 0x020000AB RID: 171
	public partial class FormRegistryEditor : global::System.Windows.Forms.Form
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x00004FD9 File Offset: 0x000031D9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000495A0 File Offset: 0x000477A0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormRegistryEditor));
			this.multiStringValueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.selectedItem_ContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.modifyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.modifyBinaryDataToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.modifyToolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lst_ContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.newToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.keyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.stringValueToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.binaryValueToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dWORD32bitValueToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.qWORD64bitValueToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.multiStringValueToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.expandableStringValueToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.expandableStringValueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.tvRegistryDirectory = new global::Server.Helper.RegistryTreeView();
			this.imageRegistryDirectoryList = new global::System.Windows.Forms.ImageList(this.components);
			this.hName = new global::System.Windows.Forms.ColumnHeader();
			this.hType = new global::System.Windows.Forms.ColumnHeader();
			this.hValue = new global::System.Windows.Forms.ColumnHeader();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.menuStrip = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.modifyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.modifyBinaryDataToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.modifyNewtoolStripSeparator = new global::System.Windows.Forms.ToolStripSeparator();
			this.newToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.keyToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.stringValueToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.binaryValueToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dWORD32bitValueToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.qWORD64bitValueToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.multiStringValueToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.expandableStringValueToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.qWORD64bitValueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new global::System.Windows.Forms.StatusStrip();
			this.selectedStripStatusLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lstRegistryValues = new global::Server.Helper.AeroListView();
			this.imageRegistryKeyTypeList = new global::System.Windows.Forms.ImageList(this.components);
			this.tv_ContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.newToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.keyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.stringValueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.binaryValueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dWORD32bitValueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.selectedItem_ContextMenuStrip.SuspendLayout();
			this.lst_ContextMenuStrip.SuspendLayout();
			this.siticoneGradientPanel4.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.panel1.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.tv_ContextMenuStrip.SuspendLayout();
			base.SuspendLayout();
			this.multiStringValueToolStripMenuItem.Name = "multiStringValueToolStripMenuItem";
			this.multiStringValueToolStripMenuItem.Size = new global::System.Drawing.Size(200, 22);
			this.multiStringValueToolStripMenuItem.Text = "Multi-String Value";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(114, 6);
			this.deleteToolStripMenuItem.Enabled = false;
			this.deleteToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(117, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.renameToolStripMenuItem.Enabled = false;
			this.renameToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new global::System.Drawing.Size(117, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			this.selectedItem_ContextMenuStrip.BackColor = global::System.Drawing.Color.FromArgb(12, 89, 71);
			this.selectedItem_ContextMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.modifyToolStripMenuItem,
				this.modifyBinaryDataToolStripMenuItem,
				this.modifyToolStripSeparator1,
				this.deleteToolStripMenuItem1,
				this.renameToolStripMenuItem1
			});
			this.selectedItem_ContextMenuStrip.Name = "selectedItem_ContextMenuStrip";
			this.selectedItem_ContextMenuStrip.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.selectedItem_ContextMenuStrip.Size = new global::System.Drawing.Size(185, 98);
			this.modifyToolStripMenuItem.Enabled = false;
			this.modifyToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.modifyToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
			this.modifyToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.modifyToolStripMenuItem.Text = "Modify...";
			this.modifyToolStripMenuItem.Click += new global::System.EventHandler(this.modifyRegistryValue_Click);
			this.modifyBinaryDataToolStripMenuItem.Enabled = false;
			this.modifyBinaryDataToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.modifyBinaryDataToolStripMenuItem.Name = "modifyBinaryDataToolStripMenuItem";
			this.modifyBinaryDataToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.modifyBinaryDataToolStripMenuItem.Text = "Modify Binary Data...";
			this.modifyBinaryDataToolStripMenuItem.Click += new global::System.EventHandler(this.modifyBinaryDataRegistryValue_Click);
			this.modifyToolStripSeparator1.Name = "modifyToolStripSeparator1";
			this.modifyToolStripSeparator1.Size = new global::System.Drawing.Size(181, 6);
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new global::System.Drawing.Size(184, 22);
			this.deleteToolStripMenuItem1.Text = "Delete";
			this.deleteToolStripMenuItem1.Click += new global::System.EventHandler(this.deleteRegistryValue_Click);
			this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
			this.renameToolStripMenuItem1.Size = new global::System.Drawing.Size(184, 22);
			this.renameToolStripMenuItem1.Text = "Rename";
			this.renameToolStripMenuItem1.Click += new global::System.EventHandler(this.renameRegistryValue_Click);
			this.lst_ContextMenuStrip.BackColor = global::System.Drawing.Color.FromArgb(12, 89, 71);
			this.lst_ContextMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.newToolStripMenuItem1
			});
			this.lst_ContextMenuStrip.Name = "lst_ContextMenuStrip";
			this.lst_ContextMenuStrip.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.lst_ContextMenuStrip.Size = new global::System.Drawing.Size(99, 26);
			this.newToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.keyToolStripMenuItem1,
				this.toolStripSeparator4,
				this.stringValueToolStripMenuItem1,
				this.binaryValueToolStripMenuItem1,
				this.dWORD32bitValueToolStripMenuItem1,
				this.qWORD64bitValueToolStripMenuItem1,
				this.multiStringValueToolStripMenuItem1,
				this.expandableStringValueToolStripMenuItem1
			});
			this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
			this.newToolStripMenuItem1.Size = new global::System.Drawing.Size(98, 22);
			this.newToolStripMenuItem1.Text = "New";
			this.keyToolStripMenuItem1.Name = "keyToolStripMenuItem1";
			this.keyToolStripMenuItem1.Size = new global::System.Drawing.Size(200, 22);
			this.keyToolStripMenuItem1.Text = "Key";
			this.keyToolStripMenuItem1.Click += new global::System.EventHandler(this.createNewRegistryKey_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(197, 6);
			this.stringValueToolStripMenuItem1.Name = "stringValueToolStripMenuItem1";
			this.stringValueToolStripMenuItem1.Size = new global::System.Drawing.Size(200, 22);
			this.stringValueToolStripMenuItem1.Text = "String Value";
			this.stringValueToolStripMenuItem1.Click += new global::System.EventHandler(this.createStringRegistryValue_Click);
			this.binaryValueToolStripMenuItem1.Name = "binaryValueToolStripMenuItem1";
			this.binaryValueToolStripMenuItem1.Size = new global::System.Drawing.Size(200, 22);
			this.binaryValueToolStripMenuItem1.Text = "Binary Value";
			this.binaryValueToolStripMenuItem1.Click += new global::System.EventHandler(this.createBinaryRegistryValue_Click);
			this.dWORD32bitValueToolStripMenuItem1.Name = "dWORD32bitValueToolStripMenuItem1";
			this.dWORD32bitValueToolStripMenuItem1.Size = new global::System.Drawing.Size(200, 22);
			this.dWORD32bitValueToolStripMenuItem1.Text = "DWORD (32-bit) Value";
			this.dWORD32bitValueToolStripMenuItem1.Click += new global::System.EventHandler(this.createDwordRegistryValue_Click);
			this.qWORD64bitValueToolStripMenuItem1.Name = "qWORD64bitValueToolStripMenuItem1";
			this.qWORD64bitValueToolStripMenuItem1.Size = new global::System.Drawing.Size(200, 22);
			this.qWORD64bitValueToolStripMenuItem1.Text = "QWORD (64-bit) Value";
			this.qWORD64bitValueToolStripMenuItem1.Click += new global::System.EventHandler(this.createQwordRegistryValue_Click);
			this.multiStringValueToolStripMenuItem1.Name = "multiStringValueToolStripMenuItem1";
			this.multiStringValueToolStripMenuItem1.Size = new global::System.Drawing.Size(200, 22);
			this.multiStringValueToolStripMenuItem1.Text = "Multi-String Value";
			this.multiStringValueToolStripMenuItem1.Click += new global::System.EventHandler(this.createMultiStringRegistryValue_Click);
			this.expandableStringValueToolStripMenuItem1.Name = "expandableStringValueToolStripMenuItem1";
			this.expandableStringValueToolStripMenuItem1.Size = new global::System.Drawing.Size(200, 22);
			this.expandableStringValueToolStripMenuItem1.Text = "Expandable String Value";
			this.expandableStringValueToolStripMenuItem1.Click += new global::System.EventHandler(this.createExpandStringRegistryValue_Click);
			this.expandableStringValueToolStripMenuItem.Name = "expandableStringValueToolStripMenuItem";
			this.expandableStringValueToolStripMenuItem.Size = new global::System.Drawing.Size(200, 22);
			this.expandableStringValueToolStripMenuItem.Text = "Expandable String Value";
			this.timer1.Interval = 2000;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(112, 21);
			this.label1.TabIndex = 131;
			this.label1.Text = "Registry Editor";
			this.tvRegistryDirectory.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.tvRegistryDirectory.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.tvRegistryDirectory.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.tvRegistryDirectory.HideSelection = false;
			this.tvRegistryDirectory.ImageIndex = 0;
			this.tvRegistryDirectory.ImageList = this.imageRegistryDirectoryList;
			this.tvRegistryDirectory.Location = new global::System.Drawing.Point(0, 65);
			this.tvRegistryDirectory.Name = "tvRegistryDirectory";
			this.tvRegistryDirectory.SelectedImageIndex = 0;
			this.tvRegistryDirectory.Size = new global::System.Drawing.Size(301, 598);
			this.tvRegistryDirectory.TabIndex = 165;
			this.tvRegistryDirectory.NodeMouseClick += new global::System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvRegistryDirectory_NodeMouseClick);
			this.tvRegistryDirectory.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.tvRegistryDirectory_KeyUp);
			this.imageRegistryDirectoryList.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageRegistryDirectoryList.ImageStream");
			this.imageRegistryDirectoryList.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageRegistryDirectoryList.Images.SetKeyName(0, "folder.png");
			this.hName.Text = "Name";
			this.hName.Width = 173;
			this.hType.Text = "Type";
			this.hType.Width = 104;
			this.hValue.Text = "Value";
			this.hValue.Width = 214;
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Controls.Add(this.menuStrip);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 34);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(783, 31);
			this.siticoneGradientPanel4.TabIndex = 168;
			this.menuStrip.BackColor = global::System.Drawing.Color.Transparent;
			this.menuStrip.Dock = global::System.Windows.Forms.DockStyle.None;
			this.menuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem,
				this.editToolStripMenuItem
			});
			this.menuStrip.Location = new global::System.Drawing.Point(0, 3);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new global::System.Drawing.Size(84, 24);
			this.menuStrip.TabIndex = 2;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.exitToolStripMenuItem
			});
			this.fileToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new global::System.EventHandler(this.menuStripExit_Click);
			this.editToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.modifyToolStripMenuItem1,
				this.modifyBinaryDataToolStripMenuItem1,
				this.modifyNewtoolStripSeparator,
				this.newToolStripMenuItem2,
				this.toolStripSeparator6,
				this.deleteToolStripMenuItem2,
				this.renameToolStripMenuItem2
			});
			this.editToolStripMenuItem.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new global::System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			this.modifyToolStripMenuItem1.Enabled = false;
			this.modifyToolStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
			this.modifyToolStripMenuItem1.Size = new global::System.Drawing.Size(184, 22);
			this.modifyToolStripMenuItem1.Text = "Modify...";
			this.modifyToolStripMenuItem1.Visible = false;
			this.modifyToolStripMenuItem1.Click += new global::System.EventHandler(this.modifyRegistryValue_Click);
			this.modifyBinaryDataToolStripMenuItem1.Enabled = false;
			this.modifyBinaryDataToolStripMenuItem1.Name = "modifyBinaryDataToolStripMenuItem1";
			this.modifyBinaryDataToolStripMenuItem1.Size = new global::System.Drawing.Size(184, 22);
			this.modifyBinaryDataToolStripMenuItem1.Text = "Modify Binary Data...";
			this.modifyBinaryDataToolStripMenuItem1.Visible = false;
			this.modifyBinaryDataToolStripMenuItem1.Click += new global::System.EventHandler(this.modifyBinaryDataRegistryValue_Click);
			this.modifyNewtoolStripSeparator.Name = "modifyNewtoolStripSeparator";
			this.modifyNewtoolStripSeparator.Size = new global::System.Drawing.Size(181, 6);
			this.modifyNewtoolStripSeparator.Visible = false;
			this.newToolStripMenuItem2.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.keyToolStripMenuItem2,
				this.toolStripSeparator7,
				this.stringValueToolStripMenuItem2,
				this.binaryValueToolStripMenuItem2,
				this.dWORD32bitValueToolStripMenuItem2,
				this.qWORD64bitValueToolStripMenuItem2,
				this.multiStringValueToolStripMenuItem2,
				this.expandableStringValueToolStripMenuItem2
			});
			this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
			this.newToolStripMenuItem2.Size = new global::System.Drawing.Size(184, 22);
			this.newToolStripMenuItem2.Text = "New";
			this.keyToolStripMenuItem2.Name = "keyToolStripMenuItem2";
			this.keyToolStripMenuItem2.Size = new global::System.Drawing.Size(200, 22);
			this.keyToolStripMenuItem2.Text = "Key";
			this.keyToolStripMenuItem2.Click += new global::System.EventHandler(this.createNewRegistryKey_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new global::System.Drawing.Size(197, 6);
			this.stringValueToolStripMenuItem2.Name = "stringValueToolStripMenuItem2";
			this.stringValueToolStripMenuItem2.Size = new global::System.Drawing.Size(200, 22);
			this.stringValueToolStripMenuItem2.Text = "String Value";
			this.stringValueToolStripMenuItem2.Click += new global::System.EventHandler(this.createStringRegistryValue_Click);
			this.binaryValueToolStripMenuItem2.Name = "binaryValueToolStripMenuItem2";
			this.binaryValueToolStripMenuItem2.Size = new global::System.Drawing.Size(200, 22);
			this.binaryValueToolStripMenuItem2.Text = "Binary Value";
			this.binaryValueToolStripMenuItem2.Click += new global::System.EventHandler(this.createBinaryRegistryValue_Click);
			this.dWORD32bitValueToolStripMenuItem2.Name = "dWORD32bitValueToolStripMenuItem2";
			this.dWORD32bitValueToolStripMenuItem2.Size = new global::System.Drawing.Size(200, 22);
			this.dWORD32bitValueToolStripMenuItem2.Text = "DWORD (32-bit) Value";
			this.dWORD32bitValueToolStripMenuItem2.Click += new global::System.EventHandler(this.createDwordRegistryValue_Click);
			this.qWORD64bitValueToolStripMenuItem2.Name = "qWORD64bitValueToolStripMenuItem2";
			this.qWORD64bitValueToolStripMenuItem2.Size = new global::System.Drawing.Size(200, 22);
			this.qWORD64bitValueToolStripMenuItem2.Text = "QWORD (64-bit) Value";
			this.qWORD64bitValueToolStripMenuItem2.Click += new global::System.EventHandler(this.createQwordRegistryValue_Click);
			this.multiStringValueToolStripMenuItem2.Name = "multiStringValueToolStripMenuItem2";
			this.multiStringValueToolStripMenuItem2.Size = new global::System.Drawing.Size(200, 22);
			this.multiStringValueToolStripMenuItem2.Text = "Multi-String Value";
			this.multiStringValueToolStripMenuItem2.Click += new global::System.EventHandler(this.createMultiStringRegistryValue_Click);
			this.expandableStringValueToolStripMenuItem2.Name = "expandableStringValueToolStripMenuItem2";
			this.expandableStringValueToolStripMenuItem2.Size = new global::System.Drawing.Size(200, 22);
			this.expandableStringValueToolStripMenuItem2.Text = "Expandable String Value";
			this.expandableStringValueToolStripMenuItem2.Click += new global::System.EventHandler(this.createExpandStringRegistryValue_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(181, 6);
			this.deleteToolStripMenuItem2.Enabled = false;
			this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
			this.deleteToolStripMenuItem2.ShortcutKeyDisplayString = "Del";
			this.deleteToolStripMenuItem2.Size = new global::System.Drawing.Size(184, 22);
			this.deleteToolStripMenuItem2.Text = "Delete";
			this.deleteToolStripMenuItem2.Click += new global::System.EventHandler(this.menuStripDelete_Click);
			this.renameToolStripMenuItem2.Enabled = false;
			this.renameToolStripMenuItem2.Name = "renameToolStripMenuItem2";
			this.renameToolStripMenuItem2.Size = new global::System.Drawing.Size(184, 22);
			this.renameToolStripMenuItem2.Text = "Rename";
			this.renameToolStripMenuItem2.Click += new global::System.EventHandler(this.menuStripRename_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(783, 34);
			this.panel1.TabIndex = 169;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(756, 6);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(24, 22);
			this.siticoneControlBox1.TabIndex = 145;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.qWORD64bitValueToolStripMenuItem.Name = "qWORD64bitValueToolStripMenuItem";
			this.qWORD64bitValueToolStripMenuItem.Size = new global::System.Drawing.Size(200, 22);
			this.qWORD64bitValueToolStripMenuItem.Text = "QWORD (64-bit) Value";
			this.statusStrip.Dock = global::System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.selectedStripStatusLabel
			});
			this.statusStrip.Location = new global::System.Drawing.Point(180, 632);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new global::System.Drawing.Size(17, 22);
			this.statusStrip.TabIndex = 167;
			this.statusStrip.Text = "statusStrip";
			this.statusStrip.Visible = false;
			this.selectedStripStatusLabel.Name = "selectedStripStatusLabel";
			this.selectedStripStatusLabel.Size = new global::System.Drawing.Size(0, 17);
			this.lstRegistryValues.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.lstRegistryValues.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.hName,
				this.hType,
				this.hValue
			});
			this.lstRegistryValues.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstRegistryValues.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.lstRegistryValues.FullRowSelect = true;
			this.lstRegistryValues.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstRegistryValues.HideSelection = false;
			this.lstRegistryValues.Location = new global::System.Drawing.Point(301, 65);
			this.lstRegistryValues.Name = "lstRegistryValues";
			this.lstRegistryValues.Size = new global::System.Drawing.Size(482, 598);
			this.lstRegistryValues.SmallImageList = this.imageRegistryKeyTypeList;
			this.lstRegistryValues.TabIndex = 166;
			this.lstRegistryValues.UseCompatibleStateImageBehavior = false;
			this.lstRegistryValues.View = global::System.Windows.Forms.View.Details;
			this.lstRegistryValues.AfterLabelEdit += new global::System.Windows.Forms.LabelEditEventHandler(this.lstRegistryKeys_AfterLabelEdit);
			this.lstRegistryValues.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.lstRegistryKeys_KeyUp);
			this.lstRegistryValues.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.lstRegistryKeys_MouseClick);
			this.imageRegistryKeyTypeList.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageRegistryKeyTypeList.ImageStream");
			this.imageRegistryKeyTypeList.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageRegistryKeyTypeList.Images.SetKeyName(0, "reg_string.png");
			this.imageRegistryKeyTypeList.Images.SetKeyName(1, "reg_binary.png");
			this.tv_ContextMenuStrip.BackColor = global::System.Drawing.Color.FromArgb(12, 89, 71);
			this.tv_ContextMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.newToolStripMenuItem,
				this.toolStripSeparator1,
				this.deleteToolStripMenuItem,
				this.renameToolStripMenuItem
			});
			this.tv_ContextMenuStrip.Name = "contextMenuStrip";
			this.tv_ContextMenuStrip.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.tv_ContextMenuStrip.Size = new global::System.Drawing.Size(118, 76);
			this.newToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.keyToolStripMenuItem,
				this.toolStripSeparator2,
				this.stringValueToolStripMenuItem,
				this.binaryValueToolStripMenuItem,
				this.dWORD32bitValueToolStripMenuItem,
				this.qWORD64bitValueToolStripMenuItem,
				this.multiStringValueToolStripMenuItem,
				this.expandableStringValueToolStripMenuItem
			});
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new global::System.Drawing.Size(117, 22);
			this.newToolStripMenuItem.Text = "New";
			this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
			this.keyToolStripMenuItem.Size = new global::System.Drawing.Size(200, 22);
			this.keyToolStripMenuItem.Text = "Key";
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(197, 6);
			this.stringValueToolStripMenuItem.Name = "stringValueToolStripMenuItem";
			this.stringValueToolStripMenuItem.Size = new global::System.Drawing.Size(200, 22);
			this.stringValueToolStripMenuItem.Text = "String Value";
			this.binaryValueToolStripMenuItem.Name = "binaryValueToolStripMenuItem";
			this.binaryValueToolStripMenuItem.Size = new global::System.Drawing.Size(200, 22);
			this.binaryValueToolStripMenuItem.Text = "Binary Value";
			this.dWORD32bitValueToolStripMenuItem.Name = "dWORD32bitValueToolStripMenuItem";
			this.dWORD32bitValueToolStripMenuItem.Size = new global::System.Drawing.Size(200, 22);
			this.dWORD32bitValueToolStripMenuItem.Text = "DWORD (32-bit) Value";
			this.siticoneDragControl1.TargetControl = this.panel1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			base.ClientSize = new global::System.Drawing.Size(783, 663);
			base.Controls.Add(this.statusStrip);
			base.Controls.Add(this.lstRegistryValues);
			base.Controls.Add(this.tvRegistryDirectory);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.Color.Black;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormRegistryEditor";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registry Editor []";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormRegistryEditor_FormClosed);
			base.Load += new global::System.EventHandler(this.FrmRegistryEditor_Load);
			this.selectedItem_ContextMenuStrip.ResumeLayout(false);
			this.lst_ContextMenuStrip.ResumeLayout(false);
			this.siticoneGradientPanel4.ResumeLayout(false);
			this.siticoneGradientPanel4.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tv_ContextMenuStrip.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040004FB RID: 1275
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040004FC RID: 1276
		private global::System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem;

		// Token: 0x040004FD RID: 1277
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040004FE RID: 1278
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x040004FF RID: 1279
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;

		// Token: 0x04000500 RID: 1280
		private global::System.Windows.Forms.ContextMenuStrip selectedItem_ContextMenuStrip;

		// Token: 0x04000501 RID: 1281
		private global::System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;

		// Token: 0x04000502 RID: 1282
		private global::System.Windows.Forms.ToolStripMenuItem modifyBinaryDataToolStripMenuItem;

		// Token: 0x04000503 RID: 1283
		private global::System.Windows.Forms.ToolStripSeparator modifyToolStripSeparator1;

		// Token: 0x04000504 RID: 1284
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;

		// Token: 0x04000505 RID: 1285
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;

		// Token: 0x04000506 RID: 1286
		private global::System.Windows.Forms.ContextMenuStrip lst_ContextMenuStrip;

		// Token: 0x04000507 RID: 1287
		private global::System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;

		// Token: 0x04000508 RID: 1288
		private global::System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem1;

		// Token: 0x04000509 RID: 1289
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x0400050A RID: 1290
		private global::System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem1;

		// Token: 0x0400050B RID: 1291
		private global::System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem1;

		// Token: 0x0400050C RID: 1292
		private global::System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem1;

		// Token: 0x0400050D RID: 1293
		private global::System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem1;

		// Token: 0x0400050E RID: 1294
		private global::System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem1;

		// Token: 0x0400050F RID: 1295
		private global::System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem1;

		// Token: 0x04000510 RID: 1296
		private global::System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem;

		// Token: 0x04000511 RID: 1297
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000512 RID: 1298
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000513 RID: 1299
		public global::Server.Helper.RegistryTreeView tvRegistryDirectory;

		// Token: 0x04000514 RID: 1300
		private global::System.Windows.Forms.ImageList imageRegistryDirectoryList;

		// Token: 0x04000515 RID: 1301
		private global::System.Windows.Forms.ColumnHeader hName;

		// Token: 0x04000516 RID: 1302
		private global::System.Windows.Forms.ColumnHeader hType;

		// Token: 0x04000517 RID: 1303
		private global::System.Windows.Forms.ColumnHeader hValue;

		// Token: 0x04000518 RID: 1304
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000519 RID: 1305
		private global::System.Windows.Forms.MenuStrip menuStrip;

		// Token: 0x0400051A RID: 1306
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x0400051B RID: 1307
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x0400051C RID: 1308
		private global::System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

		// Token: 0x0400051D RID: 1309
		private global::System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;

		// Token: 0x0400051E RID: 1310
		private global::System.Windows.Forms.ToolStripMenuItem modifyBinaryDataToolStripMenuItem1;

		// Token: 0x0400051F RID: 1311
		private global::System.Windows.Forms.ToolStripSeparator modifyNewtoolStripSeparator;

		// Token: 0x04000520 RID: 1312
		private global::System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;

		// Token: 0x04000521 RID: 1313
		private global::System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem2;

		// Token: 0x04000522 RID: 1314
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x04000523 RID: 1315
		private global::System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem2;

		// Token: 0x04000524 RID: 1316
		private global::System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem2;

		// Token: 0x04000525 RID: 1317
		private global::System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem2;

		// Token: 0x04000526 RID: 1318
		private global::System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem2;

		// Token: 0x04000527 RID: 1319
		private global::System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem2;

		// Token: 0x04000528 RID: 1320
		private global::System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem2;

		// Token: 0x04000529 RID: 1321
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x0400052A RID: 1322
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;

		// Token: 0x0400052B RID: 1323
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem2;

		// Token: 0x0400052C RID: 1324
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400052D RID: 1325
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400052E RID: 1326
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x0400052F RID: 1327
		private global::System.Windows.Forms.StatusStrip statusStrip;

		// Token: 0x04000530 RID: 1328
		private global::System.Windows.Forms.ToolStripStatusLabel selectedStripStatusLabel;

		// Token: 0x04000531 RID: 1329
		private global::Server.Helper.AeroListView lstRegistryValues;

		// Token: 0x04000532 RID: 1330
		private global::System.Windows.Forms.ImageList imageRegistryKeyTypeList;

		// Token: 0x04000533 RID: 1331
		private global::System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem;

		// Token: 0x04000534 RID: 1332
		private global::System.Windows.Forms.ContextMenuStrip tv_ContextMenuStrip;

		// Token: 0x04000535 RID: 1333
		private global::System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;

		// Token: 0x04000536 RID: 1334
		private global::System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;

		// Token: 0x04000537 RID: 1335
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000538 RID: 1336
		private global::System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem;

		// Token: 0x04000539 RID: 1337
		private global::System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem;

		// Token: 0x0400053A RID: 1338
		private global::System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem;

		// Token: 0x0400053B RID: 1339
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
	}
}
