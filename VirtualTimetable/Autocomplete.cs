using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace VirtualTimetable
{
    class AutocompleteHelper
    {
        /// <summary>
        /// Station-Search
        /// </summary>
        public ITransport trans = new Transport();
        /// <summary>
        /// Connection-Search
        /// </summary>
        public Connections connections = new Connections();
        /// <summary>
        /// Autocomplete used for the autocomplete of the Combobox for User Controls
        /// </summary>
        public void Autocomplete(ComboBox cb)
        {
            if (cb.Text.Count() > 2)
            {
                var searchFrom = cb.Text;
                var stationsFrom = trans.GetStations(searchFrom + ",");
                cb.Items.Clear();

                foreach (Station station in stationsFrom.StationList)
                {
                    string sFrom = Convert.ToString(station);
                    cb.SelectionStart = cb.Text.Length;
                    cb.Items.Add(sFrom);
                    cb.DroppedDown = true;
                }
            }
        }
    }
}
