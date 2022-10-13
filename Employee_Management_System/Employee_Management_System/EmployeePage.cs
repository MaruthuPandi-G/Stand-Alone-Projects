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
   
    public partial class EmployeePage : Form
    {
        DataAccessObject dataAccess;        
       string employeeMobileNumber;
       
        public EmployeePage(string employeeMobileNumber)
        {
            InitializeComponent();
            this.employeeMobileNumber = employeeMobileNumber;
            dataAccess = new DataAccessObject();
           
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
           labelEmpName.Text = "Welcome " + dataAccess.GetEmployeeName(employeeMobileNumber);
            employeeIndividualData.DataSource = dataAccess.showEmployeedetails(employeeMobileNumber);        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string[]details=new string[3];
            details = dataAccess.GetEmployeeDetail(employeeMobileNumber);

         dataAccess.InsertSuggestionDetails(Convert.ToInt32(details[0]),details[1].ToString(), employeeMobileNumber, details[1].ToString(),suggestionDate.Value.ToShortDateString(),textBoxSuggestionName.Text,employeeSuggestion.Text);
            textBoxSuggestionName.Clear();
            employeeSuggestion.Clear();
            suggestionDate.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeeComplaint_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        { 
            Form1 form = new Form1();
            ActiveForm.Dispose();
            form.ShowDialog();
        }
    }
}
