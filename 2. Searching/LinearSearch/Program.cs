namespace LinearSearch
{
    internal class Program
    {
        public static int LinearSearchIterative(int[] nums, int value)
        {
            int counter = 0;
            while (counter < nums.Length)
            {
                if (nums[counter] == value)
                {
                    return counter;
                }
                counter++;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int search = 5;
            // Outputs Index 4
            Console.WriteLine(LinearSearchIterative(nums,search)); 
        }
    }
}
