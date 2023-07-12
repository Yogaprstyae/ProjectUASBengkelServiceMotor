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
    public partial class Halaman_Membayar : Form
    {
        private string stringConnection = "data source=INBOOK_X1\\MYOGAPRSTYAE;" + "database=Service;User ID=sa;Password=123";
        private SqlConnection koneksi;

        public Halaman_Membayar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void refreshform()
        {
            cbxcustomer.Enabled = false;
            cbxkasir.Enabled = false;
            cbxsparepart.Enabled = false;
            txtharga.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxcustomer.Enabled = true;
            cbxkasir.Enabled = true;
            cbxsparepart.Enabled = true;
            txtharga.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxcustomer.SelectedItem == null || cbxkasir.SelectedItem == null || cbxsparepart.SelectedItem == null || txtharga.Text.Trim() == "")
            {
                MessageBox.Show("Please select both the customer ID and vehicle number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idCustomer = cbxcustomer.SelectedItem.ToString();
            string idKasir = cbxkasir.SelectedItem.ToString();
            string idSparepart = cbxsparepart.SelectedItem.ToString();
            string Harga = txtharga.Text.Trim();

            try
            {
                koneksi.Open();
                string query = "INSERT INTO Membayar (id_customer, id_kasir, id_sparepart, total_harga) VALUES (@id_customer, @id_kasir, @id_sparepart, @total_harga)";
                SqlCommand command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@id_customer", idCustomer);
                command.Parameters.AddWithValue("@id_kasir", idKasir);
                command.Parameters.AddWithValue("@id_sparepart", idSparepart);
                command.Parameters.AddWithValue("@total_harga", Harga);
                command.ExecuteNonQuery();

                MessageBox.Show("Data has been saved to the 'Membayar' table.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cbxcustomer.Text = "";
            cbxkasir.Text = "";
            cbxsparepart.Text = "";
            txtharga.Text = "";
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT id_customer, id_kasir, id_sparepart, total_harga FROM Membayar";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cbxcustomer.SelectedItem = row.Cells["id_customer"].Value.ToString();
                cbxkasir.SelectedItem = row.Cells["id_kasir"].Value.ToString();
                cbxsparepart.SelectedItem = row.Cells["id_sparepart"].Value.ToString();
                txtharga.Text = row.Cells["total_harga"].Value.ToString();

                cbxcustomer.Enabled = false;
                cbxkasir.Enabled = false;
                cbxsparepart.Enabled = false;
                txtharga.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Relasi fa = new Halaman_Relasi();
            fa.Show();
            Hide();
        }

        private void Membayar_Load(object sender, EventArgs e)
        {
            LoadComboBoxCustomer();
            LoadComboBoxKasir();
            LoadComboBoxSparepart();
        }

        private void LoadComboBoxCustomer()
        {
            try
            {
                koneksi.Open();
                string query = "SELECT id_customer FROM Customer";
                SqlCommand command = new SqlCommand(query, koneksi);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string idCustomer = reader["id_customer"].ToString();
                    cbxcustomer.Items.Add(idCustomer);
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadComboBoxKasir()
        {
            try
            {
                koneksi.Open();
                string query = "SELECT id_kasir FROM Kasir";
                SqlCommand command = new SqlCommand(query, koneksi);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string idKasir = reader["id_kasir"].ToString();
                    cbxkasir.Items.Add(idKasir);
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadComboBoxSparepart()
        {
            try
            {
                koneksi.Open();
                string query = "SELECT id_sparepart FROM Sparepart";
                SqlCommand command = new SqlCommand(query, koneksi);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string idSparepart = reader["id_sparepart"].ToString();
                    cbxsparepart.Items.Add(idSparepart);
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
