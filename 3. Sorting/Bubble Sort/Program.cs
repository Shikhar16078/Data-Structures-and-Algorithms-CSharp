namespace Bubble_Sort
{
    internal class Program
    {
        public static int[] BubbleSort(int[] array)
        {
            int length = array.Length;
            for (int pass = length - 1; pass >= 0; pass--)
            {
                for (int i = 0; i<pass; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] result = BubbleSort(new int[] { 5, 1, 9, 11, 15, 3, 2 });
            Console.WriteLine("Sorted Array :");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
