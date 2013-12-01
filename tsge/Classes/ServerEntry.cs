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
    public class ServerEntry : ModelBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ServerEntry()
        {
            this.ServerAddress = -1;
            this.ServerName = string.Empty;
            this.SpawnX = -1;
            this.SpawnY = -1;
        }

        /// <summary>
        /// Gets or sets the server address of this server entry.
        /// </summary>
        public int ServerAddress
        {
            get { return this.Get<int>("ServerAddress"); }
            set { this.Set("ServerAddress", value); }
        }

        /// <summary>
        /// Gets or sets the server name of this server entry.
        /// </summary>
        public string ServerName
        {
            get { return this.Get<string>("ServerName"); }
            set { this.Set("ServerName", value); }
        }

        /// <summary>
        /// Gets or sets the x spawn location of this server entry.
        /// </summary>
        public int SpawnX
        {
            get { return this.Get<int>("SpawnX"); }
            set { this.Set("SpawnX", value); }
        }

        /// <summary>
        /// Gets or sets the y spawn location of this server entry.
        /// </summary>
        public int SpawnY
        {
            get { return this.Get<int>("SpawnY"); }
            set { this.Set("SpawnY", value); }
        }
    }
}
