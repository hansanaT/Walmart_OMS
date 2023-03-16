namespace Walmart_OMS
{
    partial class Orders
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
            this.panelExpenses = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_carts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_oid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_neworder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelExpenses.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelOrders.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelExpenses, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelOrders, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 749);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelExpenses
            // 
            this.panelExpenses.BackColor = System.Drawing.Color.CadetBlue;
            this.panelExpenses.Controls.Add(this.panel4);
            this.panelExpenses.Controls.Add(this.panel2);
            this.panelExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExpenses.Location = new System.Drawing.Point(587, 3);
            this.panelExpenses.Name = "panelExpenses";
            this.panelExpenses.Size = new System.Drawing.Size(578, 743);
            this.panelExpenses.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_carts);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 588);
            this.panel4.TabIndex = 3;
            // 
            // dgv_carts
            // 
            this.dgv_carts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_carts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_carts.Location = new System.Drawing.Point(0, 0);
            this.dgv_carts.Name = "dgv_carts";
            this.dgv_carts.RowHeadersWidth = 51;
            this.dgv_carts.RowTemplate.Height = 24;
            this.dgv_carts.Size = new System.Drawing.Size(578, 588);
            this.dgv_carts.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.btn_invoice);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.txt_oid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 155);
            this.panel2.TabIndex = 2;
            // 
            // btn_invoice
            // 
            this.btn_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_invoice.BackColor = System.Drawing.Color.Teal;
            this.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_invoice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.ForeColor = System.Drawing.Color.Transparent;
            this.btn_invoice.Location = new System.Drawing.Point(278, 89);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(291, 46);
            this.btn_invoice.TabIndex = 4;
            this.btn_invoice.Text = "Create Invoice for this order";
            this.btn_invoice.UseVisualStyleBackColor = false;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(239, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 27);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_oid
            // 
            this.txt_oid.Location = new System.Drawing.Point(91, 15);
            this.txt_oid.Name = "txt_oid";
            this.txt_oid.Size = new System.Drawing.Size(130, 22);
            this.txt_oid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saved Carts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Order ID:";
            // 
            // panelOrders
            // 
            this.panelOrders.BackColor = System.Drawing.Color.LightCoral;
            this.panelOrders.Controls.Add(this.panel3);
            this.panelOrders.Controls.Add(this.panel1);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(3, 3);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(578, 743);
            this.panelOrders.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_orders);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 588);
            this.panel3.TabIndex = 3;
            // 
            // dgv_orders
            // 
            this.dgv_orders.AllowUserToAddRows = false;
            this.dgv_orders.AllowUserToDeleteRows = false;
            this.dgv_orders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_orders.Location = new System.Drawing.Point(0, 0);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.ReadOnly = true;
            this.dgv_orders.RowHeadersWidth = 51;
            this.dgv_orders.RowTemplate.Height = 24;
            this.dgv_orders.Size = new System.Drawing.Size(578, 588);
            this.dgv_orders.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_neworder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 155);
            this.panel1.TabIndex = 2;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_refresh.Image = global::Walmart_OMS.Properties.Resources.refresh_24;
            this.btn_refresh.Location = new System.Drawing.Point(344, 83);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(220, 46);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_neworder
            // 
            this.btn_neworder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_neworder.BackColor = System.Drawing.Color.Lime;
            this.btn_neworder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_neworder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_neworder.ForeColor = System.Drawing.Color.White;
            this.btn_neworder.Location = new System.Drawing.Point(402, 9);
            this.btn_neworder.Name = "btn_neworder";
            this.btn_neworder.Size = new System.Drawing.Size(162, 49);
            this.btn_neworder.TabIndex = 2;
            this.btn_neworder.Text = "New Order";
            this.btn_neworder.UseVisualStyleBackColor = false;
            this.btn_neworder.Click += new System.EventHandler(this.btn_neworder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders Placed";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1168, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelExpenses.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelOrders.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelExpenses;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_carts;
        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_oid;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_neworder;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_invoice;
    }
}