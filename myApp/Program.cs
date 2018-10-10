/*

    This program is written to find the estimated cost of 
    installing flooring. Floor types include: carpet, wood, 
    tile, pvc, concrete, brick, stone, granite, and marble.

    This program and its code is written and owned by Tyler Russ.

    This code can be reproduced for educational purposes.

 */

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace myApp
{
    class Program
    {
      static void Main(String[] args)
    {
            //Declare variables

            String material;
            String input;
            double length;
            double width;
            double area;

        Random rnd = new Random();

        //Create dictionary of materials and their estimated price per square foot

        Dictionary<string, int> dict = new Dictionary<string, int>()
         {
             {"carpet", rnd.Next(2, 5)},
             {"wood", rnd.Next(2, 7)}, 
             {"tile", rnd.Next(4, 8)}, 
             {"pvc", rnd.Next(2, 5)}, 
             {"concrete", rnd.Next(3, 10)},
             {"brick", rnd.Next(4, 9)},
             {"stone", rnd.Next(5, 10)},
             {"granite", rnd.Next(8, 12)},
             {"marble", rnd.Next(10, 15)}
             
         };

         //Request user input on whether they want to import a csv file 
         //or enter each room individually

        Console.WriteLine("\nWould you like to import a csv or enter by individually?");
        Console.Write("Please enter 'csv' or 'individual': ");
        input = Console.ReadLine();

            //If the user enters individual, then it will run a script requesting 
            //the material, the width and the length of the room

            if (input == "individual")
            { 
                //Display material types and request input for material, width, and length
                Console.WriteLine("\nMaterials: carpet, wood, tile, pvc, concrete, brick, stone, granite, marble");
                Console.Write("\nPlease enter floor material: ");

                material = Console.ReadLine();

                Console.Write("Please enter the width of the room in ft: ");

                width = double.Parse(Console.ReadLine());

                Console.Write("Please enter the length of the room in ft: ");

                length = double.Parse(Console.ReadLine());

                area = length * width;  
                string value = material;

                //Returns price of material per square foot which is a random number in a range
                //Returns area
                //Returns material's price per square foot * length * width 
                //Returns total price including installation
                //Decimals are rounded to 2 places

                switch (value) 

            {
                
                case "carpet": 
                Console.WriteLine("\nPrice of carpet: $" + dict["carpet"]  + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + " x " + length + " = $" + Math.Round(dict["carpet"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["carpet"] * 1.8, 2));
                Console.WriteLine();
                break;

                case "wood":
                Console.WriteLine("\nPrice of wood: $" + dict["wood"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + " x " + length + " = $" + Math.Round(dict["wood"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["wood"] * 1.8, 2));
                Console.WriteLine();
                break;

                case "tile":
                Console.WriteLine("\nPrice of tile: $" + dict["tile"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + " x " + length + " = $" + Math.Round(dict["tile"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["tile"] * 1.8, 2));
                Console.WriteLine();
                break;

                case "pvc":
                Console.WriteLine("\nPrice of pvc: $" + dict["pvc"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + " x " + length + " = $" + Math.Round(dict["pvc"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["pvc"] * 1.8, 2));
                Console.WriteLine();
                break;
            
                case "concrete":
                Console.WriteLine("\nPrice of concrete: $" + dict["concrete"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + " x " + length + " = $" + Math.Round(dict["concrete"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["concrete"] * 1.8, 2));
                Console.WriteLine();
                break;

                case "brick":
                Console.WriteLine("\nPrice of brick: $" + dict["brick"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + " x " + length + " = $" + Math.Round(dict["brick"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["brick"] * 1.8, 2));
                Console.WriteLine();
                break;

                case "stone":
                Console.WriteLine("\nPrice of stone: $" + dict["stone"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + " x " + length + " = $" + Math.Round(dict["stone"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["stone"] * 1.8, 2));
                Console.WriteLine();
                break;

                case "granite":
                Console.WriteLine("\nPrice of granite: $" + dict["granite"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + " x " + length + " = $" + Math.Round(dict["granite"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["granite"] * 1.8, 2));
                Console.WriteLine();
                break;

                case "marble":
                Console.WriteLine("\nPrice of marble: $" + dict["marble"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + " x " + length + " = $" + Math.Round(dict["marble"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["marble"] * 1.8, 2));
                Console.WriteLine();
                break;

            } 
           
    }

        //If user enters csv instead of individual, then the user will 
        //be prompted to read from a csv file

    else if (input == "csv")
    {
        
    }

    else {
        Console.WriteLine("Incorrect entry, please try again.");
    }
    }
    }
    }
 