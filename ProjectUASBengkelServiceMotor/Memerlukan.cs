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
    public partial class Halaman_Memerlukan : Form
    {
        private string stringConnection = "data source=INBOOK_X1\\MYOGAPRSTYAE;" + "database=Service;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Halaman_Memerlukan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            LoadComboBoxService();
            LoadComboBoxSparepart();
        }

        private void refreshform()
        {
            cbxservice.Enabled = false;
            cbxsparepart.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void LoadComboBoxService()
        {
            try
            {
                koneksi.Open();
                string query = "SELECT id_service FROM Servis";
                SqlCommand command = new SqlCommand(query, koneksi);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string idService = reader["id_service"].ToString();
                    cbxservice.Items.Add(idService);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxservice.Enabled = true;
            cbxsparepart.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string idService = dataGridView1.SelectedRows[0].Cells["id_service"].Value.ToString();
                        string idSparepart = dataGridView1.SelectedRows[0].Cells["id_sparepart"].Value.ToString();

                        try
                        {
                            koneksi.Open();

                            // Hapus baris dari tabel "Memerlukan"
                            string deleteQuery = "DELETE FROM Memerlukan WHERE id_service = @id_service AND id_sparepart = @id_sparepart";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, koneksi);
                            deleteCmd.Parameters.AddWithValue("@id_service", idService);
                            deleteCmd.Parameters.AddWithValue("@id_sparepart", idSparepart);
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxservice.SelectedItem == null || cbxsparepart.SelectedItem == null)
            {
                MessageBox.Show("Please select both the customer ID and vehicle number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idService = cbxservice.SelectedItem.ToString();
            string idSparepart = cbxsparepart.SelectedItem.ToString();

            try
            {
                koneksi.Open();
                string query = "INSERT INTO Memerlukan (id_service, id_sparepart) VALUES (@id_service, @id_sparepart)";
                SqlCommand command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@id_service", idService);
                command.Parameters.AddWithValue("@id_sparepart", idSparepart);
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
            cbxservice.Text = "";
            cbxsparepart.Text = "";
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "SELECT id_service, id_sparepart FROM Memerlukan";
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
                cbxservice.SelectedItem = row.Cells["id_service"].Value.ToString();
                cbxsparepart.SelectedItem = row.Cells["id_sparepart"].Value.ToString();

                cbxservice.Enabled = false;
                cbxsparepart.Enabled = false;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Halaman_Memerlukan_Load(object sender, EventArgs e)
        {

        }
    }
}
