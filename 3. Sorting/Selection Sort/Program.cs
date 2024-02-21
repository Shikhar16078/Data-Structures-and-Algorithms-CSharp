namespace Selection_Sort
{
    internal class Program
    {
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i<array.Length - 1; i++)
            {
                int position = i;
                for (int j = i+1; j<array.Length; j++)
                {
                    if (array[j] < array[position])
                    {
                        position = j;
                    }
                }
                int temp = array[i];
                array[i] = array[position];
                array[position] = temp;
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] result = SelectionSort(new int[] { 5, 1, 9, 11, 15, 3, 2 });
            Console.WriteLine("Sorted Array :");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
