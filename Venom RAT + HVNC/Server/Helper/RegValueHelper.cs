using System;
using Microsoft.Win32;

namespace Server.Helper
{
	// Token: 0x02000053 RID: 83
	public class RegValueHelper
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x000036CF File Offset: 0x000018CF
		public static bool IsDefaultValue(string valueName)
		{
			return string.IsNullOrEmpty(valueName);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000036D7 File Offset: 0x000018D7
		public static string GetName(string valueName)
		{
			if (!RegValueHelper.IsDefaultValue(valueName))
			{
				return valueName;
			}
			return RegValueHelper.DEFAULT_REG_VALUE;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00020FA8 File Offset: 0x0001F1A8
		public static string RegistryValueToString(RegistrySeeker.RegValueData value)
		{
			switch (value.Kind)
			{
			case RegistryValueKind.String:
			case RegistryValueKind.ExpandString:
				return ByteConverter.ToString(value.Data);
			case RegistryValueKind.Binary:
				if (value.Data.Length == 0)
				{
					return "(zero-length binary value)";
				}
				return BitConverter.ToString(value.Data).Replace("-", " ").ToLower();
			case RegistryValueKind.DWord:
			{
				uint num = ByteConverter.ToUInt32(value.Data);
				return string.Format("0x{0:x8} ({1})", num, num);
			}
			case RegistryValueKind.MultiString:
				return string.Join(" ", ByteConverter.ToStringArray(value.Data));
			case RegistryValueKind.QWord:
			{
				ulong num2 = ByteConverter.ToUInt64(value.Data);
				return string.Format("0x{0:x8} ({1})", num2, num2);
			}
			}
			return string.Empty;
		}

		// Token: 0x04000243 RID: 579
		private static string DEFAULT_REG_VALUE = "(Default)";
	}
}
