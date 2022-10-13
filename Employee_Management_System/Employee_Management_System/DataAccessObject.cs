using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Employee_Management_System
{
    internal class DataAccessObject
    {
        SqlConnection Connection;
        SqlCommand  Command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable table;
      
         //DataAccessObject Constructor
        public DataAccessObject()
        {
           try
            {
                string connectionString = @"Data source=(localdb)\MSSQLLocalDB;database=sampledb;Integrated security=SSPI";
                Connection = new SqlConnection(connectionString);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }

       

        //Admin Login  in LoginForm
        public bool adminLogin(string userId,string password)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("select * from UserLogin where UserId='" + userId + "'and UserPassword='" + password + "'", Connection);
                reader = Command.ExecuteReader();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }          
            
            if (reader.Read())
            {
                MessageBox.Show("Welcome "+userId+"!");
                return true;            
                
            }
            else
            {
                MessageBox.Show("User Id Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        //Insert UserLogin details 

        public int insertUserLoginValues(string userId,string password)
        {
            int y = 0;
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("insert into UserLogin values(@userId,@password)", Connection);

                Command.Parameters.AddWithValue("@userId", userId);
                Command.Parameters.AddWithValue("@password", password);
                y = Command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return y;
        }

        //Insert Employee Details and Employee Bank Details into Employee Table in employeeForm
        public int insertEmployeeDetails(string empname, char empgender, string empdob, int empage,string empphno,string empdept, string empdesign,int empExperience, string empjoindate,string empemail,string empaddress)
        {
            int y = 0;
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("insert into EmployeeDetails values(@empname,@empgender,@empdob,@empage,@empphno,@empdept,@empdesign,@empExperience,@empjoindate,@empemail,@empaddress)", Connection);

              //  Command.Parameters.AddWithValue("@eid", eid);
                Command.Parameters.AddWithValue("@empname", empname);
                Command.Parameters.AddWithValue("@empgender", empgender);
                Command.Parameters.AddWithValue("@empdob", empdob);
                Command.Parameters.AddWithValue("@empage", empage);
                Command.Parameters.AddWithValue("@empphno", empphno);
                Command.Parameters.AddWithValue("@empdept", empdept);
                Command.Parameters.AddWithValue("@empdesign", empdesign);
                Command.Parameters.AddWithValue("@empExperience", empExperience);
                Command.Parameters.AddWithValue("@empjoindate", empjoindate);              
                Command.Parameters.AddWithValue("@empemail", empemail);
                Command.Parameters.AddWithValue("@empaddress", empaddress);
                 y = Command.ExecuteNonQuery();               
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return y;
        }

        public int insertEmployeeBankDetails(string empname, string bankName, string ifscCode, string accountNumber, string aadharNumber)
        {
            int y=0;
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("insert into EmployeeBankDetails values(@empname,@bankName,@ifscCode,@accountNumber,@aadharNumber)", Connection);

               // Command.Parameters.AddWithValue("@eid", eid);
                Command.Parameters.AddWithValue("@empname", empname);
                Command.Parameters.AddWithValue("@bankName", bankName);
                Command.Parameters.AddWithValue("@ifscCode", ifscCode);
                Command.Parameters.AddWithValue("@accountNumber", accountNumber);
                Command.Parameters.AddWithValue("@aadharNumber", aadharNumber);
                 y = Command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            return y;
           
        }

        //Show Employee Details in AdminPage Form in DataGridView
        public DataTable showDetails()
        {
            try
            {
                Connection.Close();
                Connection.Open();
                adapter = new SqlDataAdapter("select * from EmployeeDetails", Connection);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            table = new DataTable();
            adapter.Fill(table);          
            return table;      
            
        }


              

        //Get Employee Details for Paymentdetails
        public string[] findDetailAdmin(int empId)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("select * from EmployeeDetails Where EmployeeId=" + empId, Connection);
                reader = Command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string[] data = new string[4];

            if (reader.Read())
            {
                data[0] = reader[1].ToString();
                data[1] = reader[5].ToString();
                data[2] = reader[6].ToString();
                data[3] = reader[7].ToString();                            
            }
            else
            {
                MessageBox.Show("Employee Id Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return data;
        }


        //Insert Employee payment details
        public int insertPaymentDetails(int empId,string empName,string mobNo,string dept,string design,int presentDays,int absentDays,int basic,int hra,int bonus,int pf,int salary,string salaryDate,string performance)
        {
            int y = 0;
            try
            {
                Connection.Close();
                Connection.Open();                
                

                Command = new SqlCommand("insert into EmployeePaymentDetails values(@empId,@empName,@empPhNo,@empDept,@empDesign,@presentDays,@absentDays,@basic,@hra,@bonus,@pf,@salary,@salaryDate,@performance)", Connection);
                Command.Parameters.AddWithValue("@empId", empId);
                Command.Parameters.AddWithValue("@empName", empName);
                Command.Parameters.AddWithValue("@empPhNo", mobNo);               
                Command.Parameters.AddWithValue("@empDept", dept);
                Command.Parameters.AddWithValue("@empDesign", design);
                Command.Parameters.AddWithValue("@presentDays", presentDays);
                Command.Parameters.AddWithValue("@absentDays", absentDays);
                Command.Parameters.AddWithValue("@basic", basic);
                Command.Parameters.AddWithValue("@hra", hra);
                Command.Parameters.AddWithValue("@bonus", bonus);
                Command.Parameters.AddWithValue("@pf", pf);
                Command.Parameters.AddWithValue("@salary", salary);
                Command.Parameters.AddWithValue("@salaryDate", salaryDate);                           
                Command.Parameters.AddWithValue("@performance", performance);
                 y = Command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return y;
          
        }


        //Show Few details for Update and Delete

        public string[] findDetailUpdateSearch(int empId)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("select * from EmployeeDetails Where EmployeeId=" + empId, Connection);
                reader = Command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string[] data = new string[7];

            if (reader.Read())
            {
                data[0] = reader[1].ToString();
                data[1] = reader[4].ToString();
                data[2] = reader[5].ToString();
                data[3] = reader[6].ToString();
                data[4] = reader[7].ToString();
                data[5] = reader[10].ToString();
                data[6] = reader[11].ToString();
            }
            else
            {
                MessageBox.Show("Employee Id Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return data;
        }

        //Update Employee Details

        public int UpdateEmployeeDetails(int empId,int age,string mobileNumber,string department,string designation,string email,string address)
        {
            int y = 0;
            try
            {
                Connection.Close();
                Connection.Open();


                Command = new SqlCommand("update EmployeeDetails set EmployeeAge=@age,EmployeePhoneNumber=@mobileNumber,EmployeeDepartment=@department,EmployeeDesignation=@designation,EmployeeEmail=@email,EmployeeAddress=@address where EmployeeId=@empId", Connection);
                Command.Parameters.AddWithValue("@empId", empId);
                Command.Parameters.AddWithValue("@age", age);
                Command.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                Command.Parameters.AddWithValue("@department", department);
                Command.Parameters.AddWithValue("@designation", designation);
                Command.Parameters.AddWithValue("@email", email);
                Command.Parameters.AddWithValue("@address", address);               
                y = Command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return y;
        }

        //Getr values For Ex-Employee Details
        public string[] GetExEmployeeDetail(int empId)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("select * from EmployeeDetails Where EmployeeId=" + empId, Connection);
                reader = Command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string[] data = new string[12];

            if (reader.Read())
            {
                data[0] = reader[0].ToString();
                data[1] = reader[1].ToString();
                data[2] = reader[2].ToString();
                data[3] = reader[3].ToString();
                data[4] = reader[4].ToString();
                data[5] = reader[5].ToString();
                data[6] = reader[6].ToString();
                data[7] = reader[7].ToString();
                data[8] = reader[8].ToString();
                data[9] = reader[9].ToString();
                data[10] = reader[10].ToString();
                data[11] = reader[11].ToString();
            }
           
            return data;
        }

        //inserty values into Ex-Employee Details
        public void InsertExEmployeeDetails(string eid,string empname, string empgender, string empdob, string empage, string empphno, string empdept, string empdesign, string empExperience, string empjoindate, string empemail, string empaddress)
        {           
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("insert into ExEmployeeDetails values(@eid,@empname,@empgender,@empdob,@empage,@empphno,@empdept,@empdesign,@empExperience,@empjoindate,@empemail,@empaddress)", Connection);

                Command.Parameters.AddWithValue("@eid", eid);
                Command.Parameters.AddWithValue("@empname", empname);
                Command.Parameters.AddWithValue("@empgender", empgender);
                Command.Parameters.AddWithValue("@empdob", empdob);
                Command.Parameters.AddWithValue("@empage", empage);
                Command.Parameters.AddWithValue("@empphno", empphno);
                Command.Parameters.AddWithValue("@empdept", empdept);
                Command.Parameters.AddWithValue("@empdesign", empdesign);
                Command.Parameters.AddWithValue("@empExperience", empExperience);
                Command.Parameters.AddWithValue("@empjoindate", empjoindate);
                Command.Parameters.AddWithValue("@empemail", empemail);
                Command.Parameters.AddWithValue("@empaddress", empaddress);
                Command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //Delete Employee Details 
        public void DeleteEmployeeDetails(int empId)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("delete from EmployeeDetails Where EmployeeId= " + empId, Connection);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            int y = Command.ExecuteNonQuery();
            if(y == 0)
            {
                MessageBox.Show("Employee Id Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }       

        //Show Employee Payment Details from EmployeeDataSheet Table on DataGridView in EmployeePaymentForm
        public DataTable showEmployeePaydetails()
        {
            adapter = new SqlDataAdapter("select * from EmployeePaymentDetail", Connection);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }

       

        //Employee Login using Name and Mobile Number in EmployeeLoginForm
        public bool EmployeeLogin(string employeeName,string employeeMobile)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("select * from EmployeeDetails where EmployeeName='" + employeeName + "'and EmployeePhoneNumber='" + employeeMobile + "'", Connection);
                reader = Command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (reader.Read())
            {
               MessageBox.Show("Welcome " + employeeName + "!");
                return true;
            }
            else
            {
                MessageBox.Show("Not Valid!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;              
            }
        }

        //Show Employee  Details After Empoyee Login in EmployeePageForm 
        public DataTable showEmployeedetails(string num)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                adapter = new SqlDataAdapter("select E.EmployeeId,E.EmployeeName,E.Gender,E.EmployeePhoneNumber,E.EmployeeDateOfBirth,E.EmployeeAge,E.EmployeePhoneNumber,E.EmployeeDepartment,E.EmployeeDesignation,E.EmployeeExperience,E.EmployeeJoindate,E.EmployeeEmail,E.EmployeeAddress,P.SalaryDate,P.PresentDays,P.AbsentDays,P.BasicPay,P.HouseRentAllowance,P.BonusAmount,P.EmployeeProvidentFund,P.Salary,P.Performance from EmployeeDetails E inner join EmployeePaymentDetails p on E.EmployeePhoneNumber=P.EmployeePhoneNumber  where E.EmployeePhoneNumber='" + num + "'"
    , Connection);
                table = new DataTable();
                adapter.Fill(table);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        //Get Employee Name for show in the label 
        public string GetEmployeeName(string empMobileNumber)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("select EmployeeName from EmployeeDetails where EmployeePhoneNumber='" + empMobileNumber + "'", Connection);
                reader = Command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string[]name=new string[1];

           if(reader.Read())
            {
                name[0] = reader[0].ToString();
            }
           
            string employeeName = name[0].ToString();
            return employeeName;
        }

        //Get Employee details for add to the suggestion details
        public string[] GetEmployeeDetail(string empMobileNumber)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                Command = new SqlCommand("select EmployeeId,EmployeeName,EmployeeEmail from EmployeeDetails where EmployeePhoneNumber='" + empMobileNumber + "'", Connection);
                reader = Command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string[] data = new string[5];

            if (reader.Read())
            {
                data[0] = reader[0].ToString();
                data[1] = reader[1].ToString();
                data[2] = reader[2].ToString();
            }
            return data;
        }

        //Insert the values into the Suggestion details
        public void InsertSuggestionDetails(int empId, string empName, string mobNo, string email, string suggestionDate, string suggestionName, string suggestionDescription)
        {
            try
            {
                Connection.Close();
                Connection.Open();

                Command = new SqlCommand("insert into EmployeeSuggestionDetails values(@empId,@empName,@empPhNo,@empEmail,@empsuggestionDate,@empsuggestionName,@empsuggestionDescription)", Connection);
                Command.Parameters.AddWithValue("@empId", empId);
                Command.Parameters.AddWithValue("@empName", empName);
                Command.Parameters.AddWithValue("@empPhNo", mobNo);
                Command.Parameters.AddWithValue("@empEmail", email);
                Command.Parameters.AddWithValue("@empsuggestionDate", suggestionDate);
                Command.Parameters.AddWithValue("@empsuggestionName", suggestionName);
                Command.Parameters.AddWithValue("@empsuggestionDescription", suggestionDescription);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            int y = Command.ExecuteNonQuery();
            if (y == 1)
            {
                MessageBox.Show("Your Suggestion Succesfuuly Sumitted.We will Consider this.");
            }
            else
            {
                MessageBox.Show("Your Suggestion Not Sumitted..!");
            }
        }

        public DataTable IdPersonalDetails(int employeeId)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                adapter = new SqlDataAdapter("select * from EmployeeDetails Where EmployeeId=" + employeeId, Connection);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            table = new DataTable();
            int x = adapter.Fill(table);
            if (x == 0)
            {
                MessageBox.Show("Employee Id Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return table;
        }

        public DataTable IdBankDetails(int employeeId)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                adapter = new SqlDataAdapter("select * from EmployeeBankDetails Where EmployeeId=" + employeeId, Connection);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            table = new DataTable();
            int x = adapter.Fill(table);
            if (x == 0)
            {
                MessageBox.Show("Employee Id Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return table;
        }
        public DataTable IdSuggestionDetails(int employeeId)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                adapter = new SqlDataAdapter("select * from EmployeeSuggestionDetails Where EmployeeId=" + employeeId, Connection);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            table = new DataTable();
            int x = adapter.Fill(table);
            if (x == 0)
            {
                MessageBox.Show("Employee Id Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return table;
        }
        public DataTable IdSalaryDetails(int employeeId)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                adapter = new SqlDataAdapter("select * from EmployeePaymentDetails Where EmployeeId=" + employeeId, Connection);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            table = new DataTable();
            int x = adapter.Fill(table);
            if (x == 0)
            {
                MessageBox.Show("Employee Id Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return table;
        }
        public DataTable PersonalDetails()
        {
            adapter = new SqlDataAdapter("select * from EmployeeDetails", Connection);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable BankDetails()
        {
            adapter = new SqlDataAdapter("select * from EmployeeBankDetails", Connection);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SuggestionDetails()
        {
            adapter = new SqlDataAdapter("select * from EmployeeSuggestionDetails", Connection);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SalaryDetails()
        {
            adapter = new SqlDataAdapter("select * from EmployeePaymentDetails", Connection);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SpecifiedEmployeeDetails(string department,string designation)
        {
            try
            {
                Connection.Close();
                Connection.Open();
                adapter = new SqlDataAdapter("select E.EmployeeId,E.EmployeeName,E.Gender,E.EmployeePhoneNumber,E.EmployeeDateOfBirth,E.EmployeeAge,E.EmployeePhoneNumber,E.EmployeeDepartment,E.EmployeeDesignation,E.EmployeeExperience,E.EmployeeJoindate,E.EmployeeEmail,E.EmployeeAddress,P.SalaryDate,P.PresentDays,P.AbsentDays,P.BasicPay,P.HouseRentAllowance,P.BonusAmount,P.EmployeeProvidentFund,P.Salary,P.Performance from EmployeeDetails E inner join EmployeePaymentDetails p on E.EmployeePhoneNumber=P.EmployeePhoneNumber  where E.EmployeeDepartment='" + department + "' AND E.EmployeeDesignation='"+designation+"'"
    , Connection);               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            table = new DataTable();
            int x = adapter.Fill(table);
            if (x == 0)
            {
                MessageBox.Show("Data Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return table;
        }
        public DataTable ShowExEmployeeDetails()
        {
            adapter = new SqlDataAdapter("select * from ExEmployeeDetails", Connection);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
