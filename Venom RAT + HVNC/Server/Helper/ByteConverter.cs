using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Helper
{
	// Token: 0x02000040 RID: 64
	public class ByteConverter
	{
		// Token: 0x06000282 RID: 642 RVA: 0x00003557 File Offset: 0x00001757
		public static byte[] GetBytes(int value)
		{
			return BitConverter.GetBytes(value);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000355F File Offset: 0x0000175F
		public static byte[] GetBytes(long value)
		{
			return BitConverter.GetBytes(value);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003567 File Offset: 0x00001767
		public static byte[] GetBytes(uint value)
		{
			return BitConverter.GetBytes(value);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000356F File Offset: 0x0000176F
		public static byte[] GetBytes(ulong value)
		{
			return BitConverter.GetBytes(value);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00003577 File Offset: 0x00001777
		public static byte[] GetBytes(string value)
		{
			return ByteConverter.StringToBytes(value);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000357F File Offset: 0x0000177F
		public static byte[] GetBytes(string[] value)
		{
			return ByteConverter.StringArrayToBytes(value);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00003587 File Offset: 0x00001787
		public static int ToInt32(byte[] bytes)
		{
			return BitConverter.ToInt32(bytes, 0);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003590 File Offset: 0x00001790
		public static long ToInt64(byte[] bytes)
		{
			return BitConverter.ToInt64(bytes, 0);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003599 File Offset: 0x00001799
		public static uint ToUInt32(byte[] bytes)
		{
			return BitConverter.ToUInt32(bytes, 0);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000035A2 File Offset: 0x000017A2
		public static ulong ToUInt64(byte[] bytes)
		{
			return BitConverter.ToUInt64(bytes, 0);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000035AB File Offset: 0x000017AB
		public static string ToString(byte[] bytes)
		{
			return ByteConverter.BytesToString(bytes);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000035B3 File Offset: 0x000017B3
		public static string[] ToStringArray(byte[] bytes)
		{
			return ByteConverter.BytesToStringArray(bytes);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000035BB File Offset: 0x000017BB
		private static byte[] GetNullBytes()
		{
			return new byte[]
			{
				ByteConverter.NULL_BYTE,
				ByteConverter.NULL_BYTE
			};
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00020308 File Offset: 0x0001E508
		private static byte[] StringToBytes(string value)
		{
			byte[] array = new byte[value.Length * 2];
			Buffer.BlockCopy(value.ToCharArray(), 0, array, 0, array.Length);
			return array;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00020338 File Offset: 0x0001E538
		private static byte[] StringArrayToBytes(string[] strings)
		{
			List<byte> list = new List<byte>();
			foreach (string value in strings)
			{
				list.AddRange(ByteConverter.StringToBytes(value));
				list.AddRange(ByteConverter.GetNullBytes());
			}
			return list.ToArray();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0002037C File Offset: 0x0001E57C
		private static string BytesToString(byte[] bytes)
		{
			char[] array = new char[(int)Math.Ceiling((double)((float)bytes.Length / 2f))];
			Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			return new string(array);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000203B4 File Offset: 0x0001E5B4
		private static string[] BytesToStringArray(byte[] bytes)
		{
			List<string> list = new List<string>();
			int i = 0;
			StringBuilder stringBuilder = new StringBuilder(bytes.Length);
			while (i < bytes.Length)
			{
				int num = 0;
				while (i < bytes.Length && num < 3)
				{
					if (bytes[i] == ByteConverter.NULL_BYTE)
					{
						num++;
					}
					else
					{
						stringBuilder.Append(Convert.ToChar(bytes[i]));
						num = 0;
					}
					i++;
				}
				list.Add(stringBuilder.ToString());
				stringBuilder.Clear();
			}
			return list.ToArray();
		}

		// Token: 0x040001FD RID: 509
		private static byte NULL_BYTE;
	}
}
