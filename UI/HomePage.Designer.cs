namespace projekPABD1
{
    partial class HomePage
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
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnPengecekan = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnKelola = new System.Windows.Forms.Button();
            this.btnPermintaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(480, 125);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(106, 35);
            this.btnMaintenance.TabIndex = 0;
            this.btnMaintenance.Text = "maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnPengecekan
            // 
            this.btnPengecekan.Location = new System.Drawing.Point(317, 125);
            this.btnPengecekan.Name = "btnPengecekan";
            this.btnPengecekan.Size = new System.Drawing.Size(110, 35);
            this.btnPengecekan.TabIndex = 1;
            this.btnPengecekan.Text = "pengecekan";
            this.btnPengecekan.UseVisualStyleBackColor = true;
            this.btnPengecekan.Click += new System.EventHandler(this.btnPengecekan_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(656, 125);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(87, 35);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnKelola
            // 
            this.btnKelola.Location = new System.Drawing.Point(168, 125);
            this.btnKelola.Name = "btnKelola";
            this.btnKelola.Size = new System.Drawing.Size(123, 35);
            this.btnKelola.TabIndex = 3;
            this.btnKelola.Text = "kelola barang";
            this.btnKelola.UseVisualStyleBackColor = true;
            this.btnKelola.Click += new System.EventHandler(this.btnKelola_Click);
            // 
            // btnPermintaan
            // 
            this.btnPermintaan.Location = new System.Drawing.Point(22, 125);
            this.btnPermintaan.Name = "btnPermintaan";
            this.btnPermintaan.Size = new System.Drawing.Size(109, 35);
            this.btnPermintaan.TabIndex = 4;
            this.btnPermintaan.Text = "permintaan";
            this.btnPermintaan.UseVisualStyleBackColor = true;
            this.btnPermintaan.Click += new System.EventHandler(this.btnPermintaan_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPermintaan);
            this.Controls.Add(this.btnKelola);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnPengecekan);
            this.Controls.Add(this.btnMaintenance);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnPengecekan;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnKelola;
        private System.Windows.Forms.Button btnPermintaan;
    }
}

