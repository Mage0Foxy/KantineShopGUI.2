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
    public partial class English : UserControl
    {
        Store myStore = new Store();
        BindingSource kantineBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public English()
        {
            InitializeComponent();
        }

        private void English_Load(object sender, EventArgs e)
        {
            kantineBindingSource.DataSource = myStore.FoodList;

            cartBindingSource.DataSource = myStore.ShoppingList;

            listBox1.DataSource = kantineBindingSource;
            listBox1.DisplayMember = ToString();

            listBox2.DataSource = cartBindingSource;
            listBox2.DisplayMember = ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the selceted item from inventory
            Kantine selected = (Kantine)listBox1.SelectedItem;
            //add the item to the cart
            myStore.ShoppingList.Add(selected);
            //update listbox
            cartBindingSource.ResetBindings(false);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            double total = myStore.Checkout();
            lblTotal.Text = "€" + total.ToString();

            cartBindingSource.ResetBindings(false);
        }
    }
}
