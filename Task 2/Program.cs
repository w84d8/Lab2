class Program
{
    static void Main()
    {
        Converter converter = new Converter(28.0, 33.5, 7.8);

        double amountInUah = 1000.0;
        double amountInUsd = converter.ConvertToUsd(amountInUah);
        double amountInEur = converter.ConvertToEur(amountInUah);
        double amountInPln = converter.ConvertToPln(amountInUah);

        Console.WriteLine($"{amountInUah} uah = {amountInUsd} usd");
        Console.WriteLine($"{amountInUah} uah = {amountInEur} eur");
        Console.WriteLine($"{amountInUah} uah = {amountInPln} pln");

        double amountInUsdToUah = converter.ConvertFromUsd(50.0);
        double amountInEurToUah = converter.ConvertFromEur(40.0);
        double amountInPlnToUah = converter.ConvertFromPln(30.0);

        Console.WriteLine($"{50.0} usd = {amountInUsdToUah} uah");
        Console.WriteLine($"{40.0} eur = {amountInEurToUah} uah");
        Console.WriteLine($"{30.0} pln = {amountInPlnToUah} uah");
    }
}
