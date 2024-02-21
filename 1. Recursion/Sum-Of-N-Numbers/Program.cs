namespace Sum_Of_N_Numbers
{
    internal class Program
    {
        public static int iterationMethod(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n;
                n--;
            }
            return sum;
        }

        public static int recursionMethod1(int sum, int n)
        {
            if (n > 0)
            {
                return recursionMethod1(sum + n, n - 1);
            }
            else
                return sum;

        }

        public static int recursionMethod2(int n)
        {
            if (n > 0)
            {
                return recursionMethod2(n-1) + n;
            }
            else
                return n;

        }



        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine(Program.iterationMethod(number));
            Console.WriteLine(Program.recursionMethod1(0, number));
            Console.WriteLine(Program.recursionMethod2(number));
        }
    }
}
