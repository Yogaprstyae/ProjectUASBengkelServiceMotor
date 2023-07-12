namespace ProjectUASBengkelServiceMotor
{
    partial class Halaman_Homepage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Halaman_Homepage));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelmenul = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnMotor = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnSparepart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panelmenul.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Orange;
            this.sidebar.Controls.Add(this.panelmenul);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(162, 450);
            this.sidebar.MinimumSize = new System.Drawing.Size(59, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(162, 450);
            this.sidebar.TabIndex = 0;
            // 
            // panelmenul
            // 
            this.panelmenul.Controls.Add(this.label1);
            this.panelmenul.Controls.Add(this.btnMenu);
            this.panelmenul.Location = new System.Drawing.Point(3, 3);
            this.panelmenul.Name = "panelmenul";
            this.panelmenul.Size = new System.Drawing.Size(158, 61);
            this.panelmenul.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCustomer);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(3, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 38);
            this.panel5.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMotor);
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 38);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnService);
            this.panel2.Location = new System.Drawing.Point(3, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 38);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSparepart);
            this.panel3.Location = new System.Drawing.Point(3, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 38);
            this.panel3.TabIndex = 5;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUASBengkelServiceMotor.Properties.Resources.Logo_Bengkel2;
            this.pictureBox1.Location = new System.Drawing.Point(262, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::ProjectUASBengkelServiceMotor.Properties.Resources.Menu_icon_2_icon_icons_com_71856;
            this.btnMenu.Location = new System.Drawing.Point(-3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(57, 55);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImage = global::ProjectUASBengkelServiceMotor.Properties.Resources.account_avatar_face_man_people_profile_user_icon_1231971;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCustomer.Location = new System.Drawing.Point(-105, -3);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(264, 46);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnMotor
            // 
            this.btnMotor.BackgroundImage = global::ProjectUASBengkelServiceMotor.Properties.Resources.cross_country_motorcycle_vehicle_transport_icon_208512;
            this.btnMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotor.Location = new System.Drawing.Point(-105, -4);
            this.btnMotor.Name = "btnMotor";
            this.btnMotor.Size = new System.Drawing.Size(264, 48);
            this.btnMotor.TabIndex = 3;
            this.btnMotor.Text = "Motor";
            this.btnMotor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMotor.UseVisualStyleBackColor = true;
            this.btnMotor.Click += new System.EventHandler(this.btnMotor_Click);
            // 
            // btnService
            // 
            this.btnService.BackgroundImage = global::ProjectUASBengkelServiceMotor.Properties.Resources.circle_customer_help_info_information_service_support_icon_123208;
            this.btnService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.Location = new System.Drawing.Point(-105, -4);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(264, 48);
            this.btnService.TabIndex = 3;
            this.btnService.Text = "Service";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnSparepart
            // 
            this.btnSparepart.BackgroundImage = global::ProjectUASBengkelServiceMotor.Properties.Resources._2849830_gear_interface_multimedia_options_setting_settings_107986;
            this.btnSparepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSparepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSparepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSparepart.Location = new System.Drawing.Point(-105, -4);
            this.btnSparepart.Name = "btnSparepart";
            this.btnSparepart.Size = new System.Drawing.Size(264, 48);
            this.btnSparepart.TabIndex = 3;
            this.btnSparepart.Text = "Sparepart";
            this.btnSparepart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSparepart.UseVisualStyleBackColor = true;
            this.btnSparepart.Click += new System.EventHandler(this.btnSparepart_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::ProjectUASBengkelServiceMotor.Properties.Resources.arrow_back_icon_151627;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(168, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Halaman_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Halaman_Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Halaman_DataDiriCustomer_Load);
            this.sidebar.ResumeLayout(false);
            this.panelmenul.ResumeLayout(false);
            this.panelmenul.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelmenul;
        private System.Windows.Forms.Button btnMotor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSparepart;
        private System.Windows.Forms.Button btnBack;
    }
}