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
using DevExpress.Utils;
using System.Reflection;


namespace RentalCar
{
    public partial class Customer : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=YUSUF;Initial Catalog=RentalCar;Integrated Security=True;");
        SqlDataAdapter da;
        SqlCommand com;

        public Customer()
        {
            InitializeComponent();
        }
        void GetCustomers()
        {
            da = new SqlDataAdapter("select * from Customers", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            DGVcustomers.DataSource = table;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            GetCustomers();
        }

        private void BTNaddCustomer_Click(object sender, EventArgs e)
        {
            com = new SqlCommand(" insert into Customers (name_surname, customer_id, mobile, mail, address, licence_Date, date_of_birth, picture) values ('" + TBname.Text + "', '" + TBid.Text + "', '" + TBmobile.Text + "', '" + TBmail.Text + "', '" + RTBaddress.Text + "', '" + DTPlicence.Text + "', '" + DTPbirth.Text + "','"+ PBcustomerPicture.ImageLocation+ "')", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Customer added successfully");
            GetCustomers();
        }

        private void BTNaddpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();
            ofl.Filter = "Image files |*.jpg; *.png; *.tif| All files|*.*";
            ofl.ShowDialog();
            PBcustomerPicture.ImageLocation = ofl.FileName;
        }

        private void BTNupdateCustomer_Click(object sender, EventArgs e)
        {
            com = new SqlCommand(" update Customers set name_surname = '" + TBname.Text + "', customer_id = '" + TBid.Text + "', mobile = '" + TBmobile.Text + "',mail = '" + TBmail.Text + "',address = '" + RTBaddress.Text + "',licence_Date = '" + DTPlicence.Text + "',date_of_birth =  '" + DTPbirth.Text + "', picture = '" + PBcustomerPicture.ImageLocation + "' where id = '" + DGVcustomers.CurrentRow.Cells[0].Value + "'", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Customer updated successfully");
            GetCustomers();
        }

        private void DGVcustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBname.Text = DGVcustomers.CurrentRow.Cells[1].Value.ToString();
            TBid.Text = DGVcustomers.CurrentRow.Cells[2].Value.ToString();
            TBmobile.Text = DGVcustomers.CurrentRow.Cells[3].Value.ToString();
            TBmail.Text = DGVcustomers.CurrentRow.Cells[4].Value.ToString();
            RTBaddress.Text = DGVcustomers.CurrentRow.Cells[5].Value.ToString();
            DTPlicence.Text = DGVcustomers.CurrentRow.Cells[6].Value.ToString();
            DTPbirth.Text = DGVcustomers.CurrentRow.Cells[7].Value.ToString();
            PBcustomerPicture.ImageLocation = DGVcustomers.CurrentRow.Cells[8].Value.ToString();

        }

        private void BTNdeleteCustomer_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("delete from Customers where id = '" + DGVcustomers.CurrentRow.Cells[0].Value + "'", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Customer deleted");
            GetCustomers();

        }

        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Customers where name_surname like '" + TBsearch.Text + "%'", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            DGVcustomers.DataSource = table;
        }
    }
}
