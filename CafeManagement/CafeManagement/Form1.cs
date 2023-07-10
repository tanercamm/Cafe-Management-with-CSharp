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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\taner\OneDrive\Belgeler\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        public static string user;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*UserOrder userOrder = new UserOrder();
            userOrder.Show();
            this.Hide();
            */

            user = txtUsername.Text;

            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter A Username Or Password!");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTbl where Uname='"+txtUsername.Text+"' and Upassword= '"+txtPassword.Text+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UserOrder userOrder = new UserOrder();
                    userOrder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
                Con.Close();
            }

            }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest = new GuestOrder();
            guest.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
