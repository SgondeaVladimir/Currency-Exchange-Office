using System;
using System.Windows.Forms;
using _2_1059_SGONDEA_VLADIMIR.Models;
using _2_1059_SGONDEA_VLADIMIR.DataAccess;

namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    public partial class CasieriForm : Form
    {
        private CasierRepository repository;
        private int idSelectat = 0;

        public CasieriForm()
        {
            InitializeComponent();
            repository = new CasierRepository();
        }

        private void CasieriForm_Load(object sender, EventArgs e)
        {
            IncarcaDate();
        }

        private void IncarcaDate()
        {
            dgvCasieri.DataSource = repository.GetAll();
            dgvCasieri.ClearSelection();
            CurataCampuri();
        }

        private void CurataCampuri()
        {
            tbNume.Clear();
            tbCodAngajat.Clear();
            idSelectat = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNume.Text) || string.IsNullOrWhiteSpace(tbCodAngajat.Text))
            {
                MessageBox.Show("Completati toate campurile!");
                return;
            }

            Casier c = new Casier { Nume = tbNume.Text, CodAngajat = tbCodAngajat.Text };
            repository.Add(c);
            IncarcaDate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0) return;

            Casier c = new Casier { Id = idSelectat, Nume = tbNume.Text, CodAngajat = tbCodAngajat.Text };
            repository.Update(c);
            IncarcaDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0) return;

            if (MessageBox.Show("Sigur stergeti casierul?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repository.Delete(idSelectat);
                IncarcaDate();
            }
        }

        private void dgvCasieri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCasieri.Rows[e.RowIndex];
                idSelectat = Convert.ToInt32(row.Cells["Id"].Value);
                tbNume.Text = row.Cells["Nume"].Value?.ToString();
                tbCodAngajat.Text = row.Cells["CodAngajat"].Value?.ToString();
            }
        }
    }
}