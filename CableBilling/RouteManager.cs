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
    public partial class RouteManager : Form
    {
        private string DeviceID, RouteCode, RouteDetails;
        private int DeviceIDInt;
        public RouteManager()
        {
            InitializeComponent();
        }
        private OleDbConnection GetConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\projects\\desktopCableBilling\\SRET CBS 3.8 DATABASE.mdb;Persist Security Info=True;Jet OLEDB:Database Password=SreTc@2020cbs";
            return new OleDbConnection(connectionString);
        }

        private void RouteManager_Load(object sender, EventArgs e)
        {
            Load_DeviceID();
            Load_Grid();
            Load_UD_DeviceID();
            Load_RouteCode();
            Load_Route_Value();
            
        }
        private void AddRoute_Button_Click(object sender, EventArgs e)
        {
            try
            { 
                DeviceID = DeviceID_AddRoute_ComboBox.Text;
                RouteCode = RouteCode_AddRoute_TextBox.Text;
                RouteDetails = RouteDetails_AddRoute_TextBox.Text;
                if(DeviceID.Equals("") ||RouteDetails.Equals("") || RouteCode.Equals(""))
                {
                    if (RouteDetails.Equals("") && RouteCode.Equals(""))
                        MessageBox.Show("Enter all the details");
                    else if(RouteDetails.Equals(""))
                        MessageBox.Show("Enter RouteDetails");
                    else if (RouteCode.Equals(""))
                        MessageBox.Show("Enter RouteCode");
                }

                else if (int.TryParse(DeviceID,out DeviceIDInt))
                {
                    using(OleDbConnection con = GetConnection())
                    {
                        con.Open();
                        using (OleDbCommand checkDeviceID = new OleDbCommand("select Device_ID from unit where DEVICE_ID = @device", con))
                        {
                            checkDeviceID.Parameters.AddWithValue("@device", DeviceIDInt);
                            OleDbDataReader deviceCheck =  checkDeviceID.ExecuteReader();
                            if (deviceCheck.Read())
                            {
                                OleDbCommand oleDbCommand = new OleDbCommand("select RT_CODE from routes where RT_CODE = @rtCode", con);
                                oleDbCommand.Parameters.AddWithValue("@rtCode", RouteCode);
                                OleDbDataReader read = oleDbCommand.ExecuteReader();
                                if (!read.Read())
                                {
                                    OleDbCommand command = new OleDbCommand("insert into routes values(@routeCode,@deviceID,@routeDetails)", con);
                                    command.Parameters.AddWithValue("@routeCode", RouteCode);
                                    command.Parameters.AddWithValue("@deviceID", DeviceIDInt);
                                    command.Parameters.AddWithValue("@routeDetails", RouteDetails);
                                    int flag = command.ExecuteNonQuery();
                                    if (flag != -1)
                                    {
                                        MessageBox.Show("Insertion Successful");
                                        RouteCode_AddRoute_TextBox.Text = string.Empty;
                                        RouteDetails_AddRoute_TextBox.Text=string.Empty;
                                        Load_Grid();
                                        Load_RouteCode();
                                        Load_UD_DeviceID();
                                        Load_Route_Value();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Insertion Failed");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Route Code already existed .. please enter another Route Code ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("DeviceID not existed .. please enter another DeviceID");
                            }

                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Enter Device In Number Format");
                }
            }
            catch(Exception ex ) 
            {
                MessageBox.Show(""+ex.Message);
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

                DeviceID_AddRoute_ComboBox.DataSource = dataTable;
                DeviceID_AddRoute_ComboBox.DisplayMember = "DEVICE_ID";

            }
        }
        private void Load_UD_DeviceID()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand loadDeviceIDCommand = new OleDbCommand("SELECT DEVICE_ID FROM unit", con1);
                OleDbDataReader dataRead = loadDeviceIDCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataRead);
                DeviceID_UD_ComboBox.DataSource = dataTable;
                DeviceID_UD_ComboBox.DisplayMember = "DEVICE_ID";

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
                RouteCode_UD_ComboBox.DataSource = dataTable;
                RouteCode_UD_ComboBox.DisplayMember = "RT_CODE";

            }
        }

        private void RouteCode_UD_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Route_Value();
        }

        private void Update_Route_Button_Click(object sender, EventArgs e)
        {
            DeviceID = DeviceID_UD_ComboBox.Text;
            RouteCode = RouteCode_UD_ComboBox.Text;
            RouteDetails = RouteDetails_UD_TextBox.Text;
            if (DeviceID.Equals("") || RouteDetails.Equals("") || RouteCode.Equals(""))
            {
                if (RouteDetails.Equals("") && RouteCode.Equals(""))
                    MessageBox.Show("Enter all the details");
                else if (RouteDetails.Equals(""))
                    MessageBox.Show("Enter RouteDetails");
                else if (RouteCode.Equals(""))
                    MessageBox.Show("Enter RouteCode");
            }
            else
            {

                using (OleDbConnection con1 = GetConnection())
                {
                    if (int.TryParse(DeviceID, out DeviceIDInt))
                    {
                        con1.Open();
                        try
                        {
                            // Assuming you have already opened the connection 'con1' before this code block

                            //OleDbCommand command = new OleDbCommand("UPDATE routes SET DEV_ID = ?, RT_DETAILS = ? WHERE RT_CODE = ?", con1);
                            OleDbCommand command = new OleDbCommand("update routes set DEV_ID = @deviceID , RT_DETAILS = @routeDetails where RT_CODE = @routeCode", con1);
                            // Assuming you have parameters for deviceID, routeDetails, and routeCode defined
                            command.Parameters.AddWithValue("@deviceID", DeviceID);
                            command.Parameters.AddWithValue("@routeDetails", RouteDetails);
                            command.Parameters.AddWithValue("@routeCode", RouteCode);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // The update was successful
                                MessageBox.Show("Update Successful");
                                Load_Grid();
                                Load_Route_Value();
                                Load_RouteCode();

                            }
                            else
                            {
                                MessageBox.Show("Update Failed");

                                // No rows were updated, handle this case as needed
                            }
                        }
                        catch (OleDbException ex)
                        {
                            // Handle any exceptions here
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        finally
                        {
                            // Close the connection when done
                            con1.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter Device In Number Format");
                    }
                }

            }

        }

        private void Delete_Route_Button_Click(object sender, EventArgs e)
        {
            RouteCode = RouteCode_UD_ComboBox.Text;
            if (RouteCode.Equals(""))
            {
                MessageBox.Show(" Select RouteCode ");
            }
            else
            {
                using (OleDbConnection con1 = GetConnection())
                {
                    con1.Open();
                    try
                    {

                        OleDbCommand command = new OleDbCommand("delete from routes where RT_CODE = @routeCode", con1);

                        command.Parameters.AddWithValue("@routeCode", RouteCode);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Delete Successful");
                            Load_Grid();
                            Load_Route_Value();
                            Load_RouteCode();

                        }
                        else
                        {
                            MessageBox.Show("Delete Failed");

                        }
                    }
                    catch (OleDbException ex)
                    {
                        // Handle any exceptions here
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    finally
                    {
                        // Close the connection when done
                        con1.Close();
                    }


                }

            }

        }

        private void Load_Grid()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM routes", con1);
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(dr);
                Route_GridView.DataSource = data;
            }
        }
        private void Load_Route_Value()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                try
                {
                    RouteCode = RouteCode_UD_ComboBox.Text;
                    con1.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM routes where RT_CODE = @routeCode", con1);
                    cmd.Parameters.AddWithValue("@routeCode", RouteCode);
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            DeviceID_UD_ComboBox.Text = dr["DEV_ID"].ToString();
                            RouteCode_UD_ComboBox.Text = dr["RT_CODE"].ToString();
                            RouteDetails_UD_TextBox.Text = dr["RT_DETAILS"].ToString();
                        }
                        else
                        {
                        }
                    }

                }
                catch (Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }
    }
}

