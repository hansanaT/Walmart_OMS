namespace Walmart_OMS
{
    partial class Leave
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_create = new System.Windows.Forms.Button();
            this.cmb_leaveType = new System.Windows.Forms.ComboBox();
            this.dTP_end = new System.Windows.Forms.DateTimePicker();
            this.dTP_start = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_reason = new System.Windows.Forms.RichTextBox();
            this.txt_eidCreate = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rtxt_reasonCancel = new System.Windows.Forms.RichTextBox();
            this.txt_eidCancel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.99657F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.00343F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.cmb_leaveType);
            this.panel1.Controls.Add(this.dTP_end);
            this.panel1.Controls.Add(this.dTP_start);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rtxt_reason);
            this.panel1.Controls.Add(this.txt_eidCreate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 743);
            this.panel1.TabIndex = 0;
            // 
            // btn_create
            // 
            this.btn_create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_create.Location = new System.Drawing.Point(197, 653);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(223, 54);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Create Leave";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // cmb_leaveType
            // 
            this.cmb_leaveType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_leaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_leaveType.FormattingEnabled = true;
            this.cmb_leaveType.Items.AddRange(new object[] {
            "",
            "Personal",
            "Medical",
            "Official",
            "Mandatory",
            "Maternity",
            "Half-Pay",
            "No-Pay"});
            this.cmb_leaveType.Location = new System.Drawing.Point(250, 350);
            this.cmb_leaveType.Name = "cmb_leaveType";
            this.cmb_leaveType.Size = new System.Drawing.Size(200, 33);
            this.cmb_leaveType.TabIndex = 5;
            // 
            // dTP_end
            // 
            this.dTP_end.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTP_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_end.Location = new System.Drawing.Point(250, 271);
            this.dTP_end.Name = "dTP_end";
            this.dTP_end.Size = new System.Drawing.Size(345, 30);
            this.dTP_end.TabIndex = 4;
            // 
            // dTP_start
            // 
            this.dTP_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTP_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_start.Location = new System.Drawing.Point(250, 198);
            this.dTP_start.Name = "dTP_start";
            this.dTP_start.Size = new System.Drawing.Size(345, 30);
            this.dTP_start.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(26, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Reason (briefly describe):";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(26, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Leave Type:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(26, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Leave End Date:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(26, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leave Start Date:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee ID:";
            // 
            // rtxt_reason
            // 
            this.rtxt_reason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxt_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_reason.Location = new System.Drawing.Point(87, 463);
            this.rtxt_reason.Name = "rtxt_reason";
            this.rtxt_reason.Size = new System.Drawing.Size(479, 164);
            this.rtxt_reason.TabIndex = 2;
            this.rtxt_reason.Text = "";
            // 
            // txt_eidCreate
            // 
            this.txt_eidCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_eidCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eidCreate.Location = new System.Drawing.Point(250, 129);
            this.txt_eidCreate.Name = "txt_eidCreate";
            this.txt_eidCreate.ReadOnly = true;
            this.txt_eidCreate.Size = new System.Drawing.Size(122, 30);
            this.txt_eidCreate.TabIndex = 1;
            this.txt_eidCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(185, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Leave";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.rtxt_reasonCancel);
            this.panel2.Controls.Add(this.txt_eidCancel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(621, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 743);
            this.panel2.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(166, 536);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(223, 54);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel Leave";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // rtxt_reasonCancel
            // 
            this.rtxt_reasonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxt_reasonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_reasonCancel.Location = new System.Drawing.Point(40, 253);
            this.rtxt_reasonCancel.Name = "rtxt_reasonCancel";
            this.rtxt_reasonCancel.Size = new System.Drawing.Size(483, 233);
            this.rtxt_reasonCancel.TabIndex = 3;
            this.rtxt_reasonCancel.Text = "";
            // 
            // txt_eidCancel
            // 
            this.txt_eidCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_eidCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eidCancel.Location = new System.Drawing.Point(220, 127);
            this.txt_eidCancel.Name = "txt_eidCancel";
            this.txt_eidCancel.ReadOnly = true;
            this.txt_eidCancel.Size = new System.Drawing.Size(122, 30);
            this.txt_eidCancel.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(34, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(401, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "Would you like to tell the reason:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(34, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Employee ID:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(544, 100);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(150, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cancel Leave";
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1168, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Leave";
            this.Text = "Leave";
            this.Load += new System.EventHandler(this.Leave_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_leaveType;
        private System.Windows.Forms.DateTimePicker dTP_end;
        private System.Windows.Forms.DateTimePicker dTP_start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_reason;
        private System.Windows.Forms.TextBox txt_eidCreate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxt_reasonCancel;
        private System.Windows.Forms.TextBox txt_eidCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
    }
}