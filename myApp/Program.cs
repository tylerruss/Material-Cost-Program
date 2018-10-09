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
       double area;

        Console.WriteLine();
        Console.WriteLine("Materials: carpet, wood, tile, pvc, concrete, brick, stone, granite, marble");
        Console.WriteLine();
        Console.Write("Please enter floor material: ");

            material = Console.ReadLine();

            Console.Write("Please enter the width of the room: ");

            width = double.Parse(Console.ReadLine());

            Console.Write("Please enter the length of the room: ");

            length = double.Parse(Console.ReadLine());

            area = length * width;


            
           

            //returns price of material
            //returns area
            //returns material's price per square foot * length * width 

           if (material == "carpet")
           
           {
               Console.WriteLine();
               Console.WriteLine("Price of carpet: $" + dict["carpet"]  + " per square foot");
               Console.WriteLine("Total Area = " + area + " sq ft");
               Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + dict["carpet"] * area);
               Console.WriteLine("Total Cost w/ installation = $" + area * dict["carpet"] * 1.8);
               Console.WriteLine();
           }

           else if (material == "wood")

         {
                Console.WriteLine();
                Console.WriteLine("Price of wood: $" + dict["wood"] + " per square foot");
                Console.WriteLine("Total Area = " + area + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + dict["wood"] * area);
                Console.WriteLine("Total Cost w/ installation = $" + area * dict["wood"] * 1.8);
                Console.WriteLine();
         }

          else if (material == "tile")

         {
                Console.WriteLine();
                Console.WriteLine("Price of tile: $" + dict["tile"] + " per square foot");
                Console.WriteLine("Total Area = " + area + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + dict["tile"] * area);
                Console.WriteLine("Total Cost w/ installation = $" + area * dict["tile"] * 1.8);
                Console.WriteLine();
         }
         
          else if (material == "pvc")
         {
                Console.WriteLine();
                Console.WriteLine("Price of pvc: $" + dict["pvc"] + " per square foot");
                Console.WriteLine("Total Area = " + area + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + dict["pvc"] * area);
                Console.WriteLine("Total Cost w/ installation = $" + area * dict["pvc"] * 1.8);
                Console.WriteLine();
         }

          else if (material == "brick")
         {
                Console.WriteLine();
                Console.WriteLine("Price of brick: $" + dict["brick"] + " per square foot");
                Console.WriteLine("Total Area = " + area + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + dict["brick"] * area);
                Console.WriteLine("Total Cost w/ installation = $" + area * dict["brick"] * 1.8);
                Console.WriteLine();
         }

          else if (material == "stone")
         {
                Console.WriteLine();
                Console.WriteLine("Price of stone: $" + dict["stone"] + " per square foot");
                Console.WriteLine("Total Area = " + area + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + dict["stone"] * area);
                Console.WriteLine("Total Cost w/ installation = $" + area * dict["stone"] * 1.8);
                Console.WriteLine();
         }

          else if (material == "granite")
         {
                Console.WriteLine();
                Console.WriteLine("Price of granite: $" + dict["granite"] + " per square foot");
                Console.WriteLine("Total Area = " + area + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + dict["granite"] * area);
                Console.WriteLine("Total Cost w/ installation = $" + area * dict["granite"] * 1.8);
                Console.WriteLine();
         }

         else if (material == "marble")
         {
                Console.WriteLine();
                Console.WriteLine("Price of marble: $" + dict["marble"] + " per square foot");
                Console.WriteLine("Total Area = " + area + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + dict["marble"] * area);
                Console.WriteLine("Total Cost w/ installation = $" + area * dict["marble"] * 1.8);
                Console.WriteLine();
         }

         else {

             Console.WriteLine("Invalid material");
         }
      }
    }
 }