using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace name_7
{
    class program_7
    {
        public static void Main(String []args)
        {
            string name = "Ashok";
            int n = name.IndexOf("s");
            string super = name.Substring(n);
            Console.WriteLine(super);
        }
    }
}