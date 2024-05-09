using MyPieShop.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPieShop
{
    internal class Utilities
    {
        //public static void usingEscapeCharacters()
        //{
        //    string firstName = "Nathaniel";
        //    string lastName = "Osana";

        //    string displayName = $"Welcome!\n{firstName}\t{lastName}";
        //    Console.WriteLine(displayName);

        //}

        //public static void manipulatingString()
        //{
        //    string firstName = "Nathaniel";
        //    string lastName = "Osana";

        //    string fullName = firstName + " " + lastName;
        //    string emloyeeIdentification = String.Concat(firstName, lastName);
        //    string empId = firstName.ToLower() + " " + lastName.Trim().ToLower();
        //    int length = empId.Length;
        //    if (fullName.Contains("nath") || fullName.Contains("Nath"))
        //    {
        //        Console.WriteLine("It is Nathaniel");
        //    }

        //    string subString = fullName.Substring(1, 3);
        //    Console.WriteLine("characters 2 to 4 of full name are :" + subString);
        //}




        //public static void usingNamedParameters()
        //{
        //    int amount = 1234;
        //    int month = 12;
        //    int bonus = 500;

        //    int yearlyWage = calculateYearlyWageWithNamed(bonus: bonus, monthlyWage: amount, noOfMonthWorked: month);
        //    Console.WriteLine($"yearly wage is : {yearlyWage}");
        //}

        //public static int calculateYearlyWageWithNamed(int monthlyWage, int noOfMonthWorked, int bonus = 0)
        //{
        //    int result = monthlyWage * noOfMonthWorked + bonus;

        //    return result;
        //}


        //public static void usingOptionalParameters()
        //{
        //    int amount = 1248;
        //    int month = 12;

        //    int yearlyWage = calculateYearlyWageWithOptional(amount, month);
        //    Console.WriteLine($"yearly wage is : {yearlyWage}");
        //}

        //public static int calculateYearlyWageWithOptional(int monthlyWage, int noOfMonthWorked, int bonus = 0)
        //{
        //    int result = monthlyWage * noOfMonthWorked + bonus;

        //    return result;
        //}
        //public static int calculateYearlyWage(int monthlyWage, int noOfMonthWorked)
        //{
        //    int result = monthlyWage * noOfMonthWorked;
        //    //Console.WriteLine("your monthly wage is :" + " " + result);

        //    if (noOfMonthWorked == 12)
        //    {
        //        int result1 = monthlyWage * (noOfMonthWorked + 1);
        //        return result1;
        //    }
        //    return result;
        //}
        //public static int calculateYearlyWage(int monthlyWage, int noOfMonthWorked, int bonus)
        //{
        //    int result = monthlyWage * noOfMonthWorked + bonus;

        //    return result;
        //}
        //public static double calculateYearlyWage(double monthlyWage, double noOfMonthWorked, double bonus)
        //{
        //    double result = monthlyWage * noOfMonthWorked + bonus;

        //    return result;
        //}

        internal static void RegisterEmployees(List<Employee> employees)
        {
            Console.WriteLine("create an employee");
            Console.WriteLine("what type of employee do you want to register?");
            Console.WriteLine("1: employee\n2: manager\n3: store manager\n4: researcher\n5: junior researcher");
            Console.WriteLine("your selection: ");

            string employeeType = Console.ReadLine();
            if (employeeType != "1" && employeeType != "2" && employeeType != "3" && employeeType != "4" && employeeType != "5")
            {
                Console.WriteLine("invalid selection");
                return;
            }

            Console.WriteLine("enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("enter email");
            string email = Console.ReadLine();

            Console.WriteLine("enter birth day");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("enter hourly rate");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);

            Employee employee = null;
            switch (employeeType)
            {
                case "1":
                    employee = new Employee(firstName, lastName, email, birthDay, rate);
                    break;
                case "2":
                    employee = new Manager(firstName, lastName, email, birthDay, rate);
                    break;
                case "3":
                    employee = new StoreManager(firstName, lastName, email, birthDay, rate);
                    break;
                case "4":
                    employee = new Researcher(firstName, lastName, email, birthDay, rate);
                    break;
                case "5":
                    employee = new JuniorResearcher(firstName, lastName, email, birthDay, rate);
                    break;
            }
            employees.Add(employee);
            Console.WriteLine("employee created!");
        }
        internal static void checkForExistingEmployeeFile(List<Employee> employees) { }
        internal static void ViewAllEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {

                employees[i].DisplayEmployeeDetails();
            }

        }
        internal static void SaveEmployees(List<Employee> employees) { }
        internal static void LoadEmployees(List<Employee> employees) { }
    }
}
