using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Walmart_OMS
{
    public partial class Staff_Dashboard : Form
    {

        private Form currentChildForm;


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCf.Controls.Add(childForm);
            panelCf.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_title.Text = childForm.Text;
        }
        
        
        public Staff_Dashboard()
        {
            InitializeComponent();
            
            //Form control

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT First_Name FROM All_Staff WHERE EID = '" + Staff_Login.EID + "'", con);
                string fname = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("SELECT Last_Name FROM All_Staff WHERE EID = '" + Staff_Login.EID + "'", con);
                string lname = cmd.ExecuteScalar().ToString();
                con.Close();

                lbl_username.Text = fname + " " + lname;
                lbl_userid.Text = Staff_Login.EID;

                timer1.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_orders.Height;
            panel_nav.Top = btn_orders.Top;
            panel_nav.Left = btn_orders.Left;
            btn_orders.BackColor = Color.FromArgb(46, 51, 73);

            OpenChildForm(new Orders_Staff_());
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_leave.Height;
            panel_nav.Top = btn_leave.Top;
            panel_nav.Left = btn_leave.Left;
            btn_leave.BackColor = Color.FromArgb(46, 51, 73);

            OpenChildForm(new Leave());
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_settings.Height;
            panel_nav.Top = btn_settings.Top;
            panel_nav.Left = btn_settings.Left;
            btn_settings.BackColor = Color.FromArgb(46, 51, 73);

            OpenChildForm(new Settings_Staff());

        }

        private void btn_adminP_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_adminP.Height;
            panel_nav.Top = btn_adminP.Top;
            panel_nav.Left = btn_adminP.Left;
            btn_adminP.BackColor = Color.FromArgb(46, 51, 73);

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Super_Admins WHERE EID = '" + Staff_Login.EID + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    OpenChildForm(new Admin_Panel());

                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("SELECT * FROM Admins WHERE EID = '" + Staff_Login.EID + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        OpenChildForm(new Admin_Panel());
                    }
                    else
                    {
                        dr.Close();
                        if (currentChildForm != null)
                        currentChildForm.Close();
                        MessageBox.Show("You cannot view this tab, You're not an Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_helpdesk_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_helpdesk.Height;
            panel_nav.Top = btn_helpdesk.Top;
            panel_nav.Left = btn_helpdesk.Left;
            btn_helpdesk.BackColor = Color.FromArgb(46, 51, 73);

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Super_Admins WHERE EID = '" + Staff_Login.EID + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    OpenChildForm(new Help_Desk_Admin_());
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("SELECT * FROM Admins WHERE EID = '" + Staff_Login.EID + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        OpenChildForm(new Help_Desk_Admin_());
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("SELECT * FROM Staff WHERE EID = '" + Staff_Login.EID + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            OpenChildForm(new Help_Desk());
                        }
                        else
                        {
                            dr.Close();
                            MessageBox.Show("Invalid User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_logout.Height;
            panel_nav.Top = btn_logout.Top;
            panel_nav.Left = btn_logout.Left;
            btn_logout.BackColor = Color.FromArgb(46, 51, 73);

            this.Close();
            Staff_Login sl = new Staff_Login();
            sl.Show();
        }

        private void btn_orders_Leave(object sender, EventArgs e)
        {
            btn_orders.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_leave_Leave(object sender, EventArgs e)
        {
            btn_leave.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_settings_Leave(object sender, EventArgs e)
        {
            btn_settings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_adminP_Leave(object sender, EventArgs e)
        {
            btn_adminP.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_helpdesk_Leave(object sender, EventArgs e)
        {
            btn_helpdesk.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_logout_Leave(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_version_Click(object sender, EventArgs e)
        {
            App_Version av = new App_Version();
            av.Show();
        }

        //Drag FORM DLL

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void pB_profile_Click(object sender, EventArgs e)
        {
            pB_intro.Visible = true;
            pB_intro.BringToFront();
        }
    }
}
