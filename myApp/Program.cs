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
            String length;
            String width;
            double area;
            double widthdouble;
            double lengthdouble;

        Random rnd = new Random();

        //Create dictionary called dict of materials and their estimated price per square foot

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

            //Returns price of material per square foot which is a random number in a range
            //Returns area
            //Returns material's price per square foot * length * width 
            //Returns total price including installation
            //Decimals are rounded to 2 places

          void computeCost(String materials)
                {
                String mat = material.ToLower();
                double cost = dict[mat];
                Console.WriteLine("\nPrice of " + mat + ": $" + dict[mat] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict[mat] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict[mat] * 1.8, 2));
                }

         //Clear console
         //Request user input on whether they want to import a csv file 
         //or enter each room individually
        Console.Clear();

        while (true)
        {
                //Display material types and request input for material, width, and length
                Console.WriteLine("\nMaterials: carpet, wood, tile, pvc, concrete, brick, stone, granite, marble");
                Console.Write("\nPlease enter floor material: ");

                material = Console.ReadLine().Trim();
                
                if (
                
                    material.ToLower() != "carpet" &&
                    material.ToLower() != "wood" &&
                    material.ToLower() != "tile" &&
                    material.ToLower() != "pvc" &&
                    material.ToLower() != "concrete" &&
                    material.ToLower() != "brick" &&
                    material.ToLower() != "stone" &&
                    material.ToLower() != "granite" &&
                    material.ToLower() != "marble"

                    )
                {
                    Console.WriteLine("Please enter a valid material");
                }  

                Console.Write("Please enter the width of the room in ft: ");

                width = Console.ReadLine().Trim();

                if (!double.TryParse(width, out widthdouble) || widthdouble < 1)
                
                {
                    Console.WriteLine("There was an error, please try again");
                }

                else {

                }

                Console.Write("Please enter the length of the room in ft: ");

                length = Console.ReadLine().Trim();

                if (!double.TryParse(length, out lengthdouble) || lengthdouble < 1)
                
                {
                    Console.WriteLine("There was an error, please try again");
                }

                else {

                }

                area = double.Parse(length) * double.Parse(width);  

        //check if parameters are met and call the computeCost function to output the 
        //function with those parameters

        if (material.ToLower() == "carpet")
           
           {
                computeCost("carpet");
           }

        else if (material.ToLower() == "wood")

         {
                computeCost("wood");
         }

        else if (material.ToLower() == "tile")

         {
                computeCost("tile");
         }
         
        else if (material.ToLower() == "pvc")

         {
                computeCost("pvc");
         }

         else if (material.ToLower() == "concrete")

         {
                computeCost("concrete");
         }

          else if (material.ToLower() == "brick")

         {
                computeCost("brick");
         }

          else if (material.ToLower() == "stone")

         {
                computeCost("stone");
         }

          else if (material.ToLower() == "granite")

         {
                computeCost("granite");
         }

         else if (material.ToLower() == "marble")

         {
                computeCost("marble");
         }

         else {

         } 

            Console.WriteLine("\nWould you like to calculate another room or material?");
            Console.WriteLine("Please choose 'yes' or 'no'.");
            input = Console.ReadLine().Trim();

             if (input.ToLower() == "no")

                {
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
                Console.Clear();
                break;
                }

            else 
            {

            }
            }
    }
    }
    }
 