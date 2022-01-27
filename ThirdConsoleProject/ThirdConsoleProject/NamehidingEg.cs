using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleProject
{
    class Vehicle
    {
       public int engine = 0;

        public void MethodDrive(string s)
        {
            Console.WriteLine("Message from base class{0}", s);
        }
    }

    class Car : Vehicle
    {

        //name hiding(field hiding)
        //redeclaring a member/field in the derived class,that is already declared in the base c1
        new int engine;

        public Car(int eng)
        {
            engine = eng;
            base.engine = eng;//initializing the base class field is optional
        }
        public Car(int eng1,int eng2)
        {
            engine = eng1;
            base.engine = eng2;
        }

        public new void MethodDrive(string str)
        {
            Console.WriteLine("message from child class{0}", str);         
        }
        public void showEngineDetails()
        {
            Console.WriteLine("Engine value in the base class:{0}", base.engine);
            Console.WriteLine("Engine value in the child  class :{0}", engine);
        }

    }
    class NamehidingEg
    {
        static void Main()
        {
            Car car = new Car(2, 5);
            car.showEngineDetails();
            car.MethodDrive("Learning Car driving");
            Vehicle vehicle = new Vehicle();
            vehicle.MethodDrive("Learning to drive a vehicle");
            Console.Read();
        }
    }
}
