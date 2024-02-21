namespace Insertion_Sort
{
    internal class Program
    {
        public static int[] InsertionSort(int[] array)
        {
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                // Test Value taken at Hand
                int testValue = array[i];
                int testPosition = i;

                while(testPosition > 0 && array[testPosition - 1] > testValue)
                {
                    // Position previous element to current position
                    array[testPosition] = array[testPosition-1]; 
                    testPosition--;
                }

                // Put back the Hand picked value in correct position.
                array[testPosition] = testValue;
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] result = InsertionSort(new int[] { 5, 1, 9, 11, 15, 3, 2});
            Console.WriteLine("Sorted Array :");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
