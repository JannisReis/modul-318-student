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
        public Connections connections = new Connections();
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
        /// <summary>
        /// CreateListView used to Create the Listview
        /// </summary>
        public void CreateListView()
        {
            listResults.View = View.Details;
            listResults.FullRowSelect = true;
            listResults.Columns.Add("", 18);
            listResults.Columns.Add("From:", 99);
            listResults.Columns.Add("To:", 99);
            listResults.Columns.Add("Durration:", 87);
            listResults.Columns.Add("Departure:", 87);
            listResults.Columns.Add("Arrival:", 90);
        }
        public void FillListView()
        {
            int x = 0;
            foreach (Connection con in connections.ConnectionList)
            {
                DateTime departure = Convert.ToDateTime(con.From.Departure);
                string depTime = departure.ToShortTimeString();

                DateTime arrival = Convert.ToDateTime(con.To.Arrival);
                string arrTime = arrival.ToShortTimeString();

                string[] durTime = con.Duration.Split('d')[1].Split(':');

                string.Format(con.From.Departure);
                x++;
                string num = Convert.ToString(x);
                ListViewItem num1 = new ListViewItem(num);

                num1.SubItems.Add(con.From.Station.Name);
                num1.SubItems.Add(con.To.Station.Name);
                num1.SubItems.Add(durTime[0] + ":" + durTime[1]);
                num1.SubItems.Add(depTime);
                num1.SubItems.Add(arrTime);
                listResults.Items.Add(num1);
                
            }
        }
        private void Timetable_Load(object sender, EventArgs e)
        {
            cBoxFrom.Focus();
            cBoxFrom.Items.Clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            connections = trans.GetConnections(cBoxFrom.Text, cBoxTo.Text);
            listResults.Items.Clear();
            CreateListView();
            FillListView();
            
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
