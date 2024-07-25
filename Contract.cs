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

namespace RentalCar
{
    public partial class Contract : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=YUSUF;Initial Catalog=RentalCar;Integrated Security=True;");
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand com;
        string licence_Date;
        TimeSpan licenceYear;
        public Contract()
        {
            InitializeComponent();
        }

        private void GetCars()
        {
            conn.Open();

            string com2 = "SELECT licence_date FROM Customers WHERE customer_id = @CustomerId";
            SqlCommand command = new SqlCommand(com2, conn);

            command.Parameters.AddWithValue("@CustomerId", TBidSearch.Text);

            using (SqlDataReader dr = command.ExecuteReader())
            {
                if (dr.Read())
                {
                    licence_Date = dr["licence_date"].ToString();
                    DateTime licenceDateParsed = DateTime.Parse(licence_Date);
                    licenceYear = DateTime.Now - licenceDateParsed;
                }
            }
            comboBox1.DataSource = null;

            string carQuery = (licenceYear.TotalDays / 365 < 2)
            ? "SELECT Plate FROM Cars WHERE Status = 'Available' AND (Class = 'Economic' OR Class = 'Comfort')"
                : "SELECT Plate FROM Cars WHERE Status = 'Available'";

            SqlDataAdapter da = new SqlDataAdapter(carQuery, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Plate";
            comboBox1.ValueMember = "Plate";

            conn.Close();
        }

        private void TBidSearch_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand();
            comboBox1.DataSource = null;

            conn.Open();
            com.Connection = conn;
            com.CommandText = " Select * from Customers where customer_id like '" + TBidSearch.Text + "'";
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                TBname.Text = dr["name_surname"].ToString();
                TBmobile.Text = dr["mobile"].ToString();
                TBlicenceDate.Text = dr["licence_date"].ToString();

            }
            dr.Close();
            conn.Close();
            GetCars();


        }

        private void Contract_Load(object sender, EventArgs e)
        {
            GetCars();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // !!<--CHATGPT-->!! //
        {

            if (comboBox1.SelectedItem == null)
            {
                return; 
            }


            DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;
            string selectedPlate = selectedRow["Plate"].ToString(); 

            string connectionString = "Data Source=YUSUF;Initial Catalog=RentalCar;Integrated Security=True;";
            string query = "SELECT * FROM Cars WHERE Plate = @Plate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand com = new SqlCommand(query, conn))
            {
                com.Parameters.AddWithValue("@Plate", selectedPlate);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TBbrand.Text = reader["Brand"].ToString();
                            TBmodel.Text = reader["Model"].ToString();
                            TBspeed.Text = reader["Speed"].ToString();
                            TBcolor.Text = reader["Color"].ToString();
                            TByear.Text = reader["Year"].ToString();
                            TBfuel.Text = reader["Fuel"].ToString();
                            double totalYears = licenceYear.TotalDays / 365;

                            if (totalYears <= 2)
                            {
                                double price = double.Parse(reader["Price"].ToString()) * 1.1;
                                TBprice.Text = price.ToString("F2");
                                textBox10.Text = price.ToString("F2");
                            }
                            else
                            {
                                double price = double.Parse(reader["Price"].ToString());
                                TBprice.Text = price.ToString("F2");
                                textBox10.Text = price.ToString("F2");
                            }

                        }
                    }
                }
                finally { };
                

            }
        }

        private void BTNcalculate_Click(object sender, EventArgs e)
        {

        }
    }



}

