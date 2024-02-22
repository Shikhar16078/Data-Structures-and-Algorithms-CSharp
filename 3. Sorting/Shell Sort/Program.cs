namespace Shell_Sort
{
    internal class Program
    {
        public static int[] ShellSort(int[] array)
        {
            int length = array.Length;
            int gap = length/2;

            while(gap > 0)
            {
                // for looping from gap to length
                int i = gap;
                while (i < length)
                {
                    int temp = array[i]; 
                    int j = i - gap;
                    // J is testing value
                    // agar J pe value temp se badi hai to
                    while(j >=0 && array[j] > temp)
                    {
                        // Temp ki position pe J ki value daal do
                        array[j + gap] = array[j];
                        // ab Gap ki left side pe dekho
                        j = j - gap;
                    }
                    // J ki old position pe Temp daal do
                    // Yaha pe Temp aur J ke beech ki swaping complete hui hai
                    array[j + gap] = temp;
                    i = i + 1;
                }
                gap = gap / 2;
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] result = ShellSort(new int[] { 5, 1, 9, 11, 15, 3, 2 });
            Console.WriteLine("Sorted Array :");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
