using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUASBengkelServiceMotor
{
    public partial class Halaman_Customer : Form
    {
        private string stringConnection = "data source=INBOOK_X1\\MYOGAPRSTYAE;" + "database=Service;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private void refreshform()
        {
            txtcustomer.Text = "";
            txtcustomer.Enabled = false;
            txtnama.Text = "";
            txtnama.Enabled = false;
            txtjalan.Text = "";
            txtjalan.Enabled = false;
            cbxkota.Text = "";
            cbxkota.Enabled = false;
            cbxprovinsi.Text = "";
            cbxprovinsi.Enabled = false;
            txtpos.Text = "";
            txtpos.Enabled = false;
            txtalamat.Text = "";
            txtalamat.Enabled = false;
            txthp.Text = "";
            txthp.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        public Halaman_Customer()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_customer, nm_customer, alamat_jalan, alamat_kota, alamat_provinsi, kode_pos, alamat, no_hp from dbo.customer";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void txtpos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Homepage fa = new Halaman_Homepage();
            fa.Show();
            Hide();
        }

        private void Halaman_Customer_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtcustomer.Text = row.Cells["id_customer"].Value.ToString();
                txtnama.Text = row.Cells["nm_customer"].Value.ToString();
                txtjalan.Text = row.Cells["alamat_jalan"].Value.ToString();
                cbxkota.Text = row.Cells["alamat_kota"].Value.ToString();
                cbxprovinsi.Text = row.Cells["alamat_provinsi"].Value.ToString();
                txtpos.Text = row.Cells["kode_pos"].Value.ToString();
                txtalamat.Text = row.Cells["alamat"].Value.ToString();
                txthp.Text = row.Cells["no_hp"].Value.ToString();



                txtcustomer.Enabled = false;
                txtnama.Enabled = false;
                txtjalan.Enabled = false;
                cbxkota.Enabled = false;
                cbxprovinsi.Enabled = false;
                txtpos.Enabled = false;
                txtalamat.Enabled = false;
                txthp.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtcustomer.Text = "";
            txtcustomer.Enabled = true;
            txtnama.Text = "";
            txtnama.Enabled = true;
            txtjalan.Text = "";
            txtjalan.Enabled = true;
            cbxkota.Text = "";
            cbxkota.Enabled = true;
            cbxprovinsi.Text = "";
            cbxprovinsi.Enabled = true;
            txtpos.Text = "";
            txtpos.Enabled = true;
            txtalamat.Text = "";
            txtalamat.Enabled = true;
            txthp.Text = "";
            txthp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string customer = txtcustomer.Text.Trim();
            string nama = txtnama.Text.Trim();
            string jalan = txtjalan.Text.Trim();
            string kota = cbxkota.SelectedItem.ToString();
            string provinsi = cbxprovinsi.SelectedItem.ToString();
            string pos = txtpos.Text.Trim();
            string alamat = txtalamat.Text.Trim();
            string hp = txthp.Text.Trim();

            if (string.IsNullOrEmpty(customer) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(jalan) || string.IsNullOrEmpty(kota) || string.IsNullOrEmpty(provinsi) || string.IsNullOrEmpty(pos) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(hp))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                try
                {
                    koneksi.Open();
                    string query = "INSERT INTO customer (id_customer, nm_customer, alamat_jalan, alamat_kota, alamat_provinsi, kode_pos, alamat, no_hp) VALUES (@id_customer, @nm_customer, @alamat_jalan, @alamat_kota, @alamat_provinsi, @kode_pos, @alamat, @no_hp)";
                    SqlCommand command = new SqlCommand(query, koneksi);
                    command.Parameters.AddWithValue("@id_customer", customer);
                    command.Parameters.AddWithValue("@nm_customer", nama);
                    command.Parameters.AddWithValue("@alamat_jalan", jalan);
                    command.Parameters.AddWithValue("@alamat_kota", kota);
                    command.Parameters.AddWithValue("@alamat_provinsi", provinsi);
                    command.Parameters.AddWithValue("@kode_pos", pos);
                    command.Parameters.AddWithValue("@alamat", alamat);
                    command.Parameters.AddWithValue("@no_hp", hp);
                    command.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data has been saved to the database.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            refreshform();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = true;
        }
    }
}
