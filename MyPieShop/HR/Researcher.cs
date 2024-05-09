using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPieShop.HR
{
    internal class Researcher : Employee
    {
        public Researcher(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }
        private int numberOfpieTasteInvented = 0;
        public int NumberOfPieTastsInvented
        {
            get { return numberOfpieTasteInvented; }
            private set { numberOfpieTasteInvented = value; }
        }
        public void ResearchNewPieTaste(int researchHours)
        {
            numbersOfHoursWorked += researchHours;
            if (new Random().Next(100) > 50)
            {
                numberOfpieTasteInvented++;
                Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie taste total number of pie taste invented: {numberOfpieTasteInvented}");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is working on a new pie taste");
            }

        }
    }
}
