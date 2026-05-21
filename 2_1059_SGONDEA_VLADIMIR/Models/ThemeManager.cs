using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2_1059_SGONDEA_VLADIMIR
{
    public static class ThemeManager
    {
        public static bool ModMatrixActiv { get; set; } = false;

        public static void AplicaTema(Form formular)
        {
            AplicaTemaLaControale(formular, ModMatrixActiv);
        }

        private static void AplicaTemaLaControale(Control parinte, bool esteMatrix)
        {
            Color culoareFundal = esteMatrix ? Color.Black : SystemColors.Control;
            Color culoareText = esteMatrix ? Color.Lime : SystemColors.ControlText;

            parinte.BackColor = culoareFundal;
            parinte.ForeColor = culoareText;

            foreach (Control copil in parinte.Controls)
            {
                if (copil is DataGridView dgv)
                {
                    dgv.BackgroundColor = esteMatrix ? Color.FromArgb(20, 20, 20) : SystemColors.AppWorkspace;
                    dgv.GridColor = esteMatrix ? Color.Lime : SystemColors.ControlDark;
                    dgv.DefaultCellStyle.BackColor = esteMatrix ? Color.Black : SystemColors.Window;
                    dgv.DefaultCellStyle.ForeColor = esteMatrix ? Color.Lime : SystemColors.ControlText;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = esteMatrix ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = esteMatrix ? Color.Lime : SystemColors.WindowText;
                    dgv.EnableHeadersVisualStyles = !esteMatrix; // Permite suprascrierea culorilor de antet
                }
                else if (copil is TextBox tb)
                {
                    tb.BackColor = esteMatrix ? Color.FromArgb(15, 15, 15) : SystemColors.Window;
                    tb.ForeColor = culoareText;
                    tb.BorderStyle = esteMatrix ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
                }
                else
                {
                    copil.BackColor = culoareFundal;
                    copil.ForeColor = culoareText;
                }

                if (copil is MenuStrip meniu)
                {
                    foreach (ToolStripItem item in meniu.Items)
                    {
                        item.BackColor = culoareFundal;
                        item.ForeColor = culoareText;
                    }
                }

                if (copil.HasChildren)
                {
                    AplicaTemaLaControale(copil, esteMatrix);
                }
            }
        }
    }
}