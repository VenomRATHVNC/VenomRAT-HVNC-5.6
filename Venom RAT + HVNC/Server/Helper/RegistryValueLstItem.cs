using System;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x02000055 RID: 85
	public class RegistryValueLstItem : ListViewItem
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00003708 File Offset: 0x00001908
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00003710 File Offset: 0x00001910
		private string _type { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00003719 File Offset: 0x00001919
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00003721 File Offset: 0x00001921
		private string _data { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000372A File Offset: 0x0000192A
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00003732 File Offset: 0x00001932
		public string RegName
		{
			get
			{
				return base.Name;
			}
			set
			{
				base.Name = value;
				base.Text = RegValueHelper.GetName(value);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00003747 File Offset: 0x00001947
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00021094 File Offset: 0x0001F294
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
				if (base.SubItems.Count < 2)
				{
					base.SubItems.Add(this._type);
				}
				else
				{
					base.SubItems[1].Text = this._type;
				}
				base.ImageIndex = this.GetRegistryValueImgIndex(this._type);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000374F File Offset: 0x0000194F
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000210F4 File Offset: 0x0001F2F4
		public string Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
				if (base.SubItems.Count < 3)
				{
					base.SubItems.Add(this._data);
					return;
				}
				base.SubItems[2].Text = this._data;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00003757 File Offset: 0x00001957
		public RegistryValueLstItem(RegistrySeeker.RegValueData value)
		{
			this.RegName = value.Name;
			this.Type = value.Kind.RegistryTypeToString();
			this.Data = RegValueHelper.RegistryValueToString(value);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00021140 File Offset: 0x0001F340
		private int GetRegistryValueImgIndex(string type)
		{
			if (!(type == "REG_MULTI_SZ") && !(type == "REG_SZ") && !(type == "REG_EXPAND_SZ"))
			{
				if (!(type == "REG_BINARY") && !(type == "REG_DWORD") && !(type == "REG_QWORD"))
				{
				}
				return 1;
			}
			return 0;
		}
	}
}
