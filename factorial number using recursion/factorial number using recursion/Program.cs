using System;
namespace name
{
    class program
    {
            public void calculate(int sum, int n)
            {
                sum *= n;
                n--;
            if (n == 0)
            {
                Console.WriteLine("the factorial is " + sum);
            }
            else
            {
                calculate(sum, n);
            }
        }
        public static void Main(string[] args)
        {
            int sum = 1;
            Console.WriteLine("Enter youor number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            program a = new program();
            a.calculate(sum, n);
        }
    }
}