using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x02000056 RID: 86
	public class WordTextBox : TextBox
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00003788 File Offset: 0x00001988
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x000024F0 File Offset: 0x000006F0
		public override int MaxLength
		{
			get
			{
				return base.MaxLength;
			}
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00003790 File Offset: 0x00001990
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x000211A0 File Offset: 0x0001F3A0
		public bool IsHexNumber
		{
			get
			{
				return this.isHexNumber;
			}
			set
			{
				if (this.isHexNumber == value)
				{
					return;
				}
				if (value)
				{
					if (this.Type == WordTextBox.WordType.DWORD)
					{
						this.Text = this.UIntValue.ToString("x");
					}
					else
					{
						this.Text = this.ULongValue.ToString("x");
					}
				}
				else if (this.Type == WordTextBox.WordType.DWORD)
				{
					this.Text = this.UIntValue.ToString();
				}
				else
				{
					this.Text = this.ULongValue.ToString();
				}
				this.isHexNumber = value;
				this.UpdateMaxLength();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00003798 File Offset: 0x00001998
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000037A0 File Offset: 0x000019A0
		public WordTextBox.WordType Type
		{
			get
			{
				return this.type;
			}
			set
			{
				if (this.type == value)
				{
					return;
				}
				this.type = value;
				this.UpdateMaxLength();
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00021238 File Offset: 0x0001F438
		public uint UIntValue
		{
			get
			{
				uint result;
				try
				{
					if (string.IsNullOrEmpty(this.Text))
					{
						result = 0U;
					}
					else if (this.IsHexNumber)
					{
						result = uint.Parse(this.Text, NumberStyles.HexNumber);
					}
					else
					{
						result = uint.Parse(this.Text);
					}
				}
				catch (Exception)
				{
					result = uint.MaxValue;
				}
				return result;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00021298 File Offset: 0x0001F498
		public ulong ULongValue
		{
			get
			{
				ulong result;
				try
				{
					if (string.IsNullOrEmpty(this.Text))
					{
						result = 0UL;
					}
					else if (this.IsHexNumber)
					{
						result = ulong.Parse(this.Text, NumberStyles.HexNumber);
					}
					else
					{
						result = ulong.Parse(this.Text);
					}
				}
				catch (Exception)
				{
					result = ulong.MaxValue;
				}
				return result;
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000037B9 File Offset: 0x000019B9
		public bool IsConversionValid()
		{
			return string.IsNullOrEmpty(this.Text) || this.IsHexNumber || this.ConvertToHex();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000037DA File Offset: 0x000019DA
		public WordTextBox()
		{
			this.InitializeComponent();
			base.MaxLength = 8;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000037EF File Offset: 0x000019EF
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			e.Handled = !this.IsValidChar(e.KeyChar);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000380D File Offset: 0x00001A0D
		private bool IsValidChar(char ch)
		{
			return char.IsControl(ch) || char.IsDigit(ch) || (this.IsHexNumber && char.IsLetter(ch) && char.ToLower(ch) <= 'f');
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003840 File Offset: 0x00001A40
		private void UpdateMaxLength()
		{
			if (this.Type == WordTextBox.WordType.DWORD)
			{
				if (this.IsHexNumber)
				{
					base.MaxLength = 8;
					return;
				}
				base.MaxLength = 10;
				return;
			}
			else
			{
				if (this.IsHexNumber)
				{
					base.MaxLength = 16;
					return;
				}
				base.MaxLength = 20;
				return;
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000212F8 File Offset: 0x0001F4F8
		private bool ConvertToHex()
		{
			bool result;
			try
			{
				if (this.Type == WordTextBox.WordType.DWORD)
				{
					uint.Parse(this.Text);
				}
				else
				{
					ulong.Parse(this.Text);
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000387C File Offset: 0x00001A7C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000389B File Offset: 0x00001A9B
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x04000246 RID: 582
		private bool isHexNumber;

		// Token: 0x04000247 RID: 583
		private WordTextBox.WordType type;

		// Token: 0x04000248 RID: 584
		private IContainer components;

		// Token: 0x02000057 RID: 87
		public enum WordType
		{
			// Token: 0x0400024A RID: 586
			DWORD,
			// Token: 0x0400024B RID: 587
			QWORD
		}
	}
}
