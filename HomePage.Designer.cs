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
            this.btnPinjam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(483, 125);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(96, 23);
            this.btnMaintenance.TabIndex = 0;
            this.btnMaintenance.Text = "maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnPengecekan
            // 
            this.btnPengecekan.Location = new System.Drawing.Point(317, 125);
            this.btnPengecekan.Name = "btnPengecekan";
            this.btnPengecekan.Size = new System.Drawing.Size(95, 23);
            this.btnPengecekan.TabIndex = 1;
            this.btnPengecekan.Text = "pengecekan";
            this.btnPengecekan.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(668, 125);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnKelola
            // 
            this.btnKelola.Location = new System.Drawing.Point(168, 125);
            this.btnKelola.Name = "btnKelola";
            this.btnKelola.Size = new System.Drawing.Size(112, 23);
            this.btnKelola.TabIndex = 3;
            this.btnKelola.Text = "kelola barang";
            this.btnKelola.UseVisualStyleBackColor = true;
            // 
            // btnPinjam
            // 
            this.btnPinjam.Location = new System.Drawing.Point(22, 125);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(75, 23);
            this.btnPinjam.TabIndex = 4;
            this.btnPinjam.Text = "peminjaman";
            this.btnPinjam.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPinjam);
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
        private System.Windows.Forms.Button btnPinjam;
    }
}

