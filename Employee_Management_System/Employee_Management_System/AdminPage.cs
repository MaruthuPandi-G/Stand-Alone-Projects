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
    public partial class AdminPage : Form
    {
        DataAccessObject dataAccess;
       
        Validation valid;
        public AdminPage()
        {
            InitializeComponent();
            dataAccess = new DataAccessObject();
           
            valid = new Validation();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            
        }

        private void adminname_Click(object sender, EventArgs e)
        {

        }

        private void btnFindDetail_Click(object sender, EventArgs e)
        {
          

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            ActiveForm.Dispose();
            log.ShowDialog();
        }

       

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            
            ActiveForm.Dispose();
                     
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UpdateDelete updatedelete = new UpdateDelete();
            ActiveForm.Dispose();
            updatedelete.ShowDialog();
        }

        private void labelAdminName_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            CreateAdmin admin = new CreateAdmin();
            ActiveForm.Dispose();
            admin.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPaymentDetails_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            ActiveForm.Dispose();
            pay.ShowDialog();
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            EmployeeDetails emp = new EmployeeDetails();
            ActiveForm.Dispose();
            emp.ShowDialog();
        }
    }
}
