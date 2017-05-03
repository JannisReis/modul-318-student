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
        public ITransport trans = new Transport();

        //when this UserControll is Loaded the textbox From is selected and cleared
        private void Timetable_Load(object sender, EventArgs e)
        {
            cBoxFrom.Focus();
            cBoxFrom.Items.Clear();
        }
        //Autocorrect after more than 3 Letters
        private void cBoxFrom_TextUpdate(object sender, EventArgs e)
        {
            if (cBoxFrom.Text.Count() > 2)
            {
                var suche = cBoxFrom.Text;
                var stations = trans.GetStations(suche + ",");
                cBoxFrom.
                cBoxFrom.Items.Clear();

                foreach (Station station in stations.StationList)
                {
                    string s = Convert.ToString(station);
                    cBoxFrom.Items.Add(s);
                    cBoxFrom.DroppedDown = true;
                }
            }
        }
    }
}
