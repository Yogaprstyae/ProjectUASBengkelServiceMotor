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
    public partial class Halaman_Homepage : Form
    {
        bool sidebarExpand;
        public Halaman_Homepage()
        {
            InitializeComponent();
        }

        private void Halaman_DataDiriCustomer_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Halaman_Customer fa = new Halaman_Customer();
            fa.Show();
            Hide();
        }

        private void btnMotor_Click(object sender, EventArgs e)
        {
            Halaman_Motor fb = new Halaman_Motor();
            fb.Show();
            Hide();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Halaman_Service fc = new Halaman_Service();
            fc.Show();
            Hide();
        }

        private void btnSparepart_Click(object sender, EventArgs e)
        {
            Halaman_Sparepart fd = new Halaman_Sparepart();
            fd.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_PilihData fa = new Halaman_PilihData();
            fa.Show();
            Hide();
        }
    }
}
