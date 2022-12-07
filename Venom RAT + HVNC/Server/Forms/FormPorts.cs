using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Server.Helper;
using Server.Properties;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x020000A3 RID: 163
	public partial class FormPorts : Form
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x00004A37 File Offset: 0x00002C37
		public FormPorts()
		{
			this.InitializeComponent();
			base.Opacity = 0.0;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00042968 File Offset: 0x00040B68
		private void PortsFrm_Load(object sender, EventArgs e)
		{
			Methods.FadeIn(this, 5);
			this.Text = Settings.Version + " | Welcome " + Environment.UserName;
			if (!File.Exists(Settings.CertificatePath))
			{
				using (FormCertificate formCertificate = new FormCertificate())
				{
					formCertificate.ShowDialog();
					return;
				}
			}
			Settings.ServerCertificate = new X509Certificate2(Settings.CertificatePath);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000429DC File Offset: 0x00040BDC
		private void button1_Click(object sender, EventArgs e)
		{
			Settings.Default.Ports = this.textPorts.Value.ToString();
			Settings.Default.Save();
			FormPorts.isOK = true;
			base.Close();
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00004A54 File Offset: 0x00002C54
		private void PortsFrm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!FormPorts.isOK)
			{
				Program.form1.notifyIcon1.Dispose();
				Environment.Exit(0);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00042A1C File Offset: 0x00040C1C
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				Convert.ToInt32(this.textPorts.Text.Trim());
			}
			catch
			{
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000024F0 File Offset: 0x000006F0
		private void BtnDelete_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400047B RID: 1147
		private static bool isOK;
	}
}
