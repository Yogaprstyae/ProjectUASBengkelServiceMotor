namespace ProjectUASBengkelServiceMotor
{
    partial class Halaman_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Halaman_Customer));
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.almt = new System.Windows.Forms.Label();
            this.txthp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtpos = new System.Windows.Forms.TextBox();
            this.cbxprovinsi = new System.Windows.Forms.ComboBox();
            this.cbxkota = new System.Windows.Forms.ComboBox();
            this.txtjalan = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(579, 296);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(170, 22);
            this.txtalamat.TabIndex = 89;
            // 
            // almt
            // 
            this.almt.AutoSize = true;
            this.almt.Location = new System.Drawing.Point(434, 299);
            this.almt.Name = "almt";
            this.almt.Size = new System.Drawing.Size(61, 16);
            this.almt.TabIndex = 88;
            this.almt.Text = "ALAMAT";
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(579, 340);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(170, 22);
            this.txthp.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 85;
            this.label8.Text = "NO HP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(368, 207);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtpos
            // 
            this.txtpos.Location = new System.Drawing.Point(579, 252);
            this.txtpos.Name = "txtpos";
            this.txtpos.Size = new System.Drawing.Size(170, 22);
            this.txtpos.TabIndex = 78;
            this.txtpos.TextChanged += new System.EventHandler(this.txtpos_TextChanged);
            // 
            // cbxprovinsi
            // 
            this.cbxprovinsi.FormattingEnabled = true;
            this.cbxprovinsi.Items.AddRange(new object[] {
            "Aceh",
            "Sumatera Utara",
            "Sumatera Barat",
            "Riau",
            "Kepulauan Riau",
            "Jambi",
            "Sumatera Selatan",
            "Bangka Belitung",
            "Bengkulu",
            "Lampung",
            "Banten",
            "Jakarta",
            "Jawa Barat",
            "Jawa Tengah",
            "Yogyakarta",
            "Jawa Timur",
            "Bali",
            "Nusa Tenggara Barat",
            "Nusa Tenggara Timur",
            "Kalimantan Barat",
            "Kalimantan Tengah",
            "Kalimantan Selatan",
            "Kalimantan Timur",
            "Kalimantan Utara",
            "Sulawesi Utara",
            "Gorontalo",
            "Sulawesi Tengah",
            "Sulawesi Barat",
            "Sulawesi Selatan",
            "Sulawesi Tenggara",
            "Maluku",
            "Maluku Utara",
            "Papua Barat",
            "Papua"});
            this.cbxprovinsi.Location = new System.Drawing.Point(579, 207);
            this.cbxprovinsi.Name = "cbxprovinsi";
            this.cbxprovinsi.Size = new System.Drawing.Size(170, 24);
            this.cbxprovinsi.TabIndex = 77;
            // 
            // cbxkota
            // 
            this.cbxkota.FormattingEnabled = true;
            this.cbxkota.Items.AddRange(new object[] {
            "Jakarta",
            "Surabaya",
            "Medan",
            "Bandung",
            "Bekasi",
            "Semarang",
            "Tangerang",
            "Depok",
            "Palembang",
            "Makassar",
            "Batam",
            "Pekanbaru",
            "Bandar Lampung",
            "Bogor",
            "Malang",
            "Yogyakarta",
            "Surakarta",
            "Padang",
            "Denpasar",
            "Manado"});
            this.cbxkota.Location = new System.Drawing.Point(579, 162);
            this.cbxkota.Name = "cbxkota";
            this.cbxkota.Size = new System.Drawing.Size(170, 24);
            this.cbxkota.TabIndex = 76;
            // 
            // txtjalan
            // 
            this.txtjalan.Location = new System.Drawing.Point(579, 119);
            this.txtjalan.Name = "txtjalan";
            this.txtjalan.Size = new System.Drawing.Size(170, 22);
            this.txtjalan.TabIndex = 75;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(579, 76);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(170, 22);
            this.txtnama.TabIndex = 74;
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(579, 35);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(170, 22);
            this.txtcustomer.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "KODE POS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "PROVINSI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 70;
            this.label5.Text = "KOTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "JALAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "NAMA CUSTOMER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "ID CUSTOMER";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(32, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 35);
            this.btnBack.TabIndex = 94;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(166, 334);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 35);
            this.btnOpen.TabIndex = 93;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(647, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 92;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(543, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 35);
            this.btnClear.TabIndex = 91;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(437, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 35);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Halaman_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.almt);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtpos);
            this.Controls.Add(this.cbxprovinsi);
            this.Controls.Add(this.cbxkota);
            this.Controls.Add(this.txtjalan);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Halaman_Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Halaman_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.Label almt;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpos;
        private System.Windows.Forms.ComboBox cbxprovinsi;
        private System.Windows.Forms.ComboBox cbxkota;
        private System.Windows.Forms.TextBox txtjalan;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
    }
}