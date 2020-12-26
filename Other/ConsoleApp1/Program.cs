using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 12, 3, 4, 7, 1, 5, 9, 13, 11, 6, 16 };

            // BubbleSort(intArray);

            // SelectionSort(intArray); 

            InsertionSort(intArray); 

            Print(intArray);

            Console.ReadLine();
        }



        private static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] >= array[i])
                    {
                        SwitchPlaces(array, j, i);
                    }
                }

            }
        }


        private static void SelectionSort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int max = 0; 

                for (int j = 0; j <= i; j++)
                {
                    if (array[max] < array[j]) max = j;
                }

                SwitchPlaces(array, max, i); 
            }
        }



        private static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int val = array[i]; 

                while (j >= 0 && array[j] > val)
                {
                    array[j + 1] = array[j];
                    j--; 
                }

                array[j + 1] = val; 
            }
        }










        private static void Print(int[] intArray)
        {
            foreach (int i in intArray) Console.WriteLine(i);
        }


        // Swap Method
        private static void SwitchPlaces(int[] array, int a, int b)
        {
            if (a == b) return;

            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }



    }
}
