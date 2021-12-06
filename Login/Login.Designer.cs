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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.User_Login = new System.Windows.Forms.Label();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.AdminGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAdmin_Login = new System.Windows.Forms.Button();
            this.UserGroupBox.SuspendLayout();
            this.AdminGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUser_Login
            // 
            this.btnUser_Login.Location = new System.Drawing.Point(57, 100);
            this.btnUser_Login.Name = "btnUser_Login";
            this.btnUser_Login.Size = new System.Drawing.Size(75, 23);
            this.btnUser_Login.TabIndex = 0;
            this.btnUser_Login.Text = "Login";
            this.btnUser_Login.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // User_Login
            // 
            this.User_Login.AutoSize = true;
            this.User_Login.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_Login.Location = new System.Drawing.Point(51, 19);
            this.User_Login.Name = "User_Login";
            this.User_Login.Size = new System.Drawing.Size(81, 20);
            this.User_Login.TabIndex = 4;
            this.User_Login.Text = "User_Login";
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.User_Login);
            this.UserGroupBox.Controls.Add(this.btnUser_Login);
            this.UserGroupBox.Controls.Add(this.textBox2);
            this.UserGroupBox.Controls.Add(this.textBox1);
            this.UserGroupBox.Location = new System.Drawing.Point(225, 226);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(200, 130);
            this.UserGroupBox.TabIndex = 5;
            this.UserGroupBox.TabStop = false;
            // 
            // AdminGroupBox
            // 
            this.AdminGroupBox.Controls.Add(this.label1);
            this.AdminGroupBox.Controls.Add(this.textBox3);
            this.AdminGroupBox.Controls.Add(this.textBox4);
            this.AdminGroupBox.Controls.Add(this.btnAdmin_Login);
            this.AdminGroupBox.Location = new System.Drawing.Point(225, 55);
            this.AdminGroupBox.Name = "AdminGroupBox";
            this.AdminGroupBox.Size = new System.Drawing.Size(200, 137);
            this.AdminGroupBox.TabIndex = 6;
            this.AdminGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin_Login";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(43, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 5;
            // 
            // btnAdmin_Login
            // 
            this.btnAdmin_Login.Location = new System.Drawing.Point(57, 108);
            this.btnAdmin_Login.Name = "btnAdmin_Login";
            this.btnAdmin_Login.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin_Login.TabIndex = 0;
            this.btnAdmin_Login.Text = "Login";
            this.btnAdmin_Login.UseVisualStyleBackColor = true;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label User_Login;
        private GroupBox UserGroupBox;
        private GroupBox AdminGroupBox;
        private Button btnAdmin_Login;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}