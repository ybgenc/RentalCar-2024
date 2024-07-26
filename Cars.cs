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
    public partial class Cars : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=YUSUF;Initial Catalog=RentalCar;Integrated Security=True;");
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand com;


        public Cars()
        {
            InitializeComponent();
        }
        void GetCars()
        {
            da = new SqlDataAdapter("select * from Cars", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            DGVcars.DataSource = table;
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            GetCars();

        }

        private void BTNaddCar_Click(object sender, EventArgs e)
        {
            com = new SqlCommand(" insert into Cars (Plate,Brand,Model,Year,Km,Class,Color,Fuel,Speed,Price,Status,Picture) values ('" + TBplate.Text + "','" + TBbrand.Text + "','" + TBmodel.Text + "','" + TByear.Text + "','" + TBkm.Text + "','" + CBclass.Text + "','" + TBcolor.Text + "','" + CBfuel.Text + "','" + CBSpeed.Text + "','" + TBprice.Text + "','" + CBstatus.Text + "','" + PBcarPicture.ImageLocation + "')", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Car added successfully");
            GetCars();
        }

        private void BTNaddpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();
            ofl.Filter = "Image files |*.jpg; *.png; *.tif| All files |*.*";
            ofl.ShowDialog();
            PBcarPicture.ImageLocation = ofl.FileName;
        }

        private void BTNupdateCar_Click(object sender, EventArgs e)
        {
            com = new SqlCommand(" update Cars set Plate = '" + TBplate.Text + "',Brand = '" + TBbrand.Text + "' ,Model = '" + TBmodel.Text + "' ,Year = '" + TByear.Text + "' ,Km = '" + TBkm.Text + "' ,Class ='" + CBclass.Text + "' ,Color ='" + TBcolor.Text + "' ,Fuel = '" + CBfuel.Text + "',Speed = '" + CBSpeed.Text + "',Price ='" + TBprice.Text + "',Status = '" + CBstatus.Text + "',Picture = '" + PBcarPicture.ImageLocation + "'where id = '" + DGVcars.CurrentRow.Cells[0].Value + "'", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Car updated successfully!");
            GetCars();

        }

        private void DGVcars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBplate.Text = DGVcars.CurrentRow.Cells[1].Value.ToString();
            TBbrand.Text = DGVcars.CurrentRow.Cells[2].Value.ToString();
            TBmodel.Text = DGVcars.CurrentRow.Cells[3].Value.ToString();
            TByear.Text = DGVcars.CurrentRow.Cells[4].Value.ToString();
            TBkm.Text = DGVcars.CurrentRow.Cells[5].Value.ToString();
            CBclass.Text = DGVcars.CurrentRow.Cells[6].Value.ToString();
            TBcolor.Text = DGVcars.CurrentRow.Cells[7].Value.ToString();
            CBfuel.Text = DGVcars.CurrentRow.Cells[8].Value.ToString();
            CBSpeed.Text = DGVcars.CurrentRow.Cells[9].Value.ToString();
            TBprice.Text = DGVcars.CurrentRow.Cells[10].Value.ToString();
            CBstatus.Text = DGVcars.CurrentRow.Cells[11].Value.ToString();
            PBcarPicture.ImageLocation = DGVcars.CurrentRow.Cells[12].Value.ToString();


        }

        private void BTNdeleteCar_Click(object sender, EventArgs e)
        {
            com = new SqlCommand(" delete from Cars where id = '" + DGVcars.CurrentRow.Cells[0].Value + "' ", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Car deleted");
            GetCars();

        }

        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Cars where brand like '"+TBsearch.Text+"%' ", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            DGVcars.DataSource = table;

        }

    }
}
