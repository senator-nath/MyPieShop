﻿// See https://aka.ms/new-console-template for more information

using MyPieShop.HR;

Employee.taxRate = 0.2;
Console.WriteLine("creating an employee");
Console.WriteLine("-------------\n");

Manager Nathaniel = new Manager("Nathaniel", "Osana", "nathanielosana@gmail.com", new DateTime(1993, 5, 5), 25);
Researcher Racheal = new Researcher("Racheal", "Uyi", "rachealuyi@gmail.com", new DateTime(2000, 5, 25), 25);
Employee Osahon = new Employee("Osahon", "Ighodaro", "OsahonIghodaro@gmail.com", new DateTime(1990, 5, 6), 25);
Employee Favour = new Employee("Favour", "Ighodaro", "favourighodaro@gmail.com", new DateTime(1998, 5, 5), 25);
Employee Peculiar = new Employee("Peculiar", "Osana", "peculiarosana@gmail.com", new DateTime(1995, 2, 1), 25);
Employee Divine = new Employee("Divine", "Favour", "divinefavour@gmail.com", new DateTime(2000, 5, 3), 25);
JuniorResearcher Royalty = new JuniorResearcher("Royalty", "Uyi", "royaltyuyi@gmail.com", new DateTime(2003, 7, 19), 25);







List<int> employeeIds = new List<int>();
Console.WriteLine("how many employee IDs do you want to enter:");
int length = int.Parse(Console.ReadLine());
for (int i = 0; i < length; i++)
{
    Console.WriteLine("enter the employee id:");
    int id = int.Parse(Console.ReadLine());
    employeeIds.Add(id);
}

List<Employee> employees = new List<Employee>();


employees.Add(Racheal);
employees.Insert(0, Nathaniel);
employees.Add(Osahon);
employees.Add(Favour);
employees.Add(Peculiar);
employees.Add(Divine);
employees.Add(Royalty);

foreach (Employee employee in employees)
{
    employee.displayEmployeeDetails();
}
