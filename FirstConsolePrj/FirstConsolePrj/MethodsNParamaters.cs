using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsolePrj
{
    class MethodsNParamaters
    {
        public static void SimpleMethod(int a)
        {
            a = 200;
        }

        // eg. for call by reference

            public static void SimplerefMethod(ref int a) // callee
        {
            a = 200;
        }
            static void Main()
        {
            int x = 100;
            SimpleMethod(x);
            Console.WriteLine(x);
            SimplerefMethod(x); //calling a function - caller
            Console.Read();

        }
    }
}
