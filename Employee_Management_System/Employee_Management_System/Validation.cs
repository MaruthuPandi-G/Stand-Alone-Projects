using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Employee_Management_System
{
    internal class Validation
    {
        public bool ValidUserId(string userId)
        {
            Regex format = new Regex(@"^[A-za-z1-9]{4,50}$");
            return format.IsMatch(userId); 
        }
        public bool ValidPassword(string password)
        {
            Regex format = new Regex(@"^[A-za-z]{4,10}@[0-9]{2,20}$");
            return format.IsMatch(password);
        }
        public bool ValidEmployeeId(string employeeId)
        {
            Regex format = new Regex(@"^[1-9]{1}[0-9]{3}$");
            return format.IsMatch(employeeId);
        }
        public bool ValidEmployeeName(string employeeName)
        {
            Regex format = new Regex(@"^[A-Za-z]{3,100}");
            return format.IsMatch(employeeName);          
        }
        public bool ValidEmployeeMobileNumber(string mobileNumber)
        {
            Regex format = new Regex(@"^[1-9]{1}[0-9]{9}$");
            return format.IsMatch(mobileNumber);
        }
        public bool ValidEmployeeEmail(string email)
        {
            Regex format = new Regex(@"^[a-z0-9]{1,50}@(gmail|yahoo).(com|in)$");
            return format.IsMatch(email);
        }
        public bool ValidEmployeeAge(string age)
        {
            Regex format = new Regex("^[0-9]{2}$");
            return format.IsMatch(age);
        }
        public bool ValidEmployeeExperience(string experience)
        {
            Regex format = new Regex("^[0-9]{2}$");
            return format.IsMatch(experience);
        }
        public bool ValidEmployeeAddress(string address)
        {
            Regex format = new Regex(@"^[a-zA-Z1-9]{5,200}");
            return format.IsMatch(address);
        }
        public bool ValidEmployeeBankName(string bankName)
        {
            Regex format = new Regex(@"^[A-Za-z]{3,100}");
            return format.IsMatch(bankName);
        }
        public bool ValidIfscCode(string ifscCode)
        {
            Regex format = new Regex(@"^[A-Z]{4}0[0-9]{6}$");
            return format.IsMatch(ifscCode);
        }
        public bool ValidAccountNumber(string accountNumber)
        {
            Regex format = new Regex(@"^[0-9]{10,20}$");
            return format.IsMatch(accountNumber);
        }
        public bool ValidAadharNumber(string aadharNumber)
        {
            Regex format = new Regex(@"^[0-9]{12}$");
            return format.IsMatch(aadharNumber);
        }
        public bool ValidPresentDays(string age)
        {
            Regex format = new Regex("^[0-9]{1,2}$");
            return format.IsMatch(age);
        }
    }
}
