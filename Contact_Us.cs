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
    public partial class Contact_Us : Form
    {
        public Contact_Us()
        {
            InitializeComponent();
        }

        private void linklbl_contactwalmart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://help.walmart.com/");
        }

        private void linklbl_ContactSams_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://samsclubanswercenter.custhelp.com/app/");
        }

        private void linklbl_media_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://corporate.walmart.com/contact-media-relations");
        }

        private void linklbl_fhc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://corporate.walmart.com/contact-us/financial-help-center");
        }

        private void linklbl_SCCC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.onlinecreditcenter6.com/sams/gen/Contacts.html");
        }

        private void linklbl_investorR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://corporate.walmart.com/store-corporate-feedback");
        }

        private void linklbl_cs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.computershare.com/us/Pages/default.aspx");
        }

        private void linklbl_RM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://stock.walmart.com/investors/investor-resources/request-materials/default.aspx");
        }

        private void linklbl_apply_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://corporate.walmart.com/suppliers");
        }

        private void btn_Sticket_Click(object sender, EventArgs e)
        {
            Submit_Ticket st = new Submit_Ticket();
            st.Show();
        }
    }
}
