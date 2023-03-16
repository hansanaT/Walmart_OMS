using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Resolve_Issue : Form
    {
        public Resolve_Issue()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        SqlConnection con;
        SqlCommand cmd;

        private void Resolve_Issue_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");

            string caseno = "Case #: ";

            txt_caseno.Text = caseno + txt_caseno.Text;
        }

        private void btn_resolved_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                cmd = new SqlCommand("INSERT INTO Resolved_App_Issues VALUES ('" + txt_caseno.Text + "','" + txt_uid.Text + "')", con);
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Issue Updated Resolved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Issue Not Resolved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd = new SqlCommand("DELETE FROM App_Issues WHERE Issue_Reference='" + txt_caseno.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();


                txt_uid.Text = "";
                txt_caseno.Text = "";
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Resolve_Issue_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    
    }
}
