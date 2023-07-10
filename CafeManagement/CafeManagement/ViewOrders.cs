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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\taner\OneDrive\Belgeler\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void Populate()
        {
            Con.Open();
            string query = "select * from OrdersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("◘◘• ORLENA CAFE •◘◘", new Font("Abeezee", 25, FontStyle.Bold), Brushes.DarkOrange, new Point(210));
            e.Graphics.DrawString("== Order Summary ==", new Font("Abeezee", 23, FontStyle.Bold), Brushes.DarkOrange, new Point(230,60));


            e.Graphics.DrawString($"Number : {Convert.ToInt32(OrdersGV.SelectedRows[0].Cells[0].Value.ToString())}", new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(230, 120));
            e.Graphics.DrawString($"Date : {OrdersGV.SelectedRows[0].Cells[1].Value.ToString()}", new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(230, 160));
            e.Graphics.DrawString($"Seller : {OrdersGV.SelectedRows[0].Cells[2].Value.ToString()}", new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(230, 200));
            e.Graphics.DrawString($"Amount : {Convert.ToInt32(OrdersGV.SelectedRows[0].Cells[3].Value.ToString())}", new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(230, 240));

            e.Graphics.DrawString("== Enjoy your Meal ==", new Font("Abeezee", 23, FontStyle.Bold), Brushes.DarkOrange, new Point(230, 300));
            
        }
    }
}
