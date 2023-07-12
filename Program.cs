using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Employee Name:");
        string employeeName = Console.ReadLine();

        Console.WriteLine("Employee Gender (M/F):");
        char employeeGender = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Employee Salary:");
        double employeeSalary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("DOJ (DD/MM/YYYY):");
        DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.WriteLine("You have to pay...");

        double taxPercentage = (employeeSalary > 90000) ? 0.3 : 0.15;
        double taxAmount = employeeSalary * taxPercentage;

        Console.WriteLine("Employee Name: {0}", employeeName);
        Console.WriteLine("Employee Gender: {0}", employeeGender);
        Console.WriteLine("Employee Salary: {0}", employeeSalary.ToString("C2"));
        Console.WriteLine("Date of Joining: {0}", dateOfJoining.ToString("dd/MM/yyyy"));
        Console.WriteLine("Tax Amount: {0}", taxAmount.ToString("C2"));

        Console.ReadLine();
    }
}