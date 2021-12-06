using KantineClassLibrary;
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
    public partial class Form2 : Form
    {
        Store myStore = new Store();
        BindingSource kantineBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kantineBindingSource.DataSource = myStore.FoodList;

            cartBindingSource.DataSource = myStore.ShoppingList;

            listBox1.DataSource = kantineBindingSource;
            listBox1.DisplayMember = ToString();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Kantine f = new Kantine(txt_Food.Text, txt_Drinks.Text, txt_Snacks.Text, int.Parse(txt_Price.Text));
            // MessageBox.Show(f.ToString());
            myStore.FoodList.Add(f);
            kantineBindingSource.ResetBindings(false);
            txt_Food.Text = "";
            txt_Drinks.Text = "";
            txt_Snacks.Text = "";
            txt_Price.Text = "";
        }


        private void Langauge_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Kantine selected = (Kantine)listBox1.SelectedItem;
            myStore.ShoppingList.Remove(selected);
        }
    }
}
