using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekPABD1
{
    public partial class HomePage: Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnPermintaan_Click(object sender, EventArgs e)
        {
            // membuat objek ke form PermintaanBarang
            PermintaanBarang permintaan = new PermintaanBarang();
            // menampilkan form PermintaanBarang
            permintaan.Show();
            // menyembunyikan halaman asal biar tidak numpuk
            this.Hide();
        }

        private void btnKelola_Click(object sender, EventArgs e)
        {
            KelolaBarang kelola = new KelolaBarang();
            kelola.Show();
            this.Hide();
        }

        private void btnPengecekan_Click(object sender, EventArgs e)
        {
            PengecekanBarang pengecekan = new PengecekanBarang();
            pengecekan.Show();
            this.Hide();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceBarang maintenance = new MaintenanceBarang();
            maintenance.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report reportBarang = new Report();
            reportBarang.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KelolaBarang barang = new KelolaBarang();
            barang.Show();
        }
    }
}
