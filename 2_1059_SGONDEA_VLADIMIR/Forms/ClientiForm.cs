using System;
using System.Windows.Forms;
using _2_1059_SGONDEA_VLADIMIR.Models;
using _2_1059_SGONDEA_VLADIMIR.DataAccess;

namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    public partial class ClientiForm : Form
    {
        private ClientRepository repository;
        private int idSelectat = 0;

        public ClientiForm()
        {
            InitializeComponent();
            repository = new ClientRepository();
        }

        private void ClientiForm_Load(object sender, EventArgs e)
        {
            ThemeManager.AplicaTema(this);
            IncarcaDate();
        }

        private void IncarcaDate()
        {
            dgvClienti.DataSource = repository.GetAll();
            dgvClienti.ClearSelection();
            CurataCampuri();
        }

        private void CurataCampuri()
        {
            tbNume.Clear();
            tbCNP.Clear();
            tbTelefon.Clear();
            idSelectat = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNume.Text) || string.IsNullOrWhiteSpace(tbCNP.Text))
            {
                MessageBox.Show("Numele si CNP-ul sunt obligatorii!");
                return;
            }

            Client c = new Client { NumeComplet = tbNume.Text, CNP = tbCNP.Text, Telefon = tbTelefon.Text };
            repository.Add(c);
            MessageBox.Show("Client adaugat cu succes!");
            IncarcaDate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0)
            {
                MessageBox.Show("Selectati un client din tabel!");
                return;
            }

            Client c = new Client { Id = idSelectat, NumeComplet = tbNume.Text, CNP = tbCNP.Text, Telefon = tbTelefon.Text };
            repository.Update(c);
            MessageBox.Show("Client modificat cu succes!");
            IncarcaDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0) return;

            if (MessageBox.Show("Sigur doriti sa stergeti clientul?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repository.Delete(idSelectat);
                IncarcaDate();
            }
        }

        private void dgvClienti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClienti.Rows[e.RowIndex];
                idSelectat = Convert.ToInt32(row.Cells["Id"].Value);
                tbNume.Text = row.Cells["NumeComplet"].Value?.ToString();
                tbCNP.Text = row.Cells["CNP"].Value?.ToString();
                tbTelefon.Text = row.Cells["Telefon"].Value?.ToString();
            }
        }
    }
}