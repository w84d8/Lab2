using System;

class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary;

        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 50000;
                break;
            case "developer":
                baseSalary = 60000;
                break;
            default:
                Console.WriteLine("Wrong position.");
                return;
        }

        double salary = baseSalary + (experience * 1000);

        double tax = 0.15 * salary;

        Console.WriteLine($"Information about the employee:");
        Console.WriteLine($"LastName: {lastName}");
        Console.WriteLine($"FirstName: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Tax: {tax}");
    }
}