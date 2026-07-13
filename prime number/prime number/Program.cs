using System;

namespace name
{
    class program
    {
        public static void Main(String[] args)
        {
            bool isPrime = true;
            Console.WriteLine("enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for ( int i = 2; i <= n/2; i++ )
            {
                if ( n%i == 0 )
                {
                    isPrime = false;
                    break;
                }
            }

            if (  isPrime )
            {
                Console.WriteLine("the number is prime.");
            }
            else
            {
                Console.WriteLine("The number is not prime.");
            }
        }
    }

}
