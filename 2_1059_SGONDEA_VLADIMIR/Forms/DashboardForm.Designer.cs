namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartValute = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEvolutie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartValute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolutie)).BeginInit();
            this.SuspendLayout();
            // 
            // chartValute
            // 
            chartArea5.Name = "ChartArea1";
            this.chartValute.ChartAreas.Add(chartArea5);
            this.chartValute.Dock = System.Windows.Forms.DockStyle.Top;
            legend5.Name = "Legend1";
            this.chartValute.Legends.Add(legend5);
            this.chartValute.Location = new System.Drawing.Point(0, 0);
            this.chartValute.Name = "chartValute";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartValute.Series.Add(series5);
            this.chartValute.Size = new System.Drawing.Size(1009, 300);
            this.chartValute.TabIndex = 0;
            this.chartValute.Text = "chart1";
            // 
            // chartEvolutie
            // 
            chartArea6.Name = "ChartArea1";
            this.chartEvolutie.ChartAreas.Add(chartArea6);
            this.chartEvolutie.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend6.Name = "Legend1";
            this.chartEvolutie.Legends.Add(legend6);
            this.chartEvolutie.Location = new System.Drawing.Point(0, 320);
            this.chartEvolutie.Name = "chartEvolutie";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartEvolutie.Series.Add(series6);
            this.chartEvolutie.Size = new System.Drawing.Size(1009, 300);
            this.chartEvolutie.TabIndex = 1;
            this.chartEvolutie.Text = "chart2";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 620);
            this.Controls.Add(this.chartEvolutie);
            this.Controls.Add(this.chartValute);
            this.Name = "DashboardForm";
            this.Text = "Analiza si statistici";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartValute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolutie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartValute;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvolutie;
    }
}