using System;

namespace name
{
    class program
    {
        public static void Main(String[] args)
        {
            int rev = 0;
            Console.WriteLine("enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while ( n != 0)
            {
                int number = n % 10;
                n /= 10;
                rev = rev * 10 + number;
            }

            if ( temp == rev )
            {
                Console.WriteLine("the number is palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not palindrome.");
            }
        }
    }

}
