namespace HVNC
{
	// Token: 0x02000017 RID: 23
	public partial class FrmMain : global::System.Windows.Forms.Form
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00002541 File Offset: 0x00000741
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000097F4 File Offset: 0x000079F4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HVNC.FrmMain));
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.testToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.builderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.remoteExecuteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.closeConnectionToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox3 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.PortStatus = new global::System.Windows.Forms.Label();
			this.imageList2 = new global::System.Windows.Forms.ImageList(this.components);
			this.HVNCList = new global::System.Windows.Forms.ListView();
			this.columnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.HVNCListenBtn = new global::System.Windows.Forms.ToolStripMenuItem();
			this.portToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.HVNCListenPort = new global::System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.siticoneGradientPanel4 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.hvncport = new global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
			this.TogglePort = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.siticoneDragControl1 = new global::Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneGradientPanel1 = new global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
			this.ClientsOnline = new global::System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.siticoneGradientPanel4.SuspendLayout();
			this.hvncport.BeginInit();
			this.siticoneGradientPanel1.SuspendLayout();
			base.SuspendLayout();
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Black;
			this.imageList1.Images.SetKeyName(0, "ad.png");
			this.imageList1.Images.SetKeyName(1, "ae.png");
			this.imageList1.Images.SetKeyName(2, "af.png");
			this.imageList1.Images.SetKeyName(3, "ag.png");
			this.imageList1.Images.SetKeyName(4, "ai.png");
			this.imageList1.Images.SetKeyName(5, "al.png");
			this.imageList1.Images.SetKeyName(6, "am.png");
			this.imageList1.Images.SetKeyName(7, "an.png");
			this.imageList1.Images.SetKeyName(8, "ao.png");
			this.imageList1.Images.SetKeyName(9, "ar.png");
			this.imageList1.Images.SetKeyName(10, "as.png");
			this.imageList1.Images.SetKeyName(11, "at.png");
			this.imageList1.Images.SetKeyName(12, "au.png");
			this.imageList1.Images.SetKeyName(13, "aw.png");
			this.imageList1.Images.SetKeyName(14, "ax.png");
			this.imageList1.Images.SetKeyName(15, "az.png");
			this.imageList1.Images.SetKeyName(16, "ba.png");
			this.imageList1.Images.SetKeyName(17, "bb.png");
			this.imageList1.Images.SetKeyName(18, "bd.png");
			this.imageList1.Images.SetKeyName(19, "be.png");
			this.imageList1.Images.SetKeyName(20, "bf.png");
			this.imageList1.Images.SetKeyName(21, "bg.png");
			this.imageList1.Images.SetKeyName(22, "bh.png");
			this.imageList1.Images.SetKeyName(23, "bi.png");
			this.imageList1.Images.SetKeyName(24, "bj.png");
			this.imageList1.Images.SetKeyName(25, "bm.png");
			this.imageList1.Images.SetKeyName(26, "bn.png");
			this.imageList1.Images.SetKeyName(27, "bo.png");
			this.imageList1.Images.SetKeyName(28, "br.png");
			this.imageList1.Images.SetKeyName(29, "bs.png");
			this.imageList1.Images.SetKeyName(30, "bt.png");
			this.imageList1.Images.SetKeyName(31, "bv.png");
			this.imageList1.Images.SetKeyName(32, "bw.png");
			this.imageList1.Images.SetKeyName(33, "by.png");
			this.imageList1.Images.SetKeyName(34, "bz.png");
			this.imageList1.Images.SetKeyName(35, "ca.png");
			this.imageList1.Images.SetKeyName(36, "catalonia.png");
			this.imageList1.Images.SetKeyName(37, "cc.png");
			this.imageList1.Images.SetKeyName(38, "cd.png");
			this.imageList1.Images.SetKeyName(39, "cf.png");
			this.imageList1.Images.SetKeyName(40, "cg.png");
			this.imageList1.Images.SetKeyName(41, "ch.png");
			this.imageList1.Images.SetKeyName(42, "ci.png");
			this.imageList1.Images.SetKeyName(43, "ck.png");
			this.imageList1.Images.SetKeyName(44, "cl.png");
			this.imageList1.Images.SetKeyName(45, "cm.png");
			this.imageList1.Images.SetKeyName(46, "cn.png");
			this.imageList1.Images.SetKeyName(47, "co.png");
			this.imageList1.Images.SetKeyName(48, "cr.png");
			this.imageList1.Images.SetKeyName(49, "cs.png");
			this.imageList1.Images.SetKeyName(50, "cu.png");
			this.imageList1.Images.SetKeyName(51, "cv.png");
			this.imageList1.Images.SetKeyName(52, "cx.png");
			this.imageList1.Images.SetKeyName(53, "cy.png");
			this.imageList1.Images.SetKeyName(54, "cz.png");
			this.imageList1.Images.SetKeyName(55, "de.png");
			this.imageList1.Images.SetKeyName(56, "dj.png");
			this.imageList1.Images.SetKeyName(57, "dk.png");
			this.imageList1.Images.SetKeyName(58, "dm.png");
			this.imageList1.Images.SetKeyName(59, "do.png");
			this.imageList1.Images.SetKeyName(60, "dz.png");
			this.imageList1.Images.SetKeyName(61, "ec.png");
			this.imageList1.Images.SetKeyName(62, "ee.png");
			this.imageList1.Images.SetKeyName(63, "eg.png");
			this.imageList1.Images.SetKeyName(64, "eh.png");
			this.imageList1.Images.SetKeyName(65, "england.png");
			this.imageList1.Images.SetKeyName(66, "er.png");
			this.imageList1.Images.SetKeyName(67, "es.png");
			this.imageList1.Images.SetKeyName(68, "et.png");
			this.imageList1.Images.SetKeyName(69, "europeanunion.png");
			this.imageList1.Images.SetKeyName(70, "fam.png");
			this.imageList1.Images.SetKeyName(71, "fi.png");
			this.imageList1.Images.SetKeyName(72, "fj.png");
			this.imageList1.Images.SetKeyName(73, "fk.png");
			this.imageList1.Images.SetKeyName(74, "fm.png");
			this.imageList1.Images.SetKeyName(75, "fo.png");
			this.imageList1.Images.SetKeyName(76, "fr.png");
			this.imageList1.Images.SetKeyName(77, "ga.png");
			this.imageList1.Images.SetKeyName(78, "gb.png");
			this.imageList1.Images.SetKeyName(79, "gd.png");
			this.imageList1.Images.SetKeyName(80, "ge.png");
			this.imageList1.Images.SetKeyName(81, "gf.png");
			this.imageList1.Images.SetKeyName(82, "gh.png");
			this.imageList1.Images.SetKeyName(83, "gi.png");
			this.imageList1.Images.SetKeyName(84, "gl.png");
			this.imageList1.Images.SetKeyName(85, "gm.png");
			this.imageList1.Images.SetKeyName(86, "gn.png");
			this.imageList1.Images.SetKeyName(87, "gp.png");
			this.imageList1.Images.SetKeyName(88, "gq.png");
			this.imageList1.Images.SetKeyName(89, "gr.png");
			this.imageList1.Images.SetKeyName(90, "gs.png");
			this.imageList1.Images.SetKeyName(91, "gt.png");
			this.imageList1.Images.SetKeyName(92, "gu.png");
			this.imageList1.Images.SetKeyName(93, "gw.png");
			this.imageList1.Images.SetKeyName(94, "gy.png");
			this.imageList1.Images.SetKeyName(95, "hk.png");
			this.imageList1.Images.SetKeyName(96, "hm.png");
			this.imageList1.Images.SetKeyName(97, "hn.png");
			this.imageList1.Images.SetKeyName(98, "hr.png");
			this.imageList1.Images.SetKeyName(99, "ht.png");
			this.imageList1.Images.SetKeyName(100, "hu.png");
			this.imageList1.Images.SetKeyName(101, "id.png");
			this.imageList1.Images.SetKeyName(102, "ie.png");
			this.imageList1.Images.SetKeyName(103, "il.png");
			this.imageList1.Images.SetKeyName(104, "in.png");
			this.imageList1.Images.SetKeyName(105, "io.png");
			this.imageList1.Images.SetKeyName(106, "iq.png");
			this.imageList1.Images.SetKeyName(107, "ir.png");
			this.imageList1.Images.SetKeyName(108, "is.png");
			this.imageList1.Images.SetKeyName(109, "it.png");
			this.imageList1.Images.SetKeyName(110, "jm.png");
			this.imageList1.Images.SetKeyName(111, "jo.png");
			this.imageList1.Images.SetKeyName(112, "jp.png");
			this.imageList1.Images.SetKeyName(113, "ke.png");
			this.imageList1.Images.SetKeyName(114, "kg.png");
			this.imageList1.Images.SetKeyName(115, "kh.png");
			this.imageList1.Images.SetKeyName(116, "ki.png");
			this.imageList1.Images.SetKeyName(117, "km.png");
			this.imageList1.Images.SetKeyName(118, "kn.png");
			this.imageList1.Images.SetKeyName(119, "kp.png");
			this.imageList1.Images.SetKeyName(120, "kr.png");
			this.imageList1.Images.SetKeyName(121, "kw.png");
			this.imageList1.Images.SetKeyName(122, "ky.png");
			this.imageList1.Images.SetKeyName(123, "kz.png");
			this.imageList1.Images.SetKeyName(124, "la.png");
			this.imageList1.Images.SetKeyName(125, "lb.png");
			this.imageList1.Images.SetKeyName(126, "lc.png");
			this.imageList1.Images.SetKeyName(127, "li.png");
			this.imageList1.Images.SetKeyName(128, "lk.png");
			this.imageList1.Images.SetKeyName(129, "lr.png");
			this.imageList1.Images.SetKeyName(130, "ls.png");
			this.imageList1.Images.SetKeyName(131, "lt.png");
			this.imageList1.Images.SetKeyName(132, "lu.png");
			this.imageList1.Images.SetKeyName(133, "lv.png");
			this.imageList1.Images.SetKeyName(134, "ly.png");
			this.imageList1.Images.SetKeyName(135, "ma.png");
			this.imageList1.Images.SetKeyName(136, "mc.png");
			this.imageList1.Images.SetKeyName(137, "md.png");
			this.imageList1.Images.SetKeyName(138, "me.png");
			this.imageList1.Images.SetKeyName(139, "mg.png");
			this.imageList1.Images.SetKeyName(140, "mh.png");
			this.imageList1.Images.SetKeyName(141, "mk.png");
			this.imageList1.Images.SetKeyName(142, "ml.png");
			this.imageList1.Images.SetKeyName(143, "mm.png");
			this.imageList1.Images.SetKeyName(144, "mn.png");
			this.imageList1.Images.SetKeyName(145, "mo.png");
			this.imageList1.Images.SetKeyName(146, "mp.png");
			this.imageList1.Images.SetKeyName(147, "mq.png");
			this.imageList1.Images.SetKeyName(148, "mr.png");
			this.imageList1.Images.SetKeyName(149, "ms.png");
			this.imageList1.Images.SetKeyName(150, "mt.png");
			this.imageList1.Images.SetKeyName(151, "mu.png");
			this.imageList1.Images.SetKeyName(152, "mv.png");
			this.imageList1.Images.SetKeyName(153, "mw.png");
			this.imageList1.Images.SetKeyName(154, "mx.png");
			this.imageList1.Images.SetKeyName(155, "my.png");
			this.imageList1.Images.SetKeyName(156, "mz.png");
			this.imageList1.Images.SetKeyName(157, "na.png");
			this.imageList1.Images.SetKeyName(158, "nc.png");
			this.imageList1.Images.SetKeyName(159, "ne.png");
			this.imageList1.Images.SetKeyName(160, "nf.png");
			this.imageList1.Images.SetKeyName(161, "ng.png");
			this.imageList1.Images.SetKeyName(162, "ni.png");
			this.imageList1.Images.SetKeyName(163, "nl.png");
			this.imageList1.Images.SetKeyName(164, "no.png");
			this.imageList1.Images.SetKeyName(165, "np.png");
			this.imageList1.Images.SetKeyName(166, "nr.png");
			this.imageList1.Images.SetKeyName(167, "nu.png");
			this.imageList1.Images.SetKeyName(168, "nz.png");
			this.imageList1.Images.SetKeyName(169, "om.png");
			this.imageList1.Images.SetKeyName(170, "pa.png");
			this.imageList1.Images.SetKeyName(171, "pe.png");
			this.imageList1.Images.SetKeyName(172, "pf.png");
			this.imageList1.Images.SetKeyName(173, "pg.png");
			this.imageList1.Images.SetKeyName(174, "ph.png");
			this.imageList1.Images.SetKeyName(175, "pk.png");
			this.imageList1.Images.SetKeyName(176, "pl.png");
			this.imageList1.Images.SetKeyName(177, "pm.png");
			this.imageList1.Images.SetKeyName(178, "pn.png");
			this.imageList1.Images.SetKeyName(179, "pr.png");
			this.imageList1.Images.SetKeyName(180, "ps.png");
			this.imageList1.Images.SetKeyName(181, "pt.png");
			this.imageList1.Images.SetKeyName(182, "pw.png");
			this.imageList1.Images.SetKeyName(183, "py.png");
			this.imageList1.Images.SetKeyName(184, "qa.png");
			this.imageList1.Images.SetKeyName(185, "re.png");
			this.imageList1.Images.SetKeyName(186, "ro.png");
			this.imageList1.Images.SetKeyName(187, "rs.png");
			this.imageList1.Images.SetKeyName(188, "ru.png");
			this.imageList1.Images.SetKeyName(189, "rw.png");
			this.imageList1.Images.SetKeyName(190, "sa.png");
			this.imageList1.Images.SetKeyName(191, "sb.png");
			this.imageList1.Images.SetKeyName(192, "sc.png");
			this.imageList1.Images.SetKeyName(193, "scotland.png");
			this.imageList1.Images.SetKeyName(194, "sd.png");
			this.imageList1.Images.SetKeyName(195, "se.png");
			this.imageList1.Images.SetKeyName(196, "sg.png");
			this.imageList1.Images.SetKeyName(197, "sh.png");
			this.imageList1.Images.SetKeyName(198, "si.png");
			this.imageList1.Images.SetKeyName(199, "sj.png");
			this.imageList1.Images.SetKeyName(200, "sk.png");
			this.imageList1.Images.SetKeyName(201, "sl.png");
			this.imageList1.Images.SetKeyName(202, "sm.png");
			this.imageList1.Images.SetKeyName(203, "sn.png");
			this.imageList1.Images.SetKeyName(204, "so.png");
			this.imageList1.Images.SetKeyName(205, "sr.png");
			this.imageList1.Images.SetKeyName(206, "st.png");
			this.imageList1.Images.SetKeyName(207, "sv.png");
			this.imageList1.Images.SetKeyName(208, "sy.png");
			this.imageList1.Images.SetKeyName(209, "sz.png");
			this.imageList1.Images.SetKeyName(210, "tc.png");
			this.imageList1.Images.SetKeyName(211, "td.png");
			this.imageList1.Images.SetKeyName(212, "tf.png");
			this.imageList1.Images.SetKeyName(213, "tg.png");
			this.imageList1.Images.SetKeyName(214, "th.png");
			this.imageList1.Images.SetKeyName(215, "tj.png");
			this.imageList1.Images.SetKeyName(216, "tk.png");
			this.imageList1.Images.SetKeyName(217, "tl.png");
			this.imageList1.Images.SetKeyName(218, "tm.png");
			this.imageList1.Images.SetKeyName(219, "tn.png");
			this.imageList1.Images.SetKeyName(220, "to.png");
			this.imageList1.Images.SetKeyName(221, "tr.png");
			this.imageList1.Images.SetKeyName(222, "tt.png");
			this.imageList1.Images.SetKeyName(223, "tv.png");
			this.imageList1.Images.SetKeyName(224, "tw.png");
			this.imageList1.Images.SetKeyName(225, "tz.png");
			this.imageList1.Images.SetKeyName(226, "ua.png");
			this.imageList1.Images.SetKeyName(227, "ug.png");
			this.imageList1.Images.SetKeyName(228, "um.png");
			this.imageList1.Images.SetKeyName(229, "us.png");
			this.imageList1.Images.SetKeyName(230, "uy.png");
			this.imageList1.Images.SetKeyName(231, "uz.png");
			this.imageList1.Images.SetKeyName(232, "va.png");
			this.imageList1.Images.SetKeyName(233, "vc.png");
			this.imageList1.Images.SetKeyName(234, "ve.png");
			this.imageList1.Images.SetKeyName(235, "vg.png");
			this.imageList1.Images.SetKeyName(236, "vi.png");
			this.imageList1.Images.SetKeyName(237, "vn.png");
			this.imageList1.Images.SetKeyName(238, "vu.png");
			this.imageList1.Images.SetKeyName(239, "wales.png");
			this.imageList1.Images.SetKeyName(240, "wf.png");
			this.imageList1.Images.SetKeyName(241, "ws.png");
			this.imageList1.Images.SetKeyName(242, "ye.png");
			this.imageList1.Images.SetKeyName(243, "yt.png");
			this.imageList1.Images.SetKeyName(244, "za.png");
			this.imageList1.Images.SetKeyName(245, "zm.png");
			this.imageList1.Images.SetKeyName(246, "zw.png");
			this.contextMenuStrip1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(25, 25);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.testToolStripMenuItem,
				this.builderToolStripMenuItem,
				this.optionsToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(165, 100);
			this.testToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("testToolStripMenuItem.Image");
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new global::System.Drawing.Size(164, 32);
			this.testToolStripMenuItem.Text = "Venom HVNC";
			this.testToolStripMenuItem.Click += new global::System.EventHandler(this.HVNCList_DoubleClick);
			this.builderToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("builderToolStripMenuItem.Image");
			this.builderToolStripMenuItem.Name = "builderToolStripMenuItem";
			this.builderToolStripMenuItem.Size = new global::System.Drawing.Size(164, 32);
			this.builderToolStripMenuItem.Text = "Builder";
			this.builderToolStripMenuItem.Click += new global::System.EventHandler(this.builderToolStripMenuItem_Click);
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.remoteExecuteToolStripMenuItem,
				this.closeConnectionToolStripMenuItem
			});
			this.optionsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("optionsToolStripMenuItem.Image");
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new global::System.Drawing.Size(164, 32);
			this.optionsToolStripMenuItem.Text = "Options";
			this.remoteExecuteToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("remoteExecuteToolStripMenuItem.Image");
			this.remoteExecuteToolStripMenuItem.Name = "remoteExecuteToolStripMenuItem";
			this.remoteExecuteToolStripMenuItem.Size = new global::System.Drawing.Size(186, 32);
			this.remoteExecuteToolStripMenuItem.Text = "Remote Execute";
			this.remoteExecuteToolStripMenuItem.Click += new global::System.EventHandler(this.remoteExecuteToolStripMenuItem_Click);
			this.closeConnectionToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("closeConnectionToolStripMenuItem.Image");
			this.closeConnectionToolStripMenuItem.Name = "closeConnectionToolStripMenuItem";
			this.closeConnectionToolStripMenuItem.Size = new global::System.Drawing.Size(186, 32);
			this.closeConnectionToolStripMenuItem.Text = "Close Connection";
			this.closeConnectionToolStripMenuItem.Click += new global::System.EventHandler(this.closeConnectionToolStripMenuItem_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel1.Controls.Add(this.siticoneControlBox3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1088, 36);
			this.panel1.TabIndex = 2;
			this.siticoneControlBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox3.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox3.HoverState.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox3.Location = new global::System.Drawing.Point(1058, 3);
			this.siticoneControlBox3.Name = "siticoneControlBox3";
			this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.Size = new global::System.Drawing.Size(30, 30);
			this.siticoneControlBox3.TabIndex = 149;
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 32);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 144;
			this.pictureBox1.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label3.Location = new global::System.Drawing.Point(38, 8);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(54, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "HVNC";
			this.PortStatus.AutoSize = true;
			this.PortStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.PortStatus.ForeColor = global::System.Drawing.Color.White;
			this.PortStatus.Location = new global::System.Drawing.Point(868, 8);
			this.PortStatus.Name = "PortStatus";
			this.PortStatus.Size = new global::System.Drawing.Size(71, 13);
			this.PortStatus.TabIndex = 146;
			this.PortStatus.Text = "Listening Port";
			this.PortStatus.Visible = false;
			this.imageList2.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList2.ImageStream");
			this.imageList2.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "connected_480px.png");
			this.imageList2.Images.SetKeyName(1, "disconnected_480px.png");
			this.HVNCList.Activation = global::System.Windows.Forms.ItemActivation.OneClick;
			this.HVNCList.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.HVNCList.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.HVNCList.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader3,
				this.columnHeader1
			});
			this.HVNCList.ContextMenuStrip = this.contextMenuStrip1;
			this.HVNCList.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.HVNCList.ForeColor = global::System.Drawing.Color.Transparent;
			this.HVNCList.FullRowSelect = true;
			this.HVNCList.HideSelection = false;
			this.HVNCList.LabelEdit = true;
			this.HVNCList.Location = new global::System.Drawing.Point(0, 67);
			this.HVNCList.Name = "HVNCList";
			this.HVNCList.Size = new global::System.Drawing.Size(1088, 514);
			this.HVNCList.SmallImageList = this.imageList1;
			this.HVNCList.TabIndex = 7;
			this.HVNCList.UseCompatibleStateImageBehavior = false;
			this.HVNCList.View = global::System.Windows.Forms.View.Details;
			this.columnHeader3.Text = "IP Address";
			this.columnHeader3.Width = 150;
			this.columnHeader1.Text = "";
			this.columnHeader1.Width = 938;
			this.HVNCListenBtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.HVNCListenBtn.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.portToolStripMenuItem,
				this.HVNCListenPort,
				this.toolStripSeparator3
			});
			this.HVNCListenBtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("HVNCListenBtn.Image");
			this.HVNCListenBtn.Name = "HVNCListenBtn";
			this.HVNCListenBtn.Size = new global::System.Drawing.Size(189, 32);
			this.HVNCListenBtn.Text = "listening Port";
			this.HVNCListenBtn.Click += new global::System.EventHandler(this.HVNCListenBtn_Click_1);
			this.portToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("portToolStripMenuItem.Image");
			this.portToolStripMenuItem.Name = "portToolStripMenuItem";
			this.portToolStripMenuItem.Size = new global::System.Drawing.Size(160, 22);
			this.portToolStripMenuItem.Text = "Port :";
			this.HVNCListenPort.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.HVNCListenPort.Name = "HVNCListenPort";
			this.HVNCListenPort.Size = new global::System.Drawing.Size(100, 23);
			this.HVNCListenPort.Text = "9031";
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(157, 6);
			this.siticoneGradientPanel4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Controls.Add(this.hvncport);
			this.siticoneGradientPanel4.Controls.Add(this.TogglePort);
			this.siticoneGradientPanel4.Controls.Add(this.PortStatus);
			this.siticoneGradientPanel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.siticoneGradientPanel4.FillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel4.FillColor2 = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel4.Location = new global::System.Drawing.Point(0, 36);
			this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
			this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
			this.siticoneGradientPanel4.Size = new global::System.Drawing.Size(1088, 31);
			this.siticoneGradientPanel4.TabIndex = 157;
			this.hvncport.BackColor = global::System.Drawing.Color.Transparent;
			this.hvncport.BorderColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.hvncport.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.hvncport.DisabledState.Parent = this.hvncport;
			this.hvncport.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.hvncport.FocusedState.Parent = this.hvncport;
			this.hvncport.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.hvncport.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.hvncport.Location = new global::System.Drawing.Point(1002, 3);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown = this.hvncport;
			int[] array = new int[4];
			array[0] = 65535;
			siticoneNumericUpDown.Maximum = new decimal(array);
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown2 = this.hvncport;
			int[] array2 = new int[4];
			array2[0] = 1024;
			siticoneNumericUpDown2.Minimum = new decimal(array2);
			this.hvncport.Name = "hvncport";
			this.hvncport.ShadowDecoration.Parent = this.hvncport;
			this.hvncport.Size = new global::System.Drawing.Size(83, 25);
			this.hvncport.TabIndex = 162;
			this.hvncport.UpDownButtonFillColor = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.hvncport.UpDownButtonForeColor = global::System.Drawing.Color.Gainsboro;
			global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown siticoneNumericUpDown3 = this.hvncport;
			int[] array3 = new int[4];
			array3[0] = 4448;
			siticoneNumericUpDown3.Value = new decimal(array3);
			this.TogglePort.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.TogglePort.BackColor = global::System.Drawing.Color.Transparent;
			this.TogglePort.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.TogglePort.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.TogglePort.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.TogglePort.CheckedState.InnerBorderThickness = 2;
			this.TogglePort.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.TogglePort.CheckedState.Parent = this.TogglePort;
			this.TogglePort.Location = new global::System.Drawing.Point(945, 5);
			this.TogglePort.Name = "TogglePort";
			this.TogglePort.ShadowDecoration.Parent = this.TogglePort;
			this.TogglePort.Size = new global::System.Drawing.Size(39, 20);
			this.TogglePort.TabIndex = 157;
			this.TogglePort.UncheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.TogglePort.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.TogglePort.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.TogglePort.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.TogglePort.UncheckedState.Parent = this.TogglePort;
			this.TogglePort.CheckedChanged += new global::System.EventHandler(this.TogglePort_Click);
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.siticoneBorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(29, 185, 84);
			this.siticoneDragControl1.TargetControl = this.panel1;
			this.siticoneGradientPanel1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.Controls.Add(this.ClientsOnline);
			this.siticoneGradientPanel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.siticoneGradientPanel1.FillColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.siticoneGradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(27, 91, 50);
			this.siticoneGradientPanel1.Location = new global::System.Drawing.Point(0, 581);
			this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
			this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
			this.siticoneGradientPanel1.Size = new global::System.Drawing.Size(1088, 24);
			this.siticoneGradientPanel1.TabIndex = 158;
			this.ClientsOnline.AutoSize = true;
			this.ClientsOnline.BackColor = global::System.Drawing.Color.Transparent;
			this.ClientsOnline.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ClientsOnline.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.ClientsOnline.Location = new global::System.Drawing.Point(2, 4);
			this.ClientsOnline.Name = "ClientsOnline";
			this.ClientsOnline.Size = new global::System.Drawing.Size(132, 15);
			this.ClientsOnline.TabIndex = 5;
			this.ClientsOnline.Text = "Client in HVNC Panel 0";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			base.ClientSize = new global::System.Drawing.Size(1088, 605);
			this.ContextMenuStrip = this.contextMenuStrip1;
			base.Controls.Add(this.HVNCList);
			base.Controls.Add(this.siticoneGradientPanel4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.siticoneGradientPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(1040, 521);
			base.Name = "FrmMain";
			base.Opacity = 0.97;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HVNC";
			base.TransparencyKey = global::System.Drawing.Color.FromArgb(0, 0, 9, 19);
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
			base.Load += new global::System.EventHandler(this.FrmMain_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.siticoneGradientPanel4.ResumeLayout(false);
			this.siticoneGradientPanel4.PerformLayout();
			this.hvncport.EndInit();
			this.siticoneGradientPanel1.ResumeLayout(false);
			this.siticoneGradientPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400005E RID: 94
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000064 RID: 100
		public global::System.Windows.Forms.ToolStripMenuItem HVNCListenBtn;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.ToolStripTextBox HVNCListenPort;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.ImageList imageList2;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400006B RID: 107
		public global::System.Windows.Forms.ListView HVNCList;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.ToolStripMenuItem builderToolStripMenuItem;

		// Token: 0x0400006E RID: 110
		public global::System.Windows.Forms.Label PortStatus;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.ToolStripMenuItem remoteExecuteToolStripMenuItem;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.ToolStripMenuItem closeConnectionToolStripMenuItem;

		// Token: 0x04000072 RID: 114
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;

		// Token: 0x04000073 RID: 115
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x04000074 RID: 116
		private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000075 RID: 117
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Label ClientsOnline;

		// Token: 0x04000077 RID: 119
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch TogglePort;

		// Token: 0x04000078 RID: 120
		private global::Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown hvncport;

		// Token: 0x04000079 RID: 121
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
	}
}
