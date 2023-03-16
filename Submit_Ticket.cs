using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Submit_Ticket : Form
    {
        public Submit_Ticket()
        {
            InitializeComponent();

            //Form Control
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = false;
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Ticket_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");

            try
            {


                con.Open();
                cmd = new SqlCommand("SELECT * FROM Users WHERE User_ID='" + Login.UID + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    txt_uid.Text = Login.UID;
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("SELECT * FROM All_Staff WHERE EID='" + Staff_Login.EID + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        txt_uid.Text = Staff_Login.EID;
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Unknown Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();

                string ID = "Case #: 000";
                con.Open();
                cmd = new SqlCommand("SELECT COUNT (ID) FROM App_Issues", con);
                int x = Convert.ToInt32(cmd.ExecuteScalar());
                if (x == 0)
                {
                    con.Close();
                    txt_IssueID.Text = ID + (x + 1).ToString();
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("SELECT MAX (ID) FROM App_Issues", con);
                    int y = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    txt_IssueID.Text = ID + (y + 1).ToString();
                }

                txt_Aversion.Text = "V" + Application.ProductVersion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_version_Click(object sender, EventArgs e)
        {
            App_Version app = new App_Version();
            app.Show();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                cmd = new SqlCommand("INSERT INTO App_Issues VALUES ('" + txt_uid.Text + "','" + txt_IssueID.Text + "','" + txt_Aversion.Text + "','" + rtxt_issue.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Your issue has been submitted successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unknow Error Occured \nPlease try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

                txt_IssueID.Text = "";
                rtxt_issue.Text = "";


                //Refresh Form for a new case

                string ID = "Case #: 000";
                con.Open();
                cmd = new SqlCommand("SELECT MAX (ID) FROM App_Issues", con);
                int y = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                txt_IssueID.Text = ID + (y + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Submit_Ticket_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
