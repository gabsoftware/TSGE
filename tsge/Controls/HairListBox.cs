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

    public partial class HairListBox : ListBox
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public HairListBox()
        {
            InitializeComponent();

            // Add each hair file to our item list..
            foreach (var file in Terraria.Instance.HairFiles)
                this.Items.Add(file);
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

            // Cast the incoming argument as a string..
            var filePath = (string)this.Items[e.Index];

            // Adjust the background based on selection..
            e.Graphics.FillRectangle((e.State & DrawItemState.Selected) == DrawItemState.Selected ?
                Brushes.SkyBlue : Brushes.White, e.Bounds);

            // Draw seperator line..
            e.Graphics.DrawLine(Pens.Black, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);

            // Draw the hair icon..
            var bmp = new Bitmap(string.Format("{0}\\Data\\Hair\\{1}", Application.StartupPath, filePath));
            e.Graphics.DrawImage(bmp, e.Bounds.X + this.Margin.Left, e.Bounds.Y + this.Margin.Top, 48, 48);

            // Calculate name string bounds..
            var nameBounds = new Rectangle(e.Bounds.X + this.Margin.Horizontal + 48,
                                           e.Bounds.Y + this.Margin.Top + (e.Bounds.Height / 2) - (int)this.Font.GetHeight(),
                                           e.Bounds.Width - this.Margin.Right - 48 - this.Margin.Horizontal,
                                           (int)this.Font.GetHeight() + 2);

            var styleId = filePath.Replace("hair_", "").Replace(".png", "");

            // Draw style information string..
            e.Graphics.DrawString(string.Format("Hair Style: {0}", styleId), this.Font, Brushes.Black, nameBounds);

            // Draw the focused item rect..
            e.DrawFocusRectangle();
        }
    }
}
