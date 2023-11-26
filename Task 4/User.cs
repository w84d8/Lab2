using System;

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("User information:");
        Console.WriteLine($"Login: {login}");
        Console.WriteLine($"FirstName: {firstName}");
        Console.WriteLine($"LastName: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Date of filling in the form: {registrationDate}");
    }
}