using System;
using System.Windows.Forms;
using _2_1059_SGONDEA_VLADIMIR.Models;
using _2_1059_SGONDEA_VLADIMIR.DataAccess;

namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    public partial class CursuriValutareForm : Form
    {
        private CursValutarRepository cursRepo;
        private ValutaRepository valutaRepo; 
        private int idSelectat = 0;

        public CursuriValutareForm()
        {
            InitializeComponent();
            cursRepo = new CursValutarRepository();
            valutaRepo = new ValutaRepository();
        }

        private void CursuriValutareForm_Load(object sender, EventArgs e)
        {
            IncarcaValuteInComboBox();
            IncarcaDate();
        }
        private void IncarcaValuteInComboBox()
        {
            cbValuta.DataSource = valutaRepo.GetAll();
            cbValuta.DisplayMember = "Cod";
            cbValuta.ValueMember = "Id";
        }

        private void IncarcaDate()
        {
            dgvCursuri.DataSource = cursRepo.GetAll();
            dgvCursuri.ClearSelection();
            CurataCampuri();
        }

        private void CurataCampuri()
        {
            tbCumparare.Clear();
            tbVanzare.Clear();
            dtpData.Value = DateTime.Now;
            if (cbValuta.Items.Count > 0) cbValuta.SelectedIndex = 0;
            idSelectat = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbValuta.SelectedValue == null || string.IsNullOrWhiteSpace(tbCumparare.Text) || string.IsNullOrWhiteSpace(tbVanzare.Text))
            {
                MessageBox.Show("Completati toate campurile!");
                return;
            }

            CursValutar c = new CursValutar
            {
                ValutaId = Convert.ToInt32(cbValuta.SelectedValue),
                DataCotatiei = dtpData.Value,
                CursCumparare = Convert.ToDecimal(tbCumparare.Text),
                CursVanzare = Convert.ToDecimal(tbVanzare.Text)
            };

            cursRepo.Add(c);
            IncarcaDate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0) return;

            CursValutar c = new CursValutar
            {
                Id = idSelectat,
                ValutaId = Convert.ToInt32(cbValuta.SelectedValue),
                DataCotatiei = dtpData.Value,
                CursCumparare = Convert.ToDecimal(tbCumparare.Text),
                CursVanzare = Convert.ToDecimal(tbVanzare.Text)
            };

            cursRepo.Update(c);
            IncarcaDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0) return;

            if (MessageBox.Show("Sigur stergeti cursul?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cursRepo.Delete(idSelectat);
                IncarcaDate();
            }
        }

        private void dgvCursuri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCursuri.Rows[e.RowIndex];
                idSelectat = Convert.ToInt32(row.Cells["Id"].Value);

                cbValuta.SelectedValue = row.Cells["ValutaId"].Value;
                dtpData.Value = Convert.ToDateTime(row.Cells["DataCotatiei"].Value);
                tbCumparare.Text = row.Cells["CursCumparare"].Value.ToString();
                tbVanzare.Text = row.Cells["CursVanzare"].Value.ToString();
            }
        }
    }
}