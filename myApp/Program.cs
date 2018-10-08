using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
      static void Main(String[] args)
    {

        Dictionary<string, int> dict = new Dictionary<string, int>()
         {
             {"carpet", 2},
             {"wood", 3}, 
             {"tile", 5}, 
             {"pvc", 2}, 
             {"concrete", 4},
             {"brick", 6},
             {"stone", 7},
             {"granite", 9},
             {"marble", 11}
             
         };


       String material;
       double length;
       double width;

       Console.Write("Please enter material: ");

            material = Console.ReadLine();

            Console.Write("Please enter the width of the room: ");

            width = double.Parse(Console.ReadLine());

            Console.Write("Please enter the length of the room: ");

            length = double.Parse(Console.ReadLine());

            //returns material's price per square foot * length * width
           if (material == "carpet")
           
           {
               Console.WriteLine("Total Cost = $" + dict["carpet"] * length * width);
           }
           else if (material == "wood")
         {
                
                Console.WriteLine("Total Cost = $" + dict["wood"] * length * width);
         }

         else {
             Console.WriteLine("Invalid material");
         }
      }
    }
 }