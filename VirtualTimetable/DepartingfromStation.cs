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
        }
        /// <summary>
        /// Transport Interface used for Station-Search
        /// </summary>
        public ITransport trans = new Transport();
        private void DepartingfromStation_Load(object sender, EventArgs e)
        {
            cBoxFrom.Focus();
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listResultsDfS.Items.Clear();
            ListViewHelper listView = new ListViewHelper();
            listView.CreateListView(listResultsDfS);
            listView.FillListViewDfS(cBoxFrom, listResultsDfS);
        }

        private void cBoxFrom_TextUpdate(object sender, EventArgs e)
        {
            Autocomplete Autocomplete = new Autocomplete();
            Autocomplete.autocomplete(cBoxFrom);
        }
    }
}
