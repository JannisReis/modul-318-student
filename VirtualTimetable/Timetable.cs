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
            if(cBoxFrom.Text == "" && cBoxTo.Text == "")
            {
                MessageBox.Show("Please enter s start- and an endstation.");
            }
            else  if (cBoxFrom.Text == "")
            {
                MessageBox.Show("Please enter a startstation!");
            }
            else if(cBoxTo.Text == "")
            {
                MessageBox.Show("Please enter an endstation!");
            }
            else
            {
                try
                {
                    listResultsTimetable.Items.Clear();
                    ListViewHelper listView = new ListViewHelper();
                    listView.CreateListView(listResultsTimetable);
                    listView.FillListViewTimetable(cBoxFrom, cBoxTo, listResultsTimetable, dTPicker);
                }
                catch
                {
                    MessageBox.Show("There are too many serverrequests!\nPlease wait... ");
                }
            }
        }
        private void cBoxFrom_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                AutocompleteHelper autocomplete = new AutocompleteHelper();
                autocomplete.Autocomplete(cBoxFrom);
            }
            catch
            {
                MessageBox.Show("There are too many serverrequests!\nPlease wait... ");
            }
        }
        private void cBoxTo_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                AutocompleteHelper autocomplete = new AutocompleteHelper();
                autocomplete.Autocomplete(cBoxTo);
            }
            catch
            {
                MessageBox.Show("There are too many serverrequests!\nPlease wait... ");
            }
        }
    }
}
