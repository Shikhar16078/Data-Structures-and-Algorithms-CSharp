namespace Fibbonacci_Sequence
{
    internal class Program
    {
        public static int recursion1(int n)
        {
            if(n==1 || n == 2)
            {
                Console.WriteLine(n);
                return n;
            }
            else
            {
                Console.WriteLine((n-1) + (n-2));
                return recursion1(n - 1) + recursion1(n - 2);
            }
        }

        public static void recursion2(int n)
        {
            if (n == 1 || n == 2)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine((n - 1) + (n - 2));
            }
        }
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine($"{number}th term of fibbo series is {recursion1(number)}");
            //recursion2(number);
        }
    }
}
