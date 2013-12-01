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
    using System.Diagnostics;
    using System.Reflection;
    using System.Windows.Forms;

    public partial class frmAbout : Form
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public frmAbout()
        {
            InitializeComponent();

            // Set the application version label..
            var appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            this.lblVersion.Text = string.Format("Version: {0}.{1}.{2}.{3}", appVersion.Major, appVersion.Minor, appVersion.Build, appVersion.Revision);
        }
        
        /// <summary>
        /// Launches the users browser and navigates to Twitter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwitter_Click(object sender, System.EventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.twitter.com/atom0s"));
        }

        /// <summary>
        /// Launches the users browser and navigates to Paypal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDonate_Click(object sender, System.EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=7U7Q2GRT6KUJN"));
        }

        /// <summary>
        /// Launches the users browser and navigates to Google.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://code.google.com/p/tsge/"));
        }
    }
}
