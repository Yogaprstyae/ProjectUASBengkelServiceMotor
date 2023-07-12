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
    public partial class Halaman_Utama : Form
    {
        private string stringConnection = "data source=INBOOK_X1\\MYOGAPRSTYAE;" + "database=Service;User ID=sa;Password=123";
        private SqlConnection koneksi;

        private void refreshform()
        {
            txtid.Text = "";
            txtid.Enabled = false;
            txtnama.Text = "";
            txtnama.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        public Halaman_Utama()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_kasir, nm_kasir from dbo.kasir";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["id_kasir"].Value.ToString();
                txtnama.Text = row.Cells["nm_kasir"].Value.ToString();

                txtnama.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Halaman_PilihData fa = new Halaman_PilihData();
            fa.Show();
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtid.Enabled = true;
            txtnama.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idKasir = txtid.Text.Trim();
            string nmKasir = txtnama.Text.Trim();
            if (idKasir == "")
            {
                MessageBox.Show("masukkan id kasir", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (nmKasir == "")
            {
                MessageBox.Show("masukkan nama kasir", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO kasir (id_kasir, nm_kasir) VALUES (@id_kasir, @nm_kasir)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_kasir", idKasir));
                cmd.Parameters.Add(new SqlParameter("nm_kasir", nmKasir));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("data berhasil disimpan", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kodeKaryawan = dataGridView1.SelectedRows[0].Cells["id_kasir"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.kasir WHERE id_kasir = @id_kasir";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id_kasir", kodeKaryawan));
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                    refreshform();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
