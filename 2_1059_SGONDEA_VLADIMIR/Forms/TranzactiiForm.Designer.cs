namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    partial class TranzactiiForm
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
            this.dgvTranzactii = new System.Windows.Forms.DataGridView();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.cbCasier = new System.Windows.Forms.ComboBox();
            this.cbTipTranzactie = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.tbSumaValuta = new System.Windows.Forms.TextBox();
            this.tbTotalLei = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChitanta = new System.Windows.Forms.Button();
            this.tbCautareClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkFiltruData = new System.Windows.Forms.CheckBox();
            this.dtpFiltruData = new System.Windows.Forms.DateTimePicker();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzactii)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTranzactii
            // 
            this.dgvTranzactii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranzactii.Location = new System.Drawing.Point(12, 268);
            this.dgvTranzactii.Name = "dgvTranzactii";
            this.dgvTranzactii.RowHeadersWidth = 51;
            this.dgvTranzactii.RowTemplate.Height = 24;
            this.dgvTranzactii.Size = new System.Drawing.Size(903, 255);
            this.dgvTranzactii.TabIndex = 0;
            this.dgvTranzactii.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTranzactii_CellClick);
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(12, 24);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(121, 24);
            this.cbClient.TabIndex = 1;
            // 
            // cbValuta
            // 
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(139, 24);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(121, 24);
            this.cbValuta.TabIndex = 2;
            this.cbValuta.SelectedIndexChanged += new System.EventHandler(this.cbValuta_SelectedIndexChanged);
            // 
            // cbCasier
            // 
            this.cbCasier.FormattingEnabled = true;
            this.cbCasier.Location = new System.Drawing.Point(266, 24);
            this.cbCasier.Name = "cbCasier";
            this.cbCasier.Size = new System.Drawing.Size(121, 24);
            this.cbCasier.TabIndex = 3;
            // 
            // cbTipTranzactie
            // 
            this.cbTipTranzactie.FormattingEnabled = true;
            this.cbTipTranzactie.Location = new System.Drawing.Point(393, 24);
            this.cbTipTranzactie.Name = "cbTipTranzactie";
            this.cbTipTranzactie.Size = new System.Drawing.Size(121, 24);
            this.cbTipTranzactie.TabIndex = 4;
            this.cbTipTranzactie.SelectedIndexChanged += new System.EventHandler(this.cbTipTranzactie_SelectedIndexChanged);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(530, 26);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 5;
            // 
            // tbSumaValuta
            // 
            this.tbSumaValuta.Location = new System.Drawing.Point(116, 103);
            this.tbSumaValuta.Name = "tbSumaValuta";
            this.tbSumaValuta.Size = new System.Drawing.Size(90, 22);
            this.tbSumaValuta.TabIndex = 6;
            this.tbSumaValuta.TextChanged += new System.EventHandler(this.tbSumaValuta_TextChanged);
            // 
            // tbTotalLei
            // 
            this.tbTotalLei.Location = new System.Drawing.Point(268, 103);
            this.tbTotalLei.Name = "tbTotalLei";
            this.tbTotalLei.ReadOnly = true;
            this.tbTotalLei.Size = new System.Drawing.Size(100, 22);
            this.tbTotalLei.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(762, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(762, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 37);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Modifica";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(762, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valuta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Casier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tip Tranzactie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adauga Suma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total conversie";
            // 
            // btnChitanta
            // 
            this.btnChitanta.Location = new System.Drawing.Point(812, 217);
            this.btnChitanta.Name = "btnChitanta";
            this.btnChitanta.Size = new System.Drawing.Size(103, 45);
            this.btnChitanta.TabIndex = 17;
            this.btnChitanta.Text = "Genereaza Chitanta";
            this.btnChitanta.UseVisualStyleBackColor = true;
            this.btnChitanta.Click += new System.EventHandler(this.btnChitanta_Click);
            // 
            // tbCautareClient
            // 
            this.tbCautareClient.Location = new System.Drawing.Point(15, 203);
            this.tbCautareClient.Name = "tbCautareClient";
            this.tbCautareClient.Size = new System.Drawing.Size(143, 22);
            this.tbCautareClient.TabIndex = 18;
            this.tbCautareClient.TextChanged += new System.EventHandler(this.tbCautareClient_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cauta dupa nume client";
            // 
            // chkFiltruData
            // 
            this.chkFiltruData.AutoSize = true;
            this.chkFiltruData.Location = new System.Drawing.Point(224, 203);
            this.chkFiltruData.Name = "chkFiltruData";
            this.chkFiltruData.Size = new System.Drawing.Size(144, 20);
            this.chkFiltruData.TabIndex = 20;
            this.chkFiltruData.Text = "Filtreaza dupa data";
            this.chkFiltruData.UseVisualStyleBackColor = true;
            this.chkFiltruData.TextChanged += new System.EventHandler(this.chkFiltruData_TextChanged);
            // 
            // dtpFiltruData
            // 
            this.dtpFiltruData.Location = new System.Drawing.Point(205, 234);
            this.dtpFiltruData.Name = "dtpFiltruData";
            this.dtpFiltruData.Size = new System.Drawing.Size(200, 22);
            this.dtpFiltruData.TabIndex = 21;
            this.dtpFiltruData.ValueChanged += new System.EventHandler(this.dtpFiltruData_ValueChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.Lime;
            this.btnExportExcel.Location = new System.Drawing.Point(442, 209);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(125, 53);
            this.btnExportExcel.TabIndex = 22;
            this.btnExportExcel.Text = "Exporta in Excel(.csv)";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // TranzactiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 535);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dtpFiltruData);
            this.Controls.Add(this.chkFiltruData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCautareClient);
            this.Controls.Add(this.btnChitanta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbTotalLei);
            this.Controls.Add(this.tbSumaValuta);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cbTipTranzactie);
            this.Controls.Add(this.cbCasier);
            this.Controls.Add(this.cbValuta);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.dgvTranzactii);
            this.Name = "TranzactiiForm";
            this.Text = "TranzactiiForm";
            this.Load += new System.EventHandler(this.TranzactiiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzactii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTranzactii;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.ComboBox cbCasier;
        private System.Windows.Forms.ComboBox cbTipTranzactie;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox tbSumaValuta;
        private System.Windows.Forms.TextBox tbTotalLei;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChitanta;
        private System.Windows.Forms.TextBox tbCautareClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkFiltruData;
        private System.Windows.Forms.DateTimePicker dtpFiltruData;
        private System.Windows.Forms.Button btnExportExcel;
    }
}