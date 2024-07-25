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
    public partial class Employee : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=YUSUF;Initial Catalog=RentalCar;Integrated Security=True;");
        SqlDataAdapter da;
        SqlCommand com;

        public Employee()
        {
            InitializeComponent();
        }

        void GetEmployee()
        {
            da = new SqlDataAdapter("select * from Employees", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            DGVemployee.DataSource = table;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            GetEmployee();

        }

        private void BTNaddEmployee_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("insert into Employees (Name, National_id, Mobile, Mail, User_id, Password, Date_of_start, Date_of_birth, Picture) values ('" + TBname.Text + "','" + TBid.Text + "','" + TBmobile.Text + "','" + TBmail.Text + "','" + TBuserId.Text + "','" + TBpassword.Text + "','" + DTPdateOfStart.Text + "','" + DTPdateOfBirth.Text + "','" + PBemployeePicture.ImageLocation + "')", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Employee added successfully");
            GetEmployee();
            ;
        }

        private void BTNupdateEmployee_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("update Employees set Name = '" + TBname.Text + "',National_id = '" + TBid.Text + "',Mobile = '" + TBmobile.Text + "',Mail = '" + TBmail.Text + "',User_id = '" + TBuserId.Text + "',Password = '" + TBpassword.Text + "',Date_of_start = '" + DTPdateOfStart.Text + "',Date_of_birth = '" + DTPdateOfBirth.Text + "',Picture = '" + PBemployeePicture.ImageLocation + "' where id = '" + DGVemployee.CurrentRow.Cells[0].Value + "'", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Employee updated successfully");
            GetEmployee();

        }

        private void BTNdeleteEmployee_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("delete from Employees where id = '" + DGVemployee.CurrentRow.Cells[0].Value + "'", conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Employee deleted");
            GetEmployee();

        }

        private void BTNaddEmployeepicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();
            ofl.Filter = "Image files |*.jpg; *.png; *.tif| All files|*.*";
            ofl.ShowDialog();
            PBemployeePicture.ImageLocation = ofl.FileName;

        }

        private void DGVemployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBname.Text = DGVemployee.CurrentRow.Cells[1].Value.ToString();
            TBid.Text = DGVemployee.CurrentRow.Cells[2].Value.ToString();
            TBmobile.Text = DGVemployee.CurrentRow.Cells[3].Value.ToString();
            TBmail.Text = DGVemployee.CurrentRow.Cells[4].Value.ToString();
            TBuserId.Text = DGVemployee.CurrentRow.Cells[5].Value.ToString();
            TBpassword.Text = DGVemployee.CurrentRow.Cells[6].Value.ToString();
            DTPdateOfStart.Text = DGVemployee.CurrentRow.Cells[7].Value.ToString();
            DTPdateOfBirth.Text = DGVemployee.CurrentRow.Cells[8].Value.ToString();
            PBemployeePicture.ImageLocation = DGVemployee.CurrentRow.Cells[9].Value.ToString();

        }

        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Employees where Name like '" + TBsearch.Text + "%'", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            DGVemployee.DataSource = table;
        }
    }
}
