using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPieShop
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numbersOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthday;

        const int minimalHourWorked = 1;

        public void performWork()
        {
            performWork(minimalHourWorked);
        }
        public void performWork(int numberOfHours)
        {
            numbersOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }
        public double recieveWage(bool restHours = true)
        {
            wage = numbersOfHoursWorked * hourlyRate;
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for{numbersOfHoursWorked} hour(s) of work");
            if (restHours)

                numbersOfHoursWorked = 0;
            return wage;

        }
        public void displayEmployeeDetails()
        {
            Console.WriteLine($"\nfirst name:\t{firstName} \nlast name: \t{lastName} \nemail: \t{email} \nbirthday:\t{birthday.ToShortDateString()}")};
    }


}
