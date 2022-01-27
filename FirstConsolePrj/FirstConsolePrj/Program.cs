using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsolePrj
{
    class Program
    {
        int a;
        int Id;
        String Name;
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Id = 5;
            p.Name = "zensar";
            Program p1 = new Program();
            p1.Id = 10;
            p1.Name = ".net";
            Console.WriteLine("Id of object p" + " " + p.Id + " " + p.Name);
            Console.WriteLine("Id of object p1" + " " + p1.Id + " " + p1.Name);
            display();
            p.TestFunc();
            p1.TestFunc();


        }

        public static void display()
        {
            Console.WriteLine("Hello static");
        }

        public void TestFunc()
        {
            Console.WriteLine("Hi object p");
            
       
        }
    }
}
