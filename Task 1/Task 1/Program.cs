﻿class Program
{
    static void Main()
    {
        Address myAddress = new Address();

        myAddress.Index = 12345;
        myAddress.Country = "Ukraine";
        myAddress.City = "Kyiv";
        myAddress.Street = "Pushkyna street";
        myAddress.House = "42";
        myAddress.Apartment = "18";

        Console.WriteLine($"Index: {myAddress.Index}");
        Console.WriteLine($"Country: {myAddress.Country}");
        Console.WriteLine($"City: {myAddress.City}");
        Console.WriteLine($"Street: {myAddress.Street}");
        Console.WriteLine($"House: {myAddress.House}");
        Console.WriteLine($"Apartment: {myAddress.Apartment}");
    }
}