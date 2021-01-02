using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {12, 4, -3, -2, 7, 18, 3, 13, 19, 6};

            ShellSort(array);

            PrintArrayContents(array);
            
            Console.ReadLine(); 
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
            Console.Write(" ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write("\b\b.");
        }

    }
}
