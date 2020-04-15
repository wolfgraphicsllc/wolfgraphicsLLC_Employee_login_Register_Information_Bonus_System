using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wolfgraphicsLLC_Employee_login_Register_Information_Bonus_System
{
    public partial class wolfgraphicsLLC_Employee_Information : Form
    {
        public wolfgraphicsLLC_Employee_Information(string id)
        {
            InitializeComponent();
            EmployeeIDOutput_label.Text = id;

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeInfoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form ss = new Login_Form();
            ss.Show();
        }

        private void ResetBonus_Click(object sender, EventArgs e)
        {

            this.Hide();
            BonusTabulator ss = new BonusTabulator(EmployeeIDOutput_label.Text);
            ss.Show();
        }

        private void PassworReset_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Password_Reset ss = new Password_Reset(EmployeeIDOutput_label.Text);
            ss.Show();
        }
    }
}
