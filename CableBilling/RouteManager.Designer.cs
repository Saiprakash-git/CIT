namespace CableBilling
{
    partial class RouteManager
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
            this.Route_GridView = new System.Windows.Forms.DataGridView();
            this.UpdateDeleteDevice_GroupBox = new System.Windows.Forms.GroupBox();
            this.DeviceID_UD_ComboBox = new System.Windows.Forms.ComboBox();
            this.RouteCode_UD_ComboBox = new System.Windows.Forms.ComboBox();
            this.Update_Route_Button = new System.Windows.Forms.Button();
            this.DeviceID_UD_Label = new System.Windows.Forms.Label();
            this.RouteDetails_UD_TextBox = new System.Windows.Forms.TextBox();
            this.RouteDetails_UD_Label = new System.Windows.Forms.Label();
            this.Delete_Route_Button = new System.Windows.Forms.Button();
            this.RouteCode_UD_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeviceID_AddRoute_ComboBox = new System.Windows.Forms.ComboBox();
            this.DeviceID_AddRoute_Label = new System.Windows.Forms.Label();
            this.RouteDetails_AddRoute_TextBox = new System.Windows.Forms.TextBox();
            this.RouteDetails_AddRoute_Label = new System.Windows.Forms.Label();
            this.AddRoute_Button = new System.Windows.Forms.Button();
            this.RouteCode_AddRoute_TextBox = new System.Windows.Forms.TextBox();
            this.RouteCode_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Route_GridView)).BeginInit();
            this.UpdateDeleteDevice_GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Route_GridView);
            this.panel1.Controls.Add(this.UpdateDeleteDevice_GroupBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1615, 855);
            this.panel1.TabIndex = 1;
            // 
            // Route_GridView
            // 
            this.Route_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Route_GridView.Location = new System.Drawing.Point(451, 522);
            this.Route_GridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Route_GridView.Name = "Route_GridView";
            this.Route_GridView.RowHeadersWidth = 51;
            this.Route_GridView.RowTemplate.Height = 24;
            this.Route_GridView.Size = new System.Drawing.Size(543, 254);
            this.Route_GridView.TabIndex = 16;
            // 
            // UpdateDeleteDevice_GroupBox
            // 
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.DeviceID_UD_ComboBox);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.RouteCode_UD_ComboBox);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.Update_Route_Button);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.DeviceID_UD_Label);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.RouteDetails_UD_TextBox);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.RouteDetails_UD_Label);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.Delete_Route_Button);
            this.UpdateDeleteDevice_GroupBox.Controls.Add(this.RouteCode_UD_Label);
            this.UpdateDeleteDevice_GroupBox.Location = new System.Drawing.Point(764, 149);
            this.UpdateDeleteDevice_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateDeleteDevice_GroupBox.Name = "UpdateDeleteDevice_GroupBox";
            this.UpdateDeleteDevice_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateDeleteDevice_GroupBox.Size = new System.Drawing.Size(475, 344);
            this.UpdateDeleteDevice_GroupBox.TabIndex = 15;
            this.UpdateDeleteDevice_GroupBox.TabStop = false;
            this.UpdateDeleteDevice_GroupBox.Text = "UPDATE / DELETE ROUTE";
            // 
            // DeviceID_UD_ComboBox
            // 
            this.DeviceID_UD_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceID_UD_ComboBox.FormattingEnabled = true;
            this.DeviceID_UD_ComboBox.Location = new System.Drawing.Point(171, 77);
            this.DeviceID_UD_ComboBox.Name = "DeviceID_UD_ComboBox";
            this.DeviceID_UD_ComboBox.Size = new System.Drawing.Size(201, 24);
            this.DeviceID_UD_ComboBox.TabIndex = 13;
            // 
            // RouteCode_UD_ComboBox
            // 
            this.RouteCode_UD_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RouteCode_UD_ComboBox.FormattingEnabled = true;
            this.RouteCode_UD_ComboBox.Location = new System.Drawing.Point(168, 31);
            this.RouteCode_UD_ComboBox.Name = "RouteCode_UD_ComboBox";
            this.RouteCode_UD_ComboBox.Size = new System.Drawing.Size(204, 24);
            this.RouteCode_UD_ComboBox.TabIndex = 8;
            this.RouteCode_UD_ComboBox.SelectedIndexChanged += new System.EventHandler(this.RouteCode_UD_ComboBox_SelectedIndexChanged);
            // 
            // Update_Route_Button
            // 
            this.Update_Route_Button.Location = new System.Drawing.Point(38, 267);
            this.Update_Route_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_Route_Button.Name = "Update_Route_Button";
            this.Update_Route_Button.Size = new System.Drawing.Size(148, 39);
            this.Update_Route_Button.TabIndex = 7;
            this.Update_Route_Button.Text = "UPDATE  ROUTE";
            this.Update_Route_Button.UseVisualStyleBackColor = true;
            this.Update_Route_Button.Click += new System.EventHandler(this.Update_Route_Button_Click);
            // 
            // DeviceID_UD_Label
            // 
            this.DeviceID_UD_Label.AutoSize = true;
            this.DeviceID_UD_Label.Location = new System.Drawing.Point(20, 80);
            this.DeviceID_UD_Label.Name = "DeviceID_UD_Label";
            this.DeviceID_UD_Label.Size = new System.Drawing.Size(72, 16);
            this.DeviceID_UD_Label.TabIndex = 5;
            this.DeviceID_UD_Label.Text = "DEVICE ID";
            // 
            // RouteDetails_UD_TextBox
            // 
            this.RouteDetails_UD_TextBox.Location = new System.Drawing.Point(171, 121);
            this.RouteDetails_UD_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RouteDetails_UD_TextBox.Multiline = true;
            this.RouteDetails_UD_TextBox.Name = "RouteDetails_UD_TextBox";
            this.RouteDetails_UD_TextBox.Size = new System.Drawing.Size(201, 119);
            this.RouteDetails_UD_TextBox.TabIndex = 4;
            // 
            // RouteDetails_UD_Label
            // 
            this.RouteDetails_UD_Label.AutoSize = true;
            this.RouteDetails_UD_Label.Location = new System.Drawing.Point(20, 121);
            this.RouteDetails_UD_Label.Name = "RouteDetails_UD_Label";
            this.RouteDetails_UD_Label.Size = new System.Drawing.Size(114, 16);
            this.RouteDetails_UD_Label.TabIndex = 3;
            this.RouteDetails_UD_Label.Text = "ROUTE DETAILS";
            // 
            // Delete_Route_Button
            // 
            this.Delete_Route_Button.Location = new System.Drawing.Point(224, 267);
            this.Delete_Route_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_Route_Button.Name = "Delete_Route_Button";
            this.Delete_Route_Button.Size = new System.Drawing.Size(148, 39);
            this.Delete_Route_Button.TabIndex = 2;
            this.Delete_Route_Button.Text = "DELETE ROUTE";
            this.Delete_Route_Button.UseVisualStyleBackColor = true;
            this.Delete_Route_Button.Click += new System.EventHandler(this.Delete_Route_Button_Click);
            // 
            // RouteCode_UD_Label
            // 
            this.RouteCode_UD_Label.AutoSize = true;
            this.RouteCode_UD_Label.Location = new System.Drawing.Point(20, 39);
            this.RouteCode_UD_Label.Name = "RouteCode_UD_Label";
            this.RouteCode_UD_Label.Size = new System.Drawing.Size(96, 16);
            this.RouteCode_UD_Label.TabIndex = 0;
            this.RouteCode_UD_Label.Text = "ROUTE CODE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeviceID_AddRoute_ComboBox);
            this.groupBox1.Controls.Add(this.DeviceID_AddRoute_Label);
            this.groupBox1.Controls.Add(this.RouteDetails_AddRoute_TextBox);
            this.groupBox1.Controls.Add(this.RouteDetails_AddRoute_Label);
            this.groupBox1.Controls.Add(this.AddRoute_Button);
            this.groupBox1.Controls.Add(this.RouteCode_AddRoute_TextBox);
            this.groupBox1.Controls.Add(this.RouteCode_label);
            this.groupBox1.Location = new System.Drawing.Point(280, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(475, 344);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD ROUTE";
            // 
            // DeviceID_AddRoute_ComboBox
            // 
            this.DeviceID_AddRoute_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceID_AddRoute_ComboBox.FormattingEnabled = true;
            this.DeviceID_AddRoute_ComboBox.Location = new System.Drawing.Point(171, 77);
            this.DeviceID_AddRoute_ComboBox.Name = "DeviceID_AddRoute_ComboBox";
            this.DeviceID_AddRoute_ComboBox.Size = new System.Drawing.Size(204, 24);
            this.DeviceID_AddRoute_ComboBox.TabIndex = 6;
            // 
            // DeviceID_AddRoute_Label
            // 
            this.DeviceID_AddRoute_Label.AutoSize = true;
            this.DeviceID_AddRoute_Label.Location = new System.Drawing.Point(20, 80);
            this.DeviceID_AddRoute_Label.Name = "DeviceID_AddRoute_Label";
            this.DeviceID_AddRoute_Label.Size = new System.Drawing.Size(72, 16);
            this.DeviceID_AddRoute_Label.TabIndex = 5;
            this.DeviceID_AddRoute_Label.Text = "DEVICE ID";
            // 
            // RouteDetails_AddRoute_TextBox
            // 
            this.RouteDetails_AddRoute_TextBox.Location = new System.Drawing.Point(171, 121);
            this.RouteDetails_AddRoute_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RouteDetails_AddRoute_TextBox.Multiline = true;
            this.RouteDetails_AddRoute_TextBox.Name = "RouteDetails_AddRoute_TextBox";
            this.RouteDetails_AddRoute_TextBox.Size = new System.Drawing.Size(204, 119);
            this.RouteDetails_AddRoute_TextBox.TabIndex = 4;
            // 
            // RouteDetails_AddRoute_Label
            // 
            this.RouteDetails_AddRoute_Label.AutoSize = true;
            this.RouteDetails_AddRoute_Label.Location = new System.Drawing.Point(20, 121);
            this.RouteDetails_AddRoute_Label.Name = "RouteDetails_AddRoute_Label";
            this.RouteDetails_AddRoute_Label.Size = new System.Drawing.Size(114, 16);
            this.RouteDetails_AddRoute_Label.TabIndex = 3;
            this.RouteDetails_AddRoute_Label.Text = "ROUTE DETAILS";
            // 
            // AddRoute_Button
            // 
            this.AddRoute_Button.Location = new System.Drawing.Point(99, 267);
            this.AddRoute_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRoute_Button.Name = "AddRoute_Button";
            this.AddRoute_Button.Size = new System.Drawing.Size(148, 39);
            this.AddRoute_Button.TabIndex = 2;
            this.AddRoute_Button.Text = "ADD ROUTE";
            this.AddRoute_Button.UseVisualStyleBackColor = true;
            this.AddRoute_Button.Click += new System.EventHandler(this.AddRoute_Button_Click);
            // 
            // RouteCode_AddRoute_TextBox
            // 
            this.RouteCode_AddRoute_TextBox.Location = new System.Drawing.Point(171, 39);
            this.RouteCode_AddRoute_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RouteCode_AddRoute_TextBox.Name = "RouteCode_AddRoute_TextBox";
            this.RouteCode_AddRoute_TextBox.Size = new System.Drawing.Size(204, 22);
            this.RouteCode_AddRoute_TextBox.TabIndex = 1;
            // 
            // RouteCode_label
            // 
            this.RouteCode_label.AutoSize = true;
            this.RouteCode_label.Location = new System.Drawing.Point(20, 39);
            this.RouteCode_label.Name = "RouteCode_label";
            this.RouteCode_label.Size = new System.Drawing.Size(96, 16);
            this.RouteCode_label.TabIndex = 0;
            this.RouteCode_label.Text = "ROUTE CODE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 58);
            this.label1.TabIndex = 13;
            this.label1.Text = "ADD / UPDATE / DELETE ROUTE ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RouteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 855);
            this.Controls.Add(this.panel1);
            this.Name = "RouteManager";
            this.Text = "RouteManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RouteManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Route_GridView)).EndInit();
            this.UpdateDeleteDevice_GroupBox.ResumeLayout(false);
            this.UpdateDeleteDevice_GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Route_GridView;
        private System.Windows.Forms.GroupBox UpdateDeleteDevice_GroupBox;
        private System.Windows.Forms.ComboBox DeviceID_UD_ComboBox;
        private System.Windows.Forms.ComboBox RouteCode_UD_ComboBox;
        private System.Windows.Forms.Button Update_Route_Button;
        private System.Windows.Forms.Label DeviceID_UD_Label;
        private System.Windows.Forms.TextBox RouteDetails_UD_TextBox;
        private System.Windows.Forms.Label RouteDetails_UD_Label;
        private System.Windows.Forms.Button Delete_Route_Button;
        private System.Windows.Forms.Label RouteCode_UD_Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DeviceID_AddRoute_ComboBox;
        private System.Windows.Forms.Label DeviceID_AddRoute_Label;
        private System.Windows.Forms.TextBox RouteDetails_AddRoute_TextBox;
        private System.Windows.Forms.Label RouteDetails_AddRoute_Label;
        private System.Windows.Forms.Button AddRoute_Button;
        private System.Windows.Forms.TextBox RouteCode_AddRoute_TextBox;
        private System.Windows.Forms.Label RouteCode_label;
        private System.Windows.Forms.Label label1;
    }
}