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
    public partial class KalkulatorFinansowy : Form
    {
        public KalkulatorFinansowy()
        {
            InitializeComponent();
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carRentalDataSet);

        }

        private void KalkulatorFinansowy_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'carRentalDataSet.Cars' . Możesz go przenieść lub usunąć.
            this.carsTableAdapter.Fill(this.carRentalDataSet.Cars);

        }

        private void carsDataGridView_Click(object sender, EventArgs e)
        {

        }

        private void carsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void carsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = carsDataGridView.CurrentCell.RowIndex;
            int columnIndex = carsDataGridView.CurrentCell.ColumnIndex;

            textBox1.Text = carsDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            textBox2.Text = carsDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            textBox3.Text = carsDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = trackBar1.Value.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox4.Text) < 30)
                {
                    trackBar1.Value = 60;
                }
                else
                {
                    trackBar1.Value = Convert.ToInt32(textBox4.Text);
                }
            }
            catch { }
        }
    }
}
