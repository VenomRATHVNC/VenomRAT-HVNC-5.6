using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Helper.HexEditor
{
	// Token: 0x02000067 RID: 103
	public class HexEditor : Control
	{
		// Token: 0x17000097 RID: 151
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003E85 File Offset: 0x00002085
		public override Font Font
		{
			set
			{
				base.Font = value;
				this.UpdateRectanglePositioning();
				base.Invalidate();
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00003E9A File Offset: 0x0000209A
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003EA2 File Offset: 0x000020A2
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00022864 File Offset: 0x00020A64
		// (set) Token: 0x0600037E RID: 894 RVA: 0x000228AC File Offset: 0x00020AAC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public byte[] HexTable
		{
			get
			{
				object hexTableLock = this._hexTableLock;
				byte[] result;
				lock (hexTableLock)
				{
					result = this._hexTable.ToArray();
				}
				return result;
			}
			set
			{
				object hexTableLock = this._hexTableLock;
				lock (hexTableLock)
				{
					if (value == this._hexTable.ToArray())
					{
						return;
					}
					this._hexTable = new ByteCollection(value);
				}
				this.UpdateRectanglePositioning();
				base.Invalidate();
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00003EAB File Offset: 0x000020AB
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003EB3 File Offset: 0x000020B3
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public SizeF CharSize
		{
			get
			{
				return this._charSize;
			}
			private set
			{
				if (this._charSize == value)
				{
					return;
				}
				this._charSize = value;
				if (this.CharSizeChanged != null)
				{
					this.CharSizeChanged(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00003EE4 File Offset: 0x000020E4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int MaxBytesV
		{
			get
			{
				return this._maxBytesV;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00003EEC File Offset: 0x000020EC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int FirstVisibleByte
		{
			get
			{
				return this._firstByte;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00003EF4 File Offset: 0x000020F4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int LastVisibleByte
		{
			get
			{
				return this._lastByte;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00003EFC File Offset: 0x000020FC
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00022910 File Offset: 0x00020B10
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool VScrollBarHidden
		{
			get
			{
				return this._isVScrollHidden;
			}
			set
			{
				if (this._isVScrollHidden == value)
				{
					return;
				}
				this._isVScrollHidden = value;
				if (!this._isVScrollHidden)
				{
					base.Controls.Add(this._vScrollBar);
				}
				else
				{
					base.Controls.Remove(this._vScrollBar);
				}
				this.UpdateRectanglePositioning();
				base.Invalidate();
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00003F04 File Offset: 0x00002104
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00003F0C File Offset: 0x0000210C
		[DefaultValue(8)]
		[Category("Hex")]
		[Description("Property that specifies the number of bytes to display per line.")]
		public int BytesPerLine
		{
			get
			{
				return this._bytesPerLine;
			}
			set
			{
				if (this._bytesPerLine == value)
				{
					return;
				}
				this._bytesPerLine = value;
				this.UpdateRectanglePositioning();
				base.Invalidate();
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00003F2B File Offset: 0x0000212B
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00003F33 File Offset: 0x00002133
		[DefaultValue(10)]
		[Category("Hex")]
		[Description("Property that specifies the margin between each of the entitys in the control.")]
		public int EntityMargin
		{
			get
			{
				return this._entityMargin;
			}
			set
			{
				if (this._entityMargin == value)
				{
					return;
				}
				this._entityMargin = value;
				this.UpdateRectanglePositioning();
				base.Invalidate();
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00003F52 File Offset: 0x00002152
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00003F5A File Offset: 0x0000215A
		[DefaultValue(BorderStyle.Fixed3D)]
		[Category("Appearance")]
		[Description("Indicates where the control should have a border.")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this._borderStyle;
			}
			set
			{
				if (this._borderStyle == value)
				{
					return;
				}
				if (value != BorderStyle.FixedSingle)
				{
					this._borderColor = Color.Empty;
				}
				this._borderStyle = value;
				this.UpdateRectanglePositioning();
				base.Invalidate();
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00003F88 File Offset: 0x00002188
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00003F90 File Offset: 0x00002190
		[DefaultValue(typeof(Color), "Empty")]
		[Category("Appearance")]
		[Description("Indicates the color to be used when displaying a FixedSingle border.")]
		public Color BorderColor
		{
			get
			{
				return this._borderColor;
			}
			set
			{
				if (this.BorderStyle != BorderStyle.FixedSingle || this._borderColor == value)
				{
					return;
				}
				this._borderColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00003FB7 File Offset: 0x000021B7
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00003FBF File Offset: 0x000021BF
		[DefaultValue(typeof(Color), "Blue")]
		[Category("Hex")]
		[Description("Property for the background color of the selected text areas.")]
		public Color SelectionBackColor
		{
			get
			{
				return this._selectionBackColor;
			}
			set
			{
				if (this._selectionBackColor == value)
				{
					return;
				}
				this._selectionBackColor = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00003FD7 File Offset: 0x000021D7
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00003FDF File Offset: 0x000021DF
		[DefaultValue(typeof(Color), "White")]
		[Category("Hex")]
		[Description("Property for the foreground color of the selected text areas.")]
		public Color SelectionForeColor
		{
			get
			{
				return this._selectionForeColor;
			}
			set
			{
				if (this._selectionForeColor == value)
				{
					return;
				}
				this._selectionForeColor = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00003FF7 File Offset: 0x000021F7
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00003FFF File Offset: 0x000021FF
		[DefaultValue(HexEditor.CaseStyle.UpperCase)]
		[Category("Hex")]
		[Description("Property for the case type to use on the line counter.")]
		public HexEditor.CaseStyle LineCountCaseStyle
		{
			get
			{
				return this._lineCountCaseStyle;
			}
			set
			{
				if (this._lineCountCaseStyle == value)
				{
					return;
				}
				this._lineCountCaseStyle = value;
				if (this._lineCountCaseStyle == HexEditor.CaseStyle.LowerCase)
				{
					this._lineCountCaps = "x";
				}
				else
				{
					this._lineCountCaps = "X";
				}
				base.Invalidate();
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00004038 File Offset: 0x00002238
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00004040 File Offset: 0x00002240
		[DefaultValue(HexEditor.CaseStyle.UpperCase)]
		[Category("Hex")]
		[Description("Property for the case type to use for the hexadecimal values view.")]
		public HexEditor.CaseStyle HexViewCaseStyle
		{
			get
			{
				return this._hexViewCaseStyle;
			}
			set
			{
				if (this._hexViewCaseStyle == value)
				{
					return;
				}
				this._hexViewCaseStyle = value;
				if (this._hexViewCaseStyle == HexEditor.CaseStyle.LowerCase)
				{
					this._editView.SetLowerCase();
				}
				else
				{
					this._editView.SetUpperCase();
				}
				base.Invalidate();
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00004079 File Offset: 0x00002279
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00004081 File Offset: 0x00002281
		[DefaultValue(false)]
		[Category("Hex")]
		[Description("Property for the visibility of the vertical scrollbar.")]
		public bool VScrollBarVisisble
		{
			get
			{
				return this._isVScrollVisible;
			}
			set
			{
				if (this._isVScrollVisible == value)
				{
					return;
				}
				this._isVScrollVisible = value;
				this.UpdateRectanglePositioning();
				base.Invalidate();
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000398 RID: 920 RVA: 0x00022968 File Offset: 0x00020B68
		// (remove) Token: 0x06000399 RID: 921 RVA: 0x000229A0 File Offset: 0x00020BA0
		[Description("Event that is triggered whenever the hextable has been changed.")]
		public event EventHandler HexTableChanged;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600039A RID: 922 RVA: 0x000229D8 File Offset: 0x00020BD8
		// (remove) Token: 0x0600039B RID: 923 RVA: 0x00022A10 File Offset: 0x00020C10
		[Description("Event that is triggered whenever the SelectionStart value is changed.")]
		public event EventHandler SelectionStartChanged;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600039C RID: 924 RVA: 0x00022A48 File Offset: 0x00020C48
		// (remove) Token: 0x0600039D RID: 925 RVA: 0x00022A80 File Offset: 0x00020C80
		[Description("Event that is triggered whenever the SelectionLength value is changed.")]
		public event EventHandler SelectionLengthChanged;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600039E RID: 926 RVA: 0x00022AB8 File Offset: 0x00020CB8
		// (remove) Token: 0x0600039F RID: 927 RVA: 0x00022AF0 File Offset: 0x00020CF0
		[Description("Event that is triggered whenever the size of the char is changed.")]
		public event EventHandler CharSizeChanged;

		// Token: 0x060003A0 RID: 928 RVA: 0x00022B28 File Offset: 0x00020D28
		protected void OnVScrollBarScroll(object sender, ScrollEventArgs e)
		{
			switch (e.Type)
			{
			case ScrollEventType.SmallDecrement:
				this.ScrollLineUp(1);
				break;
			case ScrollEventType.SmallIncrement:
				this.ScrollLineDown(1);
				break;
			case ScrollEventType.LargeDecrement:
				this.ScrollLineUp(this._vScrollLarge);
				break;
			case ScrollEventType.LargeIncrement:
				this.ScrollLineDown(this._vScrollLarge);
				break;
			case ScrollEventType.ThumbTrack:
				this.ScrollThumbTrack(e.NewValue - e.OldValue);
				break;
			}
			base.Invalidate();
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000040A0 File Offset: 0x000022A0
		protected void CaretSelectionStartChanged(object sender, EventArgs e)
		{
			if (this.SelectionStartChanged != null)
			{
				this.SelectionStartChanged(this, e);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000040B7 File Offset: 0x000022B7
		protected void CaretSelectionLengthChanged(object sender, EventArgs e)
		{
			if (this.SelectionLengthChanged != null)
			{
				this.SelectionLengthChanged(this, e);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000040CE File Offset: 0x000022CE
		protected override void OnMarginChanged(EventArgs e)
		{
			base.OnMarginChanged(e);
			this.UpdateRectanglePositioning();
			base.Invalidate();
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000040E3 File Offset: 0x000022E3
		protected override void OnGotFocus(EventArgs e)
		{
			if (this._handler != null)
			{
				this._handler.OnGotFocus(e);
			}
			this.UpdateRectanglePositioning();
			base.Invalidate();
			base.OnGotFocus(e);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000410C File Offset: 0x0000230C
		protected override void OnLostFocus(EventArgs e)
		{
			this._dragging = false;
			this.DestroyCaret();
			base.OnLostFocus(e);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00004122 File Offset: 0x00002322
		protected override bool IsInputKey(Keys keyData)
		{
			return keyData - Keys.Left <= 3 || keyData - (Keys.LButton | Keys.MButton | Keys.Space | Keys.Shift) <= 3 || base.IsInputKey(keyData);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000413E File Offset: 0x0000233E
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if (this._handler != null)
			{
				this._handler.OnKeyPress(e);
			}
			base.OnKeyPress(e);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00022BA4 File Offset: 0x00020DA4
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Next)
			{
				if (!this._isVScrollHidden)
				{
					this.ScrollLineDown(this._vScrollLarge);
					base.Invalidate();
				}
			}
			else if (e.KeyCode == Keys.Prior)
			{
				if (!this._isVScrollHidden)
				{
					this.ScrollLineUp(this._vScrollLarge);
					base.Invalidate();
				}
			}
			else if (this._handler != null)
			{
				this._handler.OnKeyDown(e);
			}
			base.OnKeyDown(e);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000415B File Offset: 0x0000235B
		protected override void OnKeyUp(KeyEventArgs e)
		{
			if (this._handler != null)
			{
				this._handler.OnKeyUp(e);
			}
			base.OnKeyUp(e);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00022C18 File Offset: 0x00020E18
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (this.Focused)
			{
				if (this._handler != null)
				{
					this._handler.OnMouseDown(e);
				}
				if (e.Button == MouseButtons.Left)
				{
					this._dragging = true;
					base.Invalidate();
				}
			}
			else
			{
				base.Focus();
			}
			base.OnMouseDown(e);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00004178 File Offset: 0x00002378
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (this.Focused && this._dragging)
			{
				if (this._handler != null)
				{
					this._handler.OnMouseDragged(e);
				}
				base.Invalidate();
			}
			base.OnMouseMove(e);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000041AB File Offset: 0x000023AB
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this._dragging = false;
			if (this.Focused && this._handler != null)
			{
				this._handler.OnMouseUp(e);
			}
			base.OnMouseUp(e);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000041D7 File Offset: 0x000023D7
		protected override void OnMouseDoubleClick(MouseEventArgs e)
		{
			if (this.Focused && this._handler != null)
			{
				this._handler.OnMouseDoubleClick(e);
			}
			base.OnMouseDoubleClick(e);
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00022C6C File Offset: 0x00020E6C
		public int CaretPosX
		{
			get
			{
				object caretLock = this._caretLock;
				int x;
				lock (caretLock)
				{
					x = this._caret.Location.X;
				}
				return x;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00022CBC File Offset: 0x00020EBC
		public int CaretPosY
		{
			get
			{
				object caretLock = this._caretLock;
				int y;
				lock (caretLock)
				{
					y = this._caret.Location.Y;
				}
				return y;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00022D0C File Offset: 0x00020F0C
		public int SelectionStart
		{
			get
			{
				object caretLock = this._caretLock;
				int selectionStart;
				lock (caretLock)
				{
					selectionStart = this._caret.SelectionStart;
				}
				return selectionStart;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00022D54 File Offset: 0x00020F54
		public int SelectionLength
		{
			get
			{
				object caretLock = this._caretLock;
				int selectionLength;
				lock (caretLock)
				{
					selectionLength = this._caret.SelectionLength;
				}
				return selectionLength;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00022D9C File Offset: 0x00020F9C
		public int CaretIndex
		{
			get
			{
				object caretLock = this._caretLock;
				int currentIndex;
				lock (caretLock)
				{
					currentIndex = this._caret.CurrentIndex;
				}
				return currentIndex;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00022DE4 File Offset: 0x00020FE4
		public bool CaretFocused
		{
			get
			{
				object caretLock = this._caretLock;
				bool focused;
				lock (caretLock)
				{
					focused = this._caret.Focused;
				}
				return focused;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00022E2C File Offset: 0x0002102C
		public void SetCaretStart(int index, Point location)
		{
			location = this.ScrollToCaret(index, location);
			object caretLock = this._caretLock;
			lock (caretLock)
			{
				this._caret.SetStartIndex(index);
				this._caret.SetCaretLocation(location);
			}
			base.Invalidate();
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00022E90 File Offset: 0x00021090
		public void SetCaretEnd(int index, Point location)
		{
			location = this.ScrollToCaret(index, location);
			object caretLock = this._caretLock;
			lock (caretLock)
			{
				this._caret.SetEndIndex(index);
				this._caret.SetCaretLocation(location);
			}
			base.Invalidate();
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00022EF4 File Offset: 0x000210F4
		public bool IsSelected(int byteIndex)
		{
			object caretLock = this._caretLock;
			bool result;
			lock (caretLock)
			{
				result = this._caret.IsSelected(byteIndex);
			}
			return result;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00022F3C File Offset: 0x0002113C
		public void DestroyCaret()
		{
			object caretLock = this._caretLock;
			lock (caretLock)
			{
				this._caret.Destroy();
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00022F84 File Offset: 0x00021184
		public int HexTableLength
		{
			get
			{
				object hexTableLock = this._hexTableLock;
				int length;
				lock (hexTableLock)
				{
					length = this._hexTable.Length;
				}
				return length;
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00022FCC File Offset: 0x000211CC
		public void RemoveSelectedBytes()
		{
			int selectionStart = this.SelectionStart;
			int selectionLength = this.SelectionLength;
			if (selectionLength > 0)
			{
				object hexTableLock = this._hexTableLock;
				lock (hexTableLock)
				{
					this._hexTable.RemoveRange(selectionStart, selectionLength);
				}
				this.UpdateRectanglePositioning();
				base.Invalidate();
				if (this.HexTableChanged != null)
				{
					this.HexTableChanged(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0002304C File Offset: 0x0002124C
		public void RemoveByteAt(int index)
		{
			object hexTableLock = this._hexTableLock;
			lock (hexTableLock)
			{
				this._hexTable.RemoveAt(index);
			}
			this.UpdateRectanglePositioning();
			base.Invalidate();
			if (this.HexTableChanged != null)
			{
				this.HexTableChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000230B8 File Offset: 0x000212B8
		public void AppendByte(byte item)
		{
			object hexTableLock = this._hexTableLock;
			lock (hexTableLock)
			{
				this._hexTable.Add(item);
			}
			this.UpdateRectanglePositioning();
			base.Invalidate();
			if (this.HexTableChanged != null)
			{
				this.HexTableChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00023124 File Offset: 0x00021324
		public void InsertByte(int index, byte item)
		{
			object hexTableLock = this._hexTableLock;
			lock (hexTableLock)
			{
				this._hexTable.Insert(index, item);
			}
			this.UpdateRectanglePositioning();
			base.Invalidate();
			if (this.HexTableChanged != null)
			{
				this.HexTableChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00023190 File Offset: 0x00021390
		public char GetByteAsChar(int index)
		{
			object hexTableLock = this._hexTableLock;
			char charAt;
			lock (hexTableLock)
			{
				charAt = this._hexTable.GetCharAt(index);
			}
			return charAt;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000231D8 File Offset: 0x000213D8
		public byte GetByte(int index)
		{
			object hexTableLock = this._hexTableLock;
			byte at;
			lock (hexTableLock)
			{
				at = this._hexTable.GetAt(index);
			}
			return at;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00023220 File Offset: 0x00021420
		public void SetByte(int index, byte item)
		{
			object hexTableLock = this._hexTableLock;
			lock (hexTableLock)
			{
				this._hexTable.SetAt(index, item);
			}
			base.Invalidate();
			if (this.HexTableChanged != null)
			{
				this.HexTableChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00023288 File Offset: 0x00021488
		public void ScrollLineUp(int lines)
		{
			if (this._firstByte > 0)
			{
				lines = ((lines > this._vScrollPos) ? this._vScrollPos : lines);
				this._vScrollPos -= this._vScrollSmall * lines;
				this.UpdateVisibleByteIndex();
				this.UpdateScrollValues();
				if (this.CaretFocused)
				{
					Point caretLocation = new Point(this.CaretPosX, this.CaretPosY);
					caretLocation.Y += this._recLineCount.Height * lines;
					object caretLock = this._caretLock;
					lock (caretLock)
					{
						this._caret.SetCaretLocation(caretLocation);
					}
				}
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00023348 File Offset: 0x00021548
		public void ScrollLineDown(int lines)
		{
			if (this._vScrollPos <= this._vScrollMax - this._vScrollLarge)
			{
				lines = ((lines + this._vScrollPos > this._vScrollMax - this._vScrollLarge) ? (this._vScrollMax - this._vScrollLarge - this._vScrollPos + 1) : lines);
				this._vScrollPos += this._vScrollSmall * lines;
				this.UpdateVisibleByteIndex();
				this.UpdateScrollValues();
				if (this.CaretFocused)
				{
					Point caretLocation = new Point(this.CaretPosX, this.CaretPosY);
					caretLocation.Y -= this._recLineCount.Height * lines;
					object caretLock = this._caretLock;
					lock (caretLock)
					{
						this._caret.SetCaretLocation(caretLocation);
						if (caretLocation.Y < this._recContent.Y)
						{
							this._caret.Hide(base.Handle);
						}
					}
				}
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000041FC File Offset: 0x000023FC
		public void ScrollThumbTrack(int lines)
		{
			if (lines == 0)
			{
				return;
			}
			if (lines < 0)
			{
				this.ScrollLineUp(-1 * lines);
				return;
			}
			this.ScrollLineDown(lines);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00023458 File Offset: 0x00021658
		public Point ScrollToCaret(int caretIndex, Point position)
		{
			if (position.Y < 0)
			{
				this._vScrollPos -= Math.Abs((position.Y - this._recContent.Y) / this._recLineCount.Height) * this._vScrollSmall;
				this.UpdateVisibleByteIndex();
				this.UpdateScrollValues();
				if (this.CaretFocused)
				{
					position.Y = this._recContent.Y;
				}
			}
			else if (position.Y > this._maxVisibleBytesV * this._recLineCount.Height)
			{
				this._vScrollPos += (position.Y / this._recLineCount.Height - (this._maxVisibleBytesV - 1)) * this._vScrollSmall;
				if (this._vScrollPos > this._vScrollMax - (this._vScrollLarge - 1))
				{
					this._vScrollPos = this._vScrollMax - (this._vScrollLarge - 1);
				}
				this.UpdateVisibleByteIndex();
				this.UpdateScrollValues();
				if (this.CaretFocused)
				{
					position.Y = (this._maxVisibleBytesV - 1) * this._recLineCount.Height + this._recContent.Y;
				}
			}
			return position;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0002358C File Offset: 0x0002178C
		private void UpdateRectanglePositioning()
		{
			if (base.ClientRectangle.Width == 0)
			{
				return;
			}
			SizeF sizeF;
			using (Graphics graphics = base.CreateGraphics())
			{
				sizeF = graphics.MeasureString("D", this.Font, 100, this._stringFormat);
			}
			this.CharSize = new SizeF((float)Math.Ceiling((double)sizeF.Width), (float)Math.Ceiling((double)sizeF.Height));
			this._recContent = base.ClientRectangle;
			this._recContent.X = this._recContent.X + base.Margin.Left;
			this._recContent.Y = this._recContent.Y + base.Margin.Top;
			this._recContent.Width = this._recContent.Width - base.Margin.Right;
			this._recContent.Height = this._recContent.Height - base.Margin.Bottom;
			if (this.BorderStyle == BorderStyle.Fixed3D)
			{
				this._recContent.X = this._recContent.X + 2;
				this._recContent.Y = this._recContent.Y + 2;
				this._recContent.Width = this._recContent.Width - 1;
				this._recContent.Height = this._recContent.Height - 1;
			}
			else if (this.BorderStyle == BorderStyle.FixedSingle)
			{
				this._recContent.X = this._recContent.X + 1;
				this._recContent.Y = this._recContent.Y + 1;
				this._recContent.Width = this._recContent.Width - 1;
				this._recContent.Height = this._recContent.Height - 1;
			}
			if (!this.VScrollBarHidden)
			{
				this._recContent.Width = this._recContent.Width - this._vScrollBarWidth;
				this._vScrollBar.Left = this._recContent.X + this._recContent.Width - base.Margin.Left;
				this._vScrollBar.Top = this._recContent.Y - base.Margin.Top;
				this._vScrollBar.Width = this._vScrollBarWidth;
				this._vScrollBar.Height = this._recContent.Height;
			}
			this._recLineCount = new Rectangle(this._recContent.X, this._recContent.Y, (int)(this._charSize.Width * 4f), (int)this._charSize.Height - 2);
			this._editView.Update(this._recLineCount.X + this._recLineCount.Width + this._entityMargin / 2, this._recContent);
			this._maxBytesH = this._bytesPerLine;
			this._maxBytesV = (int)Math.Ceiling((double)((float)this._recContent.Height / (float)this._recLineCount.Height));
			this._maxBytes = this._maxBytesH * this._maxBytesV;
			this._maxVisibleBytesV = (int)Math.Floor((double)((float)this._recContent.Height / (float)this._recLineCount.Height));
			this.UpdateScrollBarSize();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000238CC File Offset: 0x00021ACC
		private void UpdateVisibleByteIndex()
		{
			if (this._hexTable.Length == 0)
			{
				this._firstByte = 0;
				this._lastByte = 0;
				return;
			}
			this._firstByte = this._vScrollPos * this._maxBytesH;
			this._lastByte = Math.Min(this.HexTableLength, this._firstByte + this._maxBytes);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00023928 File Offset: 0x00021B28
		private void UpdateScrollValues()
		{
			if (!this._isVScrollHidden)
			{
				this._vScrollBar.Minimum = this._vScrollMin;
				this._vScrollBar.Maximum = this._vScrollMax;
				this._vScrollBar.Value = this._vScrollPos;
				this._vScrollBar.SmallChange = this._vScrollSmall;
				this._vScrollBar.LargeChange = this._vScrollLarge;
				this._vScrollBar.Visible = true;
				return;
			}
			this._vScrollBar.Visible = false;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000239AC File Offset: 0x00021BAC
		private void UpdateScrollBarSize()
		{
			if (!this.VScrollBarVisisble || this._maxVisibleBytesV <= 0 || this._maxBytesH <= 0)
			{
				this.VScrollBarHidden = true;
				return;
			}
			int maxVisibleBytesV = this._maxVisibleBytesV;
			int num = 1;
			int vScrollMin = 0;
			int num2 = this.HexTableLength / this._maxBytesH;
			int num3 = this._firstByte / this._maxBytesH;
			if (maxVisibleBytesV != this._vScrollLarge || num != this._vScrollSmall)
			{
				this._vScrollLarge = maxVisibleBytesV;
				this._vScrollSmall = num;
			}
			if (num2 >= maxVisibleBytesV)
			{
				if (num2 != this._vScrollMax || num3 != this._vScrollPos)
				{
					this._vScrollMin = vScrollMin;
					this._vScrollMax = num2;
					this._vScrollPos = num3;
				}
				this.VScrollBarHidden = false;
				this.UpdateScrollValues();
				return;
			}
			this.VScrollBarHidden = true;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00004217 File Offset: 0x00002417
		public HexEditor() : this(new ByteCollection())
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00023A70 File Offset: 0x00021C70
		public HexEditor(ByteCollection collection)
		{
			this._stringFormat = new StringFormat(StringFormat.GenericTypographic);
			this._stringFormat.Alignment = StringAlignment.Center;
			this._stringFormat.LineAlignment = StringAlignment.Center;
			this._hexTable = collection;
			this._vScrollBar = new VScrollBar();
			this._vScrollBar.Scroll += this.OnVScrollBarScroll;
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.Selectable, true);
			this._caret = new Caret(this);
			this._caret.SelectionStartChanged += this.CaretSelectionStartChanged;
			this._caret.SelectionLengthChanged += this.CaretSelectionLengthChanged;
			this._editView = new EditView(this);
			this._handler = this._editView;
			this.Cursor = Cursors.IBeam;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00023BD0 File Offset: 0x00021DD0
		private RectangleF GetLineCountBound(int index)
		{
			return new RectangleF((float)this._recLineCount.X, (float)(this._recLineCount.Y + this._recLineCount.Height * index), (float)this._recLineCount.Width, (float)this._recLineCount.Height);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00023C20 File Offset: 0x00021E20
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			if (this.BorderStyle == BorderStyle.Fixed3D)
			{
				SolidBrush brush = new SolidBrush(this.BackColor);
				Rectangle clientRectangle = base.ClientRectangle;
				pevent.Graphics.FillRectangle(brush, clientRectangle);
				ControlPaint.DrawBorder3D(pevent.Graphics, base.ClientRectangle, Border3DStyle.Sunken);
				return;
			}
			if (this.BorderStyle == BorderStyle.FixedSingle)
			{
				SolidBrush brush2 = new SolidBrush(this.BackColor);
				Rectangle clientRectangle2 = base.ClientRectangle;
				pevent.Graphics.FillRectangle(brush2, clientRectangle2);
				ControlPaint.DrawBorder(pevent.Graphics, base.ClientRectangle, this.BorderColor, ButtonBorderStyle.Solid);
				return;
			}
			base.OnPaintBackground(pevent);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00023CB4 File Offset: 0x00021EB4
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Region region = new Region(base.ClientRectangle);
			region.Exclude(this._recContent);
			e.Graphics.ExcludeClip(region);
			this.UpdateVisibleByteIndex();
			this.PaintLineCount(e.Graphics, this._firstByte, this._lastByte);
			this._editView.Paint(e.Graphics, this._firstByte, this._lastByte);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00023D28 File Offset: 0x00021F28
		private void PaintLineCount(Graphics g, int startIndex, int lastIndex)
		{
			SolidBrush brush = new SolidBrush(this.ForeColor);
			int num = 0;
			while (num * this._maxBytesH + startIndex <= lastIndex)
			{
				RectangleF lineCountBound = this.GetLineCountBound(num);
				string text = (startIndex + num * this._maxBytesH).ToString(this._lineCountCaps);
				int num2 = this._nrCharsLineCount - text.Length;
				string s;
				if (num2 > -1)
				{
					s = new string('0', num2) + text;
				}
				else
				{
					s = new string('~', this._nrCharsLineCount);
				}
				g.DrawString(s, this.Font, brush, lineCountBound, this._stringFormat);
				num++;
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00004224 File Offset: 0x00002424
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.UpdateRectanglePositioning();
			base.Invalidate();
		}

		// Token: 0x0400029D RID: 669
		private object _caretLock = new object();

		// Token: 0x0400029E RID: 670
		private object _hexTableLock = new object();

		// Token: 0x0400029F RID: 671
		private IKeyMouseEventHandler _handler;

		// Token: 0x040002A0 RID: 672
		private EditView _editView;

		// Token: 0x040002A1 RID: 673
		private ByteCollection _hexTable;

		// Token: 0x040002A2 RID: 674
		private string _lineCountCaps = "X";

		// Token: 0x040002A3 RID: 675
		private int _nrCharsLineCount = 4;

		// Token: 0x040002A4 RID: 676
		private Caret _caret;

		// Token: 0x040002A5 RID: 677
		private Rectangle _recContent;

		// Token: 0x040002A6 RID: 678
		private Rectangle _recLineCount;

		// Token: 0x040002A7 RID: 679
		private StringFormat _stringFormat;

		// Token: 0x040002A8 RID: 680
		private int _firstByte;

		// Token: 0x040002A9 RID: 681
		private int _lastByte;

		// Token: 0x040002AA RID: 682
		private int _maxBytesH;

		// Token: 0x040002AB RID: 683
		private int _maxBytesV;

		// Token: 0x040002AC RID: 684
		private int _maxBytes;

		// Token: 0x040002AD RID: 685
		private int _maxVisibleBytesV;

		// Token: 0x040002AE RID: 686
		private VScrollBar _vScrollBar;

		// Token: 0x040002AF RID: 687
		private int _vScrollBarWidth = 20;

		// Token: 0x040002B0 RID: 688
		private int _vScrollPos;

		// Token: 0x040002B1 RID: 689
		private int _vScrollMax;

		// Token: 0x040002B2 RID: 690
		private int _vScrollMin;

		// Token: 0x040002B3 RID: 691
		private int _vScrollSmall;

		// Token: 0x040002B4 RID: 692
		private int _vScrollLarge;

		// Token: 0x040002B5 RID: 693
		private SizeF _charSize;

		// Token: 0x040002B6 RID: 694
		private bool _isVScrollHidden = true;

		// Token: 0x040002B7 RID: 695
		private int _bytesPerLine = 8;

		// Token: 0x040002B8 RID: 696
		private int _entityMargin = 10;

		// Token: 0x040002B9 RID: 697
		private BorderStyle _borderStyle = BorderStyle.Fixed3D;

		// Token: 0x040002BA RID: 698
		private Color _borderColor = Color.Empty;

		// Token: 0x040002BB RID: 699
		private Color _selectionBackColor = Color.Blue;

		// Token: 0x040002BC RID: 700
		private Color _selectionForeColor = Color.White;

		// Token: 0x040002BD RID: 701
		private HexEditor.CaseStyle _lineCountCaseStyle = HexEditor.CaseStyle.UpperCase;

		// Token: 0x040002BE RID: 702
		private HexEditor.CaseStyle _hexViewCaseStyle = HexEditor.CaseStyle.UpperCase;

		// Token: 0x040002BF RID: 703
		private bool _isVScrollVisible;

		// Token: 0x040002C4 RID: 708
		private bool _dragging;

		// Token: 0x02000068 RID: 104
		public enum CaseStyle
		{
			// Token: 0x040002C6 RID: 710
			LowerCase,
			// Token: 0x040002C7 RID: 711
			UpperCase
		}
	}
}
