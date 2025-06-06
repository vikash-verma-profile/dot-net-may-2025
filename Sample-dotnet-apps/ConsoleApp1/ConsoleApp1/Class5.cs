using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void MyDelegate(string message);
    public delegate int Calculate(int x,int y);
    public delegate void Notify();
    public class Printer
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine("Message : "+message);
        }

        public int Add(int x, int y) => x + y;
        public void Task1() => Console.WriteLine("Task 1 done");
        public void Task2() => Console.WriteLine("Task 2 done");
    }
    internal class Class5
    {
      
        static void Main5(string[] args)
        {
            Printer printer = new Printer();

            MyDelegate del = new MyDelegate(printer.PrintMessage);
            Calculate calculate =new Calculate(printer.Add);

            del("Hello from delegate");
            Console.WriteLine(calculate(1,2));

            Notify notify = printer.Task1;
            notify += printer.Task2;
            notify();
        }
    }
}
