using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolfgraphicsLLC_Employee_login_Register_Information_Bonus_System
{
    public class Bonus : Employee
    {
        public Bonus(string name, int id, string title, string gender, string eMail, int phone, string address, int password, decimal anual, decimal simi, decimal quarter, int vacation, decimal jackpot)
            : base(name, id, title, gender, eMail, phone, address, password)
        {
            AnualBonus = anual;
            SimiAnualBonus = simi;
            QuarterlyBonus = quarter;
            ExtraVacationDays = vacation;
            JackPotBonus = jackpot;
        }

        public decimal AnualBonus { get; set; }
        public decimal SimiAnualBonus { get; set; }
        public decimal QuarterlyBonus { get; set; }
        public int ExtraVacationDays { get; set; }
        public decimal JackPotBonus { get; set; }

    }
}
