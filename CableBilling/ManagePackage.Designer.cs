namespace CableBilling
{
    partial class ManagePackage
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
            this.PackageGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PackageName_UD = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PackagePrice_UD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PackageCode_UD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PackageID_UD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddPackage = new System.Windows.Forms.Button();
            this.PackageName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PackagePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PackageCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PackageID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.packageTypeAP = new System.Windows.Forms.ComboBox();
            this.packageTypeUD = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PackageGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PackageGridView);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1617, 821);
            this.panel1.TabIndex = 1;
            // 
            // PackageGridView
            // 
            this.PackageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackageGridView.Location = new System.Drawing.Point(94, 494);
            this.PackageGridView.Margin = new System.Windows.Forms.Padding(4);
            this.PackageGridView.Name = "PackageGridView";
            this.PackageGridView.RowHeadersWidth = 51;
            this.PackageGridView.Size = new System.Drawing.Size(792, 279);
            this.PackageGridView.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(288, 426);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 42);
            this.button4.TabIndex = 14;
            this.button4.Text = "PACKAGE LIST";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.packageTypeUD);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.PackageName_UD);
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.UpdateButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PackagePrice_UD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PackageCode_UD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PackageID_UD);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(626, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(484, 392);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE / DELETE PACKAGE";
            // 
            // PackageName_UD
            // 
            this.PackageName_UD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PackageName_UD.FormattingEnabled = true;
            this.PackageName_UD.Location = new System.Drawing.Point(192, 93);
            this.PackageName_UD.Name = "PackageName_UD";
            this.PackageName_UD.Size = new System.Drawing.Size(251, 24);
            this.PackageName_UD.TabIndex = 10;
            this.PackageName_UD.SelectedIndexChanged += new System.EventHandler(this.PackageName_UD_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(283, 323);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(160, 42);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(40, 323);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(160, 42);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "PACKAGE NAME";
            // 
            // PackagePrice_UD
            // 
            this.PackagePrice_UD.Location = new System.Drawing.Point(195, 206);
            this.PackagePrice_UD.Margin = new System.Windows.Forms.Padding(4);
            this.PackagePrice_UD.Name = "PackagePrice_UD";
            this.PackagePrice_UD.Size = new System.Drawing.Size(249, 22);
            this.PackagePrice_UD.TabIndex = 5;
            this.PackagePrice_UD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PackagePrice_UD_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "PACKAGE PRICE";
            // 
            // PackageCode_UD
            // 
            this.PackageCode_UD.Location = new System.Drawing.Point(195, 153);
            this.PackageCode_UD.Margin = new System.Windows.Forms.Padding(4);
            this.PackageCode_UD.Name = "PackageCode_UD";
            this.PackageCode_UD.Size = new System.Drawing.Size(249, 22);
            this.PackageCode_UD.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "PACKAGE CODE";
            // 
            // PackageID_UD
            // 
            this.PackageID_UD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PackageID_UD.Location = new System.Drawing.Point(192, 42);
            this.PackageID_UD.Margin = new System.Windows.Forms.Padding(4);
            this.PackageID_UD.Name = "PackageID_UD";
            this.PackageID_UD.ReadOnly = true;
            this.PackageID_UD.Size = new System.Drawing.Size(249, 22);
            this.PackageID_UD.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "PACKAGE ID ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.packageTypeAP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.AddPackage);
            this.groupBox1.Controls.Add(this.PackageName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PackagePrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PackageCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PackageID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(94, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 392);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD PACKAGE";
            // 
            // AddPackage
            // 
            this.AddPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPackage.Location = new System.Drawing.Point(192, 326);
            this.AddPackage.Margin = new System.Windows.Forms.Padding(4);
            this.AddPackage.Name = "AddPackage";
            this.AddPackage.Size = new System.Drawing.Size(253, 42);
            this.AddPackage.TabIndex = 8;
            this.AddPackage.Text = "ADD PACKAGE ";
            this.AddPackage.UseVisualStyleBackColor = true;
            this.AddPackage.Click += new System.EventHandler(this.AddPackage_Click);
            // 
            // PackageName
            // 
            this.PackageName.Location = new System.Drawing.Point(192, 92);
            this.PackageName.Margin = new System.Windows.Forms.Padding(4);
            this.PackageName.Name = "PackageName";
            this.PackageName.Size = new System.Drawing.Size(249, 22);
            this.PackageName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "PACKAGE NAME";
            // 
            // PackagePrice
            // 
            this.PackagePrice.Location = new System.Drawing.Point(195, 206);
            this.PackagePrice.Margin = new System.Windows.Forms.Padding(4);
            this.PackagePrice.Name = "PackagePrice";
            this.PackagePrice.Size = new System.Drawing.Size(249, 22);
            this.PackagePrice.TabIndex = 5;
            this.PackagePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PackagePrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "PACKAGE PRICE";
            // 
            // PackageCode
            // 
            this.PackageCode.Location = new System.Drawing.Point(195, 153);
            this.PackageCode.Margin = new System.Windows.Forms.Padding(4);
            this.PackageCode.Name = "PackageCode";
            this.PackageCode.Size = new System.Drawing.Size(249, 22);
            this.PackageCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "PACKAGE CODE";
            // 
            // PackageID
            // 
            this.PackageID.Location = new System.Drawing.Point(192, 42);
            this.PackageID.Margin = new System.Windows.Forms.Padding(4);
            this.PackageID.Name = "PackageID";
            this.PackageID.Size = new System.Drawing.Size(249, 22);
            this.PackageID.TabIndex = 1;
            this.PackageID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PackageID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PACKAGE ID ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 265);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "PACKAGE TYPE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 263);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "PACKAGE TYPE";
            // 
            // packageTypeAP
            // 
            this.packageTypeAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packageTypeAP.FormattingEnabled = true;
            this.packageTypeAP.Location = new System.Drawing.Point(194, 257);
            this.packageTypeAP.Name = "packageTypeAP";
            this.packageTypeAP.Size = new System.Drawing.Size(251, 24);
            this.packageTypeAP.TabIndex = 11;
            // 
            // packageTypeUD
            // 
            this.packageTypeUD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packageTypeUD.FormattingEnabled = true;
            this.packageTypeUD.Location = new System.Drawing.Point(195, 257);
            this.packageTypeUD.Name = "packageTypeUD";
            this.packageTypeUD.Size = new System.Drawing.Size(251, 24);
            this.packageTypeUD.TabIndex = 12;
            // 
            // ManagePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 821);
            this.Controls.Add(this.panel1);
            this.Name = "ManagePackage";
            this.Text = "ManagePackage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagePackage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PackageGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView PackageGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PackagePrice_UD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PackageCode_UD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PackageID_UD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddPackage;
        private System.Windows.Forms.TextBox PackageName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PackagePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PackageCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PackageID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PackageName_UD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox packageTypeUD;
        private System.Windows.Forms.ComboBox packageTypeAP;
    }
}