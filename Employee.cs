using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolfgraphicsLLC_Employee_login_Register_Information_Bonus_System
{
   public class Employee
    {
        public Employee(string name, int id, string title, string gender, string eMail, int phone, string address, int password )
        {
            Employee_Name = name;
            EmployeeID = id;
            EmployeeTitle = title;
            EmployeeGender = gender;
            EmailAddress = eMail;
            EmployeePhone = phone;
            EmployeeAddress = address;
            EmployeePassword = password;
        }
        public string Employee_Name { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeGender { get; set; }
        public string EmailAddress { get; set; }
        public int EmployeePhone { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmployeePassword { get; set; }


        public override string ToString()
        {
            return "Employee Name:" + Employee_Name + "\r\n" +
                   "Employee ID: " + EmployeeID + "\r\n" +
                   "Job Title:" + EmployeeTitle + "\r\n" +
                   "Gender:" + EmployeeGender + "\r\n" +
                   "Email:" + EmailAddress + "\r\n" +
                   "Address: " + EmployeeAddress + "\r\n" +
                   "Password:" + EmployeePassword + "\r\n";
        }

    }
}
