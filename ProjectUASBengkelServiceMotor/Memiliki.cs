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
    public partial class Halaman_Memiliki : Form
    {
        private string stringConnection = "data source=INBOOK_X1\\MYOGAPRSTYAE;" + "database=Service;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Halaman_Memiliki()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void refreshform()
        {
            cbxcustomer.Enabled = false;
            cbxpolisi.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxcustomer.Enabled = true;
            cbxpolisi.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string idCustomer = dataGridView1.SelectedRows[0].Cells["id_customer"].Value.ToString();
                    string noPolisi = dataGridView1.SelectedRows[0].Cells["no_polisi"].Value.ToString();

                    try
                    {
                        koneksi.Open();

                        // Hapus baris dari tabel "Memiliki"
                        string deleteQuery = "DELETE FROM Memiliki WHERE id_customer = @id_customer AND no_polisi = @no_polisi";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, koneksi);
                        deleteCmd.Parameters.AddWithValue("@id_customer", idCustomer);
                        deleteCmd.Parameters.AddWithValue("@no_polisi", noPolisi);
                        deleteCmd.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView();
                        refreshform();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tekan button back lalu masuk kembali kesini untuk menimbulkan efek", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    finally
                    {
                        koneksi.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxcustomer.SelectedItem == null || cbxpolisi.SelectedItem == null)
            {
                MessageBox.Show("Please select both the customer ID and vehicle number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idCustomer = cbxcustomer.SelectedItem.ToString();
            string noPolisi = cbxpolisi.SelectedItem.ToString();

            try
            {
                koneksi.Open();
                string query = "INSERT INTO Memiliki (id_customer, no_polisi) VALUES (@id_customer, @no_polisi)";
                SqlCommand command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@id_customer", idCustomer);
                command.Parameters.AddWithValue("@no_polisi", noPolisi);
                command.ExecuteNonQuery();

                MessageBox.Show("Data has been saved to the 'Memiliki' table.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cbxpolisi.Text = "";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT id_customer, no_polisi FROM Memiliki";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Relasi fa = new Halaman_Relasi();
            fa.Show();
            Hide();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cbxcustomer.SelectedItem = row.Cells["id_customer"].Value.ToString();
                cbxpolisi.SelectedItem = row.Cells["no_polisi"].Value.ToString();

                cbxcustomer.Enabled = false;
                cbxpolisi.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Memiliki_Load(object sender, EventArgs e)
        {
            LoadComboBoxCustomer();
            LoadComboBoxMotor();
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

        private void LoadComboBoxMotor()
        {
            try
            {
                koneksi.Open();
                string query = "SELECT no_polisi FROM Motor";
                SqlCommand command = new SqlCommand(query, koneksi);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string noPolisi = reader["no_polisi"].ToString();
                    cbxpolisi.Items.Add(noPolisi);
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
