// -----------------------------------------------------------------------
//    This file is part of TSGE.
//
//    TSGE is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    TSGE is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with TSGE.  If not, see <http://www.gnu.org/licenses/>.
// -----------------------------------------------------------------------

namespace tsge.Controls
{
    using Classes;
    using System.Drawing;
    using System.Windows.Forms;

    public sealed partial class BuffListBox : ListBox
    {
        /// <summary>
        /// Internal italic font.
        /// </summary>
        private readonly Font m_ItalicFont;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BuffListBox()
        {
            InitializeComponent();

            // Prepare the italic font..
            this.m_ItalicFont = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Italic);

        }
        
        /// <summary>
        /// OnDrawItem override to draw our custom item.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Validation check to prevent designer errors..
            if (this.Items.Count <= 0)
                return;

            // Cast the incoming argument as a buff entry..
            var buff = (Buff)this.Items[e.Index];

            // Adjust the background based on selection..
            e.Graphics.FillRectangle((e.State & DrawItemState.Selected) == DrawItemState.Selected ? 
                Brushes.SkyBlue : Brushes.White, e.Bounds);

            // Draw seperator line..
            e.Graphics.DrawLine(Pens.Black, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);

            // Draw the buff icon..
            var bmp = new Bitmap(buff.Icon.LocalPath);
            e.Graphics.DrawImage(bmp, e.Bounds.X + this.Margin.Left, e.Bounds.Y + this.Margin.Top, 32, 32);

            // Calculate name string bounds..
            var nameBounds = new Rectangle(e.Bounds.X + this.Margin.Horizontal + 32,
                                           e.Bounds.Y + this.Margin.Top,
                                           e.Bounds.Width - this.Margin.Right - 32 - this.Margin.Horizontal,
                                           (int)this.Font.GetHeight() + 2);

            // Calculate duration string bounds..
            var durationBounds = new Rectangle(e.Bounds.X + this.Margin.Horizontal + 32,
                                              e.Bounds.Y + (int)this.Font.GetHeight() + 2 + this.Margin.Vertical + this.Margin.Top,
                                              e.Bounds.Width - this.Margin.Right - 32 - this.Margin.Horizontal,
                                              e.Bounds.Height - this.Margin.Bottom - (int)this.Font.GetHeight() - 2 - this.Margin.Vertical - this.Margin.Top);

            // Calculate tooltip string bounds..
            var toolTipBounds = new Rectangle(e.Bounds.X,
                                              e.Bounds.Y + this.Margin.Top + 32 + 5,
                                              e.Bounds.Width - this.Margin.Right - 32 - this.Margin.Horizontal,
                                              (int)this.Font.GetHeight() + 2);

            // Draw buff information strings..
            e.Graphics.DrawString(buff.Name, this.Font, Brushes.Black, nameBounds);
            e.Graphics.DrawString(buff.DurationString, this.Font, Brushes.Black, durationBounds);
            e.Graphics.DrawString(buff.Tooltip, this.m_ItalicFont, Brushes.Black, toolTipBounds);

            // Draw the focused item rect..
            e.DrawFocusRectangle();
        }
    }
}
