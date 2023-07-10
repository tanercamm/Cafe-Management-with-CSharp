using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagement
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
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
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ItemNameTb.Text == "" || ItemNumTb.Text == "" || PriceCb.Text == "")
            {
                MessageBox.Show("Fill All The Data");
            }
            else
            {
                Con.Open();
                string query = "insert into ItemTbl values(" + ItemNumTb.Text + ",'" + ItemNameTb.Text + "','" + CatCb.SelectedItem.ToString() + "',"+PriceCb.Text+")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Succesfuly Created.");
                Con.Close();
                Populate();
            }
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNumTb.Text = ItemsGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            ItemNameTb.Text = ItemsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            CatCb.SelectedItem = ItemsGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            PriceCb.Text = ItemsGV.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "")
            {
                MessageBox.Show("Select The Item to be Deleted.");
            }
            else
            {
                Con.Open();
                string query = "delete from ItemTbl where ItemNum = '" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Deleted.");
                Con.Close();
                Populate();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || PriceCb.Text == "")
            {
                MessageBox.Show("Fill All The fields");
            }
            else
            {
                Con.Open();
                string query = "update ItemTbl set ItemName='" + ItemNameTb.Text + "',Itemcat='" + CatCb.SelectedItem.ToString() + "' where ItemPrice =" + PriceCb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Updated.");
                Con.Close();
                Populate();
            }
        }
    }
}
