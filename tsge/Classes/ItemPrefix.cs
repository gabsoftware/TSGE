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
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Xml.Serialization;

    public class ItemPrefix : ModelBase, ICloneable
    {
        /// <summary>
        /// Gets or sets the id property.
        /// </summary>
        [XmlAttribute("id")]
        public int Id
        {
            get { return this.Get<int>("Id"); }
            set { this.Set("Id", value); }
        }

        /// <summary>
        /// Gets or sets the prefix property.
        /// </summary>
        [XmlAttribute("prefix")]
        public string Prefix
        {
            get { return this.Get<string>("Prefix"); }
            set { this.Set("Prefix", value); }
        }

        /// <summary>
        /// Gets or sets the category prefix.
        /// </summary>
        [XmlAttribute("category")]
        public int Category
        {
            get { return this.Get<int>("Category"); }
            set { this.Set("Category", value); }
        }

        /// <summary>
        /// Tostring override to return this item prefixes prefix.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Prefix;
        }

        /// <summary>
        /// ICloneable implementation.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            try
            {
                using (var mStream = new MemoryStream())
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(mStream, this);
                    mStream.Position = 0;
                    return formatter.Deserialize(mStream);
                }
            }
            catch
            {
                return this.MemberwiseClone();
            }
        }
    }
}
