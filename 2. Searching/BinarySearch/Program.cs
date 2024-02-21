namespace BinarySearch
{
    internal class Program
    {
        public static int BinarySearchIterative(int[] array, int targetValue)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middleIndex = (left + right) / 2;
                int middleValue = array[middleIndex];
                if(middleValue == targetValue)
                {
                    return middleIndex;
                }
                else if (middleValue < targetValue) {
                    left = middleIndex + 1;
                }
                else {
                    right = middleIndex - 1;
                }
            }
            return -1;
        }
        public static int BinarySearchRecursion(int[] array, int targetValue, int left, int right)
        {
            if(left > right)
            {
                return -1;
            }
            else
            {
                int middleIndex = (left + right) / 2;
                int middleValue = array[middleIndex];
                if (middleValue == targetValue)
                {
                    return middleIndex;
                }
                else if (middleValue < targetValue)
                {
                    return BinarySearchRecursion(array, targetValue, middleIndex + 1, right);
                }
                else
                {
                    return BinarySearchRecursion(array, targetValue, left, middleIndex - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] {3,5,7,11,16,19,25};

            // Outputs 6
            Console.WriteLine(BinarySearchIterative(array, 25));
            Console.WriteLine(BinarySearchRecursion(array, 25, 0, array.Length - 1));

            // Outputs 2
            Console.WriteLine(BinarySearchIterative(array, 7));
            Console.WriteLine(BinarySearchRecursion(array, 7, 0, array.Length - 1));

            // Outputs -1
            Console.WriteLine(BinarySearchIterative(array, 30));
            Console.WriteLine(BinarySearchRecursion(array, 30, 0, array.Length - 1));
        }
    }
}
