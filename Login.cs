using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RentalCar
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlDataReader dr;
        SqlCommand com;

        public Login()
        {
            InitializeComponent();
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            string user = TBuserId.Text;
            string password = TBpassword.Text;
            conn = new SqlConnection("Data Source=YUSUF;Initial Catalog=RentalCar;Integrated Security=True;");
            com = new SqlCommand();
            conn.Open();
            com.Connection = conn;
            com.CommandText= "Select * From Employees where User_id ='" + TBuserId.Text + "'And Password='" + TBpassword.Text + "'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Login successful");
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User ID or password is wrong!");
            }
            conn.Close();



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
