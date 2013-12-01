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
    using System.IO;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Attach unhandled exception handler..
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            // Execute the application..
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        /// <summary>
        /// Catches and saves unhandled exceptions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="unhandledExceptionEventArgs"></param>
        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            try
            {
                if (unhandledExceptionEventArgs.ExceptionObject == null)
                    return;

                var ex = (Exception)unhandledExceptionEventArgs.ExceptionObject;
                using (var writer = new StreamWriter("crashlog.txt"))
                {
                    writer.Write(ex);
                    writer.Flush();
                }

                MessageBox.Show(ex.ToString(), "Error!");
            }
            catch
            {
            }
        }
    }
}
