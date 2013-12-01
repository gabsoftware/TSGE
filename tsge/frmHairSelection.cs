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
    using System;
    using System.Windows.Forms;

    public partial class frmHairSelection : Form
    {
        /// <summary>
        /// Internal hair id value.
        /// </summary>
        private int m_HairId;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public frmHairSelection()
        {
            InitializeComponent();

            this.m_HairId = 0;
            this.lstHairSelection.SelectedIndex = this.HairId;
        }

        /// <summary>
        /// Selects the hair style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstHairSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HairId = this.lstHairSelection.SelectedIndex;
        }

        /// <summary>
        /// Closes this form with a valid result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectHair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Closes this form with a cancelled result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Gets or sets the selected hair index.
        /// </summary>
        public int HairId
        {

            get { return this.m_HairId; }
            set
            {
                this.m_HairId = value;
                this.lstHairSelection.SelectedIndex = value;
            }
        }
    }
}
