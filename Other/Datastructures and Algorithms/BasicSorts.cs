using System;
using System.Collections.Generic;

namespace Datastructures
{
    class BasicSorts
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 33, 10, -11, 5, 3, 14, 8, 1, 33 };

            // BubbleSort(array);

            //// SELECTION SORTS
            // SelectionSort1(array); 
            // SelectionSort2(array); 

            //// INSERTION SORTS
            // InsertionSort(array); 
            // ShellSort(array); 

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

        private static void SelectionSort1(int[] array) // Select index with largest value
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

        private static void SelectionSort2(int[] array) // Select index with smallest value
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

        private static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int val = array[i];
                int j = i;

                while (j > 0 && array[j - 1] > val)
                {
                    array[j] = array[j - 1];
                    j -= 1;
                }

                array[j] = val;
            }
        }

        private static void ShellSort(int[] array)
        {
            for (int gap = array.Length / 2; gap > 0; gap /= 2)
            {

                for (int i = gap; i < array.Length; i++)
                {
                    int val = array[i];
                    int j = i; 

                    while (j >= gap && array[j - gap] > val)
                    {
                        array[j] = array[j - gap]; 
                        j -= gap; 
                    }

                    array[j] = val;
                }
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
