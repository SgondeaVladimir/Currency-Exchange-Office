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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void valuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValuteForm formValute = new ValuteForm();
            formValute.ShowDialog();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientiForm formClienti = new ClientiForm();
            formClienti.ShowDialog();
        }

        private void casieriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CasieriForm formCasieri = new CasieriForm();
            formCasieri.ShowDialog();
        }

        private void cursuriValutareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursuriValutareForm formCursuri = new CursuriValutareForm();
            formCursuri.ShowDialog();
        }

        private void tranzactiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranzactiiForm formTranzactii = new TranzactiiForm();
            formTranzactii.ShowDialog();
        }

        private void dashboardgraficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm f = new DashboardForm();
            f.ShowDialog();
        }

        private void temaIntunecataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeManager.ModMatrixActiv = !ThemeManager.ModMatrixActiv;
            ThemeManager.AplicaTema(this);
        }
        
    }
}
