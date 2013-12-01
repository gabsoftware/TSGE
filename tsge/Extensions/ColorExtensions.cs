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

namespace tsge.Extensions
{
    using System;
    using System.Drawing;

    public static class ColorExtensions
    {
        /// <summary>
        /// Converts a byte array of three bytes to a System.Drawing.Color.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="btColor"></param>
        /// <returns></returns>
        public static Color FromBytes(this Color c, byte[] btColor)
        {
            if (btColor == null || btColor.Length != 3)
                throw new ArgumentException("Invalid array size for incoming color.", "btColor");
            return Color.FromArgb(255, btColor[0], btColor[1], btColor[2]);
        }

        /// <summary>
        /// Converts a System.Drawing.Color to a three byte array.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this Color c)
        {
            return new[] { c.R, c.G, c.B };
        }
    }
}
