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

namespace Walmart_OMS
{
    public partial class Leave : Form
    {
        public Leave()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void Leave_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");

            txt_eidCreate.Text = Staff_Login.EID;
            txt_eidCancel.Text = Staff_Login.EID;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (dTP_start.Value < DateTime.Today)
                {
                    MessageBox.Show("You cannot create leave in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dTP_start.Value > dTP_end.Value)
                {
                    MessageBox.Show("Invalid date range selected \nStart date cannot be after end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_leaveType.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select leave type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rtxt_reason.Text.Length == 0)
                {
                    MessageBox.Show("Please enter reason for taking the selected leave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Employee_Leave_History VALUES ('" + txt_eidCreate.Text + "','" + dTP_start.Value + "','" + dTP_end.Value + "','" + cmb_leaveType.Text + "','" + rtxt_reason.Text + "')", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Leave created successfully,Enjoy your Holiday!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Leave creation failed,Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();

                    dTP_start.Value = DateTime.Today;
                    dTP_end.Value = DateTime.Today;
                    cmb_leaveType.SelectedIndex = 0;
                    rtxt_reason.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Employee_Leave_History WHERE EID='" + txt_eidCancel.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Leave cancellation successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Leave cancellation unsuccessfull,Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();

                con.Open();
                cmd = new SqlCommand("INSERT INTO Employee_Leave_Cancellation VALUES ('" + txt_eidCancel.Text + "','" + rtxt_reasonCancel.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
