using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace name_7
{
    class program_7
    {
        public static void Main(String[] args)
        {
            string name = "Ashok";
            string name2 = "Jaat";
            string fullname = string.Concat(name + name2);
            Console.WriteLine(fullname);

            Console.WriteLine($"My first name is {name} and last name is {name2}");

            Console.WriteLine("my name is \"Ashok\" hello");
        }
    }
}