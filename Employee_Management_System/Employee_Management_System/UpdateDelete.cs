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
    public partial class UpdateDelete : Form
    {
        DataAccessObject dataAccess;
        Validation valid;
        public UpdateDelete()
        {
            InitializeComponent();
            dataAccess=new DataAccessObject();
            valid=new Validation();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            ActiveForm.Dispose();
            admin.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int age;
            string mobileNumber;
            string email;
            string employeeAddress;

            if (!valid.ValidEmployeeAge(textBoxAge.Text))
            {
                MessageBox.Show("Enter Age In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                age = Convert.ToInt32(textBoxAge.Text);
            }

            if (!valid.ValidEmployeeMobileNumber(textBoxPhoneNumber.Text))
            {
                MessageBox.Show("Enter Mobile In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                mobileNumber = textBoxPhoneNumber.Text;
            }

            if (!valid.ValidEmployeeEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Enter E-mail In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                email = textBoxEmail.Text;
            }

            if (!valid.ValidEmployeeAddress(address.Text))
            {
                MessageBox.Show("Enter Address In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                employeeAddress = address.Text;
            }
           int y= dataAccess.UpdateEmployeeDetails(Convert.ToInt32(textBoxId.Text),age, mobileNumber, department.SelectedItem.ToString(), designation.SelectedItem.ToString(), email, employeeAddress);
         
            if(y==1)
            {
                MessageBox.Show("Details Successfully Updated", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            labelName.Text = "";
            textBoxAge.Clear();
            textBoxPhoneNumber.Clear();
            department.Text="";
            designation.Text="";
            textBoxEmail.Clear();
            address.Clear();
        }

        private void btnSearchForUpdateDelete_Click(object sender, EventArgs e)
        {
            string employeeId;
            if (!valid.ValidEmployeeId(textBoxId.Text))
            {
                MessageBox.Show("Enter Employee Id In Correct Format Example (1111)", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                employeeId = textBoxId.Text;
            }

            string[] records = dataAccess.findDetailUpdateSearch(Convert.ToInt32(employeeId));
            labelName.Text = records[0]+" Details";
            textBoxAge.Text = records[1];
            textBoxPhoneNumber.Text = records[2];
            department.Text = records[3];
            designation.Text = records[4];
            textBoxEmail.Text = records[5];
            address.Text = records[6];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] data = dataAccess.GetExEmployeeDetail(Convert.ToInt32(textBoxId.Text));

            dataAccess.InsertExEmployeeDetails(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10], data[11]);

            DialogResult dr = MessageBox.Show("Are You Delete this Data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr==DialogResult.OK)
            {
                dataAccess.DeleteEmployeeDetails(Convert.ToInt32(textBoxId.Text));
            }
            else if(dr==DialogResult.Cancel)
            {
                MessageBox.Show("Your Request Cancelled");
            }
            labelName.Text = "";
            textBoxAge.Clear();
            textBoxPhoneNumber.Clear();
            department.Text="";
            designation.Text="";
            textBoxEmail.Clear();
            address.Clear();
        }
    }
}
