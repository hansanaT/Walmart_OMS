using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.VisualBasic;

namespace Walmart_OMS
{
    public partial class Register : Form
    {
        private UserCredential credential;
        
        public Register()
        {
            InitializeComponent();

            //Form Control
            this.ControlBox = false;
            this.DoubleBuffered = false;
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void cb_showpassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_showpassword.Checked)
            {
                txt_pass.UseSystemPasswordChar = false; txt_confirmpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true; txt_confirmpass.UseSystemPasswordChar = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HANSANA-7620;Initial Catalog=WalmartOMS_DB;Integrated Security=True");
            string ID = "WC-";
            string s94 = "+94";
            txt_TP.Text = s94 + txt_TP.Text;
            
            try
            {
                con.Open();
                cmd = new SqlCommand("select count (ID) from Users", con);
                int x = Convert.ToInt32(cmd.ExecuteScalar());
                if (x == 0)
                {
                    con.Close();
                    txt_userid.Text = ID + (x + 1).ToString();
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("SELECT MAX (ID) FROM Users", con);
                    int y = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    txt_userid.Text = ID + (y + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text.Length == 0)
                {
                    MessageBox.Show("Please create a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_fname.Text.Length == 0)
                {
                    MessageBox.Show("Please enter First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_fname.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("First Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_fname.Text, @"^[A-Z][a-zA-Z]*$"))
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
                else if (!Regex.IsMatch(txt_Lname.Text, @"^[A-Z][a-zA-Z]*$"))
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
                    MessageBox.Show("Please enter a Mobile / Fixed number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_TP.Text, @"^(?:0|94|\+94|0094)?(?:(11|21|23|24|25|26|27|31|32|33|34|35|36|37|38|41|45|47|51|52|54|55|57|63|65|66|67|81|91)(0|2|3|4|5|7|9)|7(0|1|2|4|5|6|7|8)\d)\d{6}$"))
                {
                    MessageBox.Show("Please enter valid Mobile / Fixed Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$"))
                {
                    MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!cb_terms.Checked)
                {
                    MessageBox.Show("Please agree to the Terms and Conditions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    con.Open();
                    if (txt_pass.Text == txt_confirmpass.Text)
                    {
                        cmd = new SqlCommand("select * from Users where Username='" + txt_username.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("SELECT * FROM Users WHERE Mobile_Fixed_No='" + txt_TP.Text + "'", con);
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                dr.Close();
                                MessageBox.Show("Account already exist for this mobile number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dr.Close();
                                cmd = new SqlCommand("insert into Users values('" + txt_userid.Text + "','" + txt_username.Text + "','" + txt_fname.Text + "','" + txt_Lname.Text + "','" + txt_pass.Text + "','" + txt_TP.Text + "','" + txt_email.Text + "')", con);
                                int i = cmd.ExecuteNonQuery();
                                if (i == 1)
                                {
                                    MessageBox.Show("Account created successfully, You are ready to Login!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Login login = new Login();
                                    login.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Account creation unsuccessfull, Please try again!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter both passwords same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linklbl_TandC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.walmart.com/help/article/walmart-com-terms-of-use/3b75080af40340d6bbd596f116fae5a0");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
