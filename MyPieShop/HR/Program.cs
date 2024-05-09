// See https://aka.ms/new-console-template for more information

using MyPieShop;
using MyPieShop.HR;

//Employee.taxRate = 0.2;
//Console.WriteLine("creating an employee");
//Console.WriteLine("-------------\n");

//IEmployee Nathaniel = new Manager("Nathaniel", "Osana", "nathanielosana@gmail.com", new DateTime(1993, 5, 5), 25);
//IEmployee Racheal = new Researcher("Racheal", "Uyi", "rachealuyi@gmail.com", new DateTime(2000, 5, 25), 25);
//IEmployee Osahon = new Employee("Osahon", "Ighodaro", "OsahonIghodaro@gmail.com", new DateTime(1990, 5, 6), 25);
//IEmployee Favour = new Employee("Favour", "Ighodaro", "favourighodaro@gmail.com", new DateTime(1998, 5, 5), 25, "new street", "112", "123456", "port ville");
//IEmployee Peculiar = new Employee("Peculiar", "Osana", "peculiarosana@gmail.com", new DateTime(1995, 2, 1), 25);
//IEmployee Divine = new Employee("Divine", "Favour", "divinefavour@gmail.com", new DateTime(2000, 5, 3), 25);
//IEmployee Royalty = new JuniorResearcher("Royalty", "Uyi", "royaltyuyi@gmail.com", new DateTime(2003, 7, 19), 25);




////Osahon.displayEmployeeDetails();
////Osahon.performWork(8);
////Osahon.performWork();
////Osahon.performWork(3);
////Osahon.performWork();

////Nathaniel.displayEmployeeDetails();
////Nathaniel.performWork(25);
////Nathaniel.performWork();
////Nathaniel.performWork();
////Nathaniel.performWork();
//////Nathaniel.AttendManagementMeetings();

////Royalty.ResearchNewPieTaste(5);
////Royalty.ResearchNewPieTaste(5);


////List<int> employeeIds = new List<int>();
////Console.WriteLine("how many employee IDs do you want to enter:");
////int length = int.Parse(Console.ReadLine());
////for (int i = 0; i < length; i++)
////{
////    Console.WriteLine("enter the employee id:");
////    int id = int.Parse(Console.ReadLine());
////    employeeIds.Add(id);
////}

//List<IEmployee> employees = new List<IEmployee>();


//employees.Add(Racheal);
//employees.Insert(0, Nathaniel);
//employees.Add(Osahon);
//employees.Add(Favour);
//employees.Add(Peculiar);
//employees.Add(Divine);
//employees.Add(Royalty);

//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    employee.GiveBonus();
//    employee.GiveComplement();
//}
List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("****************************");
Console.WriteLine("* My Pie Shop Employee App *");
Console.WriteLine("****************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.checkForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"loaded {employees.Count} employee(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("****************************");
    Console.WriteLine("select an option");
    Console.WriteLine("****************************");

    Console.WriteLine("1: register employee");
    Console.WriteLine("2: view all employee");
    Console.WriteLine("3: save data");
    Console.WriteLine("4: load data");
    Console.WriteLine("9: quit application");
    Console.WriteLine("your selection: ");

    userSelection = Console.ReadLine();
    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployees(employees); break;
        case "2":
            Utilities.ViewAllEmployees(employees); break;
        case "3":
            Utilities.SaveEmployees(employees); break;
        case "4":
            Utilities.LoadEmployees(employees); break;
        case "9":
            break;
        default:
            Console.WriteLine("Invalid selection please try again");
            break;

    }

}
while (userSelection != "9");
Console.WriteLine("thanks for using the application");