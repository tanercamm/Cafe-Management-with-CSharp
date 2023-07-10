using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagement
{
    public partial class GuestOrder : Form
    {
        public GuestOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\taner\OneDrive\Belgeler\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void Populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        void FilterByCategory()
        {
            Con.Open();
            string query = "select * from ItemTbl where Itemcat = '" + cbxCatergory.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
        int num = 0;
        int price, total;
        string item, cat;
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;

        private void GuestOrder_Load(object sender, EventArgs e)
        {
            Populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGv.DataSource = table;

            lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("What is The Quantity of Item?");
            }
            else if (flag == 0)
                MessageBox.Show("Select The Product To be Ordered.");
            else
            {
                num += 1;
                total = price * Convert.ToInt32(txtQuantity.Text);
                table.Rows.Add(num, item, cat, price, total);
                OrdersGv.DataSource = table;
                flag = 0;
            }
            sum += total;
            lblAmount.Text = "" + sum;
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            cat = ItemsGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.Rows[e.RowIndex].Cells[3].Value.ToString());
            flag = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into OrdersTbl values(" + txtOrderNum.Text + ",'" + lblDate.Text + "','" + txtSellerName.Text + "',"+lblAmount.Text+")";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Succesfuly Created.");
            Con.Close();
        }

        private void cbxCatergory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
