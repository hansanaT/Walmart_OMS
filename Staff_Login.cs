using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Staff_Login : Form
    {
        public Staff_Login()
        {
            InitializeComponent();

            //Form Control
            this.ControlBox = false;
            this.DoubleBuffered = false;
        }
        SqlConnection con;
        SqlCommand cmd;

        public static string empid;

        public static string EID
        {
            get { return empid; }
            set { empid = value; }
        }

        private void Staff_Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");
        }

        private void txt_empID_enter(object sender, EventArgs e)
        {
            if (txt_empID.Text == "Employee ID")
            {
                txt_empID.Text = "";
                txt_empID.ForeColor = Color.Black;
            }
        }

        private void txt_empID_leave(object sender, EventArgs e)
        {
            if (txt_empID.Text == "")
            {
                txt_empID.Text = "Employee ID";
                txt_empID.ForeColor = Color.Silver;
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

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }


        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {


                if (rbtn_SA.Checked == true)
                {

                    con.Open();
                    if (txt_password.Text != string.Empty || txt_empID.Text != string.Empty)
                    {

                        cmd = new SqlCommand("select EID from Super_Admins where EID='" + txt_empID.Text + "'", con);
                        string ID = Convert.ToString(cmd.ExecuteScalar());
                        txt_empID.Text = ID;

                        EID = txt_empID.Text;



                        cmd = new SqlCommand("select Count(*) from Super_Admins where EID='" + txt_empID.Text + "' and Password='" + txt_password.Text + "'COLLATE SQL_Latin1_general_CP1_CS_AS", con);
                        int i = Convert.ToInt32(cmd.ExecuteScalar());
                        if (i > 0)
                        {

                            MessageBox.Show("Log in successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Staff_Dashboard sd = new Staff_Dashboard();
                            sd.Show();
                        }
                        else
                        {
                            MessageBox.Show("Employee not found in the server or Please check your account type and password, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter values in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();

                }
                else if (rbtn_admin.Checked == true)
                {


                    con.Open();
                    if (txt_password.Text != string.Empty || txt_empID.Text != string.Empty)
                    {

                        cmd = new SqlCommand("select EID from Admins where EID='" + txt_empID.Text + "'", con);
                        string ID = Convert.ToString(cmd.ExecuteScalar());
                        txt_empID.Text = ID;

                        EID = txt_empID.Text;



                        cmd = new SqlCommand("select Count(*) from Admins where EID='" + txt_empID.Text + "' and Password='" + txt_password.Text + "'COLLATE SQL_Latin1_general_CP1_CS_AS", con);
                        int i = Convert.ToInt32(cmd.ExecuteScalar());
                        if (i > 0)
                        {

                            MessageBox.Show("Log in successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Staff_Dashboard sd = new Staff_Dashboard();
                            sd.Show();
                        }
                        else
                        {
                            MessageBox.Show("Employee not found in the server or Please check your account type and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter values in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();

                }
                else if (rbtn_employee.Checked == true)
                {

                    con.Open();
                    if (txt_password.Text != string.Empty || txt_empID.Text != string.Empty)
                    {

                        cmd = new SqlCommand("select EID from Staff where EID='" + txt_empID.Text + "'", con);
                        string ID = Convert.ToString(cmd.ExecuteScalar());
                        txt_empID.Text = ID;

                        EID = txt_empID.Text;



                        cmd = new SqlCommand("select Count(*) from Staff where EID='" + txt_empID.Text + "' and Password='" + txt_password.Text + "'COLLATE SQL_Latin1_general_CP1_CS_AS", con);
                        int i = Convert.ToInt32(cmd.ExecuteScalar());
                        if (i > 0)
                        {

                            MessageBox.Show("Log in successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Staff_Dashboard sd = new Staff_Dashboard();
                            sd.Show();
                        }
                        else
                        {
                            MessageBox.Show("Employee not found in the server or Please check your account type and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter values in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                    MessageBox.Show("Please select account type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
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
