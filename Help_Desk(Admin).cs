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
    public partial class Help_Desk_Admin_ : Form
    {
        public Help_Desk_Admin_()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void Help_Desk_Admin__Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT User_ID,Issue_Reference,App_Version,Issue_Description FROM App_Issues", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_pending.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_resolved_Click(object sender, EventArgs e)
        {
            Resolve_Issue ri = new Resolve_Issue();
            ri.Show();
        }

        private void btn_searchIssues_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT Issue_Reference,App_Version,Issue_Description FROM App_Issues WHERE User_ID='"+txt_cusIDpending.Text+"'", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_pending.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Resolved_App_Issues", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_resolved.DataSource = dt;
                con.Close();

                con.Open();
                cmd = new SqlCommand("SELECT User_ID,Issue_Reference,App_Version,Issue_Description FROM App_Issues", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                dgv_pending.DataSource = dt1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
