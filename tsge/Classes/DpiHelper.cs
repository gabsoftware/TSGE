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

namespace tsge.Classes
{
    using System;
    using System.Drawing;

    internal static class DpiHelper
    {
        /// <summary>
        /// Obtains the current device DPI.
        /// </summary>
        /// <returns></returns>
        internal static int GetCurrentDpi()
        {
            using (var g = Graphics.FromHwnd(IntPtr.Zero))
            {
                return NativeAPI.GetDeviceCaps(g.GetHdc(), 88);
            }
        }

        /// <summary>
        /// Obtains the current device DPI scale percent.
        /// </summary>
        /// <returns></returns>
        internal static int GetScalePercent()
        {
            return GetCurrentDpi() * 100 / 96;
        }

        /// <summary>
        /// Determines the scaled DPI size of an object.
        /// </summary>
        /// <param name="baseSize"></param>
        /// <returns></returns>
        internal static int ScaleAsDpi(int baseSize)
        {
            return baseSize * GetScalePercent() / 100;
        }
    }
}
