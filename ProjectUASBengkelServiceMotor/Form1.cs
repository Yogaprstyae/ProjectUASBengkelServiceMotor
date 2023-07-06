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
    public partial class Halaman_Login : Form
    {
        public Halaman_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Halaman_DataDiriCustomer fa = new Halaman_DataDiriCustomer();
            fa.Show();
            Hide();
        }
    }
}
