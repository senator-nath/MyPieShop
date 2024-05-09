using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPieShop.HR
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }
        public void AttendManagementMeetings()
        {
            numbersOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting");
        }
        public override void GiveBonus()
        {
            if (numbersOfHoursWorked > 5)
            {
                Console.WriteLine($"Manager {FirstName} {LastName} recieve a management bonous of 500;");
            }
            else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} recieve a management bonous of 500;");
            }
        }
    }
}
