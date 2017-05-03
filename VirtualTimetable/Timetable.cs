using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace VirtualTimetable
{
    public partial class Timetable : UserControl
    {
        public Timetable()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Transport Interface used for Station-Search
        /// </summary>
        public ITransport trans = new Transport();

        /// <summary>
        /// Autocomplete used for the autocomplete of the Combobox for Timetable User Control
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
        private void Timetable_Load(object sender, EventArgs e)
        {
            cBoxFrom.Focus();
            cBoxFrom.Items.Clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Connections connections = new Connections();
            connections = trans.GetConnections(cBoxFrom.Text, cBoxTo.Text);
            listResults.Items.Clear();
            foreach (Connection con in connections.ConnectionList)
            {
                DateTime departure = Convert.ToDateTime(con.From.Departure);
                string depTime = departure.ToShortTimeString();

                DateTime arrival = Convert.ToDateTime(con.To.Arrival);
                string arrTime = arrival.ToShortTimeString();

                string[] durration = con.Duration.Split('d')[1].Split(':');

                string.Format(con.From.Departure );
                listResults.Items.Add("From: " + con.From.Station.Name + "   To: " + con.To.Station.Name + "   Duration: " + durration[0] + ":" + durration[1] + " min   Departure: " + depTime + "   Arrival: " + arrTime);
                listResults.Items.Add("");
            }
        }
        private void cBoxFrom_TextUpdate(object sender, EventArgs e)
        {
            Autocomplete(cBoxFrom);
        }

        private void cBoxTo_TextUpdate(object sender, EventArgs e)
        {
            Autocomplete(cBoxTo);
        }
    }
}
