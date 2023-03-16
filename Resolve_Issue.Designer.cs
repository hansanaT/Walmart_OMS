namespace Walmart_OMS
{
    partial class Resolve_Issue
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
            this.txt_caseno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_resolved = new System.Windows.Forms.Button();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_caseno
            // 
            this.txt_caseno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_caseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_caseno.Location = new System.Drawing.Point(252, 121);
            this.txt_caseno.Name = "txt_caseno";
            this.txt_caseno.Size = new System.Drawing.Size(148, 30);
            this.txt_caseno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Case #:";
            // 
            // btn_resolved
            // 
            this.btn_resolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_resolved.BackColor = System.Drawing.Color.Red;
            this.btn_resolved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resolved.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resolved.ForeColor = System.Drawing.Color.White;
            this.btn_resolved.Location = new System.Drawing.Point(146, 202);
            this.btn_resolved.Name = "btn_resolved";
            this.btn_resolved.Size = new System.Drawing.Size(254, 50);
            this.btn_resolved.TabIndex = 6;
            this.btn_resolved.Text = "Add to Resolved issues";
            this.btn_resolved.UseVisualStyleBackColor = false;
            this.btn_resolved.Click += new System.EventHandler(this.btn_resolved_Click);
            // 
            // txt_uid
            // 
            this.txt_uid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uid.Location = new System.Drawing.Point(252, 71);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(148, 30);
            this.txt_uid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 36);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_exit.Image = global::Walmart_OMS.Properties.Resources.close_window_24;
            this.btn_exit.Location = new System.Drawing.Point(519, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(25, 25);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Resolve_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(556, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_resolved);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_caseno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Resolve_Issue";
            this.Text = "Resolve_Issue";
            this.Load += new System.EventHandler(this.Resolve_Issue_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resolve_Issue_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_caseno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_resolved;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
    }
}