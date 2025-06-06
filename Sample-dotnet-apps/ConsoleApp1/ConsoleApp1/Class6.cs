using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class6
    {
        public static void Modify(ref int x)
        {
            x += 10;
        }
        public static void ModifyOut(out int x)
        {
            Console.WriteLine("I am out");
            x = 10;
        }
        public static void Main8()
        {
            //var vs dynamic

            var sample = "vikash";
            //sample = 1;
            Console.WriteLine(sample);

            dynamic sample1 = "vikash";
            sample1 = 1;
            Console.WriteLine(sample1);

            //ref  vs out vs in
            //variable must be intialzed
            int a = 5;
            Modify(ref a);
            int b;
            ModifyOut(out b);
            Console.WriteLine(b);


        }
    }
}
