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
    public partial class DepartingfromStation : UserControl
    {
        public DepartingfromStation()
        {
            InitializeComponent();
            ITransport transport;
        }

        private void DepartingfromStation_Load(object sender, EventArgs e)
        {
            cBoxFrom.Focus();
            
        }
    }
}
