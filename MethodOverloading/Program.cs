namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 5));
            Console.WriteLine(Add(10.5, 5.0));
            Console.WriteLine(Add(5, 5, true));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(5, 5, false));
            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isDollars)
        {
            int sum = Add(a, b);

            if (isDollars)
            {
                string dollarSuffix = (sum > 1) ? "Dollars" : "Dollar";
                return $"{sum} {dollarSuffix}";
            }

            return $"{sum}";
        }
    }
}
