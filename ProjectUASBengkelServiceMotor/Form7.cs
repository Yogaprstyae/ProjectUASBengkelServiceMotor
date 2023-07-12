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
    public partial class Halaman_PilihData : Form
    {
        public Halaman_PilihData()
        {
            InitializeComponent();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            Halaman_Homepage fa = new Halaman_Homepage();
            fa.Show();
            Hide();
        }

        private void btnRelasi_Click(object sender, EventArgs e)
        {
            Halaman_Relasi fb = new Halaman_Relasi();
            fb.Show();
            Hide();
        }
    }
}
