class Program
{
    static void Main()
    {
        Employee employee = new Employee("Sergay", "Serezha");

        employee.CalculateSalaryAndTax("manager", 3);
    }
}