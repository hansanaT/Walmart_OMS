using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walmart_OMS
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            try
            {
                if (Orders.OID == null)
                {
                    MessageBox.Show("Please enter Order ID to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // TODO: This line of code loads data into the 'order_Inv.Carts' table. You can move, or remove it, as needed.
                    this.cartsTableAdapter.Fill(this.order_Inv.Carts, Orders.OID);

                    this.reportViewer1.RefreshReport();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
