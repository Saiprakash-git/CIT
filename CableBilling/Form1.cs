using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableBilling
{
    public partial class Form1 : Form
    {
        private string passwordFix = "ADMIN";
        public Form1()
        {
            InitializeComponent();
        }

        private void Ok_Button_Click(object sender, EventArgs e)
        {
            string username1 = string.Empty;
            string password = password_TextBox.Text;
            if (!admin_RadioButton.Checked && !user_RadioButtton.Checked || password.Equals(""))
            {
                if (!admin_RadioButton.Checked && !user_RadioButtton.Checked)
                    MessageBox.Show("Select Login Type ");
                else if (password.Equals(""))
                    MessageBox.Show("Enter Password");
            }
            else
            {
                if (admin_RadioButton.Checked)
                {
                    username1 = admin_RadioButton.Text;
                    if (password.Equals(passwordFix))
                    {
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("wrong password ");
                }
                else
                {
                    username1 = user_RadioButtton.Text;
                   
                }

            }
        }
    }
}
