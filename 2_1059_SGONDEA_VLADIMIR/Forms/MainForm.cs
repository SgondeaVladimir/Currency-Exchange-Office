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

            // O deschidem ca fereastră de tip "Dialog" (utilizatorul nu poate da click pe fereastra principală până nu o închide pe aceasta)
            formValute.ShowDialog();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientiForm formClienti = new ClientiForm();
            formClienti.ShowDialog();
        }
    }
}
