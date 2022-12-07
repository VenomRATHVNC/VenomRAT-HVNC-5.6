using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Server.Helper.HexEditor
{
	// Token: 0x02000065 RID: 101
	public class Caret
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00003BFC File Offset: 0x00001DFC
		public int SelectionStart
		{
			get
			{
				if (this._endIndex < this._startIndex)
				{
					return this._endIndex;
				}
				return this._startIndex;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00003C19 File Offset: 0x00001E19
		public int SelectionLength
		{
			get
			{
				if (this._endIndex < this._startIndex)
				{
					return this._startIndex - this._endIndex;
				}
				return this._endIndex - this._startIndex;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00003C44 File Offset: 0x00001E44
		public bool Focused
		{
			get
			{
				return this._isCaretActive;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00003C4C File Offset: 0x00001E4C
		public int CurrentIndex
		{
			get
			{
				return this._endIndex;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00003C54 File Offset: 0x00001E54
		public Point Location
		{
			get
			{
				return this._location;
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000359 RID: 857 RVA: 0x0002254C File Offset: 0x0002074C
		// (remove) Token: 0x0600035A RID: 858 RVA: 0x00022584 File Offset: 0x00020784
		public event EventHandler SelectionStartChanged;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600035B RID: 859 RVA: 0x000225BC File Offset: 0x000207BC
		// (remove) Token: 0x0600035C RID: 860 RVA: 0x000225F4 File Offset: 0x000207F4
		public event EventHandler SelectionLengthChanged;

		// Token: 0x0600035D RID: 861 RVA: 0x00003C5C File Offset: 0x00001E5C
		public Caret(HexEditor editor)
		{
			this._editor = editor;
			this._isCaretActive = false;
			this._startIndex = 0;
			this._endIndex = 0;
			this._isCaretHidden = true;
			this._location = new Point(0, 0);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0002262C File Offset: 0x0002082C
		private bool Create(IntPtr hWHandler)
		{
			if (!this._isCaretActive)
			{
				this._isCaretActive = true;
				return Caret.CreateCaret(hWHandler, IntPtr.Zero, 0, (int)this._editor.CharSize.Height - 2);
			}
			return false;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00003C94 File Offset: 0x00001E94
		private bool Show(IntPtr hWnd)
		{
			if (this._isCaretActive)
			{
				this._isCaretHidden = false;
				return Caret.ShowCaret(hWnd);
			}
			return false;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003CAD File Offset: 0x00001EAD
		public bool Hide(IntPtr hWnd)
		{
			if (this._isCaretActive && !this._isCaretHidden)
			{
				this._isCaretHidden = true;
				return Caret.HideCaret(hWnd);
			}
			return false;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003CCE File Offset: 0x00001ECE
		public bool Destroy()
		{
			if (this._isCaretActive)
			{
				this._isCaretActive = false;
				this.DeSelect();
				Caret.DestroyCaret();
			}
			return false;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0002266C File Offset: 0x0002086C
		public void SetStartIndex(int index)
		{
			this._startIndex = index;
			this._endIndex = this._startIndex;
			if (this.SelectionStartChanged != null)
			{
				this.SelectionStartChanged(this, EventArgs.Empty);
			}
			if (this.SelectionLengthChanged != null)
			{
				this.SelectionLengthChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003CEC File Offset: 0x00001EEC
		public void SetEndIndex(int index)
		{
			this._endIndex = index;
			if (this.SelectionStartChanged != null)
			{
				this.SelectionStartChanged(this, EventArgs.Empty);
			}
			if (this.SelectionLengthChanged != null)
			{
				this.SelectionLengthChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000226C0 File Offset: 0x000208C0
		public void SetCaretLocation(Point start)
		{
			this.Create(this._editor.Handle);
			this._location = start;
			Caret.SetCaretPos(this._location.X, this._location.Y);
			this.Show(this._editor.Handle);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003D27 File Offset: 0x00001F27
		public bool IsSelected(int byteIndex)
		{
			return this.SelectionStart <= byteIndex && byteIndex < this.SelectionStart + this.SelectionLength;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00022714 File Offset: 0x00020914
		private void DeSelect()
		{
			if (this._endIndex < this._startIndex)
			{
				this._startIndex = this._endIndex;
			}
			else
			{
				this._endIndex = this._startIndex;
			}
			if (this.SelectionStartChanged != null)
			{
				this.SelectionStartChanged(this, EventArgs.Empty);
			}
			if (this.SelectionLengthChanged != null)
			{
				this.SelectionLengthChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000367 RID: 871
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

		// Token: 0x06000368 RID: 872
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool DestroyCaret();

		// Token: 0x06000369 RID: 873
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool SetCaretPos(int x, int y);

		// Token: 0x0600036A RID: 874
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool ShowCaret(IntPtr hWnd);

		// Token: 0x0600036B RID: 875
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool HideCaret(IntPtr hWnd);

		// Token: 0x04000292 RID: 658
		private int _startIndex;

		// Token: 0x04000293 RID: 659
		private int _endIndex;

		// Token: 0x04000294 RID: 660
		private bool _isCaretActive;

		// Token: 0x04000295 RID: 661
		private bool _isCaretHidden;

		// Token: 0x04000296 RID: 662
		private Point _location;

		// Token: 0x04000297 RID: 663
		private HexEditor _editor;
	}
}
