using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KeyAuth;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x02000091 RID: 145
	public partial class FormLogin : Form
	{
		// Token: 0x0600046A RID: 1130 RVA: 0x000044DD File Offset: 0x000026DD
		public FormLogin()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0002D9E8 File Offset: 0x0002BBE8
		private void LoginForm_Load(object sender, EventArgs e)
		{
			FormLogin.KeyAuthApp.init();
			if (File.Exists("Venom.License"))
			{
				string[] array = File.ReadAllText("Venom.License").Split(new char[]
				{
					':'
				});
				this.usernameBox.Text = array[0];
				this.passwordBox.Text = array[1];
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000044EB File Offset: 0x000026EB
		private void siticoneRoundedButton6_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0002DA44 File Offset: 0x0002BC44
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			if (FormLogin.KeyAuthApp.login(this.usernameBox.Text, this.passwordBox.Text))
			{
				FormMain.islogin = true;
				MessageBox.Show("Welcome to Venom RAT + HVNC, " + this.usernameBox.Text);
				base.Hide();
				if (this.BtnSavedLogin.Checked)
				{
					FormMain.islogin = true;
					MessageBox.Show("Welcome to Venom RAT + HVNC, " + this.usernameBox.Text);
					base.Hide();
					return;
				}
			}
			else
			{
				FormMain.islogin = true;
				MessageBox.Show("Welcome to Venom RAT + HVNC, " + this.usernameBox.Text);
				base.Hide();
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000044F3 File Offset: 0x000026F3
		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			this.registerPanel.Visible = false;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
		private void siticoneRoundedButton4_Click(object sender, EventArgs e)
		{
			if (FormLogin.KeyAuthApp.register(this.regUsernamebox.Text, this.regPasswordbox.Text, this.regKeybox.Text))
			{
				MessageBox.Show("Registered with the username " + this.regUsernamebox.Text);
				return;
			}
			MessageBox.Show("Failed to register");
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00004501 File Offset: 0x00002701
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			this.registerPanel.Visible = true;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000450F File Offset: 0x0000270F
		private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!FormMain.islogin)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000451E File Offset: 0x0000271E
		private void BtnResetHWID_LinkClicked(object sender, EventArgs e)
		{
			Process.Start("https://auth.venomlicense.com/panel/Venom/Venom%20HVNC");
		}

		// Token: 0x04000338 RID: 824
		private static string name = "Venom HVNC";

		// Token: 0x04000339 RID: 825
		private static string ownerid = "lyvCMfkzTe";

		// Token: 0x0400033A RID: 826
		private static string secret = "ed687f5eef92a968b231708d338718d98faedf3efe99c5ad0b451e79ed910988";

		// Token: 0x0400033B RID: 827
		private static string version = "5.0.5";

		// Token: 0x0400033C RID: 828
		public static api KeyAuthApp = new api(FormLogin.name, FormLogin.ownerid, FormLogin.secret, FormLogin.version);
	}
}
