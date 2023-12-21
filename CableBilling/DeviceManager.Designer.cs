namespace CableBilling
{
    partial class DeviceManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Device_GridView = new System.Windows.Forms.DataGridView();
            this.UpdateDeleteDevice_GroupBox = new System.Windows.Forms.GroupBox();
            this.DeviceID_UD_ComboBox = new System.Windows.Forms.ComboBox();
            this.Update_Button = new System.Windows.Forms.Button();
            this.EmployeeName_UD_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNO_UD_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmploayeeName_EmployeeName_TextBox = new System.Windows.Forms.TextBox();
            this.EmployeeName_Label = new System.Windows.Forms.Label();
            this.PhoneNO_PhoneNO_TextBox = new System.Windows.Forms.TextBox();
            this.PhoneNO_Label = new System.Windows.Forms.Label();
            this.AddDevice_Button = new System.Windows.Forms.Button();
            this.DeviceID_AddDevice_TextBox = new System.Windows.Forms.TextBox();
            this.DeviceID_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Device_GridView)).BeginInit();
            this.UpdateDeleteDevice_GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Device_GridView);
            this.panel1.Controls.Add(this.UpdateDeleteDevice_GroupBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 819);
            this.panel1.TabIndex = 10;
            // 
            // Device_GridView
            // 
            this.Device_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Device_GridView.Location = new System.Drawing.Point(288, 451);
            this.Device_GridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Device_GridView.Name = "Device_GridView";
            this.Device_GridView.RowHeadersWidth = 51;
            this.Device_GridView.RowTemplate.Height = 24;
            this.Device_GridView.Size = new System.Drawing.Size(517, 254);
            this.Device_GridView.TabIndex = 17;
            // 
            // UpdateDeleteDevice_GroupBox
            // 
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.DeviceID_UD_ComboBox);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.Update_Button);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.EmployeeName_UD_TextBox);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.label2);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.PhoneNO_UD_TextBox);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.label3);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.Delete_Button);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.label4);
            this.UpdateDeleteDevice_GroupBox.Location = new System.Drawing.Point(772, 195);
            this.UpdateDeleteDevice_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateDeleteDevice_GroupBox.Name = "UpdateDeleteDevice_GroupBox";
            this.UpdateDeleteDevice_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateDeleteDevice_GroupBox.Size = new System.Drawing.Size(427, 240);
            this.UpdateDeleteDevice_GroupBox.TabIndex = 11;
            this.UpdateDeleteDevice_GroupBox.TabStop = false;
            this.UpdateDeleteDevice_GroupBox.Text = "UPDATE / DELETE DEVICE ";
            // 
            // DeviceID_UD_ComboBox
            // 
            this.DeviceID_UD_ComboBox.FormattingEnabled = true;
            this.DeviceID_UD_ComboBox.Location = new System.Drawing.Point(171, 36);
            this.DeviceID_UD_ComboBox.Name = "DeviceID_UD_ComboBox";
            this.DeviceID_UD_ComboBox.Size = new System.Drawing.Size(181, 24);
            this.DeviceID_UD_ComboBox.TabIndex = 8;
            this.DeviceID_UD_ComboBox.SelectedIndexChanged += new System.EventHandler(this.DeviceID_UD_ComboBox_SelectedIndexChanged);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(23, 178);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(148, 39);
            this.Update_Button.TabIndex = 7;
            this.Update_Button.Text = "UPDATE ";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // EmployeeName_UD_TextBox
            // 
            this.EmployeeName_UD_TextBox.Location = new System.Drawing.Point(171, 80);
            this.EmployeeName_UD_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeName_UD_TextBox.Name = "EmployeeName_UD_TextBox";
            this.EmployeeName_UD_TextBox.Size = new System.Drawing.Size(181, 22);
            this.EmployeeName_UD_TextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "EMPLOYEE NAME";
            // 
            // PhoneNO_UD_TextBox
            // 
            this.PhoneNO_UD_TextBox.Location = new System.Drawing.Point(171, 121);
            this.PhoneNO_UD_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNO_UD_TextBox.Name = "PhoneNO_UD_TextBox";
            this.PhoneNO_UD_TextBox.Size = new System.Drawing.Size(181, 22);
            this.PhoneNO_UD_TextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PHONE NO";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(227, 178);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(148, 39);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "DELETE";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "DEVICE ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmploayeeName_EmployeeName_TextBox);
            this.groupBox1.Controls.Add(this.EmployeeName_Label);
            this.groupBox1.Controls.Add(this.PhoneNO_PhoneNO_TextBox);
            this.groupBox1.Controls.Add(this.PhoneNO_Label);
            this.groupBox1.Controls.Add(this.AddDevice_Button);
            this.groupBox1.Controls.Add(this.DeviceID_AddDevice_TextBox);
            this.groupBox1.Controls.Add(this.DeviceID_label);
            this.groupBox1.Location = new System.Drawing.Point(288, 195);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(427, 240);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD DEVICE ";
            // 
            // EmploayeeName_EmployeeName_TextBox
            // 
            this.EmploayeeName_EmployeeName_TextBox.Location = new System.Drawing.Point(171, 80);
            this.EmploayeeName_EmployeeName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmploayeeName_EmployeeName_TextBox.Name = "EmploayeeName_EmployeeName_TextBox";
            this.EmploayeeName_EmployeeName_TextBox.Size = new System.Drawing.Size(181, 22);
            this.EmploayeeName_EmployeeName_TextBox.TabIndex = 6;
            // 
            // EmployeeName_Label
            // 
            this.EmployeeName_Label.AutoSize = true;
            this.EmployeeName_Label.Location = new System.Drawing.Point(20, 80);
            this.EmployeeName_Label.Name = "EmployeeName_Label";
            this.EmployeeName_Label.Size = new System.Drawing.Size(122, 16);
            this.EmployeeName_Label.TabIndex = 5;
            this.EmployeeName_Label.Text = "EMPLOYEE NAME";
            // 
            // PhoneNO_PhoneNO_TextBox
            // 
            this.PhoneNO_PhoneNO_TextBox.Location = new System.Drawing.Point(171, 121);
            this.PhoneNO_PhoneNO_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNO_PhoneNO_TextBox.Name = "PhoneNO_PhoneNO_TextBox";
            this.PhoneNO_PhoneNO_TextBox.Size = new System.Drawing.Size(181, 22);
            this.PhoneNO_PhoneNO_TextBox.TabIndex = 4;
            // 
            // PhoneNO_Label
            // 
            this.PhoneNO_Label.AutoSize = true;
            this.PhoneNO_Label.Location = new System.Drawing.Point(20, 121);
            this.PhoneNO_Label.Name = "PhoneNO_Label";
            this.PhoneNO_Label.Size = new System.Drawing.Size(78, 16);
            this.PhoneNO_Label.TabIndex = 3;
            this.PhoneNO_Label.Text = "PHONE NO";
            // 
            // AddDevice_Button
            // 
            this.AddDevice_Button.Location = new System.Drawing.Point(99, 178);
            this.AddDevice_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDevice_Button.Name = "AddDevice_Button";
            this.AddDevice_Button.Size = new System.Drawing.Size(148, 39);
            this.AddDevice_Button.TabIndex = 2;
            this.AddDevice_Button.Text = "ADD  DEVICE ";
            this.AddDevice_Button.UseVisualStyleBackColor = true;
            this.AddDevice_Button.Click += new System.EventHandler(this.AddDevice_Button_Click);
            // 
            // DeviceID_AddDevice_TextBox
            // 
            this.DeviceID_AddDevice_TextBox.Location = new System.Drawing.Point(171, 39);
            this.DeviceID_AddDevice_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeviceID_AddDevice_TextBox.Name = "DeviceID_AddDevice_TextBox";
            this.DeviceID_AddDevice_TextBox.Size = new System.Drawing.Size(181, 22);
            this.DeviceID_AddDevice_TextBox.TabIndex = 1;
            // 
            // DeviceID_label
            // 
            this.DeviceID_label.AutoSize = true;
            this.DeviceID_label.Location = new System.Drawing.Point(20, 39);
            this.DeviceID_label.Name = "DeviceID_label";
            this.DeviceID_label.Size = new System.Drawing.Size(72, 16);
            this.DeviceID_label.TabIndex = 0;
            this.DeviceID_label.Text = "DEVICE ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(846, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "ADD / UPDATE / DELETE DEVICE ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeviceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 819);
            this.Controls.Add(this.panel1);
            this.Name = "DeviceManager";
            this.Text = "DeviceManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeviceManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Device_GridView)).EndInit();
            this.UpdateDeleteDevice_GroupBox.ResumeLayout(false);
            this.UpdateDeleteDevice_GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox UpdateDeleteDevice_GroupBox;
        private System.Windows.Forms.ComboBox DeviceID_UD_ComboBox;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.TextBox EmployeeName_UD_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneNO_UD_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EmploayeeName_EmployeeName_TextBox;
        private System.Windows.Forms.Label EmployeeName_Label;
        private System.Windows.Forms.TextBox PhoneNO_PhoneNO_TextBox;
        private System.Windows.Forms.Label PhoneNO_Label;
        private System.Windows.Forms.Button AddDevice_Button;
        private System.Windows.Forms.TextBox DeviceID_AddDevice_TextBox;
        private System.Windows.Forms.Label DeviceID_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Device_GridView;
    }
}