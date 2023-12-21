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
    public partial class ManagePackage : Form
    {
        private string  packageName, packageCode,packageType;
        private int packageID,checkCommand;
        private OleDbDataReader SelectData;
        private Double packagePrice;
        public ManagePackage()
        {
            InitializeComponent();
        }

        private OleDbConnection GetConnection()
        {

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\projects\\desktopCableBilling\\SRET CBS 3.8 DATABASE.mdb;Persist Security Info=True;Jet OLEDB:Database Password=SreTc@2020cbs";
            return new OleDbConnection(connectionString);
        }
        private void PackageID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit or the Backspace key (ASCII 8).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                // Block the key press event.
                e.Handled = true;
            }
            else
            {
            }
        }

        private void PackagePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ManagePackage_Load(object sender, EventArgs e)
        {
            Load_Grid();
            SetPackageEmpty();
            Load_PackageName();
            Load_PackageDetails();
            Load_PackageType();

        }

        private void Load_PackageType()
        {
            packageTypeAP.Items.Add("28");
            packageTypeAP.Items.Add("29");
            packageTypeAP.Items.Add("30");
            packageTypeAP.Items.Add("90");
            packageTypeAP.Items.Add("180");
            packageTypeAP.Items.Add("360");
            packageTypeAP.Items.Add("MONTHLY");

            packageTypeUD.Items.Add("28");
            packageTypeUD.Items.Add("29");
            packageTypeUD.Items.Add("30");
            packageTypeUD.Items.Add("90");
            packageTypeUD.Items.Add("180");
            packageTypeUD.Items.Add("360");
            packageTypeUD.Items.Add("MONTHLY");

        }

        private void AddPackage_Click(object sender, EventArgs e)
        {
           
            packageName = PackageName.Text;
            packageCode = PackageCode.Text;
            packageType = packageTypeAP.Text;
            if (packageName.Equals("") || PackageCode.Equals("") || PackageID.Text.Equals("") || PackagePrice.Text.Equals("") || packageType.Equals(""))
            {
                if (packageName.Equals("") && PackageCode.Equals("") && PackageID.Text.Equals("") && PackagePrice.Text.Equals(""))
                    MessageBox.Show("ENTER ALL PACKAGE DETAILS");
                else if (PackageID.Text.Equals(""))
                    MessageBox.Show("ENTER PACKAGE ID");
                else if (packageName.Equals(""))
                    MessageBox.Show("ENTER PACKAGE NAME");
                else if (packageCode.Equals(""))
                    MessageBox.Show("ENTER PACKAGE CODE");
                else if (PackagePrice.Text.Equals(""))
                    MessageBox.Show("ENTER PACKAGE PRICE");
                else if (packageType.Equals(""))
                    MessageBox.Show("ENTER PACKAGE TYPE");
            }
            else
            {
                packageID = Convert.ToInt32(PackageID.Text);
                packagePrice = Convert.ToDouble(PackagePrice.Text);
                using (OleDbConnection con = GetConnection())
                {
                    con.Open();

                    using (OleDbCommand IDCheck = new OleDbCommand("select PID from package where PID = @pID", con))
                    {
                        IDCheck.Parameters.AddWithValue("@pID", packageID);
                        SelectData = IDCheck.ExecuteReader();

                        if (!SelectData.Read())
                        {
                            using (OleDbCommand checkPackageName = new OleDbCommand("select PKG_NAME from package where PKG_NAME = @pName", con))
                            {
                                checkPackageName.Parameters.AddWithValue("@pName", packageName);
                                SelectData = checkPackageName.ExecuteReader();
                                if (!SelectData.Read())
                                {
                                    using (OleDbCommand InsertCommand = new OleDbCommand("insert into package values(@pID,@pName,@pCode,@pPrice,@pType) ", con))
                                    {
                                        InsertCommand.Parameters.AddWithValue("@pID", packageID);
                                        InsertCommand.Parameters.AddWithValue("@pName", packageName);
                                        InsertCommand.Parameters.AddWithValue("@pCode", packageCode);
                                        InsertCommand.Parameters.AddWithValue("@pPrice", packagePrice);
                                        InsertCommand.Parameters.AddWithValue("@pType", packageType);
                                        checkCommand = InsertCommand.ExecuteNonQuery();

                                        if (checkCommand != -1)
                                        {
                                            MessageBox.Show("PACKAGE ADDED SUCCESSFUL");
                                            SetPackageEmpty();
                                            Load_Grid();
                                            Load_PackageName();

                                        }
                                        else
                                        {
                                            MessageBox.Show("PACKAGE ADDED FAILED");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("PACKAGE NAME ALREADY EXISTED .. PLEASE ENTER ANOTHER PACKAGE NAME");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("PACKAGE ID ALREADY EXISTED .. PLEASE ENTER ANOTHER PACKAGE ID");
                        }

                    }
                  
                }

            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            packageName = PackageName_UD.Text;
            packageCode = PackageCode_UD.Text;
            packageType = packageTypeUD.Text;
            if (packageName.Equals("") || PackageCode.Equals("") || PackageID_UD.Text.Equals("") || PackagePrice_UD.Text.Equals(""))
            {
                if (packageName.Equals("") && PackageCode.Equals("") && PackageID.Text.Equals("") && PackagePrice.Text.Equals(""))
                    MessageBox.Show("ENTER ALL PACKAGE DETAILS");
                else if (PackageID.Text.Equals(""))
                    MessageBox.Show("ENTER PACKAGE ID");
                else if (packageName.Equals(""))
                    MessageBox.Show("ENTER PACKAGE NAME");
                else if (packageCode.Equals(""))
                    MessageBox.Show("ENTER PACKAGE CODE");
                else if (PackagePrice.Text.Equals(""))
                    MessageBox.Show("ENTER PACKAGE PRICE");
            }
            else
            {
                packageID = Convert.ToInt32(PackageID_UD.Text);
                packagePrice = Convert.ToDouble(PackagePrice_UD.Text);

                using (OleDbConnection con = GetConnection())
                {
                    con.Open();

                    using (OleDbCommand checkPackageName = new OleDbCommand("select PKG_NAME from package where PKG_NAME = @pName", con))
                    {
                        checkPackageName.Parameters.AddWithValue("@pName", packageName);
                        SelectData = checkPackageName.ExecuteReader();
                        if (SelectData.Read())
                        {
                            using (OleDbCommand InsertCommand = new OleDbCommand("UPDATE package SET PKG_CODE = @pCode, PKG_PRICE = @pPrice , PKG_TYPE = @pType WHERE PKG_NAME = @pName", con))
                            {
                                InsertCommand.Parameters.AddWithValue("@pCode", packageCode);
                                InsertCommand.Parameters.AddWithValue("@pPrice", packagePrice);
                                InsertCommand.Parameters.AddWithValue("@pName", packageName);
                                InsertCommand.Parameters.AddWithValue("@pType", packageType);



                                checkCommand = InsertCommand.ExecuteNonQuery();
                                if (checkCommand != -1)
                                {
                                    MessageBox.Show("PACKAGE UPDATED SUCCESSFUL");
                                    Load_Grid();
                                    Load_PackageName();
                                    Load_PackageDetails();
                                }
                                else
                                {
                                    MessageBox.Show("PACKAGE UPDATED FAILED");
                                }
                            }


                        }
                        else
                        {

                            MessageBox.Show("PACKAGE NAME NOT EXISTED .. PLEASE ENTER ANOTHER PACKAGE NAME");

                        }

                    }

                }

            }

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            packageName = PackageName_UD.Text;
            packageCode = PackageCode_UD.Text;
            if (packageName.Equals("") || PackageCode.Equals("") || PackageID_UD.Text.Equals("") || PackagePrice_UD.Text.Equals("") )
            {
                if (packageName.Equals("") && PackageCode.Equals("") && PackageID.Text.Equals("") && PackagePrice.Text.Equals(""))
                    MessageBox.Show("ENTER ALL PACKAGE DETAILS");
                else if (PackageID.Text.Equals(""))
                    MessageBox.Show("ENTER PACKAGE ID");
                else if (packageName.Equals(""))
                    MessageBox.Show("ENTER PACKAGE NAME");
                else if (packageCode.Equals(""))
                    MessageBox.Show("ENTER PACKAGE CODE");
                else if (PackagePrice.Text.Equals(""))
                    MessageBox.Show("ENTER PACKAGE PRICE");
              
            }
            else
            {
                packageID = Convert.ToInt32(PackageID_UD.Text);
                packagePrice = Convert.ToDouble(PackagePrice_UD.Text);

                using (OleDbConnection con = GetConnection())
                {
                    con.Open();

                    using (OleDbCommand checkPackageName = new OleDbCommand("select PKG_NAME from package where PKG_NAME = @pName", con))
                    {
                        checkPackageName.Parameters.AddWithValue("@pName", packageName);
                        SelectData = checkPackageName.ExecuteReader();
                        if (SelectData.Read())
                        {
                            using (OleDbCommand InsertCommand = new OleDbCommand(" DELETE from package WHERE PKG_NAME = @pName", con))
                            {

                                InsertCommand.Parameters.AddWithValue("@pName", packageName);

                                checkCommand = InsertCommand.ExecuteNonQuery();
                                if (checkCommand != -1)
                                {
                                    MessageBox.Show("PACKAGE DELETED SUCCESSFUL");
                                    Load_Grid();
                                    Load_PackageName();
                                    Load_PackageDetails();
                                }
                                else
                                {
                                    MessageBox.Show("PACKAGE DELETED FAILED");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("PACKAGE NAME NOT EXISTED .. PLEASE ENTER ANOTHER PACKAGE NAME");
                        }

                    }

                }

            }
        }

        private void Load_Grid()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM package", con1);
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(dr);
                PackageGridView.DataSource = data;
            }
        }
        private void SetPackageEmpty()
        {
            PackageName.Text =string.Empty ;
            PackageCode.Text = string.Empty;
            PackageID.Text = string.Empty;
            PackagePrice.Text = string.Empty;
        }

        private void PackagePrice_UD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PackageName_UD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_PackageDetails();
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
                PackageName_UD.DataSource = data;
                PackageName_UD.DisplayMember = "PKG_NAME";
            }
        }
        private void Load_PackageDetails()
        {
            using(OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                packageName=PackageName_UD.Text;
                using( OleDbCommand PackageDetailCommand = new OleDbCommand("select * from package where PKG_NAME = @pkgName",con1))
                {
                    PackageDetailCommand.Parameters.AddWithValue("@pkgName",packageName);
                    using (SelectData = PackageDetailCommand.ExecuteReader())
                    {
                        if (SelectData.Read())
                        {
                            PackageID_UD.Text = SelectData["PID"].ToString();
                            PackageCode_UD.Text = SelectData["PKG_CODE"].ToString();
                            PackagePrice_UD.Text = SelectData["PKG_PRICE"].ToString();
                            packageTypeUD.SelectedItem = SelectData["PKG_TYPE"].ToString();
                        }
                    }                   
                }

            }
        }
    }
}
