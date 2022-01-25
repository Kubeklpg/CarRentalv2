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
    public partial class DodawanieKlientow : Form
    {
        public DodawanieKlientow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clientsTableAdapter1.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            MessageBox.Show("Dodano Klienta");
        }
    }
}
