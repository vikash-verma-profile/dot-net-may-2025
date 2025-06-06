using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    interface IA
    {
        void Show();
    }
    interface IB
    {
        void Show();
    }

    class C : IA, IB
    {
         void IA.Show()
        {
            Console.WriteLine("Hi I am called with IA");
        }
         void IB.Show()
        {
            Console.WriteLine("Hi I am called with IB");
        }
    }
    internal class Class3
    {
        static void Main3(string[] args)
        {
            //C c = new C();
            //c.MethodA();

            IA a=new C();
            a.Show();

            IB b=new C();
            b.Show();


        }
    }
}
