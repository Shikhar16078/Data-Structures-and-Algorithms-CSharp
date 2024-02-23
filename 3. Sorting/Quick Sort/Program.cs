using System;

namespace Quick_Sort
{
    internal class Program
    {
        // Determine the Pivot's sorted position,
        // and then call Quick Sort on left and right arrays:
        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int index = Partition(array, low, high);
                QuickSort(array, low, index - 1);
                QuickSort(array, index + 1, high);
            }
        }

        // Sets the Pivot to its sorted position
        public static int Partition(int[] array, int low, int high)
        {
            int pivot = array[low];
            int i = low + 1;
            int j = high;
            do
            {
                // Set i to first value that is greater than pivot
                while (i <= j && array[i] <= pivot)
                    i = i + 1;

                // Set j to first value that is less than pivot
                while (i <= j && array[j] > pivot)
                    j = j - 1;

                if (i <= j)
                {
                    Swap(array, i, j);
                }
            } while (i < j);

            // Move pivot to its correct position
            Swap(array, low, j);

            // Return the pivot index
            return j;
        }

        // Spwan Method to Swap Elements in an Array
        public static void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 1, 9, 11, 15, 3, 2 };
            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted Array :");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
