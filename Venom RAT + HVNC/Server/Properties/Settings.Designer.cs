using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Server.Properties
{
	// Token: 0x02000035 RID: 53
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00002F05 File Offset: 0x00001105
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00002F0C File Offset: 0x0000110C
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002F1E File Offset: 0x0000111E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Ports
		{
			get
			{
				return (string)this["Ports"];
			}
			set
			{
				this["Ports"] = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00002F2C File Offset: 0x0000112C
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002F3E File Offset: 0x0000113E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Filename
		{
			get
			{
				return (string)this["Filename"];
			}
			set
			{
				this["Filename"] = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00002F4C File Offset: 0x0000114C
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002F5E File Offset: 0x0000115E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool Notification
		{
			get
			{
				return (bool)this["Notification"];
			}
			set
			{
				this["Notification"] = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00002F71 File Offset: 0x00001171
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002F83 File Offset: 0x00001183
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Paste_bin
		{
			get
			{
				return (string)this["Paste_bin"];
			}
			set
			{
				this["Paste_bin"] = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002F91 File Offset: 0x00001191
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002FA3 File Offset: 0x000011A3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string IP
		{
			get
			{
				return (string)this["IP"];
			}
			set
			{
				this["IP"] = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00002FB1 File Offset: 0x000011B1
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002FC3 File Offset: 0x000011C3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ProductName
		{
			get
			{
				return (string)this["ProductName"];
			}
			set
			{
				this["ProductName"] = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00002FD1 File Offset: 0x000011D1
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002FE3 File Offset: 0x000011E3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtDescription
		{
			get
			{
				return (string)this["txtDescription"];
			}
			set
			{
				this["txtDescription"] = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00002FF1 File Offset: 0x000011F1
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00003003 File Offset: 0x00001203
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtCompany
		{
			get
			{
				return (string)this["txtCompany"];
			}
			set
			{
				this["txtCompany"] = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00003011 File Offset: 0x00001211
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00003023 File Offset: 0x00001223
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtCopyright
		{
			get
			{
				return (string)this["txtCopyright"];
			}
			set
			{
				this["txtCopyright"] = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00003031 File Offset: 0x00001231
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00003043 File Offset: 0x00001243
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtTrademarks
		{
			get
			{
				return (string)this["txtTrademarks"];
			}
			set
			{
				this["txtTrademarks"] = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00003051 File Offset: 0x00001251
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00003063 File Offset: 0x00001263
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtOriginalFilename
		{
			get
			{
				return (string)this["txtOriginalFilename"];
			}
			set
			{
				this["txtOriginalFilename"] = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00003071 File Offset: 0x00001271
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00003083 File Offset: 0x00001283
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0.0.0.0")]
		public string txtProductVersion
		{
			get
			{
				return (string)this["txtProductVersion"];
			}
			set
			{
				this["txtProductVersion"] = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00003091 File Offset: 0x00001291
		// (set) Token: 0x0600021E RID: 542 RVA: 0x000030A3 File Offset: 0x000012A3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0.0.0.0")]
		public string txtFileVersion
		{
			get
			{
				return (string)this["txtFileVersion"];
			}
			set
			{
				this["txtFileVersion"] = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000030B1 File Offset: 0x000012B1
		// (set) Token: 0x06000220 RID: 544 RVA: 0x000030C3 File Offset: 0x000012C3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtBlocked
		{
			get
			{
				return (string)this["txtBlocked"];
			}
			set
			{
				this["txtBlocked"] = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000030D1 File Offset: 0x000012D1
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000030E3 File Offset: 0x000012E3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Default")]
		public string Group
		{
			get
			{
				return (string)this["Group"];
			}
			set
			{
				this["Group"] = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000030F1 File Offset: 0x000012F1
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00003103 File Offset: 0x00001303
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("VenomMutex_qwqdanchun")]
		public string Mutex
		{
			get
			{
				return (string)this["Mutex"];
			}
			set
			{
				this["Mutex"] = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00003111 File Offset: 0x00001311
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00003123 File Offset: 0x00001323
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool DingDing
		{
			get
			{
				return (bool)this["DingDing"];
			}
			set
			{
				this["DingDing"] = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00003136 File Offset: 0x00001336
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00003148 File Offset: 0x00001348
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string WebHook
		{
			get
			{
				return (string)this["WebHook"];
			}
			set
			{
				this["WebHook"] = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00003156 File Offset: 0x00001356
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00003168 File Offset: 0x00001368
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Secret
		{
			get
			{
				return (string)this["Secret"];
			}
			set
			{
				this["Secret"] = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00003176 File Offset: 0x00001376
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00003188 File Offset: 0x00001388
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("3128")]
		public decimal ReverseProxyPort
		{
			get
			{
				return (decimal)this["ReverseProxyPort"];
			}
			set
			{
				this["ReverseProxyPort"] = value;
			}
		}

		// Token: 0x040001D1 RID: 465
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
