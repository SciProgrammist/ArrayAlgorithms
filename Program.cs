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
            var MethodsBoy = new Program();
            do
            {
                controlswitch = MethodsBoy.Menu_gui();
                switch (controlswitch)
                {
                    case 1:
                        MethodsBoy.FillMyArray();
                        break;

                    case 2:
                        MethodsBoy.SelectionSort();
                        break;

                    case 3:
                        MethodsBoy.BinarySearch();
                        break;

                    case 4:
                        break;
                    default:
                      
                        break;
                }
                Console.Clear();
            } while (controlswitch != -1);

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

        //Selection sort Algorithm O(n^2)
        private void SelectionSort()
        {
            //The first for helps to get into the range of numbers in the array and the main idea
            //it is to have one part sorted and the other with numbers greater or equal to the part that
            //has already been sorted
            for (int current = 0; current < (integersArray.Length - 1); current++)
            {
                //We give to our minIndex the current value because we need to compare with it.
                int minIndex = current;
                //This for is to loop on the sub-array of unsorted numbers, but that are greater or equal to the ones
                //that have already been sorted.
                for (int check = current+1; check < integersArray.Length; check++)
                {
                    //Here we check that the value and its index from the sub-array (the one that is not sorted) is
                    //greater or equal to our value in the current index at the sub-array(that is sorted).
                    if (integersArray[check] < integersArray[minIndex]) minIndex = check;

                }

                //here we just perform a simple swap.

                int tempNum = integersArray[current];
                integersArray[current] = integersArray[minIndex];
                integersArray[minIndex] = tempNum;
                
            }
        }

        //Binary search O(log N)
        private void BinarySearch()
        {
            Console.WriteLine("\tWhich number are you looking for? ");
            int target = int.Parse(Console.ReadLine());
            int low, high;
            low = 0;
            high = integersArray.Length;

            while (low<= high)
            {
                int mid = (int)Math.Round(05 * (float)(low + high));
                if (integersArray[mid] > target) high = mid - 1;
                else if (integersArray[mid] < target) low = mid + 1;
                else if (integersArray[mid] == target) Console.WriteLine($"\tThe value you are looking for, it's in index = {mid} ");

            }

            
        }
        


    }
}
