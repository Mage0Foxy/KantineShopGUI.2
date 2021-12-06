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
    public partial class Form3 : Form
    {
        English u1;
        Nederlands u2;
        public Form3()
        {
            u1 = new English();
            u2 = new Nederlands();
            InitializeComponent();
        }

        private void English_Click(object sender, EventArgs e)
        {
            u1.Show();
            u2.Hide();
            this.Controls.Add(u1);
        }

        private void Nederlands_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u2.Show();
            this.Controls.Add(u2);
        }
    }
}
