using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Order_Dashboard_User_ : Form
    {
        public Order_Dashboard_User_()
        {
            InitializeComponent();

            //Form Control
            this.ControlBox = false;
            this.DoubleBuffered = false;
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void Order_Dashboard_User__Load(object sender, EventArgs e)
        {
            try
            {
                
            
                txt_uid.Text = Login.UID;
                con = new SqlConnection("Data Source=HANSANA-3501;Initial Catalog=WalmartOMS_DB;Integrated Security=True");
                string ID = "OID-";
                con.Open();
                cmd = new SqlCommand("select count (ID) from Orders", con);
                int x = Convert.ToInt32(cmd.ExecuteScalar());
                if (x == 0)
                {
                    con.Close();
                    txt_orderid.Text = ID + (x + 1).ToString();
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("SELECT MAX (ID) FROM Orders", con);
                    int y = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    txt_orderid.Text = ID + (y + 1).ToString();
                }

                con.Open();
                cmd = new SqlCommand("select Mobile_Fixed_No from Users where User_ID='" + txt_uid.Text + "'", con);
                string mno = cmd.ExecuteScalar().ToString();
                txt_mobileno.Text = mno.ToString();
                con.Close();

                con.Open();
                cmd = new SqlCommand("SELECT Item_Name,Unit_price FROM Items", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dR = dt.NewRow();
                dR["Item_Name"] = "Select Item";
                dt.Rows.InsertAt(dR, 0);

                cmb_productName.DataSource = dt;
                cmb_productName.DisplayMember = "Item_Name";
                cmb_productName.ValueMember = "Unit_price";
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_productName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_unitprice.Text = cmb_productName.SelectedValue.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
            
                if (txt_qty.Text.Length > 0)
                {
                    txt_total.Text = (Convert.ToInt32(txt_qty.Text) * Convert.ToInt32(txt_unitprice.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            try
            {
                
            
                if (txt_qty.Text.Length == 0)
                {
                    MessageBox.Show("Please enter valid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_qty.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Please enter only numbers for quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] arr = new string[4];
                    arr[0] = cmb_productName.Text;
                    arr[1] = txt_unitprice.Text;
                    arr[2] = txt_qty.Text;
                    arr[3] = txt_total.Text;

                    ListViewItem lv = new ListViewItem(arr);
                    listView1.Items.Add(lv);

                    txt_netamount.Text = (Convert.ToInt32(txt_netamount.Text) + Convert.ToInt32(txt_total.Text)).ToString();

                    cmb_productName.Text = "";
                    txt_unitprice.Text = "";
                    txt_qty.Text = "";
                    txt_total.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string order_type = string.Empty;

            try
            {
                
            
            
                if (dateTimePicker1.Value < DateTime.Today)
                {
                    MessageBox.Show("You cannot place orders in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbtn_pickup.Checked == false & rbtn_delivery.Checked == false)
                {
                    MessageBox.Show("Please select order type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_address.Text.Length == 0)
                {
                    MessageBox.Show("Please enter your shipping address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (rbtn_pickup.Checked == true)
                    {
                        order_type = "Pickup";
                    }
                    else if (rbtn_delivery.Checked == true)
                    {
                        order_type = "Delivery";
                    }



                    con.Open();
                    cmd = new SqlCommand("Insert into Orders values ('" + txt_orderid.Text + "','" + txt_uid.Text + "','" + txt_mobileno.Text + "','" + dateTimePicker1.Value + "','" + order_type + "','" + txt_address.Text + "','" + txt_netamount.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();


                    foreach (ListViewItem lst_item in listView1.Items)
                    {
                        cmd = new SqlCommand("Insert into Carts values ('" + txt_orderid.Text + "','" + txt_uid.Text + "','" + lst_item.SubItems[0].Text + "','" + lst_item.SubItems[1].Text + "','" + lst_item.SubItems[2].Text + "','" + lst_item.SubItems[3].Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Cart saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Selected)
                        {
                            txt_netamount.Text = (Convert.ToInt32(txt_netamount.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                            listView1.Items[i].Remove();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "";
            txt_total.Text = "";
            txt_netamount.Text = "0";
            txt_unitprice.Text = "";
            cmb_productName.Text = "";
            listView1.Items.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_productName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Order_Dashboard_User__MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    
}
