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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public static string eid;
        public static string empid
        {
            get { return empid; }
            set { empid = value; }
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");
                con.Open();

                cmd = new SqlCommand("SELECT EID,First_Name,Last_Name,Contact_No FROM Staff", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_staff.DataSource = dt;

                cmd = new SqlCommand("SELECT EID,First_Name,Last_Name,Contact_No FROM Admins ", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dgv_admins.DataSource = dt1;

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dgv_staff.Refresh();
            dgv_admins.Refresh();

            try
            {
                con.Open();

                cmd = new SqlCommand("SELECT * FROM Admins WHERE EID = '" + Staff_Login.EID + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    txt_eiddelete.ReadOnly = true;
                    MessageBox.Show("You are not allowed to delete employees", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("SELECT * FROM Staff WHERE EID = '" + txt_eiddelete.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        cmd = new SqlCommand("DELETE FROM Staff WHERE EID='" + txt_eiddelete.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("DELETE FROM All_Staff WHERE EID='" + txt_eiddelete.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Employee deletion successful !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("SELECT * FROM Admins WHERE EID='" + txt_eiddelete.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            cmd = new SqlCommand("DELETE FROM Admins WHERE EID='" + txt_eiddelete.Text + "'", con);
                            cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("DELETE FROM All_Staff WHERE EID='" + txt_eiddelete.Text + "'", con);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Admin deleted successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("SELECT * FROM Super_Admins WHERE EID='" + txt_eiddelete.Text + "'", con);
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                dr.Close();
                                MessageBox.Show("You cannot delete a SUPER ADMIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("No such employee was found in the server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    

                }
                con.Close();

                txt_eiddelete.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                eid = txt_eidupdate.Text;
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Super_Admins WHERE EID='" + txt_eidupdate.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    cmd = new SqlCommand("SELECT * FROM Admins WHERE EID='" + Staff_Login.EID + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("You need elevated access to update a SUPER ADMIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        Update_Employee ue = new Update_Employee();
                        ue.Show();
                    }
                }
                else
                {
                    dr.Close();
                    Update_Employee ue = new Update_Employee();
                    ue.Show();
                }
                con.Close();

                txt_eidupdate.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
