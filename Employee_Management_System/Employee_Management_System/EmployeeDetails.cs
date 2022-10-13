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
    public partial class EmployeeDetails : Form
    {
        DataAccessObject dataAccess;
       
        Validation valid;
        public EmployeeDetails()
        {
            InitializeComponent();
            dataAccess = new DataAccessObject();
           
            valid = new Validation();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            dataGridViewEmployeeDetails.DataSource = dataAccess.showDetails();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeId.Text != "")
            {
                dataGridViewEmployeeDetails.DataSource = dataAccess.IdPersonalDetails(Convert.ToInt32(textBoxEmployeeId.Text));
            }
            else if (textBoxEmployeeId.Text == null)
            {
                dataGridViewEmployeeDetails.DataSource = dataAccess.PersonalDetails();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            ActiveForm.Dispose();
            admin.ShowDialog();
        }

        private void buttonBankDetails_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeId.Text == "")
            {
                dataGridViewEmployeeDetails.DataSource = dataAccess.BankDetails();
                return;
            }
            else if (textBoxEmployeeId.Text != null)
            {
                dataGridViewEmployeeDetails.DataSource = dataAccess.IdBankDetails(Convert.ToInt32(textBoxEmployeeId.Text));
                
            }
            

        }

        private void btnEmployeeSuggestion_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeId.Text == "")
            {
                dataGridViewEmployeeDetails.DataSource = dataAccess.SuggestionDetails();
            }
            else
            {
                dataGridViewEmployeeDetails.DataSource = dataAccess.IdSuggestionDetails(Convert.ToInt32(textBoxEmployeeId.Text));
            }
        }

        private void btnSalaryDetails_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeId.Text == "")
            {
                dataGridViewEmployeeDetails.DataSource = dataAccess.SalaryDetails();
            }
            else
            {
                dataGridViewEmployeeDetails.DataSource = dataAccess.IdSalaryDetails(Convert.ToInt32(textBoxEmployeeId.Text));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewEmployeeDetails.DataSource = dataAccess.SpecifiedEmployeeDetails(employeeDepartment.SelectedItem.ToString(),employeeDesignation.SelectedItem.ToString());
        }

        private void employeeDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRelievedEmployee_Click(object sender, EventArgs e)
        {
            dataGridViewEmployeeDetails.DataSource = dataAccess.ShowExEmployeeDetails();
        }
    }
}
