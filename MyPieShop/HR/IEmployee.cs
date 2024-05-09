using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPieShop.HR
{
    internal interface IEmployee
    {
        double RecieveWage(bool resetHours = true);
        void GiveBonus();
        void DisplayEmployeeDetails();
        void PerformWork();
        void PerformWork(int numberOfHours);
        void GiveComplement();
    }
}
