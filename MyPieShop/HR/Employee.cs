using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPieShop.HR
{
    internal class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string email;

        public int numbersOfHoursWorked;
        private double wage;
        private double hourlyRate;

        private DateTime birthday;
        private Address address;

        public static double taxRate = 0.15;

        const int minimalHourWorked = 1;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int NumbersOfHoursWorked { get { return numbersOfHoursWorked; } protected set { numbersOfHoursWorked = value; } }
        public double Wage { get { return wage; } set { wage = value; } }

        public Address Address { get { return address; } set { address = value; } }
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




        public Employee(string firstName, string lastName, string email, DateTime birthDay) : this(firstName, lastName, email, birthDay, 0)
        {


        }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthDay;
            HourlyRate = hourlyRate;

        }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate, string street, string city, string houseNumber, string zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthDay;
            HourlyRate = hourlyRate;
            Address = new Address(street, city, houseNumber, zipCode);

        }

        public void PerformWork()
        {
            PerformWork(minimalHourWorked);
        }
        public void PerformWork(int numberOfHours)
        {
            numbersOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }
        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName}{LastName} recieve a generic bonus of 100");
        }
        public double RecieveWage(bool restHours = true)
        {
            double wageBeforeTax = 0.0;

            double taxAmount = wageBeforeTax * taxRate;
            wage = wageBeforeTax - taxAmount;
            Console.WriteLine($"{FirstName} {LastName} has received a wage of {wage} for{numbersOfHoursWorked} hour(s) of work");
            if (restHours)

                numbersOfHoursWorked = 0;
            return wage;

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nfirst name:\t{FirstName} \nlast name: \t{LastName} \nemail: \t{Email} \nbirthday:\t{Birthday.ToShortDateString()}\n tax rate: \t{taxRate}");


        }
        public static void DisplayTaskRate()
        {
            Console.WriteLine($"the current tax rate is {taxRate}");
        }

        public void GiveComplement()
        {
            Console.WriteLine($"you have done a great job {FirstName}");
        }
    }
}



