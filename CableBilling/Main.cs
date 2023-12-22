using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableBilling
{
    public partial class Main : Form
    {   
        public Main()
        {
            InitializeComponent();
        }

        private void aDDCUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.MdiParent = this;
            addCustomer.Show();
        }

        private void cONTACTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.MdiParent = this;
            contactUs.Show();
        }

        private void DeviceManager_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceManager deviceManager = new DeviceManager();
            deviceManager.MdiParent = this;
            deviceManager.Show();
        }

        private void aDDUPDATEDELETEROUTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RouteManager routeManager = new RouteManager();
            routeManager.MdiParent = this;
            routeManager.Show();
        }

        private void sEARCHCUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCustomer searchCustomer = new SearchCustomer();
            searchCustomer.MdiParent = this;
            searchCustomer.Show();
        }

        private void uPDATEDELETECUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteCustomer updateDownloadCustomer = new UpdateDeleteCustomer();
            updateDownloadCustomer.MdiParent = this;
            updateDownloadCustomer.Show();
        }

        private void oFFICEPAYMENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfficePayments officePayments = new OfficePayments();
            officePayments.MdiParent = this;
            officePayments.Show();
        }

        private void mANAGEPACKAGEMenuItem1_Click(object sender, EventArgs e)
        {
            ManagePackage managePackage = new ManagePackage();  
            managePackage.MdiParent = this;
            managePackage.Show();
        }

        private void uPLOADDOWNLOADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadDownload  download = new UploadDownload();    
            download.MdiParent = this;
            download.Show();
        }

        private void pASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordManage passwordManage = new PasswordManage();
            passwordManage.MdiParent = this;
            passwordManage.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
