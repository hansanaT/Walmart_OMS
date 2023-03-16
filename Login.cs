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
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace Walmart_OMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


            //Form Control
            this.ControlBox = false;
            this.DoubleBuffered = false;
        }
        SqlConnection con;
        SqlCommand cmd;

        public static string userid;
        public static string username;
        
        public static string UID
        {
            get { return userid; }
            set { userid = value; }
        }
        
        public static string USR
        {
            get { return username; }
            set { username = value; }
        }

        private void txt_username_enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_username_leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Username";
                txt_username.ForeColor = Color.Silver;
            }
        }

        private void txt_password_enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_password_leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.Silver;
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void cb_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            try
            {
                
            
                con.Open();
                if (txt_password.Text != string.Empty || txt_username.Text != string.Empty)
                {
                    cmd = new SqlCommand("select User_ID from Users where Username='" + txt_username.Text + "'", con);
                    string ID = Convert.ToString(cmd.ExecuteScalar());
                    txt_userid.Text = ID;

                    UID = txt_userid.Text;

                    USR = txt_username.Text;


                    cmd = new SqlCommand("select Count(*) from Users where Username='" + txt_username.Text + "' and Password='" + txt_password.Text + "'COLLATE SQL_Latin1_general_CP1_CS_AS", con);
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    if (i>0)
                    {
                        MessageBox.Show("Log in successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        User_Dashboard ud = new User_Dashboard();
                        ud.Show();
                    }
                    else
                    {
                        MessageBox.Show("No Account available with this Username or Password, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter values in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");
        }

        private void txt_userid_enter(object sender, EventArgs e)
        {
            if (txt_userid.Text == "User ID")
            {
                txt_userid.Text = "";
                txt_userid.ForeColor = Color.Black;
            }
        }

        private void txt_userid_leave(object sender, EventArgs e)
        {
            if (txt_userid.Text == "")
            {
                txt_userid.Text = "User ID";
                txt_userid.ForeColor = Color.Silver;
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
