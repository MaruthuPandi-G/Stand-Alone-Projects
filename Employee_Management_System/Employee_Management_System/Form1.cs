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
    public partial class Form1 : Form
    {
        EmployeeLogin emplog;
        public Form1()
        {
            InitializeComponent();
            emplog = new EmployeeLogin();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            
        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnadmin_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();           
            login.ShowDialog();
         

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            EmployeeLogin emplog = new EmployeeLogin();    
            emplog.ShowDialog();
        }
    }
}
