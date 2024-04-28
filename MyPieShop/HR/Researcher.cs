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
    }
}
