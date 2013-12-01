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

// -----------------------------------------------------------------------
//    Natural Sorting Implementation 
//
//    (c) 2008 Greg Beech
//    http://stackoverflow.com/questions/248603/natural-sort-order-in-c-sharp/248613#248613
// -----------------------------------------------------------------------

namespace tsge.Comparers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    internal static class SafeNativeMethods
    {
        /// <summary>
        /// shlwapi.StrCmpLogicalW Function Import Definition
        /// </summary>
        /// <param name="psz1"></param>
        /// <param name="psz2"></param>
        /// <returns></returns>
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
        public static extern int StrCmpLogicalW(string psz1, string psz2);
    }

    public sealed class NaturalStringComparer : IComparer<string>
    {
        /// <summary>
        /// Compares two strings logically to each other.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Compare(string a, string b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a, b);
        }
    }

    public sealed class NaturalFileInfoNameComparer : IComparer<FileInfo>
    {
        /// <summary>
        /// Compares two file names logically to each other.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Compare(FileInfo a, FileInfo b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a.Name, b.Name);
        }
    }

    public sealed class NaturalBuffNameComparer : IComparer<tsge.Classes.Buff>
    {
        /// <summary>
        /// Compares two Buff classes logically to each other by name.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Compare(tsge.Classes.Buff a, tsge.Classes.Buff b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a.Name, b.Name);
        }
    }

    public sealed class NaturalItemNameComparer : IComparer<tsge.Classes.Item>
    {
        /// <summary>
        /// Compares two Item classes logically to each other by name.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Compare(tsge.Classes.Item a, tsge.Classes.Item b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a.Name, b.Name);
        }
    }

    public sealed class NaturalItemPrefixNameComparer : IComparer<tsge.Classes.ItemPrefix>
    {
        /// <summary>
        /// Compares two ItemPrefix classes logically to each other by name.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Compare(tsge.Classes.ItemPrefix a, tsge.Classes.ItemPrefix b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a.Prefix, b.Prefix);
        }
    }
}
