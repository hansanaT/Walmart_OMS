using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Settings_Staff : Form
    {
        public Settings_Staff()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        private void Settings_Staff_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");

            txt_empID.Text = Staff_Login.EID;

            try
            {
                con.Open();
            
                cmd = new SqlCommand("SELECT First_Name FROM All_Staff WHERE EID = '" + txt_empID.Text + "'", con);
                string fname = cmd.ExecuteScalar().ToString();
                txt_fname.Text = fname;

                cmd = new SqlCommand("SELECT Last_Name FROM All_Staff WHERE EID = '" + txt_empID.Text + "'", con);
                string lname = cmd.ExecuteScalar().ToString();
                txt_lname.Text = lname;

                cmd = new SqlCommand("SELECT Contact_No from All_Staff WHERE EID='" + txt_empID.Text + "'", con);
                int cno = Convert.ToInt32(cmd.ExecuteScalar());
                txt_contactno.Text = cno.ToString();

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                
            
                if(txt_currentpass.Text.Length==0)
                    MessageBox.Show("Please enter your current password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txt_newpass.Text.Length == 0)
                    MessageBox.Show("Please enter your new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txt_cnewpass.Text.Length == 0)
                    MessageBox.Show("Please confirm your new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txt_newpass.Text != txt_cnewpass.Text)
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    con.Open();

                    cmd = new SqlCommand("SELECT Password FROM All_Staff WHERE EID = '" + txt_empID.Text + "'", con);
                    string pass = cmd.ExecuteScalar().ToString();
                    if (txt_currentpass.Text != pass)
                        MessageBox.Show("Current password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        cmd = new SqlCommand("UPDATE All_Staff SET Password = '" + txt_newpass.Text + "' WHERE EID = '" + txt_empID.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("SELECT * FROM Super_Admins WHERE EID='" + txt_empID.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            cmd = new SqlCommand("UPDATE Super_Admins SET Password = '" + txt_newpass.Text + "' WHERE EID = '" + txt_empID.Text + "'", con);
                            cmd.ExecuteNonQuery();
                        }
                        dr.Close();

                        cmd = new SqlCommand("SELECT * FROM Admins WHERE EID='" + txt_empID.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            cmd = new SqlCommand("UPDATE Admins SET Password = '" + txt_newpass.Text + "' WHERE EID = '" + txt_empID.Text + "'", con);
                            cmd.ExecuteNonQuery();
                        }
                        dr.Close();

                        cmd = new SqlCommand("SELECT * FROM Staff WHERE EID='" + txt_empID.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            cmd = new SqlCommand("UPDATE Staff SET Password = '" + txt_newpass.Text + "' WHERE EID = '" + txt_empID.Text + "'", con);
                            cmd.ExecuteNonQuery();
                        }
                        dr.Close();

                        MessageBox.Show("Your profile has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_currentpass.Text = "";
                        txt_newpass.Text = "";
                        txt_cnewpass.Text = "";

                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
