using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SeoskiTurizam
{
    public partial class FGlavna : Form
    { 
        static string erorFile = "error.txt";
        StreamWriter file = File.AppendText(erorFile);
       
        public FGlavna()
        {
            InitializeComponent();
        }
        private void Prikazi(Selo x)
        {
            txtSifra.Text = x.SeloID.ToString();
            txtNaziv.Text = x.Naziv;
            cbxGrad.SelectedValue = x.GradID;
            

        }
        private void OcistiPodatke()
        {
            txtSifra.Text = String.Empty;
            txtNaziv.Text = String.Empty;
            cbxGrad.SelectedIndex = -1;
            cbxGrad.Text = "Izaberi grad...";
            listView1.SelectedItems.Clear();

        }
        private void PopuniListView(List<Selo> lista)
        {
            listView1.Items.Clear();
            foreach (Selo s in lista)
            {
                string[] podaci = { s.SeloID.ToString(), s.Naziv, s.Grad ,s.GradID.ToString()};
                ListViewItem lvi = new ListViewItem(podaci);
                listView1.Items.Add(lvi);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolVauceri.Text = string.Format("Dodeli\nvaučere"); 
            cbxGrad.DisplayMember = "Grad";
            cbxGrad.ValueMember = "GradId";
            try
            {

                cbxGrad.DataSource = Grad.UcitajSve();
              
                listView1.FullRowSelect = true;
                List<Selo> lista = Selo.UcitajSve();
                PopuniListView(lista);
                listView1.Items[0].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

        
            Selo x = new Selo();
            x.SeloID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            x.Naziv=listView1.SelectedItems[0].SubItems[1].Text;
            x.GradID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
            x.Grad = listView1.SelectedItems[0].SubItems[2].Text;
            Prikazi(x);

            
        }

        private void toolIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
            file.Close();
        }
        bool prvi = false;
        private void txtSifra_TextChanged(object sender, EventArgs e)
       {
            if (prvi)
                return;
            string sifra = txtSifra.Text;
           

            var item = listView1.FindItemWithText(sifra, false, 0, false);
            if (item != null)
            {
                listView1.SelectedItems.Clear();
                item.Selected = true;
                               
               
                txtSifra.Select();
                listView1.TopItem = listView1.SelectedItems[0];
               
            }
            else
            {
                MessageBox.Show("Nije pronadjeno selo sa unetom sifrom");

                prvi = true;
                DateTime datum = DateTime.Now;
                
                file.WriteLine("Datum greške: {0}. Greška:Nije pronadjeno selo sa unetom sifrom  {1}",datum.ToString("dd.MM.yyyy"),sifra);
                
                OcistiPodatke();
                prvi = false;
            }
            
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                Selo s = new Selo();
                s.SeloID = int.Parse(txtSifra.Text);
                if (txtNaziv.Text != string.Empty) s.Naziv = txtNaziv.Text;
                else throw new Exception("Morate uneti naziv sela");
                if (cbxGrad.SelectedIndex > -1) s.GradID = (int)cbxGrad.SelectedValue;
                else throw new Exception("Morate izabrati grad.");
                if (s.Izmeni())
                {
                    MessageBox.Show("Uspesna izmena");
                    PopuniListView(Selo.UcitajSve());
                    ListViewItem item1 = listView1.FindItemWithText(txtSifra.Text, false, 0, false);
                    item1.Selected = true;

                    listView1.Select();
                    listView1.TopItem = listView1.SelectedItems[0];

                }
                else throw new Exception("Izmena nije izvrsena");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DateTime datum = DateTime.Now;

                file.WriteLine("Datum greške: {0}. Greška: {1}", datum.ToString("dd.MM.yyyy"), ex.Message);
              
            }
        }

        private void toolVauceri_Click(object sender, EventArgs e)
        {
            FStatistika frmStat = new FStatistika();
            frmStat.ShowDialog();
        }

        private void toolAplikacija_Click(object sender, EventArgs e)
        {
            FAplikacija frmApl = new FAplikacija();
            frmApl.ShowDialog();
        }

        private void FGlavna_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            file.Close(); 
           
        }
    }
}
