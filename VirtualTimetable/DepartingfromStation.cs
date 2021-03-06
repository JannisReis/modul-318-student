﻿using System;
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
            ListViewHelper listView = new ListViewHelper();
            listView.CreateListView(listResultsDfS);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cBoxFrom.Text == "")
            {
                MessageBox.Show("Please enter a startstation!");
            }
            else
            {
                try
                {
                    listResultsDfS.Items.Clear();
                    ListViewHelper listView = new ListViewHelper();
                    listView.FillListViewDfS(cBoxFrom, listResultsDfS);
                }
                catch
                {
                    MessageBox.Show("There are too many serverrequests!\nPlease wait... ");
                }
            }
        }

        private void cBoxFrom_TextUpdate(object sender, EventArgs e)
        {
            AutocompleteHelper autocomplete = new AutocompleteHelper();
            autocomplete.Autocomplete(cBoxFrom);
        }
    }
}
