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
        public class  FileRead{

           public void readdata()
    {
        string csventry;
        Console.WriteLine("\nPlease enter path of csv file. Example 'materials.csv'");
        Console.Write("Path: ");
        csventry = Console.ReadLine();

        FileStream fs = new FileStream(csventry, FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);//Position the File Pointer at the Beginning of the File
        sr.BaseStream.Seek(0, SeekOrigin.Begin);//Read till the End of the File is Encountered
        string str = sr.ReadLine();
        while (str != null)
        {
            Console.WriteLine("{0}", str);
            str = sr.ReadLine();
        }
        //Close the Writer and File
        sr.Close();
        fs.Close();
    }
        }
       
      static void Main(String[] args)
    {

            string[][] filearray = new string[3][];

          //  filearray[0] = new string[5];

            //Declare variables

            String material;
            String input;
            String input2;
            String length;
            String width;
            double area;
            double widthdouble;
            double lengthdouble;

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

         //Clear console
         //Request user input on whether they want to import a csv file 
         //or enter each room individually
        Console.Clear();

        while (true)
        {
        Console.WriteLine("\nWould you like to import a csv or enter individually?\n");
        Console.Write("Please enter 'csv' or 'ind' or 'exit': ");
        input = Console.ReadLine().Trim();

            //If the user enters individual, then it will run a script requesting 
            //the material, the width and the length of the room

            if (input == "ind")
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

                //Returns price of material per square foot which is a random number in a range
                //Returns area
                //Returns material's price per square foot * length * width 
                //Returns total price including installation
                //Decimals are rounded to 2 places

               if (material.ToLower() == "carpet")
           
           {
               Console.WriteLine("\nPrice of carpet: $" + dict["carpet"]  + " per square foot");
               Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
               Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict["carpet"] * area, 2));
               Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["carpet"] * 1.8, 2));
               Console.WriteLine();
           }

           else if (material.ToLower() == "wood")

         {
                Console.WriteLine("\nPrice of wood: $" + dict["wood"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict["wood"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["wood"] * 1.8, 2));
                Console.WriteLine();
         }

          else if (material.ToLower() == "tile")

         {
                Console.WriteLine("\nPrice of tile: $" + dict["tile"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict["tile"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["tile"] * 1.8, 2));
                Console.WriteLine();
         }
         
          else if (material.ToLower() == "pvc")

         {
                Console.WriteLine("\nPrice of pvc: $" + dict["pvc"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict["pvc"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["pvc"] * 1.8, 2));
                Console.WriteLine();
         }

         else if (material.ToLower() == "concrete")

         {
                Console.WriteLine("\nPrice of concrete: $" + dict["concrete"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict["concrete"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["concrete"] * 1.8, 2));
                Console.WriteLine();
         }

          else if (material.ToLower() == "brick")

         {
                Console.WriteLine("\nPrice of brick: $" + dict["brick"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict["brick"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["brick"] * 1.8, 2));
                Console.WriteLine();
         }

          else if (material.ToLower() == "stone")

         {
                Console.WriteLine("\nPrice of stone: $" + dict["stone"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict["stone"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["stone"] * 1.8, 2));
                Console.WriteLine();
         }

          else if (material.ToLower() == "granite")

         {
                Console.WriteLine("\nPrice of granite: $" + dict["granite"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict["granite"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["granite"] * 1.8, 2));
                Console.WriteLine();
         }

         else if (material.ToLower() == "marble")

         {
                Console.WriteLine("\nPrice of marble: $" + dict["marble"] + " per square foot");
                Console.WriteLine("Total Area = " + Math.Round(area, 2) + " sq ft");
                Console.WriteLine("Material Cost of " + width + "x" + length + " = $" + Math.Round(dict["marble"] * area, 2));
                Console.WriteLine("Total Cost w/ installation = $" + Math.Round(area * dict["marble"] * 1.8, 2));
                Console.WriteLine();
         }

         else {
         } 

            Console.WriteLine("Would you like to calculate another room or material?");
            Console.WriteLine("Please choose 'yes' or 'no'.");
            input2 = Console.ReadLine().Trim();

             if (input2.ToLower() == "no")
                {
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
                Console.Clear();
                break;
                }

            else if (input2.ToLower() == "yes")
            {
                
            }
            else {

            }
            }
           
        //If user enters csv instead of individual, then the user will 
        //be prompted to read from a csv file

    else if (input == "csv")
    {
         FileRead fr = new FileRead();
        fr.readdata();
    }

    else if (input == "exit" ||
             input == "no" 
             )
    {
        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
        Console.Clear();
        break;
    }

    else {
        Console.WriteLine("\nIncorrect entry, press any key to try again.");
        Console.ReadKey();

    }
    }
    }
    }
}
 