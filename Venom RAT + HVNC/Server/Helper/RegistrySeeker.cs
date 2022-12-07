using System;
using System.Collections.Generic;
using Microsoft.Win32;
using ProtoBuf;

namespace Server.Helper
{
	// Token: 0x0200005B RID: 91
	public class RegistrySeeker
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00003925 File Offset: 0x00001B25
		public RegistrySeeker.RegSeekerMatch[] Matches
		{
			get
			{
				List<RegistrySeeker.RegSeekerMatch> matches = this._matches;
				if (matches == null)
				{
					return null;
				}
				return matches.ToArray();
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003938 File Offset: 0x00001B38
		public RegistrySeeker()
		{
			this._matches = new List<RegistrySeeker.RegSeekerMatch>();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00021704 File Offset: 0x0001F904
		public void BeginSeeking(string rootKeyName)
		{
			if (!string.IsNullOrEmpty(rootKeyName))
			{
				using (RegistryKey rootKey = RegistrySeeker.GetRootKey(rootKeyName))
				{
					if (rootKey != null && rootKey.Name != rootKeyName)
					{
						string name = rootKeyName.Substring(rootKey.Name.Length + 1);
						using (RegistryKey registryKey = rootKey.OpenReadonlySubKeySafe(name))
						{
							if (registryKey != null)
							{
								this.Seek(registryKey);
							}
							return;
						}
					}
					this.Seek(rootKey);
					return;
				}
			}
			this.Seek(null);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0002179C File Offset: 0x0001F99C
		private void Seek(RegistryKey rootKey)
		{
			if (rootKey == null)
			{
				using (List<RegistryKey>.Enumerator enumerator = RegistrySeeker.GetRootKeys().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						RegistryKey registryKey = enumerator.Current;
						this.ProcessKey(registryKey, registryKey.Name);
					}
					return;
				}
			}
			this.Search(rootKey);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00021800 File Offset: 0x0001FA00
		private void Search(RegistryKey rootKey)
		{
			foreach (string text in rootKey.GetSubKeyNames())
			{
				RegistryKey key = rootKey.OpenReadonlySubKeySafe(text);
				this.ProcessKey(key, text);
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00021838 File Offset: 0x0001FA38
		private void ProcessKey(RegistryKey key, string keyName)
		{
			if (key != null)
			{
				List<RegistrySeeker.RegValueData> list = new List<RegistrySeeker.RegValueData>();
				foreach (string name in key.GetValueNames())
				{
					RegistryValueKind valueKind = key.GetValueKind(name);
					object value = key.GetValue(name);
					list.Add(RegistryKeyHelper.CreateRegValueData(name, valueKind, value));
				}
				this.AddMatch(keyName, RegistryKeyHelper.AddDefaultValue(list), key.SubKeyCount);
				return;
			}
			this.AddMatch(keyName, RegistryKeyHelper.GetDefaultValues(), 0);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000218AC File Offset: 0x0001FAAC
		private void AddMatch(string key, RegistrySeeker.RegValueData[] values, int subkeycount)
		{
			RegistrySeeker.RegSeekerMatch item = new RegistrySeeker.RegSeekerMatch
			{
				Key = key,
				Data = values,
				HasSubKeys = (subkeycount > 0)
			};
			this._matches.Add(item);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000218E4 File Offset: 0x0001FAE4
		public static RegistryKey GetRootKey(string subkeyFullPath)
		{
			string[] array = subkeyFullPath.Split(new char[]
			{
				'\\'
			});
			RegistryKey result;
			try
			{
				string a = array[0];
				if (!(a == "HKEY_CLASSES_ROOT"))
				{
					if (!(a == "HKEY_CURRENT_USER"))
					{
						if (!(a == "HKEY_LOCAL_MACHINE"))
						{
							if (!(a == "HKEY_USERS"))
							{
								if (!(a == "HKEY_CURRENT_CONFIG"))
								{
									throw new Exception("Invalid rootkey, could not be found.");
								}
								result = RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, RegistryView.Registry64);
							}
							else
							{
								result = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry64);
							}
						}
						else
						{
							result = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						}
					}
					else
					{
						result = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
					}
				}
				else
				{
					result = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
				}
			}
			catch (SystemException)
			{
				throw new Exception("Unable to open root registry key, you do not have the needed permissions.");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000219DC File Offset: 0x0001FBDC
		public static List<RegistryKey> GetRootKeys()
		{
			List<RegistryKey> list = new List<RegistryKey>();
			try
			{
				list.Add(RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64));
				list.Add(RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64));
				list.Add(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64));
				list.Add(RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry64));
				list.Add(RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, RegistryView.Registry64));
			}
			catch (SystemException)
			{
				throw new Exception("Could not open root registry keys, you may not have the needed permission");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return list;
		}

		// Token: 0x0400024F RID: 591
		private readonly List<RegistrySeeker.RegSeekerMatch> _matches;

		// Token: 0x0200005C RID: 92
		[ProtoContract]
		public class RegSeekerMatch
		{
			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060002FF RID: 767 RVA: 0x0000394B File Offset: 0x00001B4B
			// (set) Token: 0x06000300 RID: 768 RVA: 0x00003953 File Offset: 0x00001B53
			[ProtoMember(1)]
			public string Key { get; set; }

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000301 RID: 769 RVA: 0x0000395C File Offset: 0x00001B5C
			// (set) Token: 0x06000302 RID: 770 RVA: 0x00003964 File Offset: 0x00001B64
			[ProtoMember(2)]
			public RegistrySeeker.RegValueData[] Data { get; set; }

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000303 RID: 771 RVA: 0x0000396D File Offset: 0x00001B6D
			// (set) Token: 0x06000304 RID: 772 RVA: 0x00003975 File Offset: 0x00001B75
			[ProtoMember(3)]
			public bool HasSubKeys { get; set; }

			// Token: 0x06000305 RID: 773 RVA: 0x0000397E File Offset: 0x00001B7E
			public override string ToString()
			{
				return string.Format("({0}:{1})", this.Key, this.Data);
			}
		}

		// Token: 0x0200005D RID: 93
		[ProtoContract]
		public class RegValueData
		{
			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000307 RID: 775 RVA: 0x00003996 File Offset: 0x00001B96
			// (set) Token: 0x06000308 RID: 776 RVA: 0x0000399E File Offset: 0x00001B9E
			[ProtoMember(1)]
			public string Name { get; set; }

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x06000309 RID: 777 RVA: 0x000039A7 File Offset: 0x00001BA7
			// (set) Token: 0x0600030A RID: 778 RVA: 0x000039AF File Offset: 0x00001BAF
			[ProtoMember(2)]
			public RegistryValueKind Kind { get; set; }

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x0600030B RID: 779 RVA: 0x000039B8 File Offset: 0x00001BB8
			// (set) Token: 0x0600030C RID: 780 RVA: 0x000039C0 File Offset: 0x00001BC0
			[ProtoMember(3)]
			public byte[] Data { get; set; }
		}
	}
}
