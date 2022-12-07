using System;
using System.IO;
using System.IO.Compression;

namespace Server.Algorithm
{
	// Token: 0x020000B4 RID: 180
	public static class Zip
	{
		// Token: 0x060005BC RID: 1468 RVA: 0x0004B584 File Offset: 0x00049784
		public static byte[] Decompress(byte[] input)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(input))
			{
				byte[] array = new byte[4];
				memoryStream.Read(array, 0, 4);
				int num = BitConverter.ToInt32(array, 0);
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					byte[] array2 = new byte[num];
					gzipStream.Read(array2, 0, num);
					result = array2;
				}
			}
			return result;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0004B604 File Offset: 0x00049804
		public static byte[] Compress(byte[] input)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				byte[] bytes = BitConverter.GetBytes(input.Length);
				memoryStream.Write(bytes, 0, 4);
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
				{
					gzipStream.Write(input, 0, input.Length);
					gzipStream.Flush();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}
}
