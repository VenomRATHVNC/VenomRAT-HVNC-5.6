using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x0200000E RID: 14
	public class api
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00005F4C File Offset: 0x0000414C
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				MessageBox.Show("Application not setup correctly. Please watch video link found in Login.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005FCC File Offset: 0x000041CC
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (response_structure.success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
				return;
			}
			response_structure.message == "invalidver";
			this.sessionid = response_structure.sessionid;
			this.initzalized = true;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006100 File Offset: 0x00004300
		public bool register(string username, string pass, string key)
		{
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool success = response_structure.success;
			this.load_user_data(response_structure.info);
			return true;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002179 File Offset: 0x00000379
		public bool login(string username, string pass)
		{
			return true;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006250 File Offset: 0x00004450
		public void upgrade(string username, string key)
		{
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
			}
			MessageBox.Show(response_structure.message);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000637C File Offset: 0x0000457C
		public bool license(string key)
		{
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool success = response_structure.success;
			this.load_user_data(response_structure.info);
			return true;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000649C File Offset: 0x0000469C
		public void ban()
		{
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006580 File Offset: 0x00004780
		public string var(string varid)
		{
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool success = response_structure.success;
			return response_structure.message;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006680 File Offset: 0x00004880
		public void webhook(string webid, string param)
		{
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			this.response_decoder.string_to_generic<api.response_structure>(text2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000678C File Offset: 0x0000498C
		public byte[] download(string fileid)
		{
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool success = response_structure.success;
			return encryption.str_to_byte_arr(response_structure.contents);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006880 File Offset: 0x00004A80
		public void log(string message)
		{
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			api.req(nameValueCollection);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006964 File Offset: 0x00004B64
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://auth.venomlicense.com/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch
			{
				MessageBox.Show("Connection failure. Please try again, or contact us for help.");
				Thread.Sleep(3500);
				Environment.Exit(0);
				result = "nothing";
			}
			return result;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000021EF File Offset: 0x000003EF
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x0400001F RID: 31
		public string name;

		// Token: 0x04000020 RID: 32
		public string ownerid;

		// Token: 0x04000021 RID: 33
		public string secret;

		// Token: 0x04000022 RID: 34
		public string version;

		// Token: 0x04000023 RID: 35
		private string sessionid;

		// Token: 0x04000024 RID: 36
		private string enckey;

		// Token: 0x04000025 RID: 37
		private bool initzalized;

		// Token: 0x04000026 RID: 38
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000027 RID: 39
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x0200000F RID: 15
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000061 RID: 97 RVA: 0x00002224 File Offset: 0x00000424
			// (set) Token: 0x06000062 RID: 98 RVA: 0x0000222C File Offset: 0x0000042C
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00002235 File Offset: 0x00000435
			// (set) Token: 0x06000064 RID: 100 RVA: 0x0000223D File Offset: 0x0000043D
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000065 RID: 101 RVA: 0x00002246 File Offset: 0x00000446
			// (set) Token: 0x06000066 RID: 102 RVA: 0x0000224E File Offset: 0x0000044E
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000067 RID: 103 RVA: 0x00002257 File Offset: 0x00000457
			// (set) Token: 0x06000068 RID: 104 RVA: 0x0000225F File Offset: 0x0000045F
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00002268 File Offset: 0x00000468
			// (set) Token: 0x0600006A RID: 106 RVA: 0x00002270 File Offset: 0x00000470
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600006B RID: 107 RVA: 0x00002279 File Offset: 0x00000479
			// (set) Token: 0x0600006C RID: 108 RVA: 0x00002281 File Offset: 0x00000481
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600006D RID: 109 RVA: 0x0000228A File Offset: 0x0000048A
			// (set) Token: 0x0600006E RID: 110 RVA: 0x00002292 File Offset: 0x00000492
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }
		}

		// Token: 0x02000010 RID: 16
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000070 RID: 112 RVA: 0x0000229B File Offset: 0x0000049B
			// (set) Token: 0x06000071 RID: 113 RVA: 0x000022A3 File Offset: 0x000004A3
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000072 RID: 114 RVA: 0x000022AC File Offset: 0x000004AC
			// (set) Token: 0x06000073 RID: 115 RVA: 0x000022B4 File Offset: 0x000004B4
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000074 RID: 116 RVA: 0x000022BD File Offset: 0x000004BD
			// (set) Token: 0x06000075 RID: 117 RVA: 0x000022C5 File Offset: 0x000004C5
			[DataMember]
			public string ip { get; set; }
		}

		// Token: 0x02000011 RID: 17
		public class user_data_class
		{
			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000077 RID: 119 RVA: 0x000022CE File Offset: 0x000004CE
			// (set) Token: 0x06000078 RID: 120 RVA: 0x000022D6 File Offset: 0x000004D6
			public string username { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000079 RID: 121 RVA: 0x000022DF File Offset: 0x000004DF
			// (set) Token: 0x0600007A RID: 122 RVA: 0x000022E7 File Offset: 0x000004E7
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x0600007B RID: 123 RVA: 0x000022F0 File Offset: 0x000004F0
			// (set) Token: 0x0600007C RID: 124 RVA: 0x000022F8 File Offset: 0x000004F8
			public string ip { get; set; }
		}

		// Token: 0x02000012 RID: 18
		public class Data
		{
			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00002301 File Offset: 0x00000501
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00002309 File Offset: 0x00000509
			public string subscription { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000080 RID: 128 RVA: 0x00002312 File Offset: 0x00000512
			// (set) Token: 0x06000081 RID: 129 RVA: 0x0000231A File Offset: 0x0000051A
			public string expiry { get; set; }
		}
	}
}
