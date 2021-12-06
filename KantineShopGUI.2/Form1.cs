using KantineClassLibrary;

namespace KantineShopGUI._2
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource kantineBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
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
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}