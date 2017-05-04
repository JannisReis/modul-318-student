using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatchSample
{

    class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                throw new MyException("mein Fehler");

                short i = 0;
                int s = 100000;

                i = Convert.ToInt16(s);

            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Konvertierungsfehler: " + ex.Message);
            }
            catch (MyException ex)
            {
                MessageBox.Show("Meine: " + ex.Message + "/" + ex.GetType().ToString());
            }
        }
    }
}
