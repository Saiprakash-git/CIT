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
    public partial class Uploadpkgs_custom_ : Form
    {
        static Uploadpkgs_custom_ uploadpkgs_Custom_;
        static int val;
        public Uploadpkgs_custom_()
        {
            InitializeComponent();
        }

        public static int ShowBox(string labelmsg,string label2msg = "Do you want to connect?")
        {
            uploadpkgs_Custom_ = new Uploadpkgs_custom_();
            uploadpkgs_Custom_.label1.Text = labelmsg;
            uploadpkgs_Custom_.label3.Text = label2msg;
            uploadpkgs_Custom_.ShowDialog();
            return val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            val = 1;
            uploadpkgs_Custom_.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            val = 0;
            uploadpkgs_Custom_.Dispose();

        }
    }
}
