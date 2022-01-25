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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        }

        private void listaAutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAut listaAut = new ListaAut();

            listaAut.MdiParent = this;
            listaAut.Show();
        }

        private void listaKlientówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaKlientow listaKlientow = new ListaKlientow();
            listaKlientow.MdiParent = this;
            listaKlientow.Show();
        }

        private void dodawanieAutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodawanieAut dodawanieAut = new DodawanieAut();
            dodawanieAut.MdiParent = this;
            dodawanieAut.Show();
        }

        private void dodawanieKlientowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodawanieKlientow dodawanieKlientow = new DodawanieKlientow();
            dodawanieKlientow.MdiParent = this;
            dodawanieKlientow.Show();
        }

        private void wypożyczAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kalkulatorFinansowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KalkulatorFinansowy kalkulator = new KalkulatorFinansowy();
            kalkulator.MdiParent = this;
            kalkulator.Show();
        }
    }
    
}
