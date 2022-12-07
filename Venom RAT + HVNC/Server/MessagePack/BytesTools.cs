using System;
using System.Text;

namespace Server.MessagePack
{
	// Token: 0x02000036 RID: 54
	public class BytesTools
	{
		// Token: 0x0600022F RID: 559 RVA: 0x000031B9 File Offset: 0x000013B9
		public static byte[] GetUtf8Bytes(string s)
		{
			return BytesTools.utf8Encode.GetBytes(s);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000031C6 File Offset: 0x000013C6
		public static string GetString(byte[] utf8Bytes)
		{
			return BytesTools.utf8Encode.GetString(utf8Bytes);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0001EDC4 File Offset: 0x0001CFC4
		public static string BytesAsString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:D3} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0001EE08 File Offset: 0x0001D008
		public static string BytesAsHexString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:X2} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001EE4C File Offset: 0x0001D04C
		public static byte[] SwapBytes(byte[] v)
		{
			byte[] array = new byte[v.Length];
			int num = v.Length - 1;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = v[num];
				num--;
			}
			return array;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000031D3 File Offset: 0x000013D3
		public static byte[] SwapInt64(long v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000031E0 File Offset: 0x000013E0
		public static byte[] SwapInt32(int v)
		{
			byte[] array = new byte[]
			{
				0,
				0,
				0,
				(byte)v
			};
			array[2] = (byte)(v >> 8);
			array[1] = (byte)(v >> 16);
			array[0] = (byte)(v >> 24);
			return array;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00003204 File Offset: 0x00001404
		public static byte[] SwapInt16(short v)
		{
			byte[] array = new byte[]
			{
				0,
				(byte)v
			};
			array[0] = (byte)(v >> 8);
			return array;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00003218 File Offset: 0x00001418
		public static byte[] SwapDouble(double v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x040001D2 RID: 466
		private static UTF8Encoding utf8Encode = new UTF8Encoding();
	}
}
