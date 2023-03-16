using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void Settings_Load(object sender, EventArgs e)
        {
            txt_uidupdate.Text = Login.UID;
            txt_uiddelete.Text = Login.UID;

            con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");

            try
            {
                con.Open();
            
                cmd = new SqlCommand("SELECT Username FROM Users WHERE User_ID='"+Login.UID+"'", con);
                string username = cmd.ExecuteScalar().ToString();
                txt_username.Text = username;

                cmd = new SqlCommand("SELECT First_Name FROM Users WHERE User_ID='" + Login.UID + "'", con);
                string fname = cmd.ExecuteScalar().ToString();
                txt_fname.Text = fname;

                cmd = new SqlCommand("SELECT Last_Name FROM Users WHERE User_ID='" + Login.UID + "'", con);
                string lname = cmd.ExecuteScalar().ToString();
                txt_Lname.Text = lname;

                cmd = new SqlCommand("SELECT Mobile_Fixed_No FROM Users WHERE User_ID='" + Login.UID + "'", con);
                string mobile = cmd.ExecuteScalar().ToString();
                txt_TP.Text = mobile;

                cmd = new SqlCommand("SELECT Email FROM Users WHERE User_ID='" + Login.UID + "'", con);
                string email = cmd.ExecuteScalar().ToString();
                txt_email.Text = email;

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
                
            
                if (txt_username.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_fname.Text.Length == 0)
                {
                    MessageBox.Show("Please enter First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_fname.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("First Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!Regex.IsMatch(txt_fname.Text, @"^[A-Z][a-zA-Z]*$"))
                {
                    MessageBox.Show("Please enter valid First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Lname.Text.Length == 0)
                {
                    MessageBox.Show("Please enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Lname.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Last Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!Regex.IsMatch(txt_Lname.Text, @"^[A-Z][a-zA-Z]*$"))
                {
                    MessageBox.Show("Please enter valid Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_pass.Text.Length == 0 || txt_confirmpass.Text.Length == 0)
                {
                    MessageBox.Show("Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_confirmpass.Text != txt_pass.Text)
                {
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_TP.Text.Length == 0)
                {
                    MessageBox.Show("Mobile/Fixed number cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_TP.Text, @"^(?:0|94|\+94|0094)?(?:(11|21|23|24|25|26|27|31|32|33|34|35|36|37|38|41|45|47|51|52|54|55|57|63|65|66|67|81|91)(0|2|3|4|5|7|9)|7(0|1|2|4|5|6|7|8)\d)\d{6}$"))
                {
                    MessageBox.Show("Please enter valid Mobile / Fixed Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$"))
                {
                    MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Users SET Username = '" + txt_username.Text + "', First_Name='" + txt_fname.Text + "',Last_Name='" + txt_Lname.Text + "',Password='" + txt_pass.Text + "',Mobile_Fixed_No='" + txt_TP.Text + "' WHERE User_ID = '" + txt_uidupdate.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("User updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Failed to update user,Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_username.Text = "";
            txt_fname.Text = "";
            txt_Lname.Text = "";
            txt_pass.Text = "";
            txt_confirmpass.Text = "";
            txt_TP.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Carts WHERE User_ID = '" + txt_uiddelete.Text + "'", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE FROM Orders WHERE User_ID = '" + txt_uiddelete.Text + "'", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE FROM Users WHERE User_ID = '" + txt_uiddelete.Text + "'", con);
                DialogResult = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Account deleted successfully, Thank you for using our services!", "Walmart Order Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                        Home hm = new Home();
                        hm.Show();
                        User_Dashboard.ActiveForm.Close();

                    }
                    else
                        MessageBox.Show("Failed to delete the account \nPlease try again or Contact Walmart customer service for assistance", "Delete Account",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Show();
                }
            
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cb_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpassword.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
                txt_confirmpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
                txt_confirmpass.UseSystemPasswordChar = true;
            }
        }
    }
}
