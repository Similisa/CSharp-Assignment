using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondConsolePrj;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {

            PartOops partoops = new PartOops();
            int retval = partoops.add(5, 10);

            Console.WriteLine("the sum of 5 and 10 is: " + retval);
            Console.Read();
        }
    }
}
