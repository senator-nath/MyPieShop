using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPieShop
{
    internal class Utilities
    {
        public static void usingEscapeCharacters()
        {
            string firstName = "Nathaniel";
            string lastName = "Osana";

            string displayName = $"Welcome!\n{firstName}\t{lastName}";
            Console.WriteLine(displayName);

        }

        public static void manipulatingString()
        {
            string firstName = "Nathaniel";
            string lastName = "Osana";

            string fullName = firstName + " " + lastName;
            string emloyeeIdentification = String.Concat(firstName, lastName);
            string empId = firstName.ToLower() + " " + lastName.Trim().ToLower();
            int length = empId.Length;
            if (fullName.Contains("nath") || fullName.Contains("Nath"))
            {
                Console.WriteLine("It is Nathaniel");
            }

            string subString = fullName.Substring(1, 3);
            Console.WriteLine("characters 2 to 4 of full name are :" + subString);
        }




        public static void usingNamedParameters()
        {
            int amount = 1234;
            int month = 12;
            int bonus = 500;

            int yearlyWage = calculateYearlyWageWithNamed(bonus: bonus, monthlyWage: amount, noOfMonthWorked: month);
            Console.WriteLine($"yearly wage is : {yearlyWage}");
        }

        public static int calculateYearlyWageWithNamed(int monthlyWage, int noOfMonthWorked, int bonus = 0)
        {
            int result = monthlyWage * noOfMonthWorked + bonus;

            return result;
        }


        public static void usingOptionalParameters()
        {
            int amount = 1248;
            int month = 12;

            int yearlyWage = calculateYearlyWageWithOptional(amount, month);
            Console.WriteLine($"yearly wage is : {yearlyWage}");
        }

        public static int calculateYearlyWageWithOptional(int monthlyWage, int noOfMonthWorked, int bonus = 0)
        {
            int result = monthlyWage * noOfMonthWorked + bonus;

            return result;
        }
        public static int calculateYearlyWage(int monthlyWage, int noOfMonthWorked)
        {
            int result = monthlyWage * noOfMonthWorked;
            //Console.WriteLine("your monthly wage is :" + " " + result);

            if (noOfMonthWorked == 12)
            {
                int result1 = monthlyWage * (noOfMonthWorked + 1);
                return result1;
            }
            return result;
        }
        public static int calculateYearlyWage(int monthlyWage, int noOfMonthWorked, int bonus)
        {
            int result = monthlyWage * noOfMonthWorked + bonus;

            return result;
        }
        public static double calculateYearlyWage(double monthlyWage, double noOfMonthWorked, double bonus)
        {
            double result = monthlyWage * noOfMonthWorked + bonus;

            return result;
        }

    }
}
