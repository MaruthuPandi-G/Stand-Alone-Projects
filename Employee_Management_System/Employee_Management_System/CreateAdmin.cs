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
    public partial class CreateAdmin : Form
    {
        DataAccessObject dataAccess;
        Validation valid;
        public CreateAdmin()
        {
            InitializeComponent();
            dataAccess = new DataAccessObject();
            valid = new Validation();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string newPassword;
            string confirmPassWord;
            string password;


            if (!valid.ValidPassword(textBoxNewPassword.Text))
            {
                MessageBox.Show("Enter Password In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {               
                newPassword = textBoxNewPassword.Text;
            }

            if (!valid.ValidPassword(textBoxConfirmPassWord.Text))
            {
                MessageBox.Show("Enter Password In Correct Format", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                confirmPassWord = textBoxConfirmPassWord.Text;
            }

            if(newPassword!=confirmPassWord)
            {
                MessageBox.Show("Password Must be Same in Both Field", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                password = newPassword;
            }
            int y = dataAccess.insertUserLoginValues(textBoxUserId.Text, password);

            if(y==1)
            {
                MessageBox.Show("New Admin Created Successfully!", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxUserId.Clear();
            textBoxNewPassword.Clear();
            textBoxConfirmPassWord.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            ActiveForm.Dispose();
            admin.ShowDialog();
        }
    }
}
