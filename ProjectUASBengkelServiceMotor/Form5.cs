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
    public partial class Halaman_Service : Form
    {
        private string stringConnection = "data source=INBOOK_X1\\MYOGAPRSTYAE;" + "database=Service;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private void refreshform()
        {
            txtservice.Text = "";
            txtservice.Enabled = false;
            cbxNama.Text = "";
            cbxNama.Enabled = false;
            txtkeluhan.Text = "";
            txtkeluhan.Enabled = false;
            dtx.Value = DateTime.Now;
            dtx.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        public Halaman_Service()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                koneksi.Open();
                string query = "SELECT id_customer FROM Customer";
                SqlCommand command = new SqlCommand(query, koneksi);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbxNama.Items.Add(reader["id_customer"].ToString());
                }

                reader.Close();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Homepage fa = new Halaman_Homepage();
            fa.Show();
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtservice.Enabled = true;
            cbxNama.Enabled = true;
            txtkeluhan.Enabled = true;
            dtx.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void Halaman_Service_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idService = txtservice.Text.Trim();
            string idCustomer = cbxNama.Text.Trim();
            string keluhan = txtkeluhan.Text.Trim();
            DateTime tanggalService = dtx.Value;

            if (idService == "")
            {
                MessageBox.Show("Masukkan ID Service", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idCustomer == "")
            {
                MessageBox.Show("Masukkan ID Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (keluhan == "")
            {
                MessageBox.Show("Masukkan Keluhan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    koneksi.Open();
                    string query = "INSERT INTO servis (id_service, id_customer, keluhan, tanggal_service) VALUES (@id_service, @id_customer, @keluhan, @tanggal_service)";
                    SqlCommand command = new SqlCommand(query, koneksi);
                    command.Parameters.AddWithValue("@id_service", idService);
                    command.Parameters.AddWithValue("@id_customer", idCustomer);
                    command.Parameters.AddWithValue("@keluhan", keluhan);
                    command.Parameters.AddWithValue("@tanggal_service", tanggalService);
                    command.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data berhasil disimpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                    refreshform();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT id_service, id_customer, keluhan, tanggal_service FROM servis";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtservice.Text = row.Cells["id_service"].Value.ToString();
                cbxNama.Text = row.Cells["id_customer"].Value.ToString();
                txtkeluhan.Text = row.Cells["keluhan"].Value.ToString();
                dtx.Value = Convert.ToDateTime(row.Cells["tanggal_service"].Value.ToString());

                cbxNama.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }
    }
}
