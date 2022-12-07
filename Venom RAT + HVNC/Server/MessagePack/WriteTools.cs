using System;
using System.IO;

namespace Server.MessagePack
{
	// Token: 0x0200003E RID: 62
	internal class WriteTools
	{
		// Token: 0x06000278 RID: 632 RVA: 0x000034CB File Offset: 0x000016CB
		public static void WriteNull(Stream ms)
		{
			ms.WriteByte(192);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00020064 File Offset: 0x0001E264
		public static void WriteString(Stream ms, string strVal)
		{
			byte[] utf8Bytes = BytesTools.GetUtf8Bytes(strVal);
			int num = utf8Bytes.Length;
			if (num <= 31)
			{
				byte value = 160 + (byte)num;
				ms.WriteByte(value);
			}
			else if (num <= 255)
			{
				byte value = 217;
				ms.WriteByte(value);
				value = (byte)num;
				ms.WriteByte(value);
			}
			else if (num <= 65535)
			{
				byte value = 218;
				ms.WriteByte(value);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)num));
				ms.Write(array, 0, array.Length);
			}
			else
			{
				byte value = 219;
				ms.WriteByte(value);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(num));
				ms.Write(array, 0, array.Length);
			}
			ms.Write(utf8Bytes, 0, utf8Bytes.Length);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00020118 File Offset: 0x0001E318
		public static void WriteBinary(Stream ms, byte[] rawBytes)
		{
			int num = rawBytes.Length;
			if (num <= 255)
			{
				byte value = 196;
				ms.WriteByte(value);
				value = (byte)num;
				ms.WriteByte(value);
			}
			else if (num <= 65535)
			{
				byte value = 197;
				ms.WriteByte(value);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)num));
				ms.Write(array, 0, array.Length);
			}
			else
			{
				byte value = 198;
				ms.WriteByte(value);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(num));
				ms.Write(array, 0, array.Length);
			}
			ms.Write(rawBytes, 0, rawBytes.Length);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000034D8 File Offset: 0x000016D8
		public static void WriteFloat(Stream ms, double fVal)
		{
			ms.WriteByte(203);
			ms.Write(BytesTools.SwapDouble(fVal), 0, 8);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000034F3 File Offset: 0x000016F3
		public static void WriteSingle(Stream ms, float fVal)
		{
			ms.WriteByte(202);
			ms.Write(BytesTools.SwapBytes(BitConverter.GetBytes(fVal)), 0, 4);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00003513 File Offset: 0x00001713
		public static void WriteBoolean(Stream ms, bool bVal)
		{
			if (bVal)
			{
				ms.WriteByte(195);
				return;
			}
			ms.WriteByte(194);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000201AC File Offset: 0x0001E3AC
		public static void WriteUInt64(Stream ms, ulong iVal)
		{
			ms.WriteByte(207);
			byte[] bytes = BitConverter.GetBytes(iVal);
			ms.Write(BytesTools.SwapBytes(bytes), 0, 8);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000201DC File Offset: 0x0001E3DC
		public static void WriteInteger(Stream ms, long iVal)
		{
			if (iVal >= 0L)
			{
				if (iVal <= 127L)
				{
					ms.WriteByte((byte)iVal);
					return;
				}
				if (iVal <= 255L)
				{
					ms.WriteByte(204);
					ms.WriteByte((byte)iVal);
					return;
				}
				if (iVal <= 65535L)
				{
					ms.WriteByte(205);
					ms.Write(BytesTools.SwapInt16((short)iVal), 0, 2);
					return;
				}
				if (iVal <= (long)((ulong)-1))
				{
					ms.WriteByte(206);
					ms.Write(BytesTools.SwapInt32((int)iVal), 0, 4);
					return;
				}
				ms.WriteByte(211);
				ms.Write(BytesTools.SwapInt64(iVal), 0, 8);
				return;
			}
			else
			{
				if (iVal <= -2147483648L)
				{
					ms.WriteByte(211);
					ms.Write(BytesTools.SwapInt64(iVal), 0, 8);
					return;
				}
				if (iVal <= -32768L)
				{
					ms.WriteByte(210);
					ms.Write(BytesTools.SwapInt32((int)iVal), 0, 4);
					return;
				}
				if (iVal <= -128L)
				{
					ms.WriteByte(209);
					ms.Write(BytesTools.SwapInt16((short)iVal), 0, 2);
					return;
				}
				if (iVal <= -32L)
				{
					ms.WriteByte(208);
					ms.WriteByte((byte)iVal);
					return;
				}
				ms.WriteByte((byte)iVal);
				return;
			}
		}
	}
}
