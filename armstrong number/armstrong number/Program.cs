using System;

namespace name
{
    class program
    {
        public static void Main( String []args)
        {
            int rev = 0,temp;
            Console.WriteLine("enter your number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while ( n != 0)
            {
                int number = n % 10;
                n /= 10;
                rev += number * number * number;
            }
            if ( temp == rev )
            {
                Console.WriteLine("The number is armstrong.");
            }
            else
            {
                Console.WriteLine("the number is not armstrong.");
            }
        }
    }
}