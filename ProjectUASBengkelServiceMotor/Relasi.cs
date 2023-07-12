using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUASBengkelServiceMotor
{
    public partial class Halaman_Relasi : Form
    {

        public Halaman_Relasi()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_PilihData fa = new Halaman_PilihData();
            fa.Show();
            Hide();
        }

        private void Halaman_Relasi_Load(object sender, EventArgs e)
        {

        }

        private void btnMelakukan_Click(object sender, EventArgs e)
        {
            Halaman_Melakukan fb = new Halaman_Melakukan();
            fb.Show();
            Hide();
        }

        private void btnMemerlukan_Click(object sender, EventArgs e)
        {
            Halaman_Memerlukan fc = new Halaman_Memerlukan();
            fc.Show();
            Hide();
        }

        private void btnMemiliki_Click(object sender, EventArgs e)
        {
            Halaman_Memiliki fd = new Halaman_Memiliki();
            fd.Show();
            Hide();
        }

        private void btnMembayar_Click(object sender, EventArgs e)
        {
            Halaman_Membayar fe = new Halaman_Membayar();
            fe.Show();
            Hide();
        }
    }
}
