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

namespace tsge
{
    partial class frmHairSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHairSelection));
            this.lstHairSelection = new tsge.Controls.HairListBox();
            this.btnSelectHair = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHairSelection
            // 
            this.lstHairSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstHairSelection.FormattingEnabled = true;
            this.lstHairSelection.ItemHeight = 48;
            this.lstHairSelection.Location = new System.Drawing.Point(12, 12);
            this.lstHairSelection.Name = "lstHairSelection";
            this.lstHairSelection.Size = new System.Drawing.Size(293, 333);
            this.lstHairSelection.TabIndex = 0;
            this.lstHairSelection.SelectedIndexChanged += new System.EventHandler(this.lstHairSelection_SelectedIndexChanged);
            // 
            // btnSelectHair
            // 
            this.btnSelectHair.Location = new System.Drawing.Point(149, 351);
            this.btnSelectHair.Name = "btnSelectHair";
            this.btnSelectHair.Size = new System.Drawing.Size(75, 23);
            this.btnSelectHair.TabIndex = 1;
            this.btnSelectHair.Text = "Select Hair";
            this.btnSelectHair.UseVisualStyleBackColor = true;
            this.btnSelectHair.Click += new System.EventHandler(this.btnSelectHair_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmHairSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(317, 386);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectHair);
            this.Controls.Add(this.lstHairSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHairSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select a hair style..";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.HairListBox lstHairSelection;
        private System.Windows.Forms.Button btnSelectHair;
        private System.Windows.Forms.Button btnCancel;
    }
}