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
            //Some change to the console letters on the console.
            Console.ForegroundColor = ConsoleColor.Green;
            //
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
                        MethodsBoy.InsertionSort();
                        break;

                    case 4:
                        MethodsBoy.BinarySearch();
                        break;
                    case 5:
                        Environment.Exit(0);
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
                Console.WriteLine($"\t°         2. Selection Sort O(n^2)         °");
                Console.WriteLine($"\t°         3. Insertion Sort O(log N)       °");
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

        private void InsertionSort()
        {
            //The first loop helps us to fix the first element of the array and give birth the its sorted part.
            for (int current = 1; current < integersArray.Length; current++)
            {
                //Between this for loop will have to start to shrink the unsorted part of the array.
                //Check as the control variable of our currents position and the index that will be used to perform the swaps needed.
                int Check = current;
                while ((Check > 0) && (integersArray[Check]<integersArray[Check-1]))
                {
                    int swap = integersArray[Check - 1];
                    integersArray[Check - 1] = integersArray[Check];
                    integersArray[Check] = swap;
                    Check--;
                }
            }
            
        }

        //Binary search O(log N)
        private void BinarySearch()
        {
         
            //Some new interaction to retrive the index and confirm that the value requested is found and the array.
            Console.WriteLine("\n\tWell, this is the array you got so far! Is has been sorted due to ");
            Console.WriteLine("\twe needed this way to get out Binary search algorithm to work! ");
            showArrayUp();
            SelectionSort();
            Console.WriteLine();
            Console.Write("\tWhich number are you looking for? Type it: ");
            int target = int.Parse(Console.ReadLine());
            bool doesExist = integersArray.Where(x => x == target).Any();

            /*Binary  search is a strategy for solving a guessing game. When you have an array that is sorted,
                * you can use the binary search strategy to search for a particular value in that Array:
                * 
                * 1. Pick an array index in the middle of the guessing interval.
                * 
                * 2. if the number you're seeking isn0t at that array index, use the number stored at that array index
                * to shrink the guessing interval as much as possible.
                */

            if (doesExist)
            {
               
                //These varibles will save the upper and lower indexes of our interval.
                int low, high;
                low = 0;
                high = integersArray.Length-1;
                //This loop will repeat until the if clause where the element in our array matches the target given by our user.
                while (low <= high)
                {

                    //We give to mid the middle index of the array.
                    int mid = (int)Math.Round(0.5 * (low + high));
                    //The first clause  makes the guessing interval shrink to the lower bound, because the target might be less than 
                    // the half of the array that will not be searched.
                    if (integersArray[mid] > target) high = mid - 1;
                    else if (integersArray[mid] < target) low = mid + 1;
                    else if (integersArray[mid] == target)
                    {
                        Console.WriteLine($"\tThe value you are looking for is {integersArray[mid]}, it's in index = {mid} ");
                        Console.ReadKey();
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("That number wasn't found in the array, please try again");
                Console.WriteLine("Press <<enter>> to get back...");
                Console.ReadKey();
                return;
            }

            
        }
        


    }
}
