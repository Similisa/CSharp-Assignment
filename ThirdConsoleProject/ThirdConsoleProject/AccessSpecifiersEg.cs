using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleProject
{

    class products
    {
        int productId;// no access outside the class
        protected float ProductPrice;//accessible only within the class and all derived class
        public string ProductName;//accessible anywhere
    }
    class AccessSpecifiersEg:products
    {
        static void main()
        {
            
            AccessSpecifiersEg acc = new AccessSpecifiersEg();
            acc.ProductName = "Desktop";
            acc.ProductPrice = 25000.50f;
        }
    }

    class Test
    {
        public void TestFunc()
        {
            products prod = new products();
            prod.ProductName = "Laptop";
        }
    }
}
