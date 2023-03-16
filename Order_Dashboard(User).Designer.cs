namespace Walmart_OMS
{
    partial class Order_Dashboard_User_
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
            this.lbl_netamount = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_product = new System.Windows.Forms.GroupBox();
            this.btn_additem = new System.Windows.Forms.Button();
            this.cmb_productName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.txt_netamount = new System.Windows.Forms.TextBox();
            this.gb_Customer = new System.Windows.Forms.GroupBox();
            this.rbtn_delivery = new System.Windows.Forms.RadioButton();
            this.rbtn_pickup = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mobileno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_product.SuspendLayout();
            this.gb_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_netamount
            // 
            this.lbl_netamount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_netamount.AutoSize = true;
            this.lbl_netamount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_netamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_netamount.Location = new System.Drawing.Point(1211, 757);
            this.lbl_netamount.Name = "lbl_netamount";
            this.lbl_netamount.Size = new System.Drawing.Size(198, 27);
            this.lbl_netamount.TabIndex = 13;
            this.lbl_netamount.Text = "Net Amount(LKR):";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1225, 650);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(161, 40);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_cls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cls.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cls.ForeColor = System.Drawing.Color.White;
            this.btn_cls.Location = new System.Drawing.Point(1225, 574);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(161, 40);
            this.btn_cls.TabIndex = 10;
            this.btn_cls.Text = "Clear Cart";
            this.btn_cls.UseVisualStyleBackColor = false;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(1225, 498);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(161, 40);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete Item";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1225, 422);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(161, 40);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 368);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1144, 521);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 407;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unit Price";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 195;
            // 
            // gb_product
            // 
            this.gb_product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_product.Controls.Add(this.btn_additem);
            this.gb_product.Controls.Add(this.cmb_productName);
            this.gb_product.Controls.Add(this.label7);
            this.gb_product.Controls.Add(this.label9);
            this.gb_product.Controls.Add(this.label10);
            this.gb_product.Controls.Add(this.label1);
            this.gb_product.Controls.Add(this.txt_qty);
            this.gb_product.Controls.Add(this.txt_total);
            this.gb_product.Controls.Add(this.txt_unitprice);
            this.gb_product.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.gb_product.Location = new System.Drawing.Point(15, 249);
            this.gb_product.Name = "gb_product";
            this.gb_product.Size = new System.Drawing.Size(1424, 100);
            this.gb_product.TabIndex = 6;
            this.gb_product.TabStop = false;
            this.gb_product.Text = "Product";
            // 
            // btn_additem
            // 
            this.btn_additem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_additem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_additem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_additem.ForeColor = System.Drawing.Color.White;
            this.btn_additem.Location = new System.Drawing.Point(1269, 33);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(136, 38);
            this.btn_additem.TabIndex = 2;
            this.btn_additem.Text = "Add Item";
            this.btn_additem.UseVisualStyleBackColor = false;
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // cmb_productName
            // 
            this.cmb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_productName.FormattingEnabled = true;
            this.cmb_productName.Location = new System.Drawing.Point(96, 43);
            this.cmb_productName.Name = "cmb_productName";
            this.cmb_productName.Size = new System.Drawing.Size(229, 28);
            this.cmb_productName.TabIndex = 1;
            this.cmb_productName.SelectionChangeCommitted += new System.EventHandler(this.cmb_productName_SelectionChangeCommitted);
            this.cmb_productName.SelectedValueChanged += new System.EventHandler(this.cmb_productName_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Unit Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(696, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Qty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(985, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(746, 42);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(195, 27);
            this.txt_qty.TabIndex = 1;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(1050, 41);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(195, 27);
            this.txt_total.TabIndex = 1;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitprice.Location = new System.Drawing.Point(460, 42);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.ReadOnly = true;
            this.txt_unitprice.Size = new System.Drawing.Size(195, 27);
            this.txt_unitprice.TabIndex = 1;
            this.txt_unitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_netamount
            // 
            this.txt_netamount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_netamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_netamount.Location = new System.Drawing.Point(1215, 801);
            this.txt_netamount.Name = "txt_netamount";
            this.txt_netamount.ReadOnly = true;
            this.txt_netamount.Size = new System.Drawing.Size(215, 34);
            this.txt_netamount.TabIndex = 7;
            this.txt_netamount.Text = "0";
            this.txt_netamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_Customer
            // 
            this.gb_Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Customer.Controls.Add(this.rbtn_delivery);
            this.gb_Customer.Controls.Add(this.rbtn_pickup);
            this.gb_Customer.Controls.Add(this.label8);
            this.gb_Customer.Controls.Add(this.dateTimePicker1);
            this.gb_Customer.Controls.Add(this.txt_address);
            this.gb_Customer.Controls.Add(this.txt_orderid);
            this.gb_Customer.Controls.Add(this.label6);
            this.gb_Customer.Controls.Add(this.txt_mobileno);
            this.gb_Customer.Controls.Add(this.label4);
            this.gb_Customer.Controls.Add(this.label5);
            this.gb_Customer.Controls.Add(this.txt_uid);
            this.gb_Customer.Controls.Add(this.label3);
            this.gb_Customer.Controls.Add(this.label2);
            this.gb_Customer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.gb_Customer.Location = new System.Drawing.Point(15, 21);
            this.gb_Customer.Name = "gb_Customer";
            this.gb_Customer.Size = new System.Drawing.Size(1425, 212);
            this.gb_Customer.TabIndex = 5;
            this.gb_Customer.TabStop = false;
            this.gb_Customer.Text = "Customer";
            // 
            // rbtn_delivery
            // 
            this.rbtn_delivery.AutoSize = true;
            this.rbtn_delivery.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_delivery.Location = new System.Drawing.Point(1207, 55);
            this.rbtn_delivery.Name = "rbtn_delivery";
            this.rbtn_delivery.Size = new System.Drawing.Size(101, 28);
            this.rbtn_delivery.TabIndex = 3;
            this.rbtn_delivery.TabStop = true;
            this.rbtn_delivery.Text = "Delivery";
            this.rbtn_delivery.UseVisualStyleBackColor = true;
            // 
            // rbtn_pickup
            // 
            this.rbtn_pickup.AutoSize = true;
            this.rbtn_pickup.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_pickup.Location = new System.Drawing.Point(1053, 55);
            this.rbtn_pickup.Name = "rbtn_pickup";
            this.rbtn_pickup.Size = new System.Drawing.Size(88, 28);
            this.rbtn_pickup.TabIndex = 3;
            this.rbtn_pickup.TabStop = true;
            this.rbtn_pickup.Text = "Pickup";
            this.rbtn_pickup.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "User ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(476, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(1056, 117);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(321, 27);
            this.txt_address.TabIndex = 1;
            // 
            // txt_orderid
            // 
            this.txt_orderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderid.Location = new System.Drawing.Point(133, 120);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.ReadOnly = true;
            this.txt_orderid.Size = new System.Drawing.Size(195, 27);
            this.txt_orderid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(852, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Shipping Address";
            // 
            // txt_mobileno
            // 
            this.txt_mobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobileno.Location = new System.Drawing.Point(476, 56);
            this.txt_mobileno.Name = "txt_mobileno";
            this.txt_mobileno.ReadOnly = true;
            this.txt_mobileno.Size = new System.Drawing.Size(289, 27);
            this.txt_mobileno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Order Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(852, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Order Type";
            // 
            // txt_uid
            // 
            this.txt_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uid.Location = new System.Drawing.Point(133, 56);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.ReadOnly = true;
            this.txt_uid.Size = new System.Drawing.Size(195, 27);
            this.txt_uid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order ID";
            // 
            // Order_Dashboard_User_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1454, 911);
            this.Controls.Add(this.lbl_netamount);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gb_product);
            this.Controls.Add(this.txt_netamount);
            this.Controls.Add(this.gb_Customer);
            this.Name = "Order_Dashboard_User_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Dashboard";
            this.Load += new System.EventHandler(this.Order_Dashboard_User__Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Order_Dashboard_User__MouseDown);
            this.gb_product.ResumeLayout(false);
            this.gb_product.PerformLayout();
            this.gb_Customer.ResumeLayout(false);
            this.gb_Customer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_netamount;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox gb_product;
        private System.Windows.Forms.Button btn_additem;
        private System.Windows.Forms.ComboBox cmb_productName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.TextBox txt_netamount;
        private System.Windows.Forms.GroupBox gb_Customer;
        private System.Windows.Forms.RadioButton rbtn_delivery;
        private System.Windows.Forms.RadioButton rbtn_pickup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mobileno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}