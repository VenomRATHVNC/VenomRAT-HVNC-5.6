using System;
using System.IO;
using System.Security.Cryptography;

namespace Server.Algorithm
{
	// Token: 0x020000B2 RID: 178
	public static class GetHash
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x0004B474 File Offset: 0x00049674
		public static string GetChecksum(string file)
		{
			string result;
			using (FileStream fileStream = File.OpenRead(file))
			{
				result = BitConverter.ToString(new SHA256Managed().ComputeHash(fileStream)).Replace("-", string.Empty);
			}
			return result;
		}
	}
}
