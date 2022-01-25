using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalv2
{
    public partial class DodawanieAut : Form
    {
        public DodawanieAut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carsTableAdapter1.Insert(textBox1.Text,textBox2.Text,1,Convert.ToDouble(textBox3.Text));
            MessageBox.Show("Dodano Auto");
        }
    }
}
