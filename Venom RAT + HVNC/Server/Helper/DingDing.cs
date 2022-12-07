using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace Server.Helper
{
	// Token: 0x02000041 RID: 65
	internal class DingDing
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00020428 File Offset: 0x0001E628
		public static void Send(string WebHook, string secret, string content)
		{
			DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
			long num = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000L) / 10000L;
			string s = num.ToString() + "\n" + secret;
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(secret);
			byte[] bytes2 = asciiencoding.GetBytes(s);
			string text;
			using (HMACSHA256 hmacsha = new HMACSHA256(bytes))
			{
				text = HttpUtility.UrlEncode(Convert.ToBase64String(hmacsha.ComputeHash(bytes2)), Encoding.UTF8);
			}
			string text2 = string.Concat(new string[]
			{
				WebHook,
				"&timestamp=",
				num.ToString(),
				"&sign=",
				text
			});
			string s2 = JsonConvert.SerializeObject(new
			{
				msgtype = "text",
				text = new
				{
					content
				}
			});
			Console.WriteLine(text2);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text2);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/json;charset=utf-8";
			byte[] bytes3 = Encoding.UTF8.GetBytes(s2);
			httpWebRequest.ContentLength = (long)bytes3.Length;
			using (Stream requestStream = httpWebRequest.GetRequestStream())
			{
				requestStream.Write(bytes3, 0, bytes3.Length);
			}
			using (StreamReader streamReader = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream(), Encoding.UTF8))
			{
				streamReader.ReadToEnd();
			}
		}
	}
}
