namespace KantineShopGUI._2
{
    partial class UserInterface
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
            this.English = new System.Windows.Forms.Button();
            this.Nederlands = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // English
            // 
            this.English.Location = new System.Drawing.Point(604, 9);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(75, 23);
            this.English.TabIndex = 0;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // Nederlands
            // 
            this.Nederlands.Location = new System.Drawing.Point(604, 38);
            this.Nederlands.Name = "Nederlands";
            this.Nederlands.Size = new System.Drawing.Size(75, 23);
            this.Nederlands.TabIndex = 1;
            this.Nederlands.Text = "Nederlands";
            this.Nederlands.UseVisualStyleBackColor = true;
            this.Nederlands.Click += new System.EventHandler(this.Nederlands_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 389);
            this.Controls.Add(this.Nederlands);
            this.Controls.Add(this.English);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.ResumeLayout(false);

        }

        #endregion

        private Button English;
        private Button Nederlands;
    }
}