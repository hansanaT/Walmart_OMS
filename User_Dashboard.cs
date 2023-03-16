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

namespace Walmart_OMS
{
    public partial class User_Dashboard : Form
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

        public User_Dashboard()
        {
            InitializeComponent();
           

            //Form control

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            string suffixID = "User ID : ";
            lbl_userid.Text = suffixID + Login.UID;

            string suffixuser = "User : ";
            lbl_username.Text = suffixuser + Login.USR;
            

            timer1.Start();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_dashboard.Height;
            panel_nav.Top = btn_dashboard.Top;
            panel_nav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);

            OpenChildForm(new Dashboard());

        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_orders.Height;
            panel_nav.Top = btn_orders.Top;
            panel_nav.Left = btn_orders.Left;
            btn_orders.BackColor = Color.FromArgb(46, 51, 73);

            OpenChildForm(new Orders());

        }

        private void btn_contactus_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_contactus.Height;
            panel_nav.Top = btn_contactus.Top;
            panel_nav.Left = btn_contactus.Left;
            btn_contactus.BackColor = Color.FromArgb(46, 51, 73);

            OpenChildForm(new Contact_Us());
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_settings.Height;
            panel_nav.Top = btn_settings.Top;
            panel_nav.Left = btn_settings.Left;
            btn_settings.BackColor = Color.FromArgb(46, 51, 73);

            OpenChildForm(new Settings());

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            panel_nav.Height = btn_logout.Height;
            panel_nav.Top = btn_logout.Top;
            panel_nav.Left = btn_logout.Left;
            btn_logout.BackColor = Color.FromArgb(46, 51, 73);

            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btn_dashboard_leave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_orders_leave(object sender, EventArgs e)
        {
            btn_orders.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_contactus_leave(object sender, EventArgs e)
        {
            btn_contactus.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_settings_leave(object sender, EventArgs e)
        {
            btn_settings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_logout_leave(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            WindowState = FormWindowState.Minimized;
        }

        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); 
        
        
        private void panel_title_mousedown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_version_Click(object sender, EventArgs e)
        {
            App_Version app_Version = new App_Version();
            app_Version.Show();
        }

        private void pB_profile_Click(object sender, EventArgs e)
        {
            pB_intro.Visible = true;
            pB_intro.BringToFront();
        }
    }
}
