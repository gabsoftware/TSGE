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
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class ModelViewer : UserControl
    {
        /// <summary>
        /// Internal copy of the hair id.
        /// </summary>
        private int m_HairId;

        /// <summary>
        /// Internal copy of the hair color.
        /// </summary>
        private Color m_HairColor;

        /// <summary>
        /// Internal copy of the head color.
        /// </summary>
        private Color m_HeadColor;

        /// <summary>
        /// Internal copy of the eye color.
        /// </summary>
        private Color m_EyeColor;

        /// <summary>
        /// Internal copy of the eye whites color.
        /// </summary>
        private Color m_EyeWhitesColor;

        /// <summary>
        /// Internal copy of the hands color.
        /// </summary>
        private Color m_HandsColor;

        /// <summary>
        /// Internal copy of the shirt color.
        /// </summary>
        private Color m_ShirtColor;

        /// <summary>
        /// Internal copy of the undershirt color.
        /// </summary>
        private Color m_UndershirtColor;

        /// <summary>
        /// Internal copy of the pants color.
        /// </summary>
        private Color m_PantsColor;

        /// <summary>
        /// Internal copy of the shoes color.
        /// </summary>
        private Color m_ShoesColor;

        /// <summary>
        /// Internal copy of the eye texture.
        /// </summary>
        private Bitmap m_EyeTexture;

        /// <summary>
        /// Internal copy of the eye whites texture.
        /// </summary>
        private Bitmap m_EyeWhitesTexture;

        /// <summary>
        /// Internal copy of the hair texture.
        /// </summary>
        private Bitmap m_HairTexture;

        /// <summary>
        /// Internal copy of the hands texture.
        /// </summary>
        private Bitmap m_HandsTexture;

        /// <summary>
        /// Internal copy of the head texture.
        /// </summary>
        private Bitmap m_HeadTexture;

        /// <summary>
        /// Internal copy of the pants texture.
        /// </summary>
        private Bitmap m_PantsTexture;

        /// <summary>
        /// Internal copy of the shirt texture.
        /// </summary>
        private Bitmap m_ShirtTexture;

        /// <summary>
        /// Internal copy of the shoes texture.
        /// </summary>
        private Bitmap m_ShoesTexture;

        /// <summary>
        /// Internal copy of the undershirt texture.
        /// </summary>
        private Bitmap m_UnderShirtTexture;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ModelViewer()
        {
            InitializeComponent();

            // Set class property defaults..
            this.Suspended = false;
            this.LargestImageWidth = 0;
            this.LargestImageHeight = 0;

            // Suspend model updates..
            this.SuspendModelUpdates();

            // Set default colors..
            this.EyeWhitesColor = Color.FromArgb(255, 255, 255, 255);
            this.EyeColor = Color.FromArgb(255, 105, 90, 75);
            this.HairColor = Color.FromArgb(255, 215, 90, 55);
            this.HandsColor = Color.FromArgb(255, 255, 125, 75);
            this.HeadColor = Color.FromArgb(255, 255, 125, 75);
            this.PantsColor = Color.FromArgb(255, 255, 230, 175);
            this.ShirtColor = Color.FromArgb(255, 175, 165, 140);
            this.ShoesColor = Color.FromArgb(255, 160, 106, 60);
            this.UndershirtColor = Color.FromArgb(255, 160, 180, 215);

            // Set default file paths..
            this.HairFile = "Data\\Hair\\hair_0.png";
            this.EyeFile = "Data\\Eyes\\eyes.png";
            this.EyeWhitesFile = "Data\\Eyes\\eye_whites.png";
            this.HeadFile = "Data\\Heads\\head.png";
            this.HandsFile = "Data\\Hands\\hands.png";
            this.ShirtFile = "Data\\Shirts\\shirt.png";
            this.UnderShirtFile = "Data\\UnderShirts\\undershirt.png";
            this.PantsFile = "Data\\Pants\\pants.png";
            this.ShoesFile = "Data\\Shoes\\shoes.png";

            // Update the model viewer..
            this.ResumeModelUpdates();
        }
        
        /// <summary>
        /// Colorizes a bitmap with the given color.
        /// </summary>
        /// <param name="bmpInput"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private Bitmap ColorizeBitmap(Bitmap bmpInput, Color c)
        {
            if (this.Suspended)
                return bmpInput;

            // Adjust the pixel colors..
            for (var h = 0; h < bmpInput.Height; h++)
                for (var w = 0; w < bmpInput.Width; w++)
                {
                    var pixel = bmpInput.GetPixel(w, h);
                    if (pixel == Color.FromArgb(0, 0, 0, 0))
                        continue;

                    if (pixel != Color.FromArgb(255, 249, 249, 249))
                    {
                        bmpInput.SetPixel(w, h, System.Drawing.Color.FromArgb(
                            (pixel.R + c.R) / 2,
                            (pixel.G + c.G) / 2,
                            (pixel.B + c.B) / 2));
                    }
                    else
                    {
                        bmpInput.SetPixel(w, h, System.Drawing.Color.White);
                    }
                }

            // Draw the new image..
            var bmpColored = new Bitmap(bmpInput.Width * 4, bmpInput.Height * 4);
            using (var g = Graphics.FromImage(bmpColored))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(bmpInput, 0, 0, bmpColored.Width, bmpColored.Height);
            }

            // Store the largest found texture size..
            if (bmpColored.Width > this.LargestImageWidth)
                this.LargestImageWidth = bmpColored.Width;
            if (bmpColored.Height > this.LargestImageHeight)
                this.LargestImageHeight = bmpColored.Height;

            return bmpColored;
        }

        /// <summary>
        /// Updates the model viewer textures and creates the new player preview.
        /// </summary>
        public void UpdateTextures()
        {
            if (this.Suspended)
                return;

            // Validation check..
            if (this.ShoesFile == null)
                return;

            try
            {
                // Update the texture files..
                this.m_EyeTexture = this.ColorizeBitmap(new Bitmap(this.EyeFile), this.EyeColor);
                this.m_EyeWhitesTexture = this.ColorizeBitmap(new Bitmap(this.EyeWhitesFile), this.EyeWhitesColor);
                this.m_HairTexture = this.ColorizeBitmap(new Bitmap(this.HairFile), this.HairColor);
                this.m_HandsTexture = this.ColorizeBitmap(new Bitmap(this.HandsFile), this.HandsColor);
                this.m_HeadTexture = this.ColorizeBitmap(new Bitmap(this.HeadFile), this.HeadColor);
                this.m_PantsTexture = this.ColorizeBitmap(new Bitmap(this.PantsFile), this.PantsColor);
                this.m_ShirtTexture = this.ColorizeBitmap(new Bitmap(this.ShirtFile), this.ShirtColor);
                this.m_ShoesTexture = this.ColorizeBitmap(new Bitmap(this.ShoesFile), this.ShoesColor);
                this.m_UnderShirtTexture = this.ColorizeBitmap(new Bitmap(this.UnderShirtFile), this.UndershirtColor);
            
                // Draw the new full model based on the largest images dimensions.
                var bmpModel = new Bitmap(this.LargestImageWidth, this.LargestImageHeight);
                using (var g = Graphics.FromImage(bmpModel))
                {
                    g.DrawImage(this.m_PantsTexture, 0, 0);
                    g.DrawImage(this.m_ShoesTexture, 0, 0);
                    g.DrawImage(this.m_ShirtTexture, 0, 0);
                    g.DrawImage(this.m_UnderShirtTexture, 0, 0);
                    g.DrawImage(this.m_HandsTexture, 0, 0);
                    g.DrawImage(this.m_HeadTexture, 0, 0);
                    g.DrawImage(this.m_HairTexture, 0, 0);
                    g.DrawImage(this.m_EyeWhitesTexture, 0, 0);
                    g.DrawImage(this.m_EyeTexture, 0, 0);
                }

                // Save the new bitmap to a memory stream..
                var ms = new MemoryStream();
                bmpModel.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                this.pbModelViewer.Image = new Bitmap(ms);

                // Collect garbage..
                GC.Collect();
            }
            catch { }
        }

        /// <summary>
        /// Suspends model updates from happening until resumed.
        /// </summary>
        public void SuspendModelUpdates()
        {
            this.Suspended = true;
        }

        /// <summary>
        /// Resumes model updates.
        /// </summary>
        public void ResumeModelUpdates()
        {
            this.Suspended = false;
            this.UpdateTextures();
        }

        /// <summary>
        /// Gets or sets if the model viewer is paused from updating.
        /// </summary>
        public bool Suspended { get; set; }

        /// <summary>
        /// Gets or sets the largest image width.
        /// </summary>
        public int LargestImageWidth { get; set; }

        /// <summary>
        /// Gets or sets the largest image height.
        /// </summary>
        public int LargestImageHeight { get; set; }

        /// <summary>
        /// Gets or sets the hair id property.
        /// </summary>
        public int HairId
        {
            get { return this.m_HairId; }
            set
            {
                this.m_HairId = value;
                this.HairFile = string.Format("Data\\Hair\\hair_{0}.png", value);
            }
        }

        /// <summary>
        /// Gets or sets the hair color property.
        /// </summary>
        public Color HairColor 
        {
            get { return m_HairColor; }
            set { this.m_HairColor = value; this.UpdateTextures(); }
        }

        /// <summary>
        /// Gets or sets the head color property.
        /// </summary>
        public Color HeadColor
        {
            get { return m_HeadColor; }
            set { this.m_HeadColor = value; this.UpdateTextures(); }
        }

        /// <summary>
        /// Gets or sets the eye color property.
        /// </summary>
        public Color EyeColor
        {
            get { return m_EyeColor; }
            set { this.m_EyeColor = value; this.UpdateTextures(); }
        }

        /// <summary>
        /// Gets or sets the eye whites color property.
        /// </summary>
        public Color EyeWhitesColor
        {
            get { return m_EyeWhitesColor; }
            set { this.m_EyeWhitesColor = value; this.UpdateTextures(); }
        }

        /// <summary>
        /// Gets or sets the hands color property.
        /// </summary>
        public Color HandsColor
        {
            get { return m_HandsColor; }
            set { this.m_HandsColor = value; this.UpdateTextures(); }
        }

        /// <summary>
        /// Gets or sets the shirt color property.
        /// </summary>
        public Color ShirtColor
        {
            get { return m_ShirtColor; }
            set { this.m_ShirtColor = value; this.UpdateTextures(); }
        }

        /// <summary>
        /// Gets or sets the under shirt color property.
        /// </summary>
        public Color UndershirtColor
        {
            get { return m_UndershirtColor; }
            set { this.m_UndershirtColor = value; this.UpdateTextures(); }
        }

        /// <summary>
        /// Gets or sets the pants color property.
        /// </summary>
        public Color PantsColor
        {
            get { return m_PantsColor; }
            set { this.m_PantsColor = value; this.UpdateTextures(); }
        }

        /// <summary>
        /// Gets or sets the shoes color property.
        /// </summary>
        public Color ShoesColor
        {
            get { return m_ShoesColor; }
            set { this.m_ShoesColor = value; this.UpdateTextures(); }
        }

        /// <summary>
        /// Gets or sets the hair file property.
        /// </summary>
        public string HairFile { get; set; }

        /// <summary>
        /// Gets or sets the head file property.
        /// </summary>
        public string HeadFile { get; set; }

        /// <summary>
        /// Gets or sets the eye file property.
        /// </summary>
        public string EyeFile { get; set; }

        /// <summary>
        /// Gets or sets the eye whites file property.
        /// </summary>
        public string EyeWhitesFile { get; set; }

        /// <summary>
        /// Gets or sets the hands file property.
        /// </summary>
        public string HandsFile { get; set; }

        /// <summary>
        /// Gets or sets the shirt file property.
        /// </summary>
        public string ShirtFile { get; set; }

        /// <summary>
        /// Gets or sets the under shirt file property.
        /// </summary>
        public string UnderShirtFile { get; set; }

        /// <summary>
        /// Gets or sets the pants file property.
        /// </summary>
        public string PantsFile { get; set; }

        /// <summary>
        /// Gets or sets the shoes file property.
        /// </summary>
        public string ShoesFile { get; set; }
    }
}
