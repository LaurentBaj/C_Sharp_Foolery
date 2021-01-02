using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 5, -20, -13, 4, 8, 19 };

            Sort(array);

            PrintArrayContents(array); 

            Console.ReadLine();
        }

        private static void Sort(int[] array)
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
