using System;

namespace name
{
    class program
    {
        public static void Main(String []args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("Enter number to print fibonacci series : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The series is : ");
            for(int i = 0; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(a+" ");
                a = b;
                b = c;
            }
        }
    }
}
