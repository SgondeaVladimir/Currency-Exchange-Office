using System;
using System.Linq;
using System.Windows.Forms;
using _2_1059_SGONDEA_VLADIMIR.Models;
using _2_1059_SGONDEA_VLADIMIR.DataAccess;

namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    public partial class TranzactiiForm : Form
    {
        private TranzactieRepository tranzRepo;
        private ClientRepository clientRepo;
        private ValutaRepository valutaRepo;
        private CasierRepository casierRepo;
        private int idSelectat = 0;

        public TranzactiiForm()
        {
            InitializeComponent();
            tranzRepo = new TranzactieRepository();
            clientRepo = new ClientRepository();
            valutaRepo = new ValutaRepository();
            casierRepo = new CasierRepository();
        }

        private void TranzactiiForm_Load(object sender, EventArgs e)
        {
            IncarcaToateComboBoxurile();
            IncarcaDate();
        }

        private void IncarcaToateComboBoxurile()
        {
            cbClient.DataSource = clientRepo.GetAll();
            cbClient.DisplayMember = "NumeComplet";
            cbClient.ValueMember = "Id";

            cbValuta.DataSource = valutaRepo.GetAll();
            cbValuta.DisplayMember = "Cod";
            cbValuta.ValueMember = "Id";

            cbCasier.DataSource = casierRepo.GetAll();
            cbCasier.DisplayMember = "Nume";
            cbCasier.ValueMember = "Id";

            cbTipTranzactie.DataSource = Enum.GetValues(typeof(TipTranzactie));
        }

        private void IncarcaDate()
        {
            AplicaFiltre();
            CurataCampuri(); 
            dgvTranzactii.ClearSelection();
            CurataCampuri();
        }

        private void CurataCampuri()
        {
            tbSumaValuta.Clear();
            tbTotalLei.Clear();
            dtpData.Value = DateTime.Now;

            if (cbClient.Items.Count > 0) cbClient.SelectedIndex = 0;
            if (cbValuta.Items.Count > 0) cbValuta.SelectedIndex = 0;
            if (cbCasier.Items.Count > 0) cbCasier.SelectedIndex = 0;
            if (cbTipTranzactie.Items.Count > 0) cbTipTranzactie.SelectedIndex = 0;

            idSelectat = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSumaValuta.Text) || string.IsNullOrWhiteSpace(tbTotalLei.Text))
            {
                MessageBox.Show("Completati sumele!");
                return;
            }

            Tranzactie t = new Tranzactie
            {
                ClientId = Convert.ToInt32(cbClient.SelectedValue),
                ValutaId = Convert.ToInt32(cbValuta.SelectedValue),
                CasierId = Convert.ToInt32(cbCasier.SelectedValue),
                DataTranzactie = dtpData.Value,
                SumaValuta = Convert.ToDecimal(tbSumaValuta.Text),
                Tip = (TipTranzactie)cbTipTranzactie.SelectedItem,
                SumaTotalaLei = Convert.ToDecimal(tbTotalLei.Text)
            };

            tranzRepo.Add(t);
            IncarcaDate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0) return;

            Tranzactie t = new Tranzactie
            {
                Id = idSelectat,
                ClientId = Convert.ToInt32(cbClient.SelectedValue),
                ValutaId = Convert.ToInt32(cbValuta.SelectedValue),
                CasierId = Convert.ToInt32(cbCasier.SelectedValue),
                DataTranzactie = dtpData.Value,
                SumaValuta = Convert.ToDecimal(tbSumaValuta.Text),
                Tip = (TipTranzactie)cbTipTranzactie.SelectedItem,
                SumaTotalaLei = Convert.ToDecimal(tbTotalLei.Text)
            };

            tranzRepo.Update(t);
            IncarcaDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0) return;

            if (MessageBox.Show("Sigur stergeti tranzactia?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tranzRepo.Delete(idSelectat);
                IncarcaDate();
            }
        }

        private void dgvTranzactii_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTranzactii.Rows[e.RowIndex];
                idSelectat = Convert.ToInt32(row.Cells["Id"].Value);

                cbClient.SelectedValue = row.Cells["ClientId"].Value;
                cbValuta.SelectedValue = row.Cells["ValutaId"].Value;
                cbCasier.SelectedValue = row.Cells["CasierId"].Value;
                cbTipTranzactie.SelectedItem = (TipTranzactie)row.Cells["Tip"].Value;

                dtpData.Value = Convert.ToDateTime(row.Cells["DataTranzactie"].Value);
                tbSumaValuta.Text = row.Cells["SumaValuta"].Value.ToString();
                tbTotalLei.Text = row.Cells["SumaTotalaLei"].Value.ToString();
            }
        }
        private void CalculeazaSumaTotala()
        {
            if (cbValuta.SelectedValue == null || cbTipTranzactie.SelectedItem == null) return;
            if (!decimal.TryParse(tbSumaValuta.Text, out decimal sumaValuta))
            {
                tbTotalLei.Clear();
                return;
            }

            int valutaId = Convert.ToInt32(cbValuta.SelectedValue);
            TipTranzactie tip = (TipTranzactie)cbTipTranzactie.SelectedItem;

            CursValutarRepository cursRepo = new CursValutarRepository();
            CursValutar curs = cursRepo.GetCursCurent(valutaId);

            if (curs != null)
            {
                decimal totalLei = 0;

                if (tip == TipTranzactie.Cumparare)
                {
                    totalLei = sumaValuta * curs.CursCumparare;
                }
                else if (tip == TipTranzactie.Vanzare)
                {
                    totalLei = sumaValuta * curs.CursVanzare;
                }

                tbTotalLei.Text = totalLei.ToString("0.00");
            }
            else
            {
                tbTotalLei.Clear();
            }
        }

        private void tbSumaValuta_TextChanged(object sender, EventArgs e)
        {
            CalculeazaSumaTotala();
        }

        private void cbTipTranzactie_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculeazaSumaTotala();
        }

        private void cbValuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculeazaSumaTotala();
        }

        private void btnChitanta_Click(object sender, EventArgs e)
        {
            if (idSelectat == 0)
            {
                MessageBox.Show("Va rugam sa selectati o tranzactie din tabel pentru a genera chitanta!", "Atentie");
                return;
            }

            string numeClient = cbClient.Text;
            string valuta = cbValuta.Text;
            string numeCasier = cbCasier.Text;
            string tipTranzactie = cbTipTranzactie.Text;
            string dataTranzactie = dtpData.Value.ToString("dd/MM/yyyy HH:mm");
            string sumaValuta = tbSumaValuta.Text;
            string totalLei = tbTotalLei.Text;

            string chitanta = "====================================\n" +
                              "      CASA DE SCHIMB VALUTAR        \n" +
                              "====================================\n" +
                              $"Numar Tranzactie: {idSelectat}\n" +
                              $"Data: {dataTranzactie}\n" +
                              $"Casier: {numeCasier}\n" +
                              "------------------------------------\n" +
                              $"Client: {numeClient}\n" +
                              $"Tip operatiune: {tipTranzactie}\n" +
                              $"Valuta: {valuta}\n" +
                              $"Suma Valuta: {sumaValuta}\n" +
                              "------------------------------------\n" +
                              $"TOTAL DE PLATA: {totalLei} RON\n" +
                              "====================================\n" +
                              "      Va multumim!                  \n";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fisier Text (*.txt)|*.txt"; 
            saveFileDialog.Title = "Salveaza Chitanta";
            saveFileDialog.FileName = $"Chitanta_{numeClient.Replace(" ", "_")}_{idSelectat}.txt"; // Un nume predefinit frumos

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, chitanta);
                MessageBox.Show("Chitanta a fost generata si salvata cu succes!", "Succes");
            }
        }

        private void AplicaFiltre()
        {
            var toateTranzactiile = tranzRepo.GetAll();
            var totiClientii = clientRepo.GetAll();

            if (!string.IsNullOrWhiteSpace(tbCautareClient.Text))
            {
                string textCautat = tbCautareClient.Text.ToLower();

                toateTranzactiile = toateTranzactiile.Where(t =>
                    totiClientii.Any(c => c.Id == t.ClientId && c.NumeComplet.ToLower().Contains(textCautat))
                ).ToList();
            }

            if (chkFiltruData.Checked)
            {
                DateTime dataAleasa = dtpFiltruData.Value.Date;
                toateTranzactiile = toateTranzactiile.Where(t => t.DataTranzactie.Date == dataAleasa).ToList();
            }

            dgvTranzactii.DataSource = toateTranzactiile;
            dgvTranzactii.ClearSelection();
        }

        private void tbCautareClient_TextChanged(object sender, EventArgs e)
        {
            AplicaFiltre();
        }

        private void chkFiltruData_TextChanged(object sender, EventArgs e)
        {
            AplicaFiltre();
        }

        private void dtpFiltruData_ValueChanged(object sender, EventArgs e)
        {
            if (chkFiltruData.Checked)
            {
                AplicaFiltre();
            }
        }
    }
}