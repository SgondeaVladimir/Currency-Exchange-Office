using _2_1059_SGONDEA_VLADIMIR.DataAccess;
using _2_1059_SGONDEA_VLADIMIR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    public partial class ValuteForm : Form
    {
        private ValutaRepository repository;
        private int idSelectat = 0; // Retin ID-ul randului selectat din tabel

        public ValuteForm()
        {
            InitializeComponent();
            repository = new ValutaRepository();
        }

        // Eveniment care se declanseaza cand se incarca fereastra
        private void ValuteForm_Load(object sender, EventArgs e)
        {
            IncarcaDate();
        }

        // Functie care reimprospateaza tabelul
        private void IncarcaDate()
        {
            dgvValute.DataSource = repository.GetAll();
            dgvValute.ClearSelection();
            CurataCampuri();
        }

        private void CurataCampuri()
        {
            tbCod.Clear();
            tbDenumire.Clear();
            idSelectat = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCod.Text) || string.IsNullOrWhiteSpace(tbDenumire.Text))
            {
                MessageBox.Show("Completati toate campurile!");
                return;
            }

            Valuta v = new Valuta { Cod = tbCod.Text, Denumire = tbDenumire.Text };
            repository.Add(v);

            MessageBox.Show("Valuta adaugata cu succes!");
            IncarcaDate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0)
            {
                MessageBox.Show("Selectati o valuta din tabel pentru a o modifica!");
                return;
            }

            Valuta v = new Valuta { Id = idSelectat, Cod = tbCod.Text, Denumire = tbDenumire.Text };
            repository.Update(v);

            MessageBox.Show("Valuta modificata cu succes!");
            IncarcaDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0)
            {
                MessageBox.Show("Selectati o valuta din tabel pentru a o sterge!");
                return;
            }

            if (MessageBox.Show("Sigur doriti sa stergeti?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repository.Delete(idSelectat);
                IncarcaDate();
            }
        }

        // Eveniment la click pe o celula/rand din tabel (pentru a prelua datele in TextBox-uri)
        private void dgvValute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvValute.Rows[e.RowIndex];
                idSelectat = Convert.ToInt32(row.Cells["Id"].Value);
                tbCod.Text = row.Cells["Cod"].Value.ToString();
                tbDenumire.Text = row.Cells["Denumire"].Value.ToString();
            }
        }
    }
}
