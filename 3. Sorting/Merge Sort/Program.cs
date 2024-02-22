namespace Merge_Sort
{
    internal class Program
    {
        public static void Merge(int[] array, int left, int mid, int right)
        {
            int i = left; // Track for left array
            int j = mid + 1; // Tracker for right array
            int sortedArrayIndex = left; // Tracker for new array

            // For Merge Sorted array
            int[] mergeSortedArray = new int[right + 1];

            while (i <= mid && j <= right)
            {
                if (array[i] < array[j])
                {
                    mergeSortedArray[sortedArrayIndex] = array[i];
                    i++;
                }
                else
                {
                    mergeSortedArray[sortedArrayIndex] = array[j];
                    j++;
                }
                // Increment index
                sortedArrayIndex++;
            }

            // If right array has no elements left
            // Copy all elements from left to sorted array:
            while (i <= mid)
            {
                mergeSortedArray[sortedArrayIndex] = array[i];
                i+=1; sortedArrayIndex++;
            }

            // If left array has no elements left
            // Copy all elements from rigth to sorted array:
            while (j <= right)
            {
                mergeSortedArray[sortedArrayIndex] = array[j];
                j++; sortedArrayIndex++;
            }


            // Copy all elements back to Original Array
            for (int current = left; current <= right; current++)
            {
                array[current] = mergeSortedArray[current];
            }
        }

        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 1, 9, 11, 15, 3, 2 };

            MergeSort(myArray,0, myArray.Length-1);
            Console.WriteLine("Sorted Array :");
            foreach (int i in myArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
