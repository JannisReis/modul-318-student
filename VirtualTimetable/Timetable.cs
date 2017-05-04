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
        /// Station-Search
        /// </summary>
        public ITransport trans = new Transport();
        /// <summary>
        /// Connection-Search
        /// </summary>
        public Connections connections = new Connections();
        private void Timetable_Load(object sender, EventArgs e)
        {
            cBoxFrom.Focus();
            cBoxFrom.Items.Clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listResultsTimetable.Items.Clear();
            ListViewHelper listView = new ListViewHelper();
            listView.CreateListView(listResultsTimetable);
            listView.FillListViewTimetable(cBoxFrom,cBoxTo, listResultsTimetable);   
        }
        private void cBoxFrom_TextUpdate(object sender, EventArgs e)
        {
            Autocomplete Autocomplete = new Autocomplete();
            Autocomplete.autocomplete(cBoxFrom);
        }
        private void cBoxTo_TextUpdate(object sender, EventArgs e)
        {
            Autocomplete Autocomplete = new Autocomplete();
            Autocomplete.autocomplete(cBoxTo);
        }
    }
}
