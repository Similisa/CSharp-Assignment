using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsolePrj
{
    class ReadOnlyConstants
    {
        public readonly int myvar1;
        public readonly int myvar2;
        public int data = 25;
        public const float PI = 3.14f;
        static int number = 5;
        internal ReadOnlyConstants(int a,int b)
        {
            myvar1 = a;
            myvar2 = b;
            data = 1;
            number = 10;
            Console.WriteLine("Displaying value of myvar1:{0} and myvar2:{1} and data{2},number :{3}", myvar1, myvar2,data,number);

        }
        static void Main()
        {
            ReadOnlyConstants rc = new ReadOnlyConstants(100,200);
            ReadOnlyConstants rc2 = new ReadOnlyConstants(200, 500);
            rc2.data = 65;
            number = 15;
            Console.WriteLine(number);
            Console.Read();
        }

    }
}
