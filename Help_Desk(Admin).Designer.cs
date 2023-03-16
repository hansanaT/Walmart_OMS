namespace Walmart_OMS
{
    partial class Help_Desk_Admin_
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
            this.dgv_pending = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_resolved = new System.Windows.Forms.Button();
            this.btn_searchIssues = new System.Windows.Forms.Button();
            this.txt_cusIDpending = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_resolved = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resolved)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.panel1.Controls.Add(this.dgv_pending);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 743);
            this.panel1.TabIndex = 0;
            // 
            // dgv_pending
            // 
            this.dgv_pending.AllowUserToAddRows = false;
            this.dgv_pending.AllowUserToDeleteRows = false;
            this.dgv_pending.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pending.Location = new System.Drawing.Point(0, 167);
            this.dgv_pending.Name = "dgv_pending";
            this.dgv_pending.ReadOnly = true;
            this.dgv_pending.RowHeadersWidth = 51;
            this.dgv_pending.RowTemplate.Height = 24;
            this.dgv_pending.Size = new System.Drawing.Size(578, 576);
            this.dgv_pending.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel5.Controls.Add(this.btn_resolved);
            this.panel5.Controls.Add(this.btn_searchIssues);
            this.panel5.Controls.Add(this.txt_cusIDpending);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(578, 67);
            this.panel5.TabIndex = 1;
            // 
            // btn_resolved
            // 
            this.btn_resolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_resolved.BackColor = System.Drawing.Color.Red;
            this.btn_resolved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resolved.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resolved.ForeColor = System.Drawing.Color.White;
            this.btn_resolved.Location = new System.Drawing.Point(344, 16);
            this.btn_resolved.Name = "btn_resolved";
            this.btn_resolved.Size = new System.Drawing.Size(216, 37);
            this.btn_resolved.TabIndex = 5;
            this.btn_resolved.Text = "Add to Resolved issues";
            this.btn_resolved.UseVisualStyleBackColor = false;
            this.btn_resolved.Click += new System.EventHandler(this.btn_resolved_Click);
            // 
            // btn_searchIssues
            // 
            this.btn_searchIssues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_searchIssues.FlatAppearance.BorderSize = 0;
            this.btn_searchIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchIssues.Image = global::Walmart_OMS.Properties.Resources.search_9_24;
            this.btn_searchIssues.Location = new System.Drawing.Point(295, 15);
            this.btn_searchIssues.Name = "btn_searchIssues";
            this.btn_searchIssues.Size = new System.Drawing.Size(43, 41);
            this.btn_searchIssues.TabIndex = 4;
            this.btn_searchIssues.UseVisualStyleBackColor = true;
            this.btn_searchIssues.Click += new System.EventHandler(this.btn_searchIssues_Click);
            // 
            // txt_cusIDpending
            // 
            this.txt_cusIDpending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cusIDpending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusIDpending.Location = new System.Drawing.Point(189, 23);
            this.txt_cusIDpending.Name = "txt_cusIDpending";
            this.txt_cusIDpending.Size = new System.Drawing.Size(100, 24);
            this.txt_cusIDpending.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer/Employee ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pending App Issues";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_resolved);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(587, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 743);
            this.panel2.TabIndex = 1;
            // 
            // dgv_resolved
            // 
            this.dgv_resolved.AllowUserToAddRows = false;
            this.dgv_resolved.AllowUserToDeleteRows = false;
            this.dgv_resolved.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_resolved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resolved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resolved.Location = new System.Drawing.Point(0, 167);
            this.dgv_resolved.Name = "dgv_resolved";
            this.dgv_resolved.ReadOnly = true;
            this.dgv_resolved.RowHeadersWidth = 51;
            this.dgv_resolved.RowTemplate.Height = 24;
            this.dgv_resolved.Size = new System.Drawing.Size(578, 576);
            this.dgv_resolved.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.btn_refresh);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(578, 67);
            this.panel6.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_refresh.Image = global::Walmart_OMS.Properties.Resources.refresh_24;
            this.btn_refresh.Location = new System.Drawing.Point(373, 14);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(196, 46);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(197, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Walmart_OMS.Properties.Resources.search_9_24;
            this.button1.Location = new System.Drawing.Point(303, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_searchIssues_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer/Employee ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 100);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resolved App Issues";
            // 
            // Help_Desk_Admin_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Help_Desk_Admin_";
            this.Text = "Help Desk";
            this.Load += new System.EventHandler(this.Help_Desk_Admin__Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resolved)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_pending;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_cusIDpending;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_resolved;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_resolved;
        private System.Windows.Forms.Button btn_searchIssues;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_refresh;
    }
}