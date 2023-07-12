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
    public partial class Halaman_Sparepart : Form
    {
        private string stringConnection = "data source=INBOOK_X1\\MYOGAPRSTYAE;" + "database=Service;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private void refreshform()
        {
            txtsparepart.Text = "";
            txtsparepart.Enabled = false;
            txtnmsparepart.Text = "";
            txtnmsparepart.Enabled = false;
            txtstok.Text = "";
            txtstok.Enabled = false;
            txtharga.Text = "";
            txtharga.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        public Halaman_Sparepart()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Homepage fa = new Halaman_Homepage();
            fa.Show();
            Hide();
        }

        private void Halaman_Sparepart_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtsparepart.Enabled = true;
            txtnmsparepart.Enabled = true;
            txtstok.Enabled = true;
            txtharga.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idSparepart = txtsparepart.Text.Trim();
            string nmSparepart = txtnmsparepart.Text.Trim();
            string stok = txtstok.Text.Trim();
            decimal harga;

            if (idSparepart == "")
            {
                MessageBox.Show("Masukkan ID Sparepart", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nmSparepart == "")
            {
                MessageBox.Show("Masukkan Nama Sparepart", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (stok == "")
            {
                MessageBox.Show("Masukkan Stok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!decimal.TryParse(txtharga.Text.Trim(), out harga))
            {
                MessageBox.Show("Masukkan Harga dengan format yang benar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    koneksi.Open();
                    string query = "INSERT INTO sparepart (id_sparepart, nm_sparepart, stok, harga) VALUES (@id_sparepart, @nm_sparepart, @stok, @harga)";
                    SqlCommand command = new SqlCommand(query, koneksi);
                    command.Parameters.AddWithValue("@id_sparepart", idSparepart);
                    command.Parameters.AddWithValue("@nm_sparepart", nmSparepart);
                    command.Parameters.AddWithValue("@stok", stok);
                    command.Parameters.AddWithValue("@harga", harga);
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
            string str = "SELECT id_sparepart, nm_sparepart, stok, harga FROM sparepart";
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
                txtsparepart.Text = row.Cells["id_sparepart"].Value.ToString();
                txtnmsparepart.Text = row.Cells["nm_sparepart"].Value.ToString();
                txtstok.Text = row.Cells["stok"].Value.ToString();
                txtharga.Text = row.Cells["harga"].Value.ToString();

                txtsparepart.Enabled = false;
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
