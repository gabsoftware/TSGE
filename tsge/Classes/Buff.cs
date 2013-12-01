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
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Xml.Serialization;

    [Serializable]
    public class Buff : ModelBase, ICloneable
    {
        /// <summary>
        /// Updates this buff entry to the given buff.
        /// </summary>
        /// <param name="buffId"></param>
        public void SetBuff(int buffId)
        {
            // Obtain the buff info..
            var buff = Terraria.Instance.Buffs.SingleOrDefault(b => b.Id == buffId);
            if (buff == null) return;

            // Set this buff info..
            this.Duration = buff.Duration;
            this.Icon = new Uri(string.Format(@"{0}\Data\Buffs\buff_{1}.png", AppDomain.CurrentDomain.BaseDirectory, buff.Id), UriKind.Absolute);
            this.Id = buff.Id;
            this.Name = buff.Name;
            this.Tooltip = buff.Tooltip;
        }

        /// <summary>
        /// Gets or sets the id property.
        /// </summary>
        [XmlAttribute("index")]
        public int Id
        {
            get { return this.Get<int>("Id"); }
            set
            {
                this.Set("Id", value);
                this.Icon = new Uri(string.Format(@"{0}\Data\Buffs\buff_{1}.png", AppDomain.CurrentDomain.BaseDirectory, value), UriKind.Absolute);
            }
        }

        /// <summary>
        /// Gets or sets the name property.
        /// </summary>
        [XmlAttribute("name")]
        public string Name
        {
            get { return this.Get<string>("Name"); }
            set { this.Set("Name", value); }
        }

        /// <summary>
        /// Gets or sets the tooltip property.
        /// </summary>
        [XmlAttribute("tooltip")]
        public string Tooltip
        {
            get { return this.Get<string>("Tooltip"); }
            set { this.Set("Tooltip", value); }
        }

        /// <summary>
        /// Gets or sets the duration property.
        /// </summary>
        [XmlAttribute("duration")]
        public int Duration
        {
            get { return this.Get<int>("Duration"); }
            set
            {
                this.Set("Duration", value);
                this.DurationString = "Refreshing..";
            }
        }

        /// <summary>
        /// Gets or sets the icon property.
        /// </summary>
        [XmlIgnore]
        public Uri Icon
        {
            get { return this.Get<Uri>("Icon"); }
            set { this.Set("Icon", value); }
        }

        /// <summary>
        /// Gets or sets the duration string property.
        /// </summary>
        [XmlIgnore]
        public string DurationString
        {
            get
            {
                this.Set("DurationString", string.Format("{0} second(s)", this.Duration / 60));
                return this.Get<string>("DurationString");
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                this.Set("DurationString", string.Format("{0} second(s)", this.Duration / 60));
            }
        }

        /// <summary>
        /// Tostring override to return this buffs name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
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
