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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\taner\OneDrive\Belgeler\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        void Populate()
        {
            Con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into UsersTbl values('" + UnameTb.Text + "','"+UphoneTb.Text+"','"+UpasswordTb.Text+"')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Succesfuly Created.");
            Con.Close();
            Populate();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
     
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //UnameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            //UphoneTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            //UpasswordTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();

            UnameTb.Text = UsersGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            UphoneTb.Text = UsersGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            UpasswordTb.Text = UsersGV.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UphoneTb.Text == "")
            {
                MessageBox.Show("Select The User to be Deleted.");
            }
            else
            {
                Con.Open();
                string query = "delete from UsersTbl where Uphone = '" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted.");
                Con.Close();
                Populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(UphoneTb.Text == "" || UpasswordTb.Text == "" || UnameTb.Text == "")
            {
                MessageBox.Show("Fill All The fields");
            }
            else
            {
                Con.Open();
                string query = "update UsersTbl set Uname='" + UnameTb.Text + "',Upassword='" + UpasswordTb.Text + "' where Uphone ='"+UphoneTb.Text+"'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated.");
                Con.Close();
                Populate();
            }
        }
    }
}
