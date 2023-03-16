namespace Walmart_OMS
{
    partial class User_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_datetime = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panelCf = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pB_intro = new System.Windows.Forms.PictureBox();
            this.pB_clock = new System.Windows.Forms.PictureBox();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_contactus = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_version = new System.Windows.Forms.Button();
            this.pB_profile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.panel_datetime.SuspendLayout();
            this.panelCf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_intro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel_nav);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_contactus);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_orders);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 929);
            this.panel1.TabIndex = 0;
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel_nav.Location = new System.Drawing.Point(0, 283);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(3, 100);
            this.panel_nav.TabIndex = 3;
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
            // lbl_userid
            // 
            this.lbl_userid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_userid.Location = new System.Drawing.Point(14, 160);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(57, 17);
            this.lbl_userid.TabIndex = 2;
            this.lbl_userid.Text = "User ID:";
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_username.Location = new System.Drawing.Point(12, 132);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(106, 28);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
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
            this.panel_title.TabIndex = 2;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_mousedown);
            // 
            // panel_datetime
            // 
            this.panel_datetime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_datetime.Controls.Add(this.pB_clock);
            this.panel_datetime.Controls.Add(this.lbl_date);
            this.panel_datetime.Controls.Add(this.lbl_time);
            this.panel_datetime.Location = new System.Drawing.Point(362, 3);
            this.panel_datetime.Name = "panel_datetime";
            this.panel_datetime.Size = new System.Drawing.Size(654, 124);
            this.panel_datetime.TabIndex = 4;
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
            this.panelCf.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pB_intro
            // 
            this.pB_intro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pB_intro.Image = global::Walmart_OMS.Properties.Resources._2018_innovationsslideshow_02;
            this.pB_intro.Location = new System.Drawing.Point(0, 0);
            this.pB_intro.Name = "pB_intro";
            this.pB_intro.Size = new System.Drawing.Size(1186, 796);
            this.pB_intro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_intro.TabIndex = 0;
            this.pB_intro.TabStop = false;
            // 
            // pB_clock
            // 
            this.pB_clock.Image = global::Walmart_OMS.Properties.Resources.clock_3_64;
            this.pB_clock.Location = new System.Drawing.Point(526, 17);
            this.pB_clock.Name = "pB_clock";
            this.pB_clock.Size = new System.Drawing.Size(100, 87);
            this.pB_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pB_clock.TabIndex = 1;
            this.pB_clock.TabStop = false;
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
            this.btn_logout.Leave += new System.EventHandler(this.btn_logout_leave);
            // 
            // btn_contactus
            // 
            this.btn_contactus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contactus.FlatAppearance.BorderSize = 0;
            this.btn_contactus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contactus.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contactus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_contactus.Image = global::Walmart_OMS.Properties.Resources.Conact;
            this.btn_contactus.Location = new System.Drawing.Point(0, 409);
            this.btn_contactus.Name = "btn_contactus";
            this.btn_contactus.Size = new System.Drawing.Size(284, 63);
            this.btn_contactus.TabIndex = 1;
            this.btn_contactus.Text = "Contact Us";
            this.btn_contactus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_contactus.UseVisualStyleBackColor = true;
            this.btn_contactus.Click += new System.EventHandler(this.btn_contactus_Click);
            this.btn_contactus.Leave += new System.EventHandler(this.btn_contactus_leave);
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
            this.btn_settings.Leave += new System.EventHandler(this.btn_settings_leave);
            // 
            // btn_orders
            // 
            this.btn_orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_orders.FlatAppearance.BorderSize = 0;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_orders.Image = global::Walmart_OMS.Properties.Resources.diagram;
            this.btn_orders.Location = new System.Drawing.Point(0, 283);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(284, 63);
            this.btn_orders.TabIndex = 1;
            this.btn_orders.Text = "Orders";
            this.btn_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            this.btn_orders.Leave += new System.EventHandler(this.btn_orders_leave);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_dashboard.Image = global::Walmart_OMS.Properties.Resources.home;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 220);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(284, 63);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            this.btn_dashboard.Leave += new System.EventHandler(this.btn_dashboard_leave);
            // 
            // btn_version
            // 
            this.btn_version.FlatAppearance.BorderSize = 0;
            this.btn_version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_version.ForeColor = System.Drawing.Color.Transparent;
            this.btn_version.Image = global::Walmart_OMS.Properties.Resources.info_5_24;
            this.btn_version.Location = new System.Drawing.Point(12, 16);
            this.btn_version.Name = "btn_version";
            this.btn_version.Size = new System.Drawing.Size(36, 38);
            this.btn_version.TabIndex = 4;
            this.btn_version.UseVisualStyleBackColor = true;
            this.btn_version.Click += new System.EventHandler(this.btn_version_Click);
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
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1470, 929);
            this.Controls.Add(this.panelCf);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel1);
            this.Name = "User_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.User_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_datetime.ResumeLayout(false);
            this.panel_datetime.PerformLayout();
            this.panelCf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_intro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pB_profile;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_contactus;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panelCf;
        private System.Windows.Forms.Panel panel_datetime;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pB_clock;
        private System.Windows.Forms.PictureBox pB_intro;
        private System.Windows.Forms.Button btn_version;
    }
}