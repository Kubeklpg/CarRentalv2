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
    public partial class ListaKlientow : Form
    {
        public ListaKlientow()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carRentalDataSet);

        }

        private void ListaKlientow_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'carRentalDataSet.Clients' . Możesz go przenieść lub usunąć.
            this.clientsTableAdapter.Fill(this.carRentalDataSet.Clients);

        }
    }
}
