using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class EmployeePayment : Form
    {
        DataAccessObject dataAccess;
        Crud crud;
        Form1 home;
        public EmployeePayment()
        {
            InitializeComponent();
            dataAccess= new DataAccessObject(); 
            crud=new Crud();
            home = new Form1();
        }

        private void EmployeePayment_Load(object sender, EventArgs e)
        {           
            crud.Hide();
            employeePaymentDetails.DataSource = dataAccess.showEmployeePaydetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.ShowDialog();
        }
    }
}
