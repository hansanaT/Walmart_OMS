using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT (Order_ID) FROM Orders WHERE User_ID='" + Login.UID + "'",con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                string suffix = "No.of Orders : ";
                lbl_noofOrders.Text = suffix + count.ToString();
                con.Close();

            

                con.Open();
                cmd = new SqlCommand("SELECT SUM (Total_Amount) FROM Orders WHERE User_ID='" + Login.UID + "'", con);
                int sum = Convert.ToInt32(cmd.ExecuteScalar());
                string suffix1 = "Total Expenses(LKR) : ";
                lbl_expenses.Text = suffix1 + sum.ToString();
                con.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Place some orders to see Expenses","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
