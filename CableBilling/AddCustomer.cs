using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableBilling
{
    public partial class AddCustomer : Form
    {
        private Double PreviousBalanceDouble, MonthlyChargeDouble, CurrentBalanceDouble, TaxOtherDouble, DiscountDouble, packagePriceDouble,
            PaidAmountDouble, LastPaidAmountDouble, InstalaltionChargesDouble;
        private String RouteCodeString, CustomerNameString, CustomerIDString, DoorNumberString,
    MobileNumberString, AddressString, CardNumberString, AadharNumberString, STBNumberString,
    ConnectionDateString, AsOnDateString, StatusString, RemarkString, LastPaidDateString , CafNoString, SelectPackageString, packagCodeString,  RemarksString;

        private int DeviceIDInt, packageIDInt, ExtraPriceInt, SelectGSTInt,count;

      
        private int[] gst = { 0, 5, 12, 18, 28 };
        private string SelectPackageName, SelectGST;
        private OleDbDataReader SelectData;
        private DateTime NextRenewalDate, ConnectionDateDate, AsOnDateDate, LastPaidDateDate;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            Grid_Load();
            string[] statusData = { "ACTIVE", "TEMPORARILY DISCONNECTED", "PERMANENTLY DISCONNECTED" };
            Status.DataSource = statusData;
            selectGst1.DataSource = gst;
            Load_PackageName();
            Load_PackageDetails();
            Load_DeviceID();
            Load_RouteCode();
            Load_StringEmpty();
            Load_DoubleValues();
            Load_Gst();
            Load_currrentBal();
            Load_ActiveCust();
            Load_CustCount();
        }
        private OleDbConnection GetConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\CIT\\cable Billling Desktop Project\\SRET CBS 3.8 DATABASE.mdb; Persist Security Info=True;Jet OLEDB:Database Password=SreTc@2020cbs";
            return new OleDbConnection(connectionString);
        }


        private void InstallationCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') || (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            else
            {
            }
        }

        private void ExtraPriceUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') || (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            else
            {
            }
        }

        private void MonthlyChargeUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') || (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            else
            {
            }
        }

        private void PreviousBalanceUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') || (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            else
            {
            }
        }

        private void AadharNumberUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                // Block the key press event.
                e.Handled = true;
            }
            else
            {
            }
        }

        private void MobileNumberUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') || (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            else
            {
            }
        }


        private void CurrentBalanceUI_Click(object sender, EventArgs e)
        {
            Load_currrentBal();
        }
        private void selectGST_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Gst();
            Load_currrentBal();
        }

        private void packageNameUI_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_PackageDetails();
            Load_Gst();
            Load_currrentBal();
        }
       
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try {

                DeviceIDInt = Convert.ToInt32(DeviceIDUI.Text);
                CustomerIDString = CustomerID.Text;
                CustomerNameString = CustomerName.Text;
                AddressString = Address.Text;
                MobileNumberString = MobileNumberUI.Text;
                STBNumberString = STBNumber.Text;
                ConnectionDateDate = Convert.ToDateTime(ConnectionDate.Text);
                AsOnDateDate = Convert.ToDateTime(AsOnDate.Text);
                PreviousBalanceDouble = Convert.ToDouble(PreviousBalanceUI.Text);
                CurrentBalanceDouble = Convert.ToDouble(CurrentBalanceUI.Text);
                PaidAmountDouble = Convert.ToDouble(PaidAmountUI.Text);
                StatusString = Status.Text;
                RemarksString = Remarks.Text;
                LastPaidDateDate = Convert.ToDateTime(LastPaidDate.Text);
                LastPaidAmountDouble = Convert.ToDouble(lastPaidAmountUI.Text);
                RouteCodeString = RouteCodeUI.Text;
                DoorNumberString = DoorNumber.Text;
                AadharNumberString = AadharNumberUI.Text;
                TaxOtherDouble = Convert.ToDouble(GstOtherUI.Text);
                SelectPackageString = packageNameUI.Text;
                packagCodeString = packageCodeUI.Text;
                packagePriceDouble = Convert.ToDouble(packagePriceUI.Text);
                CardNumberString = CardNumber.Text;
                CafNoString = CafNo.Text;
                InstalaltionChargesDouble = Convert.ToDouble(InstallationCharges.Text);

                     //PAYMENTS

                     MonthlyChargeDouble = Convert.ToDouble(MonthlyChargeUI.Text);
                     packageIDInt = Convert.ToInt32(packageIDUI.Text);
                     SelectGST = selectGst1.Text.ToString();
                     NextRenewalDate = Convert.ToDateTime(NextRenewalDate1.Text);
                     DiscountDouble = Convert.ToDouble(DiscountUI.Text);
                     ExtraPriceInt = Convert.ToInt32(ExtraPriceUI.Text);

                   


                if (DeviceIDInt == 0 || CustomerIDString.Equals("") || CustomerNameString.Equals("") || AddressString.Equals("") || MobileNumberString.Equals("") || DoorNumberString.Equals("") )
                {
                    //DeviceIDInt == 0 && RouteCodeString.Equals("") || CustomerNameString.Equals("") || CustomerIDString.Equals("") || DoorNumberString.Equals("") || MobileNumberString.Equals("") || AddressString.Equals("")|| PreviousBalanceDouble == 0 || MonthlyChargeDouble == 0 || TaxOtherDouble == 0 || PaidAmountDouble == 0 || CurrentBalanceDouble == 0
                    MessageBox.Show("Enter all * fields ");
                }
                else
                {
                    
                    using (OleDbConnection con = GetConnection())
                    {

                        con.Open();

                        using(OleDbCommand checkCustomerID = new OleDbCommand("select cust_id from customer where cust_id = @cust",con))
                        {
                            checkCustomerID.Parameters.AddWithValue("@cust", CustomerIDString);

                            SelectData=checkCustomerID.ExecuteReader();
                            if (!SelectData.Read())
                            {

                                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO customer (DEVICE_ID, CUST_ID, CUST_name, address, ph_no, stb_no, conn_date, as_on_date, prev_bal, curr_bal, paid_amt, status, remarks, last_paid_date, last_paid_amt, rt_code, door_no, aadhar_no, tax_others, pkg_name, pkg_code, pkg_price, ext_price, pid, gst, nr_date, discount) " +
                                    "VALUES (@id, @cust, @custName, @address, @phNum, @stb_no1, @conn_date1, @as_on_date1, @prev_bal1, curr_bal, @paid_amt1, @status1, @remarks1, @last_paid_date1, @last_paid_amount1, @rt_code1, @door_no1, @aadhar_no1, @tax_others1, @pkg_name1, @pkg_code1, @pkg_price1, @ext_price1, @pid1, @gst1, @nr_date1, @discount1)", con))
                                {
                                    cmd.Parameters.AddWithValue("@id", DeviceIDInt);
                                    cmd.Parameters.AddWithValue("@cust", CustomerIDString);
                                    cmd.Parameters.AddWithValue("@custName", CustomerNameString);
                                    cmd.Parameters.AddWithValue("@address", AddressString);
                                    cmd.Parameters.AddWithValue("@phNum", MobileNumberString);
                                    cmd.Parameters.AddWithValue("@stb_no1", STBNumberString);
                                    cmd.Parameters.AddWithValue("@conn_date1", ConnectionDateDate);
                                    cmd.Parameters.AddWithValue("@as_on_date1", AsOnDateDate);
                                    cmd.Parameters.AddWithValue("@prev_bal1", PreviousBalanceDouble);
                                    cmd.Parameters.AddWithValue("@curr_bal1", CurrentBalanceDouble);
                                    cmd.Parameters.AddWithValue("@paid_amt1", PaidAmountDouble);
                                    cmd.Parameters.AddWithValue("@status1", StatusString);
                                    cmd.Parameters.AddWithValue("@remarks1", RemarksString);
                                    cmd.Parameters.AddWithValue("@last_paid_date1", LastPaidDateDate);
                                    cmd.Parameters.AddWithValue("@last_paid_amount1", LastPaidAmountDouble);
                                    cmd.Parameters.AddWithValue("@rt_code1", RouteCodeString);
                                    cmd.Parameters.AddWithValue("@door_no1", DoorNumberString);
                                    cmd.Parameters.AddWithValue("@aadhar_no1", AadharNumberString);
                                    cmd.Parameters.AddWithValue("@tax_others1", TaxOtherDouble);
                                    cmd.Parameters.AddWithValue("@pkg_name1", SelectPackageString);
                                    cmd.Parameters.AddWithValue("@pkg_code1", packagCodeString);
                                    cmd.Parameters.AddWithValue("@pkg_price1", packagePriceDouble);
                                    cmd.Parameters.AddWithValue("@ext_price1", ExtraPriceInt);
                                    cmd.Parameters.AddWithValue("@pid1", packageIDInt);
                                    cmd.Parameters.AddWithValue("@gst1", SelectGST);
                                    cmd.Parameters.AddWithValue("@nr_date1", NextRenewalDate);
                                    cmd.Parameters.AddWithValue("@discount1", DiscountDouble);
                                    int D = cmd.ExecuteNonQuery();
                                    if (D == -1)
                                    {
                                        MessageBox.Show("insertion fail");
                                    }
                                    else
                                    {
                                        MessageBox.Show("insertion successful");
                                        Grid_Load();
                                        Load_ActiveCust();
                                        Load_CustCount();
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("CUSTOMER ID IS ALREADY EXISTED .... PLEASE ENTER ANOTHER CUSTOMER ID");
                            }
                        }

                       
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
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
        private void Load_PackageName()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT PKG_NAME FROM package", con1);
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(dr);
                packageNameUI.DataSource = data;
                packageNameUI.DisplayMember = "PKG_NAME";
            }
        }
        private void Load_PackageDetails()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                SelectPackageName = packageNameUI.Text;
                using (OleDbCommand PackageDetailCommand = new OleDbCommand("select * from package where PKG_NAME = @pkgName", con1))
                {
                    PackageDetailCommand.Parameters.AddWithValue("@pkgName", SelectPackageName);
                    using (SelectData = PackageDetailCommand.ExecuteReader())
                    {
                        if (SelectData.Read())
                        {
                            packageIDUI.Text = SelectData["PID"].ToString();
                            packageCodeUI.Text = SelectData["PKG_CODE"].ToString();
                            packagePriceUI.Text = SelectData["PKG_PRICE"].ToString();
                        }
                    }
                }

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
        private void Load_RouteCode()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand loadRouteCodeCommand = new OleDbCommand("SELECT RT_CODE FROM routes", con1);
                OleDbDataReader dataRead = loadRouteCodeCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataRead);
                RouteCodeUI.DataSource = dataTable;
                RouteCodeUI.DisplayMember = "RT_CODE";

            }
        }
        private void Load_DoubleValues()
        {
            InstallationCharges.Text = "0";
            PreviousBalanceUI.Text = "0";
            MonthlyChargeUI.Text = "0";
            ExtraPriceUI.Text = "0";
            PaidAmountUI.Text = "0";
            CurrentBalanceUI.Text= "0";
            DiscountUI.Text = "0";
            lastPaidAmountUI.Text= "0";
            GstOtherUI.Text = "0";


        }
        private void Load_StringEmpty()
        {
               CustomerName.Text = String.Empty;
                CustomerID.Text = String.Empty;
                DoorNumber.Text = String.Empty;
                MobileNumberUI.Text = String.Empty;
                Address.Text = String.Empty;
                CardNumber.Text = String.Empty;
                AadharNumberUI.Text= String.Empty;
                STBNumber.Text = String.Empty;
                CafNo.Text = String.Empty;
                Remarks.Text = String.Empty;
        }
        private void Load_Gst()
        {
            try
            {

                packagePriceDouble = Convert.ToDouble(packagePriceUI.Text);
                SelectGSTInt = selectGst1.SelectedIndex;
                GstOtherUI.Text = ((SelectGSTInt * packagePriceDouble) / 100).ToString();
            }
            catch (Exception ex)
            {

            }
            
        }
        private void Load_currrentBal()
        {
            try
            {
                PreviousBalanceDouble = Convert.ToDouble(PreviousBalanceUI.Text);
                MonthlyChargeDouble = Convert.ToDouble(MonthlyChargeUI.Text);
                packagePriceDouble = Convert.ToDouble(packagePriceUI.Text);
                TaxOtherDouble = Convert.ToDouble(GstOtherUI.Text);
                PaidAmountDouble = Convert.ToDouble(PaidAmountUI.Text);
                DiscountDouble = Convert.ToDouble(DiscountUI.Text);
                ExtraPriceInt = Convert.ToInt32(ExtraPriceUI.Text);
                CurrentBalanceUI.Text = Convert.ToString(PreviousBalanceDouble + MonthlyChargeDouble + packagePriceDouble + TaxOtherDouble + ExtraPriceInt - PaidAmountDouble - DiscountDouble);


            }
            catch (Exception ex)
            {

            }
        }
        private void Load_ActiveCust()
        {
            try
            {
                using (OleDbConnection con = GetConnection())
                {
                    con.Open();
                    using (OleDbCommand custCount = new OleDbCommand("select count(cust_id) from customer where status = 'ACTIVE'", con))
                    {
                        count = (int)custCount.ExecuteScalar();
                        TotalActiveCustomers.Text = count.ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_CustCount()
        {
            try
            {
                using (OleDbConnection con = GetConnection())
                {
                    con.Open();
                    using (OleDbCommand custCount = new OleDbCommand("select count(cust_id) from customer", con))
                    {
                        count = (int)custCount.ExecuteScalar();
                        TotalCustomers.Text = count.ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
 