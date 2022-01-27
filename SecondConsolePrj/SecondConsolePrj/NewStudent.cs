using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsolePrj
{
    class StudentSample
    { 
        //private fields
    
        int RollNo;
        string stdname { get; set; }
       public float marks { get; }

        public int semester { get; set; }
        //public properties declaration

            public int RegCode
        {
            get { return RollNo; }
            set { RollNo = value; }
        }

        public void show()
        {
            Console.WriteLine(RollNo + " " + stdname+" " + marks);
        }
        static void Main()
        {
            StudentSample ss = new StudentSample();

            ss.show();
            //   StudentSample ss1 = new StudentSample() { marks = 75, stdname = "Aasha", RollNo = 1 };
            StudentSample ss1 = new StudentSample() { RollNo = 6, stdname = "Albert", semester = 3 };
            ss1.show();
            Tester.checkingProperties();
            Console.Read();
        }
    }

    class Tester
    {

        public static void checkingProperties()
        {
            StudentSample studsample = new StudentSample() { RegCode =45};
            studsample.RegCode = 215; //set
            Console.WriteLine(studsample.RegCode); //get
        }
    }
}
