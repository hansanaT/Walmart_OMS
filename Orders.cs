using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataAdapter da1;

        public static string orderID;
        public static string OID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");
                con.Open();
                da = new SqlDataAdapter("SELECT Order_ID,User_ID,Mobile_Fixed_No,Order_Date,Order_Type,Shipping_Address,Total_Amount FROM Orders WHERE User_ID='" + Login.UID + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_orders.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da1 = new SqlDataAdapter("select * from Carts where Order_ID='" + txt_oid.Text + "'", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dgv_carts.DataSource = dt1;
                con.Close();
                
                OID = txt_oid.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_neworder_Click(object sender, EventArgs e)
        {
            Order_Dashboard_User_ od = new Order_Dashboard_User_();
            od.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT Order_ID,User_ID,Mobile_Fixed_No,Order_Date,Order_Type,Shipping_Address,Total_Amount FROM Orders WHERE User_ID='" + Login.UID + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_orders.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.Show();
        }
    }
}
