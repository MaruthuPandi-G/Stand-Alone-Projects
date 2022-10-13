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
    public partial class Crud : Form
    {
        DataAccessObject dao;
        Form1 home;
        Validation valid;
        public Crud()
        {
            InitializeComponent();
            dao = new DataAccessObject();
            home = new Form1();
            valid = new Validation();
        }

        private void Crud_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {

        }

       private void btnSearch_Click(object sender, EventArgs e)
        {
            string employeeId;
            if (!valid.ValidEmployeeId(textBoxSearchId.Text))
            {
                MessageBox.Show("Enter Employee Id In Correct Format Example (1111)", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                employeeId = textBoxSearchId.Text;
            }

            string[] records = dao.findDetailAdmin(Convert.ToInt32(employeeId));
            textBoxName.Text = records[0];
            textBoxMobile.Text = records[1];
            textBoxEmpEmail.Text = records[2];
            department.Text = records[3];
            designation.Text = records[4];
        }

        private void btnEmpStatus_Click(object sender, EventArgs e)
        {
            string presentDays;
            if (!valid.ValidPresentDays(textBoxPresent.Text))
            {
                MessageBox.Show("Present Days Field Accept only Numeric Value");
                return;
            }
            else
            {               
                 presentDays = textBoxPresent.Text;                
            }

            dao.insertPayDetails(Convert.ToInt32(textBoxSearchId.Text), textBoxName.Text, textBoxMobile.Text, textBoxEmpEmail.Text, SalaryDate.Value.ToShortDateString(), department.SelectedItem.ToString(), designation.SelectedItem.ToString(),Convert.ToInt32(presentDays), performance.SelectedItem.ToString());
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            EmployeePayment empPay = new EmployeePayment();
           
            empPay.ShowDialog();         
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.ShowDialog();
        }
    }
}
