using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualTimetable
{
    public partial class Form1 : Form
    {
        Timetable timetable = new Timetable();
        DepartingfromStation DfS = new DepartingfromStation();        
        public Form1()
        {
            InitializeComponent();
            panelUserControll.Controls.Add(timetable);
        }
       private void timetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUserControll.Controls.Clear();
            panelUserControll.Controls.Add(timetable);
        }

        private void departingFromStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUserControll.Controls.Clear();
            panelUserControll.Controls.Add(DfS);
        }
    }
}
