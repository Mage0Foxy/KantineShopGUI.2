using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KantineShopGUI._2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Login_Click(object sender, EventArgs e)
        {
            if(AdminUser.Text == "Admin" && AdminPassword.Text == "Admin")
            {
                this.Hide();
                var form1 = new AdminInterface();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Contact Support");
            }
        }

        private void btnUser_Login_Click(object sender, EventArgs e)
        {
            if(Username.Text =="User" && Password.Text == "Test1234?")
            {
                this.Hide();
                var form3 = new UserInterface();
                form3.Closed += (s, args) => this.Close();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Contact Support");
            }
        }
    }
}
