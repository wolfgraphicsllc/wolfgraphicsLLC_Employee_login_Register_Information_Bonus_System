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
    
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            wolfgraphicsLLC_Employee_Information ss = new wolfgraphicsLLC_Employee_Information(" ADD this latter");
            ss.Show();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Registration ss = new Employee_Registration();
            ss.Show();
        }
    }
}
