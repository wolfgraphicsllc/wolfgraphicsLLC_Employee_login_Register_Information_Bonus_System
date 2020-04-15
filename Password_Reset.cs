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
    public partial class Password_Reset : Form
    {
        public Password_Reset(string id)
        {
            InitializeComponent();
            EmployeeIDOutput_label.Text = id;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Password_Reset_Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
           wolfgraphicsLLC_Employee_Information ss = new wolfgraphicsLLC_Employee_Information(EmployeeIDOutput_label.Text);
            ss.Show();
        }

        private void Password_Reset_Save_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
