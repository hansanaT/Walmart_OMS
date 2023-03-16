namespace Walmart_OMS
{
    partial class Staff_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_employee = new System.Windows.Forms.RadioButton();
            this.rbtn_admin = new System.Windows.Forms.RadioButton();
            this.rbtn_SA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.cb_showpass = new System.Windows.Forms.CheckBox();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_empID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.44493F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.55507F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 728);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 722);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.rbtn_employee);
            this.panel2.Controls.Add(this.rbtn_admin);
            this.panel2.Controls.Add(this.rbtn_SA);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.cb_showpass);
            this.panel2.Controls.Add(this.btn_proceed);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Controls.Add(this.txt_empID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(656, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 722);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // rbtn_employee
            // 
            this.rbtn_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_employee.AutoSize = true;
            this.rbtn_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.rbtn_employee.Location = new System.Drawing.Point(301, 245);
            this.rbtn_employee.Name = "rbtn_employee";
            this.rbtn_employee.Size = new System.Drawing.Size(98, 20);
            this.rbtn_employee.TabIndex = 7;
            this.rbtn_employee.TabStop = true;
            this.rbtn_employee.Text = "Employee";
            this.rbtn_employee.UseVisualStyleBackColor = true;
            // 
            // rbtn_admin
            // 
            this.rbtn_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_admin.AutoSize = true;
            this.rbtn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.rbtn_admin.Location = new System.Drawing.Point(217, 245);
            this.rbtn_admin.Name = "rbtn_admin";
            this.rbtn_admin.Size = new System.Drawing.Size(71, 20);
            this.rbtn_admin.TabIndex = 7;
            this.rbtn_admin.TabStop = true;
            this.rbtn_admin.Text = "Admin";
            this.rbtn_admin.UseVisualStyleBackColor = true;
            // 
            // rbtn_SA
            // 
            this.rbtn_SA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_SA.AutoSize = true;
            this.rbtn_SA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_SA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.rbtn_SA.Location = new System.Drawing.Point(85, 245);
            this.rbtn_SA.Name = "rbtn_SA";
            this.rbtn_SA.Size = new System.Drawing.Size(116, 20);
            this.rbtn_SA.TabIndex = 7;
            this.rbtn_SA.TabStop = true;
            this.rbtn_SA.Text = "Super Admin";
            this.rbtn_SA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(176, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account Type";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackColor = System.Drawing.Color.Red;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(77, 530);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(341, 54);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cb_showpass
            // 
            this.cb_showpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_showpass.AutoSize = true;
            this.cb_showpass.ForeColor = System.Drawing.Color.White;
            this.cb_showpass.Location = new System.Drawing.Point(298, 424);
            this.cb_showpass.Name = "cb_showpass";
            this.cb_showpass.Size = new System.Drawing.Size(125, 20);
            this.cb_showpass.TabIndex = 4;
            this.cb_showpass.Text = "Show Password";
            this.cb_showpass.UseVisualStyleBackColor = true;
            this.cb_showpass.CheckedChanged += new System.EventHandler(this.cb_showpass_CheckedChanged);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_proceed.BackColor = System.Drawing.Color.Navy;
            this.btn_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_proceed.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proceed.ForeColor = System.Drawing.Color.White;
            this.btn_proceed.Location = new System.Drawing.Point(77, 465);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(341, 59);
            this.btn_proceed.TabIndex = 3;
            this.btn_proceed.Text = "PROCEED";
            this.btn_proceed.UseVisualStyleBackColor = false;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_password.Location = new System.Drawing.Point(77, 378);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(341, 38);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_leave);
            // 
            // txt_empID
            // 
            this.txt_empID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_empID.Location = new System.Drawing.Point(77, 303);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.Size = new System.Drawing.Size(341, 38);
            this.txt_empID.TabIndex = 1;
            this.txt_empID.Text = "Employee ID";
            this.txt_empID.Enter += new System.EventHandler(this.txt_empID_enter);
            this.txt_empID.Leave += new System.EventHandler(this.txt_empID_leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(68, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFF LOG IN";
            // 
            // Staff_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1138, 728);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Staff_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Login";
            this.Load += new System.EventHandler(this.Staff_Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_empID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.CheckBox cb_showpass;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_employee;
        private System.Windows.Forms.RadioButton rbtn_admin;
        private System.Windows.Forms.RadioButton rbtn_SA;
    }
}