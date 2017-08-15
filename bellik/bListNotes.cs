using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bellik
{
    class exListBoxItem
    {
        private string _title;
        private string _fname;
        private string _date;
        private int _id;
        private bool _synced;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool Synced
        {
            get { return _synced; }
            set { _synced = value; }
        }

        public exListBoxItem(int id, string title, string fname, string date, bool synced)
        {
            _id = id;
            _title = title;
            _fname = fname;
            _date = date;
            _synced = synced;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string iDate
        {
            get { return _date; }
            set { _date = value; }
        }


        public void drawItem(DrawItemEventArgs e, Padding margin,
                             Font titleFont, Font detailsFont, StringFormat aligment, Size iSize)
        {
            
            // if selected, mark the background differently         
            
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle((new SolidBrush(System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250))))))), e.Bounds);
            }

            // draw some item separator
            e.Graphics.DrawLine(Pens.DarkGray, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);

            // draw item image
            //e.Graphics.DrawRectangle(Pens.DarkGreen, e.Bounds.X + margin.Left, e.Bounds.Y + margin.Top, iSize.Width, iSize.Height);
            if (!Synced)
                e.Graphics.FillRectangle(Brushes.DarkGreen, e.Bounds.X, e.Bounds.Y, iSize.Width, iSize.Height);

            // calculate bounds for title text drawing
            Rectangle titleBounds = new Rectangle(e.Bounds.X + margin.Horizontal + iSize.Width,
                                                  e.Bounds.Y + margin.Top,
                                                  e.Bounds.Width - margin.Right - iSize.Width - margin.Horizontal,
                                                  (int)titleFont.GetHeight() + 2);

            // calculate bounds for details text drawing
            Rectangle detailBounds = new Rectangle(e.Bounds.X + margin.Horizontal + iSize.Width,
                                                   e.Bounds.Y + (int)titleFont.GetHeight() + 2 + margin.Vertical + margin.Top,
                                                   e.Bounds.Width - margin.Right - iSize.Width - margin.Horizontal,
                                                   e.Bounds.Height - margin.Bottom - (int)titleFont.GetHeight() - 2 - margin.Vertical - margin.Top);

            // draw the text within the bounds
            e.Graphics.DrawString(this.Title, titleFont, Brushes.Black, titleBounds, aligment);
            e.Graphics.DrawString(this.iDate, detailsFont, Brushes.DarkGray, detailBounds, aligment);

            // put some focus rectangle
            e.DrawFocusRectangle();

        }

    }
    public partial class bListNotes : ListBox
    {
        private Size _iSize;
        private StringFormat _fmt;
        private Font _titleFont;
        private Font _dateFont;

        public bListNotes(Font titleFont, Font dateFont,  
                         StringAlignment aligment, StringAlignment lineAligment)
        {
            _titleFont = titleFont;
            _dateFont = dateFont;
            //_imageSize = imageSize;
            //this.ItemHeight = _imageSize.Height + this.Margin.Vertical;
            _fmt = new StringFormat();
            _fmt.Alignment = aligment;
            _fmt.LineAlignment = lineAligment;
            _titleFont = titleFont;
            _dateFont = dateFont;
        }

        public bListNotes()
        {
            InitializeComponent();
            //this.DrawMode = DrawMode.OwnerDrawFixed;
            
            //this.ItemHeight = 48;

            //_imageSize = new Size(80, 60);
            //this.ItemHeight = _imageSize.Height + this.Margin.Vertical;
            _fmt = new StringFormat();
            _fmt.Alignment = StringAlignment.Near;
            _fmt.LineAlignment = StringAlignment.Near;
            _titleFont = new Font(this.Font, FontStyle.Regular);
            _dateFont = new Font(this.Font, FontStyle.Regular);
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {

            base.OnSelectedIndexChanged(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // prevent from error Visual Designer
            _iSize = new Size(4, 38);
            if (this.Items.Count > 0)
            {
                exListBoxItem item = (exListBoxItem)this.Items[e.Index];
                item.drawItem(e, this.Margin, _titleFont, _dateFont, _fmt, this._iSize);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }


}
