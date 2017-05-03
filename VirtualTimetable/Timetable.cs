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
        private void Timetable_Load(object sender, EventArgs e)
        {
            cBoxFrom.Focus();
            cBoxFrom.Items.Clear();
        }
        private void cBoxFrom_TextUpdate(object sender, EventArgs e)
        {
            if (cBoxFrom.Text.Count() > 2)
            {
                var searchFrom = cBoxFrom.Text;
                var stationsFrom = trans.GetStations(searchFrom + ",");
                cBoxFrom.Items.Clear();

                foreach (Station station in stationsFrom.StationList)
                {
                    string sFrom = Convert.ToString(station);
                    cBoxFrom.SelectionStart = cBoxFrom.Text.Length;
                    cBoxFrom.Items.Add(sFrom);
                    cBoxFrom.DroppedDown = true;
                }
            }
        }

        private void cBoxTo_TextUpdate(object sender, EventArgs e)
        {
            if (cBoxTo.Text.Count() > 2)
            {
                var searchTo = cBoxTo.Text;
                var stationsTo = trans.GetStations(searchTo + ",");
                cBoxTo.Items.Clear();

                foreach (Station station in stationsTo.StationList)
                {
                    string sTo = Convert.ToString(station);
                    cBoxTo.SelectionStart = cBoxTo.Text.Length;
                    cBoxTo.Items.Add(sTo);
                    cBoxTo.DroppedDown = true;
                }
            }
        }
    }
    }

