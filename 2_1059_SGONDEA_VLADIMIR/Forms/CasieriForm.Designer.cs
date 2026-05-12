namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    partial class CasieriForm
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
            this.dgvCasieri = new System.Windows.Forms.DataGridView();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCodAngajat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasieri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCasieri
            // 
            this.dgvCasieri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasieri.Location = new System.Drawing.Point(12, 201);
            this.dgvCasieri.Name = "dgvCasieri";
            this.dgvCasieri.RowTemplate.Height = 24;
            this.dgvCasieri.Size = new System.Drawing.Size(776, 237);
            this.dgvCasieri.TabIndex = 0;
            this.dgvCasieri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCasieri_CellClick);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(12, 22);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(130, 22);
            this.tbNume.TabIndex = 1;
            // 
            // tbCodAngajat
            // 
            this.tbCodAngajat.Location = new System.Drawing.Point(12, 75);
            this.tbCodAngajat.Name = "tbCodAngajat";
            this.tbCodAngajat.Size = new System.Drawing.Size(130, 22);
            this.tbCodAngajat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod Angajat";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(202, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(202, 50);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Modifica";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(202, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CasieriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodAngajat);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.dgvCasieri);
            this.Name = "CasieriForm";
            this.Text = "CasieriForm";
            this.Load += new System.EventHandler(this.CasieriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasieri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCasieri;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbCodAngajat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}