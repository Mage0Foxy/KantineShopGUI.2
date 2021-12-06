namespace KantineShopGUI._2
{
    partial class Login
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
            this.btnUser_Login = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.User_Login = new System.Windows.Forms.Label();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.AdminGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminUser = new System.Windows.Forms.TextBox();
            this.AdminPassword = new System.Windows.Forms.TextBox();
            this.btnAdmin_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserGroupBox.SuspendLayout();
            this.AdminGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUser_Login
            // 
            this.btnUser_Login.Location = new System.Drawing.Point(57, 129);
            this.btnUser_Login.Name = "btnUser_Login";
            this.btnUser_Login.Size = new System.Drawing.Size(75, 23);
            this.btnUser_Login.TabIndex = 0;
            this.btnUser_Login.Text = "Login";
            this.btnUser_Login.UseVisualStyleBackColor = true;
            this.btnUser_Login.Click += new System.EventHandler(this.btnUser_Login_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(43, 100);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 23);
            this.Password.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(43, 57);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 23);
            this.Username.TabIndex = 3;
            // 
            // User_Login
            // 
            this.User_Login.AutoSize = true;
            this.User_Login.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.User_Login.Location = new System.Drawing.Point(51, 9);
            this.User_Login.Name = "User_Login";
            this.User_Login.Size = new System.Drawing.Size(86, 20);
            this.User_Login.TabIndex = 4;
            this.User_Login.Text = "User_Login";
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.label4);
            this.UserGroupBox.Controls.Add(this.label3);
            this.UserGroupBox.Controls.Add(this.User_Login);
            this.UserGroupBox.Controls.Add(this.btnUser_Login);
            this.UserGroupBox.Controls.Add(this.Username);
            this.UserGroupBox.Controls.Add(this.Password);
            this.UserGroupBox.Location = new System.Drawing.Point(225, 198);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(189, 158);
            this.UserGroupBox.TabIndex = 5;
            this.UserGroupBox.TabStop = false;
            // 
            // AdminGroupBox
            // 
            this.AdminGroupBox.Controls.Add(this.label5);
            this.AdminGroupBox.Controls.Add(this.label2);
            this.AdminGroupBox.Controls.Add(this.label1);
            this.AdminGroupBox.Controls.Add(this.AdminUser);
            this.AdminGroupBox.Controls.Add(this.AdminPassword);
            this.AdminGroupBox.Controls.Add(this.btnAdmin_Login);
            this.AdminGroupBox.Location = new System.Drawing.Point(225, 35);
            this.AdminGroupBox.Name = "AdminGroupBox";
            this.AdminGroupBox.Size = new System.Drawing.Size(189, 157);
            this.AdminGroupBox.TabIndex = 6;
            this.AdminGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin_Login";
            // 
            // AdminUser
            // 
            this.AdminUser.Location = new System.Drawing.Point(43, 59);
            this.AdminUser.Name = "AdminUser";
            this.AdminUser.Size = new System.Drawing.Size(100, 23);
            this.AdminUser.TabIndex = 6;
            // 
            // AdminPassword
            // 
            this.AdminPassword.Location = new System.Drawing.Point(43, 102);
            this.AdminPassword.Name = "AdminPassword";
            this.AdminPassword.Size = new System.Drawing.Size(100, 23);
            this.AdminPassword.TabIndex = 5;
            // 
            // btnAdmin_Login
            // 
            this.btnAdmin_Login.Location = new System.Drawing.Point(57, 127);
            this.btnAdmin_Login.Name = "btnAdmin_Login";
            this.btnAdmin_Login.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin_Login.TabIndex = 0;
            this.btnAdmin_Login.Text = "Login";
            this.btnAdmin_Login.UseVisualStyleBackColor = true;
            this.btnAdmin_Login.Click += new System.EventHandler(this.btnAdmin_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 389);
            this.Controls.Add(this.AdminGroupBox);
            this.Controls.Add(this.UserGroupBox);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            this.AdminGroupBox.ResumeLayout(false);
            this.AdminGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUser_Login;
        private TextBox Password;
        private TextBox Username;
        private Label User_Login;
        private GroupBox UserGroupBox;
        private GroupBox AdminGroupBox;
        private Button btnAdmin_Login;
        private Label label1;
        private TextBox AdminUser;
        private TextBox AdminPassword;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
    }
}