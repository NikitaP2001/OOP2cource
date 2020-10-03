using System;
using System.Runtime.InteropServices;

class Converter
{
    public Converter(double usd, double eur)
    {
        dollarmult = usd;
        euromult = eur;
    }
    public double FromEuro(double count)
    {
        return Math.Round(count * euromult,2);
    }
    public double ToEuro(double count)
    {
        return Math.Round(count / euromult, 2);
    }
    public double FromDollar(double count)
    {
        return Math.Round(count * dollarmult, 2);
    }
    public double ToDollar(double count)
    {
        return Math.Round(count / dollarmult, 2);
    }
    double dollarmult;
    double euromult;
}
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter Convert = new Converter(28.32, 33.26);
            Console.WriteLine("to euro " + Convert.ToEuro(1.04) + "\n" +
                              "from euro " + Convert.FromEuro(5) + "\n" +
                              "to dollar " + Convert.ToDollar(4) + "\n" +
                              "from dollar " + Convert.FromDollar(6) + "\n"
                );
        }
    }
}
