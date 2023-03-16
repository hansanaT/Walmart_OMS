namespace Walmart_OMS
{
    partial class Staff_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_helpdesk = new System.Windows.Forms.Button();
            this.btn_adminP = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_leave = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_version = new System.Windows.Forms.Button();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pB_profile = new System.Windows.Forms.PictureBox();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_datetime = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panelCf = new System.Windows.Forms.Panel();
            this.pB_intro = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_profile)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel_datetime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_intro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel_nav);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_helpdesk);
            this.panel1.Controls.Add(this.btn_adminP);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_leave);
            this.panel1.Controls.Add(this.btn_orders);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 929);
            this.panel1.TabIndex = 1;
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel_nav.Location = new System.Drawing.Point(0, 283);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(3, 100);
            this.panel_nav.TabIndex = 3;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_logout.Image = global::Walmart_OMS.Properties.Resources.logout_24;
            this.btn_logout.Location = new System.Drawing.Point(0, 866);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(284, 63);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            this.btn_logout.Leave += new System.EventHandler(this.btn_logout_Leave);
            // 
            // btn_helpdesk
            // 
            this.btn_helpdesk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_helpdesk.FlatAppearance.BorderSize = 0;
            this.btn_helpdesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_helpdesk.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_helpdesk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_helpdesk.Image = global::Walmart_OMS.Properties.Resources.help_24__1_;
            this.btn_helpdesk.Location = new System.Drawing.Point(0, 472);
            this.btn_helpdesk.Name = "btn_helpdesk";
            this.btn_helpdesk.Size = new System.Drawing.Size(284, 63);
            this.btn_helpdesk.TabIndex = 1;
            this.btn_helpdesk.Text = "Help Desk";
            this.btn_helpdesk.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_helpdesk.UseVisualStyleBackColor = true;
            this.btn_helpdesk.Click += new System.EventHandler(this.btn_helpdesk_Click);
            this.btn_helpdesk.Leave += new System.EventHandler(this.btn_helpdesk_Leave);
            // 
            // btn_adminP
            // 
            this.btn_adminP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_adminP.FlatAppearance.BorderSize = 0;
            this.btn_adminP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminP.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_adminP.Image = global::Walmart_OMS.Properties.Resources.administrator_24;
            this.btn_adminP.Location = new System.Drawing.Point(0, 409);
            this.btn_adminP.Name = "btn_adminP";
            this.btn_adminP.Size = new System.Drawing.Size(284, 63);
            this.btn_adminP.TabIndex = 1;
            this.btn_adminP.Text = "Admin Panel";
            this.btn_adminP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_adminP.UseVisualStyleBackColor = true;
            this.btn_adminP.Click += new System.EventHandler(this.btn_adminP_Click);
            this.btn_adminP.Leave += new System.EventHandler(this.btn_adminP_Leave);
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_settings.Image = global::Walmart_OMS.Properties.Resources.settings;
            this.btn_settings.Location = new System.Drawing.Point(0, 346);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(284, 63);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.Leave += new System.EventHandler(this.btn_settings_Leave);
            // 
            // btn_leave
            // 
            this.btn_leave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_leave.FlatAppearance.BorderSize = 0;
            this.btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_leave.Image = global::Walmart_OMS.Properties.Resources.holiday;
            this.btn_leave.Location = new System.Drawing.Point(0, 283);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(284, 63);
            this.btn_leave.TabIndex = 1;
            this.btn_leave.Text = "Leave";
            this.btn_leave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_leave.UseVisualStyleBackColor = true;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            this.btn_leave.Leave += new System.EventHandler(this.btn_leave_Leave);
            // 
            // btn_orders
            // 
            this.btn_orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_orders.FlatAppearance.BorderSize = 0;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_orders.Image = global::Walmart_OMS.Properties.Resources.diagram;
            this.btn_orders.Location = new System.Drawing.Point(0, 220);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(284, 63);
            this.btn_orders.TabIndex = 1;
            this.btn_orders.Text = "Orders";
            this.btn_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            this.btn_orders.Leave += new System.EventHandler(this.btn_orders_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_version);
            this.panel2.Controls.Add(this.lbl_userid);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.pB_profile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 220);
            this.panel2.TabIndex = 0;
            // 
            // btn_version
            // 
            this.btn_version.FlatAppearance.BorderSize = 0;
            this.btn_version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_version.ForeColor = System.Drawing.Color.Transparent;
            this.btn_version.Image = global::Walmart_OMS.Properties.Resources.info_5_24;
            this.btn_version.Location = new System.Drawing.Point(12, 12);
            this.btn_version.Name = "btn_version";
            this.btn_version.Size = new System.Drawing.Size(36, 38);
            this.btn_version.TabIndex = 3;
            this.btn_version.UseVisualStyleBackColor = true;
            this.btn_version.Click += new System.EventHandler(this.btn_version_Click);
            // 
            // lbl_userid
            // 
            this.lbl_userid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_userid.Location = new System.Drawing.Point(12, 156);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(79, 23);
            this.lbl_userid.TabIndex = 2;
            this.lbl_userid.Text = "Emp. ID:";
            this.lbl_userid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_username.Location = new System.Drawing.Point(12, 133);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 23);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Emp. Name";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pB_profile
            // 
            this.pB_profile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pB_profile.Image = ((System.Drawing.Image)(resources.GetObject("pB_profile.Image")));
            this.pB_profile.Location = new System.Drawing.Point(92, 22);
            this.pB_profile.Name = "pB_profile";
            this.pB_profile.Size = new System.Drawing.Size(100, 97);
            this.pB_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_profile.TabIndex = 0;
            this.pB_profile.TabStop = false;
            this.pB_profile.Click += new System.EventHandler(this.pB_profile_Click);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_title.Controls.Add(this.panel_datetime);
            this.panel_title.Controls.Add(this.btn_maximize);
            this.panel_title.Controls.Add(this.btn_minimize);
            this.panel_title.Controls.Add(this.btn_exit);
            this.panel_title.Controls.Add(this.lbl_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(284, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1186, 133);
            this.panel_title.TabIndex = 3;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            // 
            // panel_datetime
            // 
            this.panel_datetime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_datetime.Controls.Add(this.pictureBox2);
            this.panel_datetime.Controls.Add(this.lbl_date);
            this.panel_datetime.Controls.Add(this.lbl_time);
            this.panel_datetime.Location = new System.Drawing.Point(362, 3);
            this.panel_datetime.Name = "panel_datetime";
            this.panel_datetime.Size = new System.Drawing.Size(654, 124);
            this.panel_datetime.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Walmart_OMS.Properties.Resources.clock_3_64;
            this.pictureBox2.Location = new System.Drawing.Point(526, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_date.Location = new System.Drawing.Point(30, 64);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(83, 37);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_time.Location = new System.Drawing.Point(30, 19);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(87, 37);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "Time";
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_maximize.Image = global::Walmart_OMS.Properties.Resources.maximize_window_24;
            this.btn_maximize.Location = new System.Drawing.Point(1114, 9);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(25, 25);
            this.btn_maximize.TabIndex = 3;
            this.btn_maximize.UseVisualStyleBackColor = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_minimize.Image = global::Walmart_OMS.Properties.Resources.minimize_window_24;
            this.btn_minimize.Location = new System.Drawing.Point(1076, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(25, 25);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_exit.Image = global::Walmart_OMS.Properties.Resources.close_window_24;
            this.btn_exit.Location = new System.Drawing.Point(1152, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(25, 25);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_title.Location = new System.Drawing.Point(40, 49);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(200, 44);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Dashboard";
            // 
            // panelCf
            // 
            this.panelCf.Controls.Add(this.pB_intro);
            this.panelCf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCf.Location = new System.Drawing.Point(284, 133);
            this.panelCf.Name = "panelCf";
            this.panelCf.Size = new System.Drawing.Size(1186, 796);
            this.panelCf.TabIndex = 4;
            // 
            // pB_intro
            // 
            this.pB_intro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pB_intro.Image = ((System.Drawing.Image)(resources.GetObject("pB_intro.Image")));
            this.pB_intro.Location = new System.Drawing.Point(0, 0);
            this.pB_intro.Name = "pB_intro";
            this.pB_intro.Size = new System.Drawing.Size(1186, 796);
            this.pB_intro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_intro.TabIndex = 0;
            this.pB_intro.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Staff_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1470, 929);
            this.Controls.Add(this.panelCf);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel1);
            this.Name = "Staff_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Dashboard";
            this.Load += new System.EventHandler(this.Staff_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_profile)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_datetime.ResumeLayout(false);
            this.panel_datetime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_intro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pB_profile;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_datetime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panelCf;
        private System.Windows.Forms.Button btn_adminP;
        private System.Windows.Forms.Button btn_helpdesk;
        private System.Windows.Forms.Button btn_version;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pB_intro;
    }
}