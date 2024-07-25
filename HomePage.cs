using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            contract.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
        }
    }
}
