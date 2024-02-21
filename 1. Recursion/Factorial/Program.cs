namespace Factorial
{
    internal class Program
    {

        public static int recursion1(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return recursion1(n - 1)*n;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(recursion1(3));
        }
    }
}
