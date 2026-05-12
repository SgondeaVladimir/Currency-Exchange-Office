namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    partial class CursuriValutareForm
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
            this.dgvCursuri = new System.Windows.Forms.DataGridView();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.tbCumparare = new System.Windows.Forms.TextBox();
            this.tbVanzare = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursuri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursuri
            // 
            this.dgvCursuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursuri.Location = new System.Drawing.Point(12, 204);
            this.dgvCursuri.Name = "dgvCursuri";
            this.dgvCursuri.RowHeadersWidth = 51;
            this.dgvCursuri.RowTemplate.Height = 24;
            this.dgvCursuri.Size = new System.Drawing.Size(776, 234);
            this.dgvCursuri.TabIndex = 0;
            this.dgvCursuri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursuri_CellClick);
            // 
            // cbValuta
            // 
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(12, 78);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(167, 24);
            this.cbValuta.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(301, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 2;
            // 
            // tbCumparare
            // 
            this.tbCumparare.Location = new System.Drawing.Point(231, 62);
            this.tbCumparare.Name = "tbCumparare";
            this.tbCumparare.Size = new System.Drawing.Size(100, 22);
            this.tbCumparare.TabIndex = 3;
            // 
            // tbVanzare
            // 
            this.tbVanzare.Location = new System.Drawing.Point(231, 100);
            this.tbVanzare.Name = "tbVanzare";
            this.tbVanzare.Size = new System.Drawing.Size(100, 22);
            this.tbVanzare.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(420, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(420, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 46);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Modifica";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 46);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CursuriValutareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbVanzare);
            this.Controls.Add(this.tbCumparare);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cbValuta);
            this.Controls.Add(this.dgvCursuri);
            this.Name = "CursuriValutareForm";
            this.Text = "CursuriValutareForm";
            this.Load += new System.EventHandler(this.CursuriValutareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursuri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursuri;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox tbCumparare;
        private System.Windows.Forms.TextBox tbVanzare;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}