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
    public partial class ListaAut : Form
    {
        public ListaAut()
        {
            InitializeComponent();
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carRentalDataSet);

        }

        private void ListaAut_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'carRentalDataSet.Cars' . Możesz go przenieść lub usunąć.
            this.carsTableAdapter.Fill(this.carRentalDataSet.Cars);

        }
    }
}
