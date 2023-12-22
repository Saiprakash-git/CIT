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
    public partial class UpdateDeleteCustomer : Form
    {
        string Selectcommand, customerString;
        OleDbDataReader reader;
        private int[] gst = { 0, 5, 12, 18, 28 };

        public UpdateDeleteCustomer()
        {
            InitializeComponent();
        }
        private OleDbConnection GetConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\projects\\desktopCableBilling\\SRET CBS 3.8 DATABASE.mdb;Persist Security Info=True;Jet OLEDB:Database Password=SreTc@2020cbs";
            return new OleDbConnection(connectionString);
        }

        private void UpdateDeleteCustomer_Load(object sender, EventArgs e)
        {
            Selectcommand = string.Empty;
            Grid_Load();
            selectGst1.DataSource = gst;
            Load_DeviceID();

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
            if (Selectcommand != null)
            {
                using (OleDbConnection con = GetConnection())
                {
                    con.Open();
                    using (OleDbCommand command = new OleDbCommand(Selectcommand, con))
                    {
                        command.Parameters.AddWithValue("@data", customerString);
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            DeviceIDUI.DisplayMember = reader["device_id"].ToString();
                            CustomerName.Text = reader["cust_name"].ToString();
                            AadharNumberUI.Text = reader["aadhar_no"].ToString();
                            Address.Text = reader["address"].ToString();
                            STBNumber.Text = reader["stb_no"].ToString();
                            ConnectionDate.Text = reader["conn_date"].ToString();
                            RouteCodeUI.SelectedItem = reader["rt_code"].ToString();
                            CustomerID.Text = reader["cust_id"].ToString();
                            MobileNumberUI.Text = reader["ph_no"].ToString();
                            DoorNumber.Text = reader["door_no"].ToString();
                            AsOnDate.Text = reader["as_on_date"].ToString();
                            PreviousBalanceUI.Text = reader["prev_bal"].ToString();
                            //  MonthlyChargeUI.Text = reader[""].ToString();
                            packagePriceUI.Text = reader["pkg_price"].ToString();
                            ExtraPriceUI.Text = reader["ext_price"].ToString();
                            GstOtherUI.Text = reader["tax_others"].ToString();
                            PaidAmountUI.Text = reader["paid_amt"].ToString();
                            CurrentBalanceUI.Text = reader["curr_bal"].ToString();
                            Status.Text = reader["status"].ToString();
                            Remarks.Text = reader["remarks"].ToString();
                            LastPaidDate.Value = Convert.ToDateTime(reader["last_paid_date"]);
                            lastPaidAmountUI.Text = reader["last_paid_amt"].ToString();
                            packageNameUI.Text = reader["pkg_name"].ToString();
                            packageCodeUI.Text = reader["pkg_code"].ToString();
                            packageIDUI.Text = reader["pid"].ToString();
                            selectGst1.DisplayMember = reader["gst"].ToString();
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
                CustomerGridGiew.DataSource = data;
            }
        }
        private void Load_DeviceID()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand loadDeviceIDCommand = new OleDbCommand("SELECT DEVICE_ID FROM unit", con1);
                OleDbDataReader dataRead = loadDeviceIDCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataRead);
                DeviceIDUI.DataSource = dataTable;
                DeviceIDUI.DisplayMember = "DEVICE_ID";

            }
        }

    }
}
