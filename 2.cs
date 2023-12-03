using System;

class Converter
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

    public double ConvertToUSD(double amountInUah)
    {
        return amountInUah / usdRate;
    }

    public double ConvertToEUR(double amountInUah)
    {
        return amountInUah / eurRate;
    }

    public double ConvertToPLN(double amountInUah)
    {
        return amountInUah / plnRate;
    }

    public double ConvertFromUSD(double amountInUSD)
    {
        return amountInUSD * usdRate;
    }

    public double ConvertFromEUR(double amountInEUR)
    {
        return amountInEUR * eurRate;
    }

    public double ConvertFromPLN(double amountInPLN)
    {
        return amountInPLN * plnRate;
    }
}

class Program
{
    static void Main()
    {
        // Ініціалізація об'єкта Converter з курсами валют відносно гривні
        Converter converter = new Converter(27.5, 31.8, 7.3);

        // Конвертація з гривні в інші валюти
        double amountInUah = 1000;
        double usdAmount = converter.ConvertToUSD(amountInUah);
        double eurAmount = converter.ConvertToE
