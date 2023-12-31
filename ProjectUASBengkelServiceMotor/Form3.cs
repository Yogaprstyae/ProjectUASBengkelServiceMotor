﻿using System;
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
    public partial class Halaman_Motor : Form
    {
        private string stringConnection = "data source=INBOOK_X1\\MYOGAPRSTYAE;" + "database=Service;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private void refreshform()
        {
            txtNo.Text = "";
            txtNo.Enabled = false;
            txtWarna.Text = "";
            txtWarna.Enabled = false;
            cbxMerk.Text = "";
            cbxMerk.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        public Halaman_Motor()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Halaman_Homepage fa = new Halaman_Homepage();
            fa.Show();
            Hide();
        }

        private void Halaman_Motor_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNo.Enabled = true;
            txtWarna.Enabled = true;
            cbxMerk.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string noPolisi = txtNo.Text.Trim();
            string warna = txtWarna.Text.Trim();
            string merk = cbxMerk.Text.Trim();

            if (noPolisi == "")
            {
                MessageBox.Show("Masukkan Nomor Polisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (warna == "")
            {
                MessageBox.Show("Masukkan Warna Motor", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (merk == "")
            {
                MessageBox.Show("Masukkan Merk Motor", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    koneksi.Open();
                    string query = "INSERT INTO Motor (no_polisi, warna, merk) VALUES (@no_polisi, @warna, @merk)";
                    SqlCommand command = new SqlCommand(query, koneksi);
                    command.Parameters.AddWithValue("@no_polisi", noPolisi);
                    command.Parameters.AddWithValue("@warna", warna);
                    command.Parameters.AddWithValue("@merk", merk);
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
            string str = "SELECT no_polisi, warna, merk FROM Motor";
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
                txtNo.Text = row.Cells["no_polisi"].Value.ToString();
                txtWarna.Text = row.Cells["warna"].Value.ToString();
                cbxMerk.Text = row.Cells["merk"].Value.ToString();

                txtNo.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = true;
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
    }
}
