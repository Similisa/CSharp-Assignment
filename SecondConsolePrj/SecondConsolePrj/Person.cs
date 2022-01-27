using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsolePrj
{
    class Person
    {
       protected string name;
        string address;
        int age;

    }

    class Doctor:Person
    {
        protected string cateogory;
        public void func1()
        {
            name = "Sreejith";
            cateogory = "cardiology";
        }
    }

    class DutyDoctor : Doctor
    {
        string Hospital;

        public void func2()
        {
            name = "Rajesh";
            cateogory = "pediatric";
            Hospital = "Apollo";
        }
    }
}
