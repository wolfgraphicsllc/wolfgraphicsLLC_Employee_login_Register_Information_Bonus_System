using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wolfgraphicsLLC_Employee_login_Register_Information_Bonus_System
{
   
    public partial class Employee_Registration : Form
    {
        public Employee_Registration()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeRegistrationBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form ss = new Login_Form();
            ss.Show();
        }

        // added on 4/10/2020 estimate taking 45 min to implament
        // took 15 min
        // found this script at : https://www.youtube.com/watch?v=kF0jleGpH60
        private void Email_textBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z]\\.)+a-zA-Z]{2,9})$";
            if(Regex.IsMatch(Email_textBox.Text,pattern))
            {
                Email_errorProvider.Clear();
            }
            else
            {
                Email_errorProvider.SetError(this.Email_textBox,"Invalid E-Email! Please Enter a Valid E-Mail!");
                return;
            }
            
        }

        private void GenarateID_button_Click(object sender, EventArgs e)
        {
            Random rand = new Random();


            EmployeeIDOutput_label.Text = rand.Next(9999, 99999).ToString();
           

        }

        
        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("EmployeeInformation.txt");

                outputFile.WriteLine(EmployeeIDOutput_label.Text);

                
                outputFile.Close();
              
                this.Hide();
                wolfgraphicsLLC_Employee_Information ss = new wolfgraphicsLLC_Employee_Information(EmployeeIDOutput_label.Text);
                ss.Show();

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
