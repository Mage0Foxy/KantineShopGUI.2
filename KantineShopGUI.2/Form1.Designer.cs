namespace KantineShopGUI._2
{
    partial class AdminInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Snacks = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Drinks = new System.Windows.Forms.TextBox();
            this.txt_Food = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Langauge = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Create.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Controls.Add(this.label6);
            this.Create.Controls.Add(this.txt_Snacks);
            this.Create.Controls.Add(this.btnCreate);
            this.Create.Controls.Add(this.label3);
            this.Create.Controls.Add(this.label2);
            this.Create.Controls.Add(this.label1);
            this.Create.Controls.Add(this.txt_Price);
            this.Create.Controls.Add(this.txt_Drinks);
            this.Create.Controls.Add(this.txt_Food);
            this.Create.Location = new System.Drawing.Point(12, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(123, 224);
            this.Create.TabIndex = 0;
            this.Create.TabStop = false;
            this.Create.Text = "Create";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Snacks";
            // 
            // txt_Snacks
            // 
            this.txt_Snacks.Location = new System.Drawing.Point(44, 91);
            this.txt_Snacks.Name = "txt_Snacks";
            this.txt_Snacks.Size = new System.Drawing.Size(79, 23);
            this.txt_Snacks.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(44, 195);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drink";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(44, 120);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(79, 23);
            this.txt_Price.TabIndex = 2;
            // 
            // txt_Drinks
            // 
            this.txt_Drinks.Location = new System.Drawing.Point(44, 60);
            this.txt_Drinks.Name = "txt_Drinks";
            this.txt_Drinks.Size = new System.Drawing.Size(79, 23);
            this.txt_Drinks.TabIndex = 1;
            // 
            // txt_Food
            // 
            this.txt_Food.Location = new System.Drawing.Point(44, 31);
            this.txt_Food.Name = "txt_Food";
            this.txt_Food.Size = new System.Drawing.Size(79, 23);
            this.txt_Food.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(158, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 319);
            this.listBox1.TabIndex = 0;
            // 
            // Langauge
            // 
            this.Langauge.Location = new System.Drawing.Point(56, 327);
            this.Langauge.Name = "Langauge";
            this.Langauge.Size = new System.Drawing.Size(75, 23);
            this.Langauge.TabIndex = 7;
            this.Langauge.Text = "Nederlands";
            this.Langauge.UseVisualStyleBackColor = true;
            this.Langauge.Click += new System.EventHandler(this.Langauge_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(445, 328);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 19;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(445, 299);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 18;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 389);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Langauge);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Create);
            this.Name = "AdminInterface";
            this.Text = "AdminInterface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Create.ResumeLayout(false);
            this.Create.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Create;
        private Button btnCreate;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Price;
        private TextBox txt_Drinks;
        private TextBox txt_Food;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private Label label6;
        private TextBox txt_Snacks;
        private Button Langauge;
        private Button Save;
        private Button Remove;
    }
}