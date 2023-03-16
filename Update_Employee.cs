using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Update_Employee : Form
    {
        public Update_Employee()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        private void Update_Employee_Load(object sender, EventArgs e)
        {
            try
            {
                txt_eid.Text = Admin_Panel.eid;
                con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT * FROM All_Staff WHERE EID='" + txt_eid.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    cmd = new SqlCommand("SELECT First_Name FROM All_Staff WHERE EID='" + txt_eid.Text + "'", con);
                    string fname = cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand("SELECT Last_Name FROM All_Staff WHERE EID='" + txt_eid.Text + "'", con);
                    string lname = cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand("SELECT Contact_No FROM All_Staff WHERE EID='" + txt_eid.Text + "'", con);
                    int cno = Convert.ToInt32(cmd.ExecuteScalar());

                    txt_fname.Text = fname;
                    txt_lname.Text = lname;
                    txt_cno.Text = cno.ToString();
                }
                else
                {
                    dr.Close();
                    this.Close();
                    MessageBox.Show("Employee Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                cmd = new SqlCommand("SELECT * FROM Staff WHERE EID='" + txt_eid.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    cmd = new SqlCommand("UPDATE Staff SET First_Name='" + txt_fname.Text + "',Last_Name='" + txt_lname.Text + "',Password='" + txt_password.Text + "',Contact_No='" + txt_cno.Text + "' WHERE EID='" + txt_eid.Text + "'", con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("UPDATE All_Staff SET First_Name='  " + txt_fname.Text + "',Last_Name='" + txt_lname.Text + "',Password='" + txt_password.Text + "',Contact_No='" + txt_cno.Text + "'   WHERE EID=  '" + txt_eid.Text + "'", con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee update successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("SELECT * FROM Admins WHERE EID='" + txt_eid.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        cmd = new SqlCommand("UPDATE Admins SET First_Name='  " + txt_fname.Text + "',Last_Name='" + txt_lname.Text + "',Password='" + txt_password.Text + "',Contact_No='" + txt_cno.Text + "'   WHERE EID=  '" + txt_eid.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("UPDATE All_Staff SET First_Name='  " + txt_fname.Text + "',Last_Name='" + txt_lname.Text + "',Password='" + txt_password.Text + "',Contact_No='" + txt_cno.Text + "'   WHERE EID=  '" + txt_eid.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Employee Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("SELECT * FROM Super_Admins WHERE EID='" + txt_eid.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            cmd = new SqlCommand("SELECT * FROM Admins WHERE EID='" + Staff_Login.EID + "'", con);
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                dr.Close();
                                MessageBox.Show("You need elevated access to the system to update a SUPER ADMIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dr.Close();
                                cmd = new SqlCommand("UPDATE Super_Admins SET First_Name='  " + txt_fname.Text + "',Last_Name='" + txt_lname.Text + "',Password='" + txt_password.Text + "',Contact_No='" + txt_cno.Text + "'   WHERE EID=  '" + txt_eid.Text + "'", con);
                                cmd.ExecuteNonQuery();

                                cmd = new SqlCommand("UPDATE All_Staff SET First_Name='  " + txt_fname.Text + "',Last_Name='" + txt_lname.Text + "',Password='" + txt_password.Text + "',Contact_No='" + txt_cno.Text + "'   WHERE EID=  '" + txt_eid.Text + "'", con);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Employee Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            dr.Close();
                            MessageBox.Show("Employee not found in the server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_control_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Update_Employee_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
