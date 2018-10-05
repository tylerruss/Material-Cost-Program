using System;
using System.IO;

namespace myApp
{
    class Program
    {
      static void Main(String[] args)
    {
        double cost;
        Console.WriteLine("Please enter the door's width in inches: ");
       double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the door's height in inches: ");
       double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the door's price per sq feet: ");
        double price = double.Parse(Console.ReadLine());

        cost = width * height * price;

        Console.WriteLine("The price of the door will be: $" + cost);
        }
    }
}