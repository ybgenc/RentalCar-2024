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

        void GetContract()
        {
            da = new SqlDataAdapter("Select * from Contracts", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            DGVcontract.DataSource = table;
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
            TBname.Text = "";
            TBmobile.Text = "";
            TBlicenceDate.Text = "";
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
            GetContract();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // !!<--CHATGPT-->!! //
        {
            TBbrand.Text = "";
            TBmodel.Text = "";
            TBspeed.Text = "";
            TBcolor.Text = "";
            TByear.Text = "";
            TBfuel.Text = "";

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
                                TBprice.Text = price.ToString("");
                            }
                            else
                            {
                                double price = double.Parse(reader["Price"].ToString());
                                TBprice.Text = price.ToString("");
                            }

                        }
                    }
                }
                finally { };


            }
        }

        private void BTNcalculate_Click(object sender, EventArgs e)
        {
            DateTime Rent = DateTime.Parse(DTPrentDate.Text);
            DateTime Delivery = DateTime.Parse(DTP.Text);

            TimeSpan days = Delivery - Rent;
            int dayResult = days.Days;

            decimal price = decimal.Parse(TBprice.Text);

            decimal total = 0;

            if (CBperiod.SelectedIndex == 0)
            {
                total = dayResult * price;
            }
            else if (CBperiod.SelectedIndex == 1 && dayResult >= 7)
            {
                total = dayResult * price * 0.9m;
            }
            else if (CBperiod.SelectedIndex == 2 && dayResult >= 30)
            {
                total = dayResult * price * 0.8m;
            }
            else
            {
                total = dayResult * price;
            }

            if (CBdiscount.SelectedIndex != -1)
            {
                decimal discount;
                if (decimal.TryParse(CBdiscount.Text, out discount))
                {
                    total = total * (1 - discount / 100);
                }
            }

            label14.Text = total.ToString("");
        }

        private void BTNrent_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = comboBox1.SelectedItem as DataRowView;
            string plate = selectedRow["Plate"].ToString();

            string insertQuery = "Insert into Contracts (Name, Mobile, Licence_Date, Plate, Brand, Model, Speed, Color, Fuel, Price, Period, Discount, Rent_Date, Delivery_Date, Cost) " +
                                 "values ('" + TBname.Text + "', '" + TBmobile.Text + "', '" + TBlicenceDate.Text + "', '" + plate + "', '" + TBbrand.Text + "', '" + TBmodel.Text + "', '" + TBspeed.Text + "', '" + TBcolor.Text + "', '" + TBfuel.Text + "', '" + decimal.Parse(TBprice.Text) + "', '" + CBperiod.SelectedItem.ToString() + "', '" + CBdiscount.SelectedItem.ToString() + "', '" + DTPrentDate.Text + "', '" + DTP.Text + "', '" + decimal.Parse(label14.Text) + "')";

            string updateQuery = "Update Cars set Status = 'Rented' where Plate = '" + plate + "'";

            using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
            {
                conn.Open();
                insertCommand.ExecuteNonQuery();
            }

            using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
            {
                updateCommand.ExecuteNonQuery();
            }

            conn.Close();
            MessageBox.Show("Car rented");
            GetContract();
            GetCars();
        }

        private void BTNpickup_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DGVcontract.CurrentRow;
            com = new SqlCommand("Update Cars set Status = 'Available' where Plate = '" + row.Cells["Plate"].Value.ToString() + "'", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Car picked up");
            GetCars();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                List<string> ids = new List<string>();

                com = new SqlCommand("Select id from Cars where Status = 'Rented'", conn);
                conn.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ids.Add(dr["id"].ToString());
                }
                dr.Close();

                if (ids.Count > 0)
                {
                    string idList = string.Join("','", ids);
                    string selectQuery = $"Select * from Contracts where id IN ('{idList}')";
                    da = new SqlDataAdapter(selectQuery, conn);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    DGVcontract.DataSource = table;
                }


                conn.Close();
            }
            else
            {
                GetContract();
            }

        }
    }
}

