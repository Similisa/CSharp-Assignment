using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleProject
{

    class student
    {
        private string RollNo;
        string Name;
        String Class;

        internal student()//Parameter less constructor
        {
            Console.WriteLine("Hi Student Class Here: ");
        }

        public void GetData()
        {
            Console.WriteLine("Enter Roll No: ");
            RollNo = Console.ReadLine();

            Console.WriteLine("Enter Name: ");
            Name= Console.ReadLine();

            Console.WriteLine("Enter class: ");
            Class = Console.ReadLine();

        }

        public void PutData()
        {
            Console.WriteLine("NAme of the student: " + Name);
            Console.WriteLine("RollNo :" + RollNo);
            Console.WriteLine("Class: " + Class);
        }
    }

    class Marks: student
    {
        protected int[] a = new int[5];

       

        public void GetMarks()
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter subject {0} Marks:", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Marks in subject{0} :{1}", i + 1, a[i]);
            }
        }
    }

    class Result : Marks
    {
        int TotalMarks = 0;
        
        public void GetResult()
        {
            for(int i = 0; i < a.Length; i++)
            {
                TotalMarks = TotalMarks + a[i];
            }
        }

        public void DisplayResult()
        {
            Console.WriteLine("---------------Result--------------");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks= " + TotalMarks);

        }
        //destructor
        ~Result()
        {
            Console.WriteLine("Bye from Result: ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Result result = new Result();
            result.GetData();
            result.GetMarks();
            result.GetResult();
            result.DisplayResult();
            result = null;
            GC.Collect();
            Console.Read();
        }
    }
}
