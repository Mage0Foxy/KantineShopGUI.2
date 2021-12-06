using KantineClassLibrary;

namespace KantineShopGUI._2
{
    public partial class AdminInterface : Form
    {
        Store myStore = new Store();
        BindingSource kantineBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            KantineMenu f = new KantineMenu(txt_Food.Text, txt_Drinks.Text, txt_Snacks.Text, int.Parse(txt_Price.Text));
           // MessageBox.Show(f.ToString());
           myStore.FoodList.Add(f);
            kantineBindingSource.ResetBindings(false);
            txt_Food.Text = "";
            txt_Drinks.Text = "";
            txt_Snacks.Text = "";
            txt_Price.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kantineBindingSource.DataSource = myStore.FoodList;

            cartBindingSource.DataSource = myStore.ShoppingList;

            listBox1.DataSource = kantineBindingSource;
            listBox1.DisplayMember = ToString();

        }


        private void Langauge_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new AdminInterfaceNL();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {

        }
    }
}