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
    public partial class Payment : Form
    {
        DataAccessObject dataAccess;
        Validation valid;
        public Payment()
        {
            InitializeComponent();
            valid = new Validation();
            dataAccess=new DataAccessObject();
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

            string[] records = dataAccess.findDetailAdmin(Convert.ToInt32(employeeId));
            textBoxName.Text = records[0];
            textBoxMobile.Text = records[1];           
            department.Text = records[2];
            designation.Text = records[3];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int presentDays;
            string salaryDate = SalaryDate.Value.ToShortDateString();
            int basicPay= Convert.ToInt32(textBoxBasicPay.Text);
            int hra = Convert.ToInt32(textBoxHra.Text);
            int bonus;
            int pf = Convert.ToInt32(textBoxPf.Text);
            string perform = performance.SelectedItem.ToString();
                    
            if (!valid.ValidPresentDays(textBoxPresentDays.Text))
            {
                MessageBox.Show("Present Days Field Accept only Numeric Value");
                return;
            }
            else
            {
                presentDays = Convert.ToInt32(textBoxPresentDays.Text);
            }            
            if(textBoxBonus.Text=="")
            {
                bonus = 0;
            }
            else
            {
                bonus = Convert.ToInt32(textBoxBonus.Text);
            }
            int salary = (basicPay + hra + bonus) - pf;
            int absentDays = 30 - presentDays;

            int y=dataAccess.insertPaymentDetails(Convert.ToInt32(textBoxSearchId.Text), textBoxName.Text, textBoxMobile.Text,department.SelectedItem.ToString(),designation.SelectedItem.ToString(),presentDays,absentDays,basicPay,hra,bonus,pf,salary,salaryDate,perform);

            if(y==1)
            {
              MessageBox.Show(textBoxName.Text+" Salary Successfully Debitted", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxSearchId.Clear();
            textBoxName.Clear();
            textBoxMobile.Clear();
            department.Text="";
            designation.Text="";
            textBoxPresentDays.Clear();
            SalaryDate.Value = DateTime.Now;      
            textBoxBasicPay.Clear();
            textBoxHra.Clear();
            textBoxBonus.Clear();
            textBoxPf.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            ActiveForm.Dispose();
            admin.ShowDialog();
        }
    }
}
