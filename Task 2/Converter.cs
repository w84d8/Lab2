﻿public class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToUsd(double uah)
    {
        return uah / usdRate;
    }

    public double ConvertToEur(double uah)
    {
        return uah / eurRate;
    }

    public double ConvertToPln(double uah)
    {
        return uah / plnRate;
    }

    public double ConvertFromUsd(double usd)
    {
        return usd * usdRate;
    }

    public double ConvertFromEur(double eur)
    {
        return eur * eurRate;
    }

    public double ConvertFromPln(double pln)
    {
        return pln * plnRate;
    }
}
