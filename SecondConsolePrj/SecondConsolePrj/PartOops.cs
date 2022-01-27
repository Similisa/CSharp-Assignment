using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsolePrj
{

    class Employee
    {
       int Empid;
        string Empname;
        double Salary;
        DateTime DateOfJoin;

     //   internal Employee()
      // {

       //     Console.WriteLine("I am your constructor here");
      //  }

       // public Employee(int Empid, string Empname)
      //  {
        //   this.Empid = Empid;
          // this.Empname = Empname;
      //  }

       // public Employee(int eid,string ename,double sal,DateTime doj)
       // {
         //   Empid = eid;
         //   Empname = ename;
        //    Salary = sal;
        //    DateOfJoin = doj;
     //   }

       public void ShowEmployeeDetails()
        {
            Console.WriteLine(Empid + " " + Empname + " " + Salary + " " + DateOfJoin);
        }

        public  void testfunc()
        {

            Employee e3 = new Employee() { Empid = 50, Empname = "rakesh", Salary = 5678.67, DateOfJoin = Convert.ToDateTime(12 / 10 / 2021) };
            ShowEmployeeDetails();
            e3.ShowEmployeeDetails();
           // PartOops partoops = new PartOops();
        }

    }
   public class PartOops

    {
        public int add(int x, int y)
        {
            return x + y;
        }
        static void Main()
        {
            Employee employee = new Employee();//default constructor is provided by the framework
            //employee.testfunc();
           // Employee e = new Employee(10, "Rama");// invokes 2 parameter

           // e.testfunc();
            Console.WriteLine("-------------------");
            //Employee e1 = new Employee(20, "seetha", 45689.67, Convert.ToDateTime("12/12/2021"));
          //  Employee e2 = new Employee(20, "seetha", 45689.67, new DateTime(2021, 12, 20));
           //  e1.testfunc();
           //  e2.testfunc();
           
             Console.Read();
        } 
    }
}
