using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // OBLIGATORIU
using _2_1059_SGONDEA_VLADIMIR.DataAccess;

namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    public partial class DashboardForm : Form
    {
        private TranzactieRepository repo;

        public DashboardForm()
        {
            InitializeComponent();
            repo = new TranzactieRepository();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            ThemeManager.AplicaTema(this);
            ConfigurareGraficValute();
            ConfigurareGraficEvolutie();
        }

        private void ConfigurareGraficValute()
        {
            var date = repo.GetStatisticiValute();

            chartValute.Series.Clear();
            chartValute.Titles.Add("Distribuție Tranzacții pe Valute");

            Series s = chartValute.Series.Add("Valute");
            s.ChartType = SeriesChartType.Pie; 

            s.IsValueShownAsLabel = true;
            chartValute.Legends[0].Enabled = true;

            foreach (var item in date)
            {
                s.Points.AddXY(item.Key, item.Value);
            }
        }

        private void ConfigurareGraficEvolutie()
        {
            var date = repo.GetEvolutieSaptamanala();

            chartEvolutie.Series.Clear();
            chartEvolutie.Titles.Add("Volum Tranzacții (Ultima Săptămână)");

            Series s = chartEvolutie.Series.Add("Total RON");
            s.ChartType = SeriesChartType.Column; 
            s.Color = System.Drawing.Color.DodgerBlue;

            foreach (var item in date)
            {
                s.Points.AddXY(item.Key.ToString("dd/MM"), item.Value);
            }
        }
    }
}