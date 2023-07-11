namespace Walmart_OMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.cb_showpassword = new System.Windows.Forms.CheckBox();
            this.btn_continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_google = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.18962F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.81038F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 665);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btn_google);
            this.panel1.Controls.Add(this.txt_userid);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.cb_showpassword);
            this.panel1.Controls.Add(this.btn_continue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 659);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // txt_userid
            // 
            this.txt_userid.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userid.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_userid.Location = new System.Drawing.Point(179, 124);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.ReadOnly = true;
            this.txt_userid.Size = new System.Drawing.Size(188, 46);
            this.txt_userid.TabIndex = 6;
            this.txt_userid.Text = "User ID";
            this.txt_userid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_userid.Enter += new System.EventHandler(this.txt_userid_enter);
            this.txt_userid.Leave += new System.EventHandler(this.txt_userid_leave);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Red;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(55, 524);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(438, 57);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cb_showpassword
            // 
            this.cb_showpassword.AutoSize = true;
            this.cb_showpassword.ForeColor = System.Drawing.Color.White;
            this.cb_showpassword.Location = new System.Drawing.Point(368, 385);
            this.cb_showpassword.Name = "cb_showpassword";
            this.cb_showpassword.Size = new System.Drawing.Size(125, 20);
            this.cb_showpassword.TabIndex = 3;
            this.cb_showpassword.Text = "Show Password";
            this.cb_showpassword.UseVisualStyleBackColor = true;
            this.cb_showpassword.CheckedChanged += new System.EventHandler(this.cb_showpassword_CheckedChanged);
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_continue.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_continue.Location = new System.Drawing.Point(55, 443);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(438, 57);
            this.btn_continue.TabIndex = 4;
            this.btn_continue.Text = "CONTINUE";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(161, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIGN IN";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_password.Location = new System.Drawing.Point(55, 313);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(438, 46);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_leave);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_username.Location = new System.Drawing.Point(55, 220);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(438, 46);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Username";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 659);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btn_google
            // 
            this.btn_google.Location = new System.Drawing.Point(55, 603);
            this.btn_google.Name = "btn_google";
            this.btn_google.Size = new System.Drawing.Size(438, 47);
            this.btn_google.TabIndex = 7;
            this.btn_google.Text = "Sign in with Google";
            this.btn_google.UseVisualStyleBackColor = true;
            this.btn_google.Click += new System.EventHandler(this.btn_google_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1002, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_showpassword;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Button btn_google;
    }
}