namespace CableBilling
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.user_RadioButtton = new System.Windows.Forms.RadioButton();
            this.password_label = new System.Windows.Forms.Label();
            this.admin_RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancel_Button);
            this.groupBox1.Controls.Add(this.Ok_Button);
            this.groupBox1.Controls.Add(this.password_TextBox);
            this.groupBox1.Controls.Add(this.user_RadioButtton);
            this.groupBox1.Controls.Add(this.password_label);
            this.groupBox1.Controls.Add(this.admin_RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(448, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN TYPE";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(240, 180);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(117, 34);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "CANCEL";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Ok_Button
            // 
            this.Ok_Button.Location = new System.Drawing.Point(84, 180);
            this.Ok_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(113, 34);
            this.Ok_Button.TabIndex = 14;
            this.Ok_Button.Text = "OK";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Click += new System.EventHandler(this.Ok_Button_Click);
            // 
            // password_TextBox
            // 
            this.password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_TextBox.Location = new System.Drawing.Point(127, 100);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(223, 22);
            this.password_TextBox.TabIndex = 10;
            this.password_TextBox.UseWaitCursor = true;
            // 
            // user_RadioButtton
            // 
            this.user_RadioButtton.AutoSize = true;
            this.user_RadioButtton.Location = new System.Drawing.Point(240, 38);
            this.user_RadioButtton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_RadioButtton.Name = "user_RadioButtton";
            this.user_RadioButtton.Size = new System.Drawing.Size(66, 20);
            this.user_RadioButtton.TabIndex = 13;
            this.user_RadioButtton.TabStop = true;
            this.user_RadioButtton.Text = "USER";
            this.user_RadioButtton.UseVisualStyleBackColor = true;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(33, 105);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(73, 16);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Password :";
            // 
            // admin_RadioButton
            // 
            this.admin_RadioButton.AutoSize = true;
            this.admin_RadioButton.Location = new System.Drawing.Point(127, 38);
            this.admin_RadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_RadioButton.Name = "admin_RadioButton";
            this.admin_RadioButton.Size = new System.Drawing.Size(71, 20);
            this.admin_RadioButton.TabIndex = 12;
            this.admin_RadioButton.TabStop = true;
            this.admin_RadioButton.Text = "ADMIN";
            this.admin_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 308);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Ok_Button;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.RadioButton user_RadioButtton;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.RadioButton admin_RadioButton;
    }
}

