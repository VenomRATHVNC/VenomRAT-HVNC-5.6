using System;
using System.IO;

namespace Server.MessagePack
{
	// Token: 0x0200003D RID: 61
	internal class ReadTools
	{
		// Token: 0x06000274 RID: 628 RVA: 0x0001FF98 File Offset: 0x0001E198
		public static string ReadString(Stream ms, int len)
		{
			byte[] array = new byte[len];
			ms.Read(array, 0, len);
			return BytesTools.GetString(array);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000034BC File Offset: 0x000016BC
		public static string ReadString(Stream ms)
		{
			return ReadTools.ReadString((byte)ms.ReadByte(), ms);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001FFBC File Offset: 0x0001E1BC
		public static string ReadString(byte strFlag, Stream ms)
		{
			int num = 0;
			byte[] array;
			if (strFlag >= 160 && strFlag <= 191)
			{
				num = (int)(strFlag - 160);
			}
			else if (strFlag == 217)
			{
				num = ms.ReadByte();
			}
			else if (strFlag == 218)
			{
				array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				num = (int)BitConverter.ToUInt16(array, 0);
			}
			else if (strFlag == 219)
			{
				array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				num = BitConverter.ToInt32(array, 0);
			}
			array = new byte[num];
			ms.Read(array, 0, num);
			return BytesTools.GetString(array);
		}
	}
}
