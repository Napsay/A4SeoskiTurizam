using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeoskiTurizam
{
    public partial class FStatistika : Form
    {
        public FStatistika()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            int broj = (int)numericUpDown1.Value;
           
            try
            {
                DataTable dt = Statistika.StatistikaKlijenata(broj);
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                     dataGridView1.Columns[dataGridView1.ColumnCount-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("U evidenciji nema klijenata koji su uplatili  izabran broj aranžmana.", "Informacija");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FStatistika_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
