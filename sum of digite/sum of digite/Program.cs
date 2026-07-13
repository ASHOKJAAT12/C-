using System;

namespace name
{
    class program
    {
        public static void Main(String[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n != 0 )
            {
                int number = n % 10;
                n /= 10;
                sum = sum + number;
            }
            Console.WriteLine("The sum of digit is : " + sum);

        }
    }
}
