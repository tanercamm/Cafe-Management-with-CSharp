namespace CafeManagement
{
    partial class GuestOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.OrdersGv = new System.Windows.Forms.DataGridView();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.cbxCatergory = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblYourOrder = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtSellerName);
            this.panel1.Controls.Add(this.txtOrderNum);
            this.panel1.Controls.Add(this.OrdersGv);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.cbxCatergory);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblYourOrder);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblPlaceOrder);
            this.panel1.Location = new System.Drawing.Point(141, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 678);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.Location = new System.Drawing.Point(60, 121);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 33);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(610, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Place The Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(759, 276);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(202, 33);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Add To Card";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(580, 276);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantity.Size = new System.Drawing.Size(155, 33);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.Text = "Quantity";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Enabled = false;
            this.txtSellerName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSellerName.ForeColor = System.Drawing.Color.Black;
            this.txtSellerName.Location = new System.Drawing.Point(60, 221);
            this.txtSellerName.Multiline = true;
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(155, 38);
            this.txtSellerName.TabIndex = 5;
            this.txtSellerName.Text = "Guest";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrderNum.ForeColor = System.Drawing.Color.Black;
            this.txtOrderNum.Location = new System.Drawing.Point(60, 177);
            this.txtOrderNum.Multiline = true;
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(155, 38);
            this.txtOrderNum.TabIndex = 5;
            this.txtOrderNum.Text = "OrderNum";
            // 
            // OrdersGv
            // 
            this.OrdersGv.BackgroundColor = System.Drawing.Color.White;
            this.OrdersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGv.Location = new System.Drawing.Point(363, 373);
            this.OrdersGv.Name = "OrdersGv";
            this.OrdersGv.RowHeadersWidth = 51;
            this.OrdersGv.RowTemplate.Height = 24;
            this.OrdersGv.Size = new System.Drawing.Size(794, 238);
            this.OrdersGv.TabIndex = 4;
            // 
            // ItemsGV
            // 
            this.ItemsGV.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.Location = new System.Drawing.Point(348, 76);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowHeadersWidth = 51;
            this.ItemsGV.RowTemplate.Height = 24;
            this.ItemsGV.Size = new System.Drawing.Size(809, 194);
            this.ItemsGV.TabIndex = 4;
            this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
            // 
            // cbxCatergory
            // 
            this.cbxCatergory.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCatergory.FormattingEnabled = true;
            this.cbxCatergory.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.cbxCatergory.Location = new System.Drawing.Point(60, 76);
            this.cbxCatergory.Name = "cbxCatergory";
            this.cbxCatergory.Size = new System.Drawing.Size(202, 39);
            this.cbxCatergory.TabIndex = 3;
            this.cbxCatergory.Text = "Category";
            this.cbxCatergory.SelectionChangeCommitted += new System.EventHandler(this.cbxCatergory_SelectionChangeCommitted);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAmount.Location = new System.Drawing.Point(949, 620);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(208, 35);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Order Amount";
            // 
            // lblYourOrder
            // 
            this.lblYourOrder.AutoSize = true;
            this.lblYourOrder.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYourOrder.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblYourOrder.Location = new System.Drawing.Point(357, 335);
            this.lblYourOrder.Name = "lblYourOrder";
            this.lblYourOrder.Size = new System.Drawing.Size(226, 35);
            this.lblYourOrder.TabIndex = 2;
            this.lblYourOrder.Text = "•• Your Order ••";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDate.Location = new System.Drawing.Point(1066, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 27);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaceOrder.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPlaceOrder.Location = new System.Drawing.Point(342, 38);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(233, 35);
            this.lblPlaceOrder.TabIndex = 2;
            this.lblPlaceOrder.Text = "•• Place Order ••";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(34, 691);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "LogOut";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.DarkOrange;
            this.lblExit.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(1355, -4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(40, 38);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(919, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "$";
            // 
            // GuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1393, 747);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.GuestOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.DataGridView ItemsGV;
        private System.Windows.Forms.ComboBox cbxCatergory;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView OrdersGv;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblYourOrder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
    }
}