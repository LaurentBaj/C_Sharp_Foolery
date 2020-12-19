using System;
using System.Collections.Generic;

namespace Datastructures
{
    class BasicSorts
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 33, 10, -11, 5, 8, 1, 33 };

            // BubbleSort(array);    

            //// Selection Sorts
            // Select index with largest value
            // SelectionSort1(array); 

            // Selects index with smallest value
            // SelectionSort2(array); 

            PrintArrayContents(array);

            Console.ReadLine();
        }


        private static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        SwitchPlaces(array, j, j + 1);
                    }
                } 
            }
        }

        private static void SelectionSort1(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int tempLargest = 0;

                for (int j = 0; j <= i; j++)
                {
                    if (array[tempLargest] < array[j])
                    {
                        tempLargest = j;
                    }
                }

                SwitchPlaces(array, i, tempLargest);
            }
        }

        private static void SelectionSort2(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int tempSmallest = i;
                
                for (int j = i; j <= array.Length - 1; j++)
                {
                    if (array[tempSmallest] > array[j])
                    {
                        tempSmallest = j; 
                    }
                }

                SwitchPlaces(array, tempSmallest, i); 
            }
        }



        // Swap Method
        private static void SwitchPlaces(int[] array, int a, int b)
        {
            if (a == b) return; 

            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }


        // Print array
        private static void PrintArrayContents(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


    }
}
