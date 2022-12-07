using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Server.Algorithm
{
	// Token: 0x020000B1 RID: 177
	public class Aes256
	{
		// Token: 0x060005B2 RID: 1458 RVA: 0x0004B0F4 File Offset: 0x000492F4
		public Aes256(string masterKey)
		{
			if (string.IsNullOrEmpty(masterKey))
			{
				throw new ArgumentException("masterKey can not be null or empty.");
			}
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(masterKey, Aes256.Salt, 50000))
			{
				this._key = rfc2898DeriveBytes.GetBytes(32);
				this._authKey = rfc2898DeriveBytes.GetBytes(64);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000050C0 File Offset: 0x000032C0
		public string Encrypt(string input)
		{
			return Convert.ToBase64String(this.Encrypt(Encoding.UTF8.GetBytes(input)));
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0004B164 File Offset: 0x00049364
		public byte[] Encrypt(byte[] input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input can not be null.");
			}
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				memoryStream.Position = 32L;
				using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
				{
					aesCryptoServiceProvider.KeySize = 256;
					aesCryptoServiceProvider.BlockSize = 128;
					aesCryptoServiceProvider.Mode = CipherMode.CBC;
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
					aesCryptoServiceProvider.Key = this._key;
					aesCryptoServiceProvider.GenerateIV();
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
					{
						memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
						cryptoStream.Write(input, 0, input.Length);
						cryptoStream.FlushFinalBlock();
						using (HMACSHA256 hmacsha = new HMACSHA256(this._authKey))
						{
							byte[] array = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
							memoryStream.Position = 0L;
							memoryStream.Write(array, 0, array.Length);
						}
					}
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000050D8 File Offset: 0x000032D8
		public string Decrypt(string input)
		{
			return Encoding.UTF8.GetString(this.Decrypt(Convert.FromBase64String(input)));
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0004B2A4 File Offset: 0x000494A4
		public byte[] Decrypt(byte[] input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input can not be null.");
			}
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(input))
			{
				using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
				{
					aesCryptoServiceProvider.KeySize = 256;
					aesCryptoServiceProvider.BlockSize = 128;
					aesCryptoServiceProvider.Mode = CipherMode.CBC;
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
					aesCryptoServiceProvider.Key = this._key;
					using (HMACSHA256 hmacsha = new HMACSHA256(this._authKey))
					{
						byte[] a = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
						byte[] array = new byte[32];
						memoryStream.Read(array, 0, array.Length);
						if (!this.AreEqual(a, array))
						{
							throw new CryptographicException("Invalid message authentication code (MAC).");
						}
					}
					byte[] array2 = new byte[16];
					memoryStream.Read(array2, 0, 16);
					aesCryptoServiceProvider.IV = array2;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
					{
						byte[] array3 = new byte[memoryStream.Length - 16L + 1L];
						byte[] array4 = new byte[cryptoStream.Read(array3, 0, array3.Length)];
						Buffer.BlockCopy(array3, 0, array4, 0, array4.Length);
						result = array4;
					}
				}
			}
			return result;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0004B44C File Offset: 0x0004964C
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private bool AreEqual(byte[] a1, byte[] a2)
		{
			bool result = true;
			for (int i = 0; i < a1.Length; i++)
			{
				if (a1[i] != a2[i])
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04000542 RID: 1346
		private const int KeyLength = 32;

		// Token: 0x04000543 RID: 1347
		private const int AuthKeyLength = 64;

		// Token: 0x04000544 RID: 1348
		private const int IvLength = 16;

		// Token: 0x04000545 RID: 1349
		private const int HmacSha256Length = 32;

		// Token: 0x04000546 RID: 1350
		private readonly byte[] _key;

		// Token: 0x04000547 RID: 1351
		private readonly byte[] _authKey;

		// Token: 0x04000548 RID: 1352
		private static readonly byte[] Salt = Encoding.ASCII.GetBytes("VenomByVenom");
	}
}
