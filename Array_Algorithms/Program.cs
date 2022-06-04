using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Algorithms
{
    internal class Program
    {
       
        public int[] integersArray = new int[10];

        static void Main(string[] args)
        {
            int controlswitch;
            //Due to the nature of this application wee need to create an instance of the class to use the methods we have coded.
            var MyMethodsBoy = new Program();
            do
            {
                controlswitch = MyMethodsBoy.Menu_gui();
                switch (controlswitch)
                {
                    case 0:
                        break;
                    case 1:
                        MyMethodsBoy.FillMyArray();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                      
                        break;
                }
                Console.Clear();
            } while (controlswitch != -1);


            //Binary search for an array.

            //Sorte algorithm for an array.

            //Insert sorte algorithm for an array.
        }

        //Method that has the GUI of the Program's menu.
        private int Menu_gui()
        {
            
            int op_Select;
            try
            {
                Console.WriteLine("");
                Console.WriteLine($"\t°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                Console.WriteLine($"\t° UDB CS Student:                          °");
                Console.WriteLine($"\t° This program has the main algorithms     °");
                Console.WriteLine($"\t° for Arrays and my solution to            °");
                Console.WriteLine($"\t° Brilliant.org CS fundamentals.           °");
                Console.WriteLine($"\t°                                          °");
                Console.WriteLine($"\t°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                Console.WriteLine($"\t° Current Array:                           °");
                showArrayUp();
                Console.WriteLine($"\t°                                          °");
                Console.WriteLine($"\t°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                Console.WriteLine($"\t°         1. New Array.                    °");
                Console.WriteLine($"\t°         2. Sort                          °");
                Console.WriteLine($"\t°         3. Sorted Insert                 °");
                Console.WriteLine($"\t°         4. Binary Search                 °");
                Console.WriteLine($"\t°         5. Exit                          °");
                Console.WriteLine($"\t°                                          °");
                Console.WriteLine($"\t°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                Console.WriteLine("");
                Console.Write("\tSelect one of the option available: ");
                op_Select = int.Parse(Console.ReadLine());
                if ((1 <= op_Select) && (5 >= op_Select)) return op_Select;
                else return -1;
            }
            catch (Exception Error)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\tAn error, please try again: " + Error.Message);
                Console.ReadKey();
                return -2;
            }

        }

        //Method to fill up an array with random numbers and then enable the possibility to
        //test the three main algorithms design for this data structure.
        private string FillMyArray()
        {
            //Random generator object.
            Random xyz = new Random();
            //Loop that will fill up the array in this method.
            for (int j = 0; j<integersArray.Length;j++)
            {
                integersArray[j] = xyz.Next(10,99);
            }
            return "the array has been succesfully filled up, dear user! ";
        }

        private void showArrayUp()
        {
            //To go througout all the array elements and print them out!
            for (int i = 0; i < integersArray.Length; i++)
            {
                //This if that I use here is to give our string a little of format, so I can look awesome when
                //I show it up on our menu GUI.
                if (i == 0) Console.Write($"\t° [{integersArray[i]}");
                else if (i == 9) Console.Write($" ,{integersArray[i]}] °");
                else Console.Write($" ,{integersArray[i]}");
            }
            Console.WriteLine();

        }
        


    }
}
