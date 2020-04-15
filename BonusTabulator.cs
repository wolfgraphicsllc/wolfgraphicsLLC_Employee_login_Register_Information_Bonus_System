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
    public partial class BonusTabulator : Form
    {
        public BonusTabulator(string id)
        {
            InitializeComponent();
            EmpoyeeIDBonusOutput_label.Text = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Tabulate_button_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_button2_Click(object sender, EventArgs e)
        {
            
        }

        private void EmployeeBonusBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            wolfgraphicsLLC_Employee_Information ss = new wolfgraphicsLLC_Employee_Information(EmployeeIDOutput_label.Text);
            ss.Show();
        }
    

        private void EmpoyeeIDBonusOutput_label_Click(object sender, EventArgs e)
        {

        }
    }
}
