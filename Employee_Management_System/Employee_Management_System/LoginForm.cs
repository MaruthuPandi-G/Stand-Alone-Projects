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
    public partial class LoginForm : Form
    {
        DataAccessObject dataAccess;
        Validation valid;
        AdminPage admin;

        public LoginForm()
        {
            InitializeComponent();
            dataAccess = new DataAccessObject();
            valid = new Validation();
            admin = new AdminPage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId;
            string password;
          
            if(!valid.ValidUserId(textUserId.Text))
            {
                labelUserId.ForeColor = Color.Red;
                labelUserId.Text = "Incorrect";
                return;
            }
            else
            {
                labelUserId.ForeColor = Color.Green;
                labelUserId.Text = "Correct";
                userId=textUserId.Text;
            }


            if (!valid.ValidPassword(textPassword.Text))
            {
                labelPassword.ForeColor = Color.Red;
                labelPassword.Text = "Incorrect";
                return;
            }
            else
            {
                labelPassword.ForeColor = Color.Green;
                labelPassword.Text = "Correct";
                password = textPassword.Text;
            }

           if( dataAccess.adminLogin(userId,password))
            {
                ActiveForm.Dispose();
                admin.ShowDialog();
            }
            labelUserId.Text = "";
            labelPassword.Text = "";
            textUserId.Clear();
            textPassword.Clear();
            
        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
