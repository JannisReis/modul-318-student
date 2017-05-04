using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace VirtualTimetable
{
    class ListViewHelper
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
        /// CreateListView used to Create the Listview for the Timetable User Controll
        /// </summary>
        public void CreateListView(System.Windows.Forms.ListView lb)
        {
            if (lb.Name == "listResultsTimetable")
            {
                lb.View = View.Details;
                lb.FullRowSelect = true;
                lb.Columns.Add("", 18);
                lb.Columns.Add("From:", 99);
                lb.Columns.Add("To:", 99);
                lb.Columns.Add("Duration:", 87);
                lb.Columns.Add("Departure:", 87);
                lb.Columns.Add("Arrival:", 90);
            }
            else
            {
                lb.View = View.Details;
                lb.FullRowSelect = true;
                lb.Columns.Add("", 1);
                lb.Columns.Add("To:", 99);
                lb.Columns.Add("Operator:", 87);
                lb.Columns.Add("Daparture:", 90);
            }
        }
        /// <summary>
        /// FillListView used to write the Data into the ListView in Timetable User Controll
        /// </summary>
        public void FillListViewTimetable(ComboBox cbfrom,ComboBox cbTo, System.Windows.Forms.ListView lb)
        {
            connections = trans.GetConnections(cbfrom.Text, cbTo.Text);
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
                lb.Items.Add(num1);

            }
        }
        /// <summary>
        /// FillListView used to write the Data into the ListView in Timetable User Controll
        /// </summary>
        public void FillListViewDfS(ComboBox cbfrom, System.Windows.Forms.ListView lb)
        {
            StationBoardRoot stationBoardRoot = new StationBoardRoot();
            stationBoardRoot = trans.GetStationBoard(cbfrom.Text, cbfrom.Text);
            foreach (StationBoard sb in stationBoardRoot.Entries)
            {
                DateTime departure = Convert.ToDateTime(sb.Stop.Departure);
                string depTime = departure.ToShortTimeString();

                ListViewItem num1 = new ListViewItem();

                num1.SubItems.Add(sb.To);
                num1.SubItems.Add(sb.Name);
                num1.SubItems.Add(depTime);
                lb.Items.Add(num1);

            }
        }
    }
}
