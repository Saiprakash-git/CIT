using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaDevices;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Threading;
using System.Runtime.InteropServices;

namespace CableBilling
{
    public partial class UploadDownload : Form
    {
        string keyString = "qwertyuiopasdfgh";
        string ivString = "hgfdsapoiuytrewq";
        private int idInt;

        public UploadDownload()
        {
            InitializeComponent();
        }
        private void UploadDownload_Load(object sender, EventArgs e)
        {
            ConnectPanel.Enabled = false;
            deviceCheck.Enabled = false;
            Load_RouteCode();
            LoadUpdateValues();
        }
        private OleDbConnection GetConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\CIT\\cable Billling Desktop Project\\SRET CBS 3.8 DATABASE.mdb; Persist Security Info=True;Jet OLEDB:Database Password=SreTc@2020cbs";
            return new OleDbConnection(connectionString);
        }


        static void uploadtoAndroid(string filepath, MediaDevice device, string androidfilename)
        {
            if (device.IsConnected)
            {
                var driveInfo = device.GetDrives();

                if (!device.DirectoryExists($"{driveInfo[0].Name}\\Android\\data\\com.cit.cablebilling\\files\\pc"))
                {
                    MessageBox.Show("Please open the app ");
                }
                MediaDirectoryInfo info = device.GetDirectoryInfo($"{driveInfo[0].Name}\\Android\\data\\com.cit.cablebilling\\files\\pc");
                FileStream file = File.Open(filepath, FileMode.Open);
                if (device.FileExists($"{info.FullName}\\{androidfilename}"))
                {
                    MessageBox.Show("Please download your previous file records");                             
                }
                else
                {
                    try
                    {
                        device.UploadFile(file, $"{info.FullName}\\{androidfilename}");
                        MessageBox.Show("File Uploaded successfully");

                    }
                    catch (Exception ex)
                    {
                        // This Problem is only for samsung mobiles.
                        MessageBox.Show("Please Try again by Reconnecting the device  by removing cable");
                    }
                }

                file.Close();
                device.Dispose();
                device.Disconnect();
            }
        }
        static MediaDevice devConnect()
        {
            var devices = MediaDevice.GetDevices();
            if (devices.Count() > 0)
            {
                var device = devices.First();
                if (!device.IsConnected)
                {
                    device.Connect();
                }
                return device;

            }
            else
            {
                return null;
            }


        }


        private void connectDeviceButton_Click(object sender, EventArgs e)
        {
            var device = devConnect();
            var result = 0;
            if (device != null) { result = Uploadpkgs_custom_.ShowBox($"{device.FriendlyName}"); }
            else { MessageBox.Show("NO Device Found"); }

            if (result == 0)
            {

                deviceCheck.Enabled = false;

            }
            else
            {

                deviceCheck.Enabled = true;
            }




        }






        private void Load_RouteCode()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand loadRouteCodeCommand = new OleDbCommand("SELECT DEVICE_ID FROM unit ORDER BY device_id", con1);
                OleDbDataReader dataRead = loadRouteCodeCommand.ExecuteReader();
                while (dataRead.Read())
                {
                    deviceID.Items.Add(dataRead.GetInt32(0));
                }


            }
        }
        private void LoadUpdateValues()
        {

            string idString = deviceID.Text.ToString();
            try
            {
                idInt = Convert.ToInt32(idString);
            }
            catch (Exception ex)
            {
            }

            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand getData = new OleDbCommand("SELECT * FROM unit WHERE DEVICE_ID = @idInt", con1);
                getData.Parameters.AddWithValue("@idInt", idInt);
                using (OleDbDataReader getData2 = getData.ExecuteReader())
                {
                    if (getData2.Read())
                    {
                        EmployeeName.Text = getData2["EMP_NAME"].ToString();
                        PhoneNumber.Text = getData2["PH_NO"].ToString();
                    }
                    else
                    {
                    }
                }
            }
        }




        private void readDev_Click(object sender, EventArgs e)
        {
            var dev = devConnect();
            var driveInfo = dev.GetDrives();
            var directoryinfo = dev.GetDirectoryInfo($"{driveInfo[0].Name}\\Android\\data\\com.cit.cablebilling\\files\\pc");
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "decryptdetails.txt");
            FileStream file = File.Open(filepath, FileMode.Create);
            if (dev.FileExists($"{directoryinfo.FullName}\\deviceDetails.txt"))
            {
                dev.DownloadFile($"{directoryinfo.FullName}\\deviceDetails.txt", file);
                file.Close();
                fileEncryptorDecryptor.DecryptFile(filepath, "decryptdetails(99).txt", keyString, ivString);
                ArrayList ar = filemanipulations.readfile("decryptdetails(99).txt");
                deviceID.SelectedItem = Convert.ToInt32(ar[0]);
                EmployeeName.Text = ar[1].ToString();
                PhoneNumber.Text = ar[2].ToString();
                File.Delete("decryptdetails(99).txt");
                ConnectPanel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Register your Device");
                ConnectPanel.Enabled = false;
            }
            file.Close( );
            dev.Disconnect();
        }

        private void RegisterDevice_Click(object sender, EventArgs e)
        {
            if (!EmployeeName.Text.Equals(""))
            {
                var device = devConnect();
                if (device.IsConnected)
                {
                    string DatabaseDeviceID = "";
                    ArrayList deviceDetails1 = new ArrayList();

                    deviceDetails1.Add(deviceID.Text.ToString());
                    deviceDetails1.Add(EmployeeName.Text);
                    deviceDetails1.Add(PhoneNumber.Text);

                    deviceDetails1.Add(device.SerialNumber);

                    using (OleDbConnection con1 = GetConnection())
                    {
                        con1.Open();
                        OleDbCommand getDeviceIDCommand = new OleDbCommand("SELECT unique_device_id FROM unit WHERE DEVICE_ID = @ID", con1);
                        getDeviceIDCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(deviceID.Text.ToString()));
                        using (OleDbDataReader getData2 = getDeviceIDCommand.ExecuteReader())
                        {
                            if (getData2.Read())
                            {
                                DatabaseDeviceID = getData2["unique_device_id"].ToString();
                            }
                            if (DatabaseDeviceID.Equals("0"))
                            {
                                ArrayList check = new ArrayList();
                                OleDbCommand CheckifIDexists = new OleDbCommand("SELECT unique_device_id FROM unit WHERE unique_device_id<>'0'", con1);
                                OleDbDataReader dataRead = CheckifIDexists.ExecuteReader();
                                while (dataRead.Read())
                                {
                                    check.Add(dataRead["unique_device_id"]);

                                }
                                if (!check.Contains(device.SerialNumber.ToString()))
                                {
                                    OleDbCommand command = new OleDbCommand("UPDATE unit SET unique_device_id = @unique WHERE DEVICE_ID = @ID", con1);
                                    command.Parameters.AddWithValue("@unique", device.SerialNumber.ToString());
                                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(deviceID.Text.ToString()));
                                    command.ExecuteNonQuery();
                                    string filepath = filemanipulations.WriteTextToFile("deviceDetails.txt", deviceDetails1);
                                    fileEncryptorDecryptor.EncryptFile(filepath, "deviceDetails(encrypted).txt", keyString, ivString);
                                    if (filepath != null && device != null)
                                    {
                                        uploadtoAndroid("deviceDetails(encrypted).txt", device, "deviceDetails.txt");
                                        ConnectPanel.Enabled = true;
                                        MessageBox.Show("Device Registered successfully !!");
                                    }
                                    else
                                        MessageBox.Show("No device details Found to Upload");
                                    File.Delete("deviceDetails.txt");
                                }
                                else
                                {
                                    OleDbCommand command = new OleDbCommand("SELECT DEVICE_ID FROM unit WHERE unique_device_id = @ID", con1);
                                    command.Parameters.AddWithValue("@ID", device.SerialNumber.ToString());
                                    OleDbDataReader reader = command.ExecuteReader();
                                    if (reader.Read())
                                        MessageBox.Show($"Mobile Already Registered with {reader["DEVICE_ID"]}");
                                }

                            }

                            else
                            {
                                MessageBox.Show("Device_ID Already Registered with other device");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select DeviceId");
            }
        }
        private void Deregister_Device_Click(object sender, EventArgs e)
        {

            var dev = devConnect();
            var driveInfo = dev.GetDrives();
            int res = Uploadpkgs_custom_.ShowBox("Do you want to Deregister", "Are you sure??");
            if (res == 1)
            {
                if (dev.DirectoryExists($"{driveInfo[0].Name}\\Android\\data\\com.cit.cablebilling\\files\\pc"))
                {
                    var directoryinfo = dev.GetDirectoryInfo($"{driveInfo[0].Name}\\Android\\data\\com.cit.cablebilling\\files\\pc");
                    if (dev.FileExists($"{directoryinfo.FullName}\\deviceDetails.txt"))
                    {
                        dev.DeleteFile($"{directoryinfo.FullName}\\deviceDetails.txt");
                    }
                }
                string deviceSerialNumber = dev.SerialNumber.ToString();
                using (OleDbConnection con1 = GetConnection())
                {
                    con1.Open();
                    using (OleDbCommand updateUniqueDeviceID = new OleDbCommand("UPDATE unit SET unique_device_id = '0' Where unique_device_id = @serialint", con1))
                    {
                        updateUniqueDeviceID.Parameters.AddWithValue("@serialint", deviceSerialNumber);
                        updateUniqueDeviceID.ExecuteNonQuery();
                        MessageBox.Show("Deregister successful");
                    }

                }
            }
        }

        private void uploadpkgs_Click_1(object sender, EventArgs e)
        {
            var device = devConnect();

            ArrayList packagedatalines = new ArrayList();

            using (OleDbConnection con = GetConnection())
            {
                con.Open();

                using (OleDbCommand command = new OleDbCommand("select * from package", con))
                {
                    using (OleDbDataReader SelectData = command.ExecuteReader())
                    {
                        string packageData = string.Empty;
                        while (SelectData.Read())
                        {
                            packageData = string.Empty;
                            packageData = Convert.ToString(SelectData.GetInt32(0));
                            packageData += ",";
                            packageData += SelectData.GetString(1);
                            packageData += ",";
                            packageData += SelectData.GetString(2);
                            packageData += ",";
                            packageData += Convert.ToString(SelectData.GetDouble(3));
                            packageData += ",";
                            packageData += SelectData.GetString(4);
                            packagedatalines.Add(packageData);
                        }
                        if (packagedatalines.Count > 0)
                        {

                            string filepath = filemanipulations.WriteTextToFile("pkgDtoA", packagedatalines);
                            fileEncryptorDecryptor.EncryptFile(filepath, "EncryptFile1.txt", keyString, ivString);
                            if (filepath != null && device != null)
                            {
                                uploadtoAndroid("EncryptFile1.txt", device, "pkgDtoA.txt");
                            }
                        }
                        else
                            MessageBox.Show("No data Found to Upload");
                    }
                }
            }

        }

        private void DownloadPkgs_Click_1(object sender, EventArgs e)
        {
            var device = devConnect();
            var driveInfo = device.GetDrives();
            var directoryinfo = device.GetDirectoryInfo($"{driveInfo[0].Name}\\Android\\data\\com.cit.cablebilling\\files\\pc");
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "decryptdown.txt");
            FileStream file = File.Open(filepath, FileMode.Create);
            try
            {
                device.DownloadFile($"{directoryinfo.FullName}\\pkgAtoD.txt", file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try again by Reconnecting the device  by removing cable");
            }
            file.Close();
            fileEncryptorDecryptor.DecryptFile(filepath, "decryptedfile.txt", keyString, ivString);
            ArrayList arrayList = filemanipulations.readfile("decryptedfile.txt");
            if (arrayList == null)
            {

            }
            else
            {
                using (OleDbConnection con = GetConnection())
                {
                    con.Open();
                    using (OleDbCommand command = new OleDbCommand("delete from package", con))
                    {
                        int rows = command.ExecuteNonQuery();
                    }
                    foreach (string line in arrayList)
                    {
                        string[] cols = line.Split(',');

                        using (OleDbCommand InsertCommand = new OleDbCommand("insert into package values(@pID,@pName,@pCode,@pPrice,@pType) ", con))
                        {
                            InsertCommand.Parameters.AddWithValue("@pID", Convert.ToInt32(cols[0]));
                            InsertCommand.Parameters.AddWithValue("@pName", cols[1]);
                            InsertCommand.Parameters.AddWithValue("@pCode", cols[2]);
                            InsertCommand.Parameters.AddWithValue("@pPrice", Convert.ToDouble(cols[3]));
                            InsertCommand.Parameters.AddWithValue("@pType", cols[4]);
                            int checkCommand = InsertCommand.ExecuteNonQuery();
                            if (checkCommand != -1)
                            {
                                MessageBox.Show("PACKAGE ADDED SUCCESSFUL");
                            }
                            else
                            {
                                MessageBox.Show("PACKAGE ADDED FAILED");
                            }

                        }

                    }
                }
                File.Delete("decryptedfile.txt");
            }
        }

        private void upload_route_code_Click(object sender, EventArgs e)
        {
            using (var device = devConnect())
            {
                if (device.IsConnected)
                {
                    if (deviceID.Text.ToString() != null)
                    {
                        int deviceIDint = Convert.ToInt32(deviceID.Text.ToString());
                        ArrayList routedataLines = new ArrayList();
                        using (OleDbConnection con = GetConnection())
                        {
                            con.Open();
                            using (OleDbCommand command = new OleDbCommand("SELECT RT_CODE,RT_DETAILS FROM routes WHERE DEV_ID = @devint", con))
                            {
                                command.Parameters.AddWithValue("@devint", deviceIDint);
                                using (OleDbDataReader SelectData2 = command.ExecuteReader())
                                {
                                    string routeData = string.Empty;
                                    if (SelectData2.HasRows)
                                    {
                                        while (SelectData2.Read())
                                        {
                                            routeData = string.Empty;
                                            routeData += SelectData2.GetString(0) + ",";
                                            routeData += SelectData2.GetString(1);
                                            routedataLines.Add(routeData);
                                        }
                                        string filepath = filemanipulations.WriteTextToFile("routesDtoA.txt", routedataLines);
                                        fileEncryptorDecryptor.EncryptFile(filepath, "EncryptedrouteFile1.txt", keyString, ivString);
                                        if (filepath != null && device != null)
                                        {
                                            uploadtoAndroid("EncryptedrouteFile1.txt", device, "routesDtoA.txt");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No route details are there to upload");
                                    }


                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please read your device before you upload");
                    }
                }
            }
        }

        private void deviceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deviceID.SelectedItem != null)
            {
                try
                {
                    LoadUpdateValues();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}