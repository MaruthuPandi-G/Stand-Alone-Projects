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

namespace Employee_Management_System
{
    public partial class em : Form
    {
        DataAccessObject dataAccess;
        Validation valid;
     //   Form1 form ;
        public em()
        {
            InitializeComponent();
            dataAccess = new DataAccessObject();
            valid = new Validation();
         //   form = new Form1();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
          //  string employeeId;
            string employeeName;
            char empGender;
            string empDob = Empdob.Value.ToShortDateString();
            int employeeAge;
            string employeeMobileNumber;
            string employeeEmail;
            int employeeExperience;
            string employeeAddress;
            string bankName;
            string ifscCode;
            string accountNumber;
            string aadharNumber;

            //if (!valid.ValidEmployeeId(empId.Text))
            //{
            //    MessageBox.Show("Enter Employee Id In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //else
            //{
            //    employeeId = empId.Text;
            //}

            if (!valid.ValidEmployeeName(empName.Text))
            {
                MessageBox.Show("Enter Employee Name In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {              
                employeeName = empName.Text;
            }

            if (!(this.male.Checked || this.female.Checked))
            {
                MessageBox.Show("Select a Gender", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //if (male.Checked)
                //{
                //    empGender = 'm';
                //    return;
                //}
                //else
                //{
                //    empGender = 'f';
                //} 
                empGender = 'm';
            }

            if (!valid.ValidEmployeeMobileNumber(empPhoneNumber.Text))
            {
                MessageBox.Show("Enter Mobile In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                employeeMobileNumber = empPhoneNumber.Text;
            }
            if (empExperience.Text == "")
            {
                employeeExperience = 0;
            }
            else
            {
                if (!valid.ValidEmployeeExperience(empExperience.Text))
                {
                    MessageBox.Show("Enter Mobile In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    employeeExperience = Convert.ToInt32(empExperience.Text);
                }
            }

            if (!valid.ValidEmployeeEmail(empEmail.Text))
            {
                MessageBox.Show("Enter E-mail In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                employeeEmail = empEmail.Text;
            }

            if (!valid.ValidEmployeeAddress(empAddress.Text))
            {
                MessageBox.Show("Enter Address In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                employeeAddress = empAddress.Text;
            }


             DateTime today = DateTime.Today;
             employeeAge = today.Year - Empdob.Value.Year;

            string employeeDept = Empdept.SelectedItem.ToString();
            string employeeDesign = Empdesign.SelectedItem.ToString();
            string employeeJoinDate = empJoinDate.Text.ToString();

            if (!valid.ValidEmployeeBankName(empBankName.Text))
            {
                MessageBox.Show("Enter Bank Name In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bankName = empBankName.Text;
            }

            if (!valid.ValidIfscCode(empIFSCCode.Text))
            {
                MessageBox.Show("Enter IFSC Code In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ifscCode = empIFSCCode.Text;
            }

            if (!valid.ValidAccountNumber(empAccountNumber.Text))
            {
                MessageBox.Show("Enter Account Number In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                accountNumber = empAccountNumber.Text;
            }

            if (!valid.ValidAadharNumber(employeeAadharNumber.Text))
            {
                MessageBox.Show("Enter Aadhar Number In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                aadharNumber = employeeAadharNumber.Text;
            }

           int x= dataAccess.insertEmployeeDetails(employeeName, empGender, empDob, employeeAge, employeeMobileNumber, employeeDept,employeeDesign,employeeExperience,employeeJoinDate, employeeEmail, employeeAddress);
           int y=dataAccess.insertEmployeeBankDetails(employeeName, bankName, ifscCode, accountNumber, aadharNumber);
            if(x==1 && y==1)
            {
                MessageBox.Show("Your inforamtion Successfully Submitted", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your details not submitted", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


          // empId.Clear();
            empName.Clear();           
            Empdob.Value=DateTime.Now;
            empExperience.Clear();
            empPhoneNumber.Clear();
            Empdept.Text = "";
            Empdesign.Text = "";          
            empEmail.Clear();
            empAddress.Clear();
            empBankName.Clear();
            empIFSCCode.Clear();
            empJoinDate.Value = DateTime.Now;
            empAccountNumber.Clear();
            employeeAadharNumber.Clear();

        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            ActiveForm.Dispose();
        }

        private void em_Load(object sender, EventArgs e)
        {

        }

        private void empAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
