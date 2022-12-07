using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Helper.HexEditor
{
	// Token: 0x02000069 RID: 105
	public class HexViewHandler
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00004239 File Offset: 0x00002439
		public int MaxWidth
		{
			get
			{
				return this._recHexValue.X + this._recHexValue.Width * this._editor.BytesPerLine;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00023DC4 File Offset: 0x00021FC4
		public HexViewHandler(HexEditor editor)
		{
			this._editor = editor;
			this._stringFormat = new StringFormat(StringFormat.GenericTypographic);
			this._stringFormat.Alignment = StringAlignment.Center;
			this._stringFormat.LineAlignment = StringAlignment.Center;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000425E File Offset: 0x0000245E
		public void OnKeyPress(KeyPressEventArgs e)
		{
			if (this.IsHex(e.KeyChar))
			{
				this.HandleUserInput(e.KeyChar);
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00023E14 File Offset: 0x00022014
		public void OnKeyDown(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
			{
				if (this._editor.SelectionLength > 0)
				{
					this.HandleUserRemove();
					int caretIndex = this._editor.CaretIndex;
					Point caretLocation = this.GetCaretLocation(caretIndex);
					this._editor.SetCaretStart(caretIndex, caretLocation);
				}
				else if (this._editor.CaretIndex < this._editor.LastVisibleByte && e.KeyCode == Keys.Delete)
				{
					this._editor.RemoveByteAt(this._editor.CaretIndex);
					Point caretLocation2 = this.GetCaretLocation(this._editor.CaretIndex);
					this._editor.SetCaretStart(this._editor.CaretIndex, caretLocation2);
				}
				else if (this._editor.CaretIndex > 0 && e.KeyCode == Keys.Back)
				{
					int index = this._editor.CaretIndex - 1;
					if (this._isEditing)
					{
						index = this._editor.CaretIndex;
					}
					this._editor.RemoveByteAt(index);
					Point caretLocation3 = this.GetCaretLocation(index);
					this._editor.SetCaretStart(index, caretLocation3);
				}
				this._isEditing = false;
				return;
			}
			if (e.KeyCode == Keys.Up && this._editor.CaretIndex - this._editor.BytesPerLine >= 0)
			{
				int num = this._editor.CaretIndex - this._editor.BytesPerLine;
				if (num % this._editor.BytesPerLine == 0 && this._editor.CaretPosX >= this._recHexValue.X + this._recHexValue.Width * this._editor.BytesPerLine)
				{
					Point location = new Point(this._editor.CaretPosX, this._editor.CaretPosY - this._recHexValue.Height);
					if (num == 0)
					{
						location = new Point(this._editor.CaretPosX, this._editor.CaretPosY);
						num = this._editor.BytesPerLine;
					}
					if (e.Shift)
					{
						this._editor.SetCaretEnd(num, location);
					}
					else
					{
						this._editor.SetCaretStart(num, location);
					}
					this._isEditing = false;
					return;
				}
				this.HandleArrowKeys(num, e.Shift);
				return;
			}
			else if (e.KeyCode == Keys.Down && (this._editor.CaretIndex - 1) / this._editor.BytesPerLine < this._editor.HexTableLength / this._editor.BytesPerLine)
			{
				int num2 = this._editor.CaretIndex + this._editor.BytesPerLine;
				if (num2 > this._editor.HexTableLength)
				{
					num2 = this._editor.HexTableLength;
					this.HandleArrowKeys(num2, e.Shift);
					return;
				}
				Point location2 = new Point(this._editor.CaretPosX, this._editor.CaretPosY + this._recHexValue.Height);
				if (e.Shift)
				{
					this._editor.SetCaretEnd(num2, location2);
				}
				else
				{
					this._editor.SetCaretStart(num2, location2);
				}
				this._isEditing = false;
				return;
			}
			else
			{
				if (e.KeyCode == Keys.Left && this._editor.CaretIndex - 1 >= 0)
				{
					int index2 = this._editor.CaretIndex - 1;
					this.HandleArrowKeys(index2, e.Shift);
					return;
				}
				if (e.KeyCode == Keys.Right && this._editor.CaretIndex + 1 <= this._editor.HexTableLength)
				{
					int index3 = this._editor.CaretIndex + 1;
					this.HandleArrowKeys(index3, e.Shift);
				}
				return;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000241B0 File Offset: 0x000223B0
		public void HandleArrowKeys(int index, bool isShiftDown)
		{
			Point caretLocation = this.GetCaretLocation(index);
			if (isShiftDown)
			{
				this._editor.SetCaretEnd(index, caretLocation);
			}
			else
			{
				this._editor.SetCaretStart(index, caretLocation);
			}
			this._isEditing = false;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000241EC File Offset: 0x000223EC
		public void OnMouseDown(int x, int y)
		{
			int num = (x - this._recHexValue.X) / this._recHexValue.Width;
			int num2 = (y - this._recHexValue.Y) / this._recHexValue.Height;
			num = ((num > this._editor.BytesPerLine) ? this._editor.BytesPerLine : num);
			num = ((num < 0) ? 0 : num);
			num2 = ((num2 > this._editor.MaxBytesV) ? this._editor.MaxBytesV : num2);
			num2 = ((num2 < 0) ? 0 : num2);
			if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine <= num2)
			{
				if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine <= num)
				{
					num = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine;
				}
				num2 = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine;
			}
			int index = Math.Min(this._editor.LastVisibleByte, this._editor.FirstVisibleByte + num + num2 * this._editor.BytesPerLine);
			int x2 = num * this._recHexValue.Width + this._recHexValue.X;
			int y2 = num2 * this._recHexValue.Height + this._recHexValue.Y;
			this._editor.SetCaretStart(index, new Point(x2, y2));
			this._isEditing = false;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0002438C File Offset: 0x0002258C
		public void OnMouseDragged(int x, int y)
		{
			int num = (x - this._recHexValue.X) / this._recHexValue.Width;
			int num2 = (y - this._recHexValue.Y) / this._recHexValue.Height;
			num = ((num > this._editor.BytesPerLine) ? this._editor.BytesPerLine : num);
			num = ((num < 0) ? 0 : num);
			num2 = ((num2 > this._editor.MaxBytesV) ? this._editor.MaxBytesV : num2);
			if (this._editor.FirstVisibleByte > 0)
			{
				num2 = ((num2 < 0) ? -1 : num2);
			}
			else
			{
				num2 = ((num2 < 0) ? 0 : num2);
			}
			if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine <= num2)
			{
				if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine <= num)
				{
					num = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine;
				}
				num2 = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine;
			}
			int index = Math.Min(this._editor.LastVisibleByte, this._editor.FirstVisibleByte + num + num2 * this._editor.BytesPerLine);
			int x2 = num * this._recHexValue.Width + this._recHexValue.X;
			int y2 = num2 * this._recHexValue.Height + this._recHexValue.Y;
			this._editor.SetCaretEnd(index, new Point(x2, y2));
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0002453C File Offset: 0x0002273C
		public void OnMouseDoubleClick()
		{
			if (this._editor.CaretIndex < this._editor.LastVisibleByte)
			{
				int index = this._editor.CaretIndex + 1;
				Point caretLocation = this.GetCaretLocation(index);
				this._editor.SetCaretEnd(index, caretLocation);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00024584 File Offset: 0x00022784
		public void Update(int startPositionX, Rectangle area)
		{
			this._recHexValue = new Rectangle(startPositionX, area.Y, (int)(this._editor.CharSize.Width * 3f), (int)this._editor.CharSize.Height - 2);
			this._recHexValue.X = this._recHexValue.X + this._editor.EntityMargin;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000245F4 File Offset: 0x000227F4
		public void Paint(Graphics g, int index, int startIndex)
		{
			Point byteColumnAndRow = this.GetByteColumnAndRow(index);
			if (this._editor.IsSelected(index + startIndex))
			{
				this.PaintByteAsSelected(g, byteColumnAndRow, index + startIndex);
				return;
			}
			this.PaintByte(g, byteColumnAndRow, index + startIndex);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00024630 File Offset: 0x00022830
		private void PaintByteAsSelected(Graphics g, Point point, int index)
		{
			SolidBrush brush = new SolidBrush(this._editor.SelectionBackColor);
			SolidBrush brush2 = new SolidBrush(this._editor.SelectionForeColor);
			RectangleF bound = this.GetBound(point);
			string s = this._editor.GetByte(index).ToString(this._hexType);
			g.FillRectangle(brush, bound);
			g.DrawString(s, this._editor.Font, brush2, bound, this._stringFormat);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000246A8 File Offset: 0x000228A8
		private void PaintByte(Graphics g, Point point, int index)
		{
			SolidBrush brush = new SolidBrush(this._editor.ForeColor);
			RectangleF bound = this.GetBound(point);
			string s = this._editor.GetByte(index).ToString(this._hexType);
			g.DrawString(s, this._editor.Font, brush, bound, this._stringFormat);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000427A File Offset: 0x0000247A
		public void SetLowerCase()
		{
			this._hexType = "x2";
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00004287 File Offset: 0x00002487
		public void SetUpperCase()
		{
			this._hexType = "X2";
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00024704 File Offset: 0x00022904
		public void Focus()
		{
			int caretIndex = this._editor.CaretIndex;
			Point caretLocation = this.GetCaretLocation(caretIndex);
			this._editor.SetCaretStart(caretIndex, caretLocation);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00024734 File Offset: 0x00022934
		private Point GetCaretLocation(int index)
		{
			int x = this._recHexValue.X + this._recHexValue.Width * (index % this._editor.BytesPerLine);
			int y = this._recHexValue.Y + this._recHexValue.Height * ((index - (this._editor.FirstVisibleByte + index % this._editor.BytesPerLine)) / this._editor.BytesPerLine);
			return new Point(x, y);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000247B0 File Offset: 0x000229B0
		private void HandleUserRemove()
		{
			int selectionStart = this._editor.SelectionStart;
			Point caretLocation = this.GetCaretLocation(selectionStart);
			this._editor.RemoveSelectedBytes();
			this._editor.SetCaretStart(selectionStart, caretLocation);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000247EC File Offset: 0x000229EC
		private void HandleUserInput(char key)
		{
			if (!this._editor.CaretFocused)
			{
				return;
			}
			this.HandleUserRemove();
			if (this._isEditing)
			{
				this._isEditing = false;
				byte b = this._editor.GetByte(this._editor.CaretIndex);
				b += Convert.ToByte(key.ToString(), 16);
				this._editor.SetByte(this._editor.CaretIndex, b);
				int index = this._editor.CaretIndex + 1;
				Point caretLocation = this.GetCaretLocation(index);
				this._editor.SetCaretStart(index, caretLocation);
				return;
			}
			this._isEditing = true;
			byte item = Convert.ToByte(key.ToString() + "0", 16);
			if (this._editor.HexTable.Length == 0)
			{
				this._editor.AppendByte(item);
			}
			else
			{
				this._editor.InsertByte(this._editor.CaretIndex, item);
			}
			int x = this._recHexValue.X + this._recHexValue.Width * (this._editor.CaretIndex % this._editor.BytesPerLine) + this._recHexValue.Width / 2;
			int y = this._recHexValue.Y + this._recHexValue.Height * ((this._editor.CaretIndex - (this._editor.FirstVisibleByte + this._editor.CaretIndex % this._editor.BytesPerLine)) / this._editor.BytesPerLine);
			this._editor.SetCaretStart(this._editor.CaretIndex, new Point(x, y));
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00024988 File Offset: 0x00022B88
		private Point GetByteColumnAndRow(int index)
		{
			int x = index % this._editor.BytesPerLine;
			int y = index / this._editor.BytesPerLine;
			return new Point(x, y);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000249B8 File Offset: 0x00022BB8
		private RectangleF GetBound(Point point)
		{
			return new RectangleF((float)(this._recHexValue.X + point.X * this._recHexValue.Width), (float)(this._recHexValue.Y + point.Y * this._recHexValue.Height), (float)this._recHexValue.Width, (float)this._recHexValue.Height);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00004294 File Offset: 0x00002494
		private bool IsHex(char c)
		{
			return (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F') || char.IsDigit(c);
		}

		// Token: 0x040002C8 RID: 712
		private bool _isEditing;

		// Token: 0x040002C9 RID: 713
		private string _hexType = "X2";

		// Token: 0x040002CA RID: 714
		private Rectangle _recHexValue;

		// Token: 0x040002CB RID: 715
		private StringFormat _stringFormat;

		// Token: 0x040002CC RID: 716
		private HexEditor _editor;
	}
}
