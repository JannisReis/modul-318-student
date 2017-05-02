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
        private void Timetable_Load(object sender, EventArgs e)
        {
            cBoxFrom.Focus();
        }

        private void cBoxFrom_TextUpdate(object sender, EventArgs e)
        {
            var suche = cBoxFrom.Text;
            var stations = trans.GetStations(suche);

            foreach (Station station in stations.StationList)
            {
                string s = Convert.ToString(station);
                MessageBox.Show(s);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
