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
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public partial class ItemLabel : Label
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ItemLabel()
        {
            InitializeComponent();

            // Set item count to show default..
            this.ShowItemCount = true;
        }

        /// <summary>
        /// OnPaint override to draw our custom item label.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Adjust the graphics quality..
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            // Draw the item image..
            if (this.Image != null)
                e.Graphics.DrawImage(this.Image, (e.ClipRectangle.Width / 2) - (this.Image.Width / 2), (e.ClipRectangle.Height / 2) - (this.Image.Height / 2));

            // Don't draw the item count if not needed..
            if (!this.ShowItemCount)
                return;

            // Draw the text background..
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(75, 0, 0, 0)),
                         0, e.ClipRectangle.Height - 15, e.ClipRectangle.Width, 15);

            // Draw the text..
            var f = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);
            var sf = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far };
            var p = new Pen(Color.FromArgb(255, 0, 0, 0), 2) { LineJoin = LineJoin.Round };

            try
            {
                using (var gp = new GraphicsPath())
                {
                    gp.AddString(this.Text, f.FontFamily, (int)f.Style, 14, new Rectangle(0, 0, this.Width - 1, this.Height - 1), sf);
                    e.Graphics.DrawPath(p, gp);
                    e.Graphics.FillPath(Brushes.White, gp);
                }
            } catch { /* Swallow designer exception.. */ }

            // Cleanup..
            p.Dispose();
            sf.Dispose();
            f.Dispose();
        }

        /// <summary>
        /// Gets or sets if the item count should be drawn.
        /// </summary>
        public bool ShowItemCount { get; set; }
    }
}
