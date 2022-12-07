using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

namespace Server.Helper
{
	// Token: 0x02000059 RID: 89
	public static class RegistryKeyHelper
	{
		// Token: 0x060002EA RID: 746 RVA: 0x00021510 File Offset: 0x0001F710
		public static bool AddRegistryKeyValue(RegistryHive hive, string path, string name, string value, bool addQuotes = false)
		{
			bool result;
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenWritableSubKeySafe(path))
				{
					if (registryKey == null)
					{
						result = false;
					}
					else
					{
						if (addQuotes && !value.StartsWith("\"") && !value.EndsWith("\""))
						{
							value = "\"" + value + "\"";
						}
						registryKey.SetValue(name, value);
						result = true;
					}
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000215A0 File Offset: 0x0001F7A0
		public static RegistryKey OpenReadonlySubKey(RegistryHive hive, string path)
		{
			RegistryKey result;
			try
			{
				result = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenSubKey(path, false);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000215D8 File Offset: 0x0001F7D8
		public static bool DeleteRegistryKeyValue(RegistryHive hive, string path, string name)
		{
			bool result;
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenWritableSubKeySafe(path))
				{
					if (registryKey == null)
					{
						result = false;
					}
					else
					{
						registryKey.DeleteValue(name, true);
						result = true;
					}
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000036CF File Offset: 0x000018CF
		public static bool IsDefaultValue(string valueName)
		{
			return string.IsNullOrEmpty(valueName);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000038A8 File Offset: 0x00001AA8
		public static RegistrySeeker.RegValueData[] AddDefaultValue(List<RegistrySeeker.RegValueData> values)
		{
			if (!values.Any((RegistrySeeker.RegValueData value) => RegistryKeyHelper.IsDefaultValue(value.Name)))
			{
				values.Add(RegistryKeyHelper.GetDefaultValue());
			}
			return values.ToArray();
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000038E2 File Offset: 0x00001AE2
		public static RegistrySeeker.RegValueData[] GetDefaultValues()
		{
			return new RegistrySeeker.RegValueData[]
			{
				RegistryKeyHelper.GetDefaultValue()
			};
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00021638 File Offset: 0x0001F838
		public static RegistrySeeker.RegValueData CreateRegValueData(string name, RegistryValueKind kind, object value = null)
		{
			RegistrySeeker.RegValueData regValueData = new RegistrySeeker.RegValueData
			{
				Name = name,
				Kind = kind
			};
			if (value == null)
			{
				regValueData.Data = new byte[0];
			}
			else
			{
				switch (regValueData.Kind)
				{
				case RegistryValueKind.String:
				case RegistryValueKind.ExpandString:
					regValueData.Data = ByteConverter.GetBytes((string)value);
					break;
				case RegistryValueKind.Binary:
					regValueData.Data = (byte[])value;
					break;
				case RegistryValueKind.DWord:
					regValueData.Data = ByteConverter.GetBytes((uint)((int)value));
					break;
				case RegistryValueKind.MultiString:
					regValueData.Data = ByteConverter.GetBytes((string[])value);
					break;
				case RegistryValueKind.QWord:
					regValueData.Data = ByteConverter.GetBytes((ulong)((long)value));
					break;
				}
			}
			return regValueData;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000038F2 File Offset: 0x00001AF2
		private static RegistrySeeker.RegValueData GetDefaultValue()
		{
			return RegistryKeyHelper.CreateRegValueData(RegistryKeyHelper.DEFAULT_VALUE, RegistryValueKind.String, null);
		}

		// Token: 0x0400024C RID: 588
		private static string DEFAULT_VALUE = string.Empty;
	}
}
