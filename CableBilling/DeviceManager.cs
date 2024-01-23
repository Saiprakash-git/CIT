using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//Device_GridView
namespace CableBilling
{
    public partial class DeviceManager : Form
    {
        // declaring variables 
        private string idString, name, phoneNumber;
        private int idInt;
        private OleDbDataReader reader;
        private int insertCheck;

        public DeviceManager()
        {
            InitializeComponent();
        }

        private OleDbConnection GetConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\projects\\desktopCableBilling\\SRET CBS 3.8 DATABASE.mdb;Persist Security Info=True;Jet OLEDB:Database Password=SreTc@2020cbs";
            
            return new OleDbConnection(connectionString);
        }

        private void DeviceManager_Load(object sender, EventArgs e)
        {
            Load_Grid();
            Load_DeviceID();
            clear_DeviceID();
            LoadUpdateValues();
          
            DeviceID_AddDevice_TextBox.Text= nextDeviceID();
        }


        private void DeviceID_UD_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeviceID_UD_ComboBox.SelectedItem != null)
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




        private void AddDevice_Button_Click(object sender, EventArgs e)
        {
            try
            {
                idString = DeviceID_AddDevice_TextBox.Text;
                name = EmploayeeName_EmployeeName_TextBox.Text;
                phoneNumber = PhoneNO_PhoneNO_TextBox.Text;

                if (string.IsNullOrWhiteSpace(idString) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber))
                {
                    MessageBox.Show("Please enter all the fields.");
                    return;
                }

                if (!int.TryParse(idString, out idInt))
                {
                    MessageBox.Show("Invalid Device ID format.");
                   
                }

                using (OleDbConnection con1 = GetConnection())
                {
                    con1.Open();
                    OleDbCommand idCheckCommand = new OleDbCommand("SELECT DEVICE_ID FROM unit WHERE DEVICE_ID = @deviceID", con1);
                    idCheckCommand.Parameters.AddWithValue("@deviceID", idInt);
                    reader = idCheckCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Device ID already exists. Please enter another Device ID.");
                    }
                    else
                    {
                        OleDbCommand insertDeviceCommand = new OleDbCommand("INSERT INTO unit (DEVICE_ID, EMP_NAME, PH_NO,unique_device_id) VALUES (@id, @name, @phoneNumber,'0')", con1); insertDeviceCommand.Parameters.AddWithValue("@id", idInt);
                        insertDeviceCommand.Parameters.AddWithValue("@name", name);
                        insertDeviceCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        insertCheck = insertDeviceCommand.ExecuteNonQuery();

                        if (insertCheck == 1)
                        {
                            MessageBox.Show("Device Added");
                            Load_Grid();
                            Load_DeviceID();
                            DeviceID_AddDevice_TextBox.Text = nextDeviceID();
                            EmploayeeName_EmployeeName_TextBox.Clear();
                            PhoneNO_PhoneNO_TextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Adding device failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void clear_DeviceID()
        {
            EmployeeName_UD_TextBox.Text = string.Empty;
            PhoneNO_UD_TextBox.Text = string.Empty;
        }

        private void Load_Grid()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT device_id,emp_name,ph_no FROM unit ORDER BY device_id", con1);
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(dr);
                Device_GridView.DataSource = data;
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            idString = DeviceID_UD_ComboBox.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                if (!int.TryParse(idString, out idInt))
                {
                    MessageBox.Show("Invalid Device ID format . Please enter number only");

                }

            }
            else
            {
                MessageBox.Show("Enter Device ID");
            }
             phoneNumber = PhoneNO_UD_TextBox.Text;
             name = EmployeeName_UD_TextBox.Text;

                using (OleDbConnection con1 = GetConnection())
                {
                    con1.Open();
                    OleDbCommand command = new OleDbCommand("UPDATE unit SET EMP_NAME = @name, PH_NO = @phNo WHERE DEVICE_ID = @ID", con1);

                command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@phNo", phoneNumber);
                    command.Parameters.AddWithValue("@ID", idInt);

                    int flag = command.ExecuteNonQuery();
                    if (flag > 0)
                    {
                        MessageBox.Show("Update Successful");
                        Load_Grid();
                        Load_DeviceID();
                        clear_DeviceID();
                        LoadUpdateValues();
                }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                }
           
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            idString = DeviceID_UD_ComboBox.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                if (!int.TryParse(idString, out idInt))
                {
                    MessageBox.Show("Invalid Device ID format . Please enter number only");

                }

            }
            else
            {
                MessageBox.Show("Enter Device ID");
            }
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand command = new OleDbCommand("delete from  unit  WHERE DEVICE_ID = @ID", con1);
                command.Parameters.AddWithValue("@ID", idInt);

                int flag = command.ExecuteNonQuery();
                if (flag > 0)
                {
                    MessageBox.Show("Delete Successful");
                    DeviceID_AddDevice_TextBox.Text = nextDeviceID();

                    Load_Grid();
                    Load_DeviceID();
                    clear_DeviceID();
                    LoadUpdateValues();

                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }
            }
        }

        private void Load_DeviceID()
        {
            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand loadDeviceIDCommand = new OleDbCommand("SELECT DEVICE_ID FROM unit ORDER BY device_id", con1);
                OleDbDataReader dataRead = loadDeviceIDCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataRead);
                DeviceID_UD_ComboBox.DataSource = dataTable;
                DeviceID_UD_ComboBox.DisplayMember = "DEVICE_ID";

            }
        }

        private void LoadUpdateValues()
        {
            idString = DeviceID_UD_ComboBox.Text.ToString();
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
                        EmployeeName_UD_TextBox.Text = getData2["EMP_NAME"].ToString();
                        PhoneNO_UD_TextBox.Text = getData2["PH_NO"].ToString();
                        DeviceID_UD_ComboBox.Text = getData2["DEVICE_ID"].ToString();
                    }
                    else
                    {
                    }
                }
            }
        }
        public string nextDeviceID()
        {
            ArrayList arrayList = new ArrayList();

            using (OleDbConnection con1 = GetConnection())
            {
                con1.Open();
                OleDbCommand loadDeviceIDCommand = new OleDbCommand("SELECT DEVICE_ID FROM unit order by DEVICE_ID ", con1);
                OleDbDataReader dataRead = loadDeviceIDCommand.ExecuteReader();

                while (dataRead.Read())
                {
                    int value = dataRead.GetInt32(0);
                    arrayList.Add(value);
                }
                arrayList.Sort();
            }

            if (arrayList.Count > 0)
            {
                // Check for consecutive gaps
                for (int i = 0; i < arrayList.Count - 1; i++)
                {
                    if ((int)arrayList[0] != 1)
                    {
                        return "" + 1;
                    } 
                    int currentID = (int)arrayList[i];
                    int nextID = (int)arrayList[i + 1];

                    if (nextID - currentID > 1)
                    {
                        return "" + (currentID + 1);
                    }
                }

                // No gaps found, use the next highest device ID
                return "" + ((int)arrayList[arrayList.Count - 1] + 1);
            }
            else
            {
                // No device IDs found, start from 1
                return "" + 1;
            }
        }
    }
}

