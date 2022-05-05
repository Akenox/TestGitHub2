using exo1;
using System;

namespace TP03
{
    class Program
    {
        static void Main(string[] args)
        {
            Product t = new Product("SP01", "Smartphone FaitIUT0121", 250, (float)0.20);
            Console.WriteLine(t.Name + "   " + t.PriceET);
            t.PriceIT = 200;
            Console.WriteLine("PriceET = " + t.PriceET);
            t.Name = "Smartphone Galaxy S20";
            Console.WriteLine(t.Name);
            Console.WriteLine("hey");

        }


    }
}
