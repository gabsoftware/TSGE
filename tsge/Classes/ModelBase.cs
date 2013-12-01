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
    using System.Collections.Generic;
    using System.ComponentModel;

    [Serializable]
    public class ModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Internal properties container.
        /// </summary>
        private readonly Dictionary<string, object> _properties;

        /// <summary>
        /// Event triggered when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ModelBase()
        {
            this._properties = new Dictionary<String, Object>();
        }

        /// <summary>
        /// Method used to raise the PropertyChanged event.
        /// </summary>
        /// <param name="prop"></param>
        public void OnPropertyChanged(String prop)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Method to raise the PropertyChanged event.
        /// </summary>
        /// <param name="property"></param>
        protected void RaisePropertyChanged(string property)
        {
            if (string.IsNullOrEmpty(property))
                throw new ArgumentNullException(property);
            this.OnPropertyChanged(property);
        }

        /// <summary>
        /// Gets a property from the internal container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="prop"></param>
        /// <returns></returns>
        protected T Get<T>(String prop)
        {
            if (this._properties.ContainsKey(prop))
                return (T)this._properties[prop];
            return default(T);
        }

        /// <summary>
        /// Sets a property in the internal container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="prop"></param>
        /// <param name="val"></param>
        protected void Set<T>(String prop, T val)
        {
            var curr = this.Get<T>(prop);
            if (Equals(curr, val))
                return;

            this._properties[prop] = val;
            this.OnPropertyChanged(prop);
        }
    }
}
