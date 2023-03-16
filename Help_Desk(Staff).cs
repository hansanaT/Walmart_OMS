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
    public partial class Help_Desk : Form
    {
        public Help_Desk()
        {
            InitializeComponent();
        }

        private void btn_Sticket_Click(object sender, EventArgs e)
        {
            Submit_Ticket st=new Submit_Ticket();
            st.Show();
        }
    }
}
