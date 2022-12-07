using System;
using System.Security.Cryptography;
using System.Text;

namespace Server.Algorithm
{
	// Token: 0x020000B3 RID: 179
	public static class Sha256
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x0004B4C8 File Offset: 0x000496C8
		public static string ComputeHash(string input)
		{
			byte[] array = Encoding.UTF8.GetBytes(input);
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				array = sha256Managed.ComputeHash(array);
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString().ToUpper();
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0004B54C File Offset: 0x0004974C
		public static byte[] ComputeHash(byte[] input)
		{
			byte[] result;
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				result = sha256Managed.ComputeHash(input);
			}
			return result;
		}
	}
}
