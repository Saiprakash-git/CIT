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
    public partial class SearchCustomer : Form
    {
        string Selectcommand,customerString;
        OleDbDataReader reader;
        public SearchCustomer()
        {
            InitializeComponent();
        }
        private OleDbConnection GetConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\projects\\desktopCableBilling\\SRET CBS 3.8 DATABASE.mdb;Persist Security Info=True;Jet OLEDB:Database Password=SreTc@2020cbs";
            return new OleDbConnection(connectionString);
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            Selectcommand = string.Empty;
            Grid_Load();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            customerString = SearchBox.Text;
            if (Phone_Radio.Checked)
            {
                Selectcommand = "select  * from customer where  ph_no = @data";
                if (customerString.Equals(""))
                    MessageBox.Show("ENTER CUSTOMER PHONE NUMBER ");
            }
            else if (CustomerID_Radio.Checked)
            {
                Selectcommand = "select  * from customer where  cust_id = @data";
                if (customerString.Equals(""))
                    MessageBox.Show("ENTER CUSTOMER ID ");
            }
            else if (STBNO_Radio.Checked)
            {
                Selectcommand = "select  * from customer where stb_no   = @data";
                if (customerString.Equals(""))
                    MessageBox.Show("ENTER STB NUMBER ");
            }
           
            else
                MessageBox.Show("Select any radio box for searching");
            if(Selectcommand != null )
            {
              using(OleDbConnection con = GetConnection())
                {
                    con.Open();
                    using (OleDbCommand command = new OleDbCommand(Selectcommand, con))
                    {
                        command.Parameters.AddWithValue("@data", customerString);
                       reader= command.ExecuteReader();
                        if (reader.Read())
                        {
                            DeviceID.Text = reader["device_id"].ToString();
                            CustomerName.Text = reader["cust_name"].ToString();
                            AadharNumber.Text = reader["aadhar_no"].ToString();
                            Address.Text = reader["address"].ToString();
                            STBNumber.Text = reader["stb_no"].ToString();
                            ConnectionDate.Text = reader["conn_date"].ToString();
                            RouteCode.Text = reader["rt_code"].ToString();
                            CustomerID.Text = reader["cust_id"].ToString();
                            MobileNumber.Text   = reader["ph_no"].ToString ();
                            DoorNumber.Text = reader["door_no"].ToString();
                            AsOnDate.Text = reader["as_on_date"].ToString();
                            PreviousBalanceUI.Text = reader["prev_bal"].ToString();
                            //  MonthlyChargeUI.Text = reader[""].ToString();
                            packagePriceUI.Text = reader["pkg_price"].ToString();
                            ExtraPriceUI.Text = reader["ext_price"].ToString();
                            GstOtherUI.Text = reader["tax_others"].ToString();
                            PaidAmountUI.Text =reader["paid_amt"].ToString();
                            CurrentBalanceUI.Text = reader["curr_bal"].ToString();
                            Status.Text = reader["status"].ToString();
                            Remarks.Text = reader["remarks"].ToString();
                            LastPaidDate.Value = Convert.ToDateTime(reader["last_paid_date"]);
                            lastPaidAmountUI.Text = reader["last_paid_amt"].ToString();
                            packageNameUI.Text  = reader["pkg_name"].ToString();
                            packageCodeUI.Text= reader["pkg_code"].ToString();
                            packageIDUI.Text = reader["pid"].ToString();
                            selectGST.Text = reader["gst"].ToString();
                            NextRenewalDate1.Text = reader["nr_date"].ToString();
                            DiscountUI.Text = reader["discount"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("GIVEN CUSTOMER IS NOT FOUND PLEASE ENTER CORRECT DATA !!! ");
                        }
                    }
                }
            }
            else
            {
               
                MessageBox.Show("Select any radio box for searching");
            }
        }
        private void Grid_Load()
        {
            using (OleDbConnection con = GetConnection())
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select * from customer ", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(dr);
                CustomerGridView.DataSource = data;
            }
        }

       
    }
}
/*
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCableBiling
{
    public partial class SearchCustomer : Form
    {
        private string CustomerString;
        private CableBillingDBEntities db = new CableBillingDBEntities();
        public SearchCustomer()
        {
            InitializeComponent();
            GridView();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                addCustomerDB selectedData = new addCustomerDB();
                CustomerString = ID_TextBox.Text;
                if (Phone_Radio.Checked)
                {
                    selectedData = db.addCustomerDBs.FirstOrDefault(q => q.MOBILE_NUMBER.Equals(CustomerString));
                }
                else if (CustomerID_Radio.Checked)
                {
                    selectedData = db.addCustomerDBs.FirstOrDefault(q => q.CUSTOMER_ID.Equals(CustomerString));
                }
                else if (STBNO_Radio.Checked)
                {
                    selectedData = db.addCustomerDBs.FirstOrDefault(q => q.STB_NO.Equals(CustomerString));
                }
                else if (CardNo_Radio.Checked)
                {
                    selectedData = db.addCustomerDBs.FirstOrDefault(q => q.CARD_NUMBER.Equals(CustomerString));
                }
                else
                    MessageBox.Show("Select any radio box for searching");

                if (CustomerString != null)
                {
                    var data = db.addCustomerDBs.FirstOrDefault(q => q.CUSTOMER_ID.Equals(CustomerString));
                    if (data != null)
                    {
                        RouteCode.Text = selectedData.ROUTE_CODE;
                        CustomerName.Text = selectedData.CUSTOMER_NAME;
                        CustomerID.Text = selectedData.CUSTOMER_ID;
                        DoorNumber.Text = selectedData.DOOR_NO;
                        MobileNumber.Text = selectedData.MOBILE_NUMBER;
                        Address.Text = selectedData.ADDRESS;
                        CardNumber.Text = selectedData.CARD_NUMBER;
                        AadharNumber.Text = selectedData.AADHAAR_NO;
                        STBNumber.Text = selectedData.STB_NO;
                        Status.Text = selectedData.STATUS;
                        PreviousBalance.Text = Convert.ToString(selectedData.PREVIOUS_BALANCE);
                        MonthlyCharge.Text = Convert.ToString(selectedData.MONTHLY_CHARGES);
                        TaxOther.Text = Convert.ToString(selectedData.TAX_OTHER);
                        PaidAmount.Text = Convert.ToString(selectedData.PAID_AMOUNT);
                        CurrentBalance.Text = Convert.ToString(selectedData.CURRENT_BALANCE);
                        DeviceID.Text = Convert.ToString(selectedData.DEVICE_ID);
                        LastPaidAmount.Text = Convert.ToString(selectedData.LAST_PAID_AMOUNT);
                        InstallationCharges.Text = Convert.ToString(selectedData.INSTALLATION_CHARGES);
                        Remarks.Text = selectedData.REMARKS;


                    }
                    else
                        MessageBox.Show("Customer Not Found..!!");
                }
                else
                    MessageBox.Show("Enter Data in Search bar");

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void GridView()
        {
            var gridData = db.addCustomerDBs.Select(q => new {
                q.DEVICE_ID,
                q.ROUTE_CODE,
                q.CUSTOMER_ID,
                q.CUSTOMER_NAME,
                q.STB_NO,
                q.CONNECTION_DATE,
                q.STATUS,
                q.CARD_NUMBER,
                q.INSTALLATION_CHARGES,
                q.PREVIOUS_BALANCE,
                q.PAID_AMOUNT,
                q.MONTHLY_CHARGES,
                q.TAX_OTHER,
                q.CURRENT_BALANCE,
                q.LAST_PAID_AMOUNT,
                q.LAST_PAID_DATE,
                q.AS_ON_DATE,
                q.MOBILE_NUMBER,
                q.DOOR_NO,
                q.ADDRESS,
                q.AADHAAR_NO,
                q.REMARKS
            }).ToList();
            CustomerGridView.DataSource = gridData;
        }

    }
}

 
 
 */