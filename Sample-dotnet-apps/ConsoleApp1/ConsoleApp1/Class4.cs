using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Baseclass Display");
        }
    }
    class DerivedClass : BaseClass
    {
        public new void Display()
        {
            Console.WriteLine("DrivedClass DIsplay");
        }
    }
    internal class Class4
    {
        static void Main4(string[] args)
        {
            BaseClass obj1 = new DerivedClass();
            obj1.Display();
            DerivedClass obj2 = new DerivedClass(); 
            obj2.Display();
        }
    }
}
