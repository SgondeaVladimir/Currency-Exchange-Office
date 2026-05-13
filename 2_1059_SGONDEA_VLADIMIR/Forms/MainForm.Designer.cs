namespace _2_1059_SGONDEA_VLADIMIR.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nomenclatoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casieriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursuriValutareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomenclatoareToolStripMenuItem,
            this.tranzactiiToolStripMenuItem,
            this.cursuriValutareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nomenclatoareToolStripMenuItem
            // 
            this.nomenclatoareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valuteToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.casieriToolStripMenuItem});
            this.nomenclatoareToolStripMenuItem.Name = "nomenclatoareToolStripMenuItem";
            this.nomenclatoareToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.nomenclatoareToolStripMenuItem.Text = "Nomenclatoare";
            // 
            // valuteToolStripMenuItem
            // 
            this.valuteToolStripMenuItem.Name = "valuteToolStripMenuItem";
            this.valuteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.valuteToolStripMenuItem.Text = "Valute";
            this.valuteToolStripMenuItem.Click += new System.EventHandler(this.valuteToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // casieriToolStripMenuItem
            // 
            this.casieriToolStripMenuItem.Name = "casieriToolStripMenuItem";
            this.casieriToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.casieriToolStripMenuItem.Text = "Casieri";
            this.casieriToolStripMenuItem.Click += new System.EventHandler(this.casieriToolStripMenuItem_Click);
            // 
            // tranzactiiToolStripMenuItem
            // 
            this.tranzactiiToolStripMenuItem.Name = "tranzactiiToolStripMenuItem";
            this.tranzactiiToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.tranzactiiToolStripMenuItem.Text = "Tranzactii";
            this.tranzactiiToolStripMenuItem.Click += new System.EventHandler(this.tranzactiiToolStripMenuItem_Click);
            // 
            // cursuriValutareToolStripMenuItem
            // 
            this.cursuriValutareToolStripMenuItem.Name = "cursuriValutareToolStripMenuItem";
            this.cursuriValutareToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.cursuriValutareToolStripMenuItem.Text = "Cursuri Valutare";
            this.cursuriValutareToolStripMenuItem.Click += new System.EventHandler(this.cursuriValutareToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Datele sunt actualizate in timp real. Sistemul este conectat la baza de date.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sistem Gestiune Casa de Schimb Valutar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nomenclatoareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casieriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursuriValutareToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}