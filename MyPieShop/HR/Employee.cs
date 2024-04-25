using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPieShop.HR
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        public int numbersOfHoursWorked;
        private double wage;
        private double hourlyRate;

        private DateTime birthday;
        private EmployeeType employeeType;
        public static double taxRate = 0.15;

        const int minimalHourWorked = 1;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int NumbersOfHoursWorked { get { return numbersOfHoursWorked; } set { numbersOfHoursWorked = value; } }
        public double Wage { get { return wage; } set { wage = value; } }
        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;

                }
            }

        }
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
        public EmployeeType EmployeeType { get { return employeeType; } set { employeeType = value; } }



        public Employee(string firstName, string lastName, string email, DateTime birthDay) : this(firstName, lastName, email, birthDay, 0, EmployeeType.StoreManager)
        {


        }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate, EmployeeType employeeType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthDay;
            HourlyRate = hourlyRate;
            EmployeeType = employeeType;
        }

        public void performWork()
        {
            performWork(minimalHourWorked);
        }
        public void performWork(int numberOfHours)
        {
            numbersOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }
        public double recieveWage(bool restHours = true)
        {
            double wageBeforeTax = 0.0;
            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {FirstName} is a manager");
                wageBeforeTax = numbersOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wageBeforeTax = numbersOfHoursWorked * hourlyRate;
            }
            double taxAmount = wageBeforeTax * taxRate;
            wage = wageBeforeTax - taxAmount;
            Console.WriteLine($"{FirstName} {LastName} has received a wage of {wage} for{numbersOfHoursWorked} hour(s) of work");
            if (restHours)

                numbersOfHoursWorked = 0;
            return wage;

        }
        public void displayEmployeeDetails()
        {
            Console.WriteLine($"\nfirst name:\t{FirstName} \nlast name: \t{LastName} \nemail: \t{Email} \nbirthday:\t{Birthday.ToShortDateString()}\n tax rate: \t{taxRate}");


        }
        public static void DisplayTaskRate()
        {
            Console.WriteLine($"the current tax rate is {taxRate}");
        }
    }
}



