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
    public partial class EmployeeLogin : Form
    {
       em employeForm;       
        DataAccessObject dataAccess;
        Validation valid;
       EmployeePage emp;
       
        public EmployeeLogin()
        {
            InitializeComponent();
             employeForm= new em();
             dataAccess = new DataAccessObject();
             valid = new Validation();
                 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            emp = new EmployeePage(textBoxEmpNumber.Text);
            string name;
            string mobileNumber;

            if (!valid.ValidEmployeeName(textBoxEmpName.Text))
            {
                labelName.ForeColor = Color.Red;
                labelName.Text = "Incorrect";
                return;
            }
            else
            {
                labelName.ForeColor = Color.Green;
                labelName.Text = "Correct";
                name= textBoxEmpName.Text;
            }


            if (!valid.ValidEmployeeMobileNumber(textBoxEmpNumber.Text))
            {
                labelMobileNumber.ForeColor = Color.Red;
                labelMobileNumber.Text = "Incorrect";
                return;
            }
            else
            {
                labelMobileNumber.ForeColor = Color.Green;
                labelMobileNumber.Text = "Correct";
                mobileNumber = textBoxEmpNumber.Text;
            }

           if(dataAccess.EmployeeLogin(name,mobileNumber))
            {
                ActiveForm.Dispose();
                emp.ShowDialog();
            }
            textBoxEmpName.Clear();
            textBoxEmpNumber.Clear();
            labelName.Text = "";
            labelMobileNumber.Text = "";
        }

        private void btnEmployeeRegister_Click(object sender, EventArgs e)
        {
            ActiveForm.Dispose();
            employeForm.ShowDialog();            
        }

        private void textBoxEmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
