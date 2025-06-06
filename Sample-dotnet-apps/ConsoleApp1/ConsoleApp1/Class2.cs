using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //braeking
    public abstract class Bird
    {
        public abstract void Eat();
    }

    public interface IFlyable
    {
        void Fly();
    }
    public class Sparrow : Bird,IFlyable
    {
        public  void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }

        public override void Eat()
        {
            Console.Write("Sparrow eats");
        }
    }

    //public class BirdProcessor
    //{
    //    public void MakeBirdFly(Bird bird)
    //    {
    //        bird.Fly();
    //    }
    //}

    public class Ostrich : Bird
    {
        public override void Eat()
        {
            Console.Write("Ostrich eats");
        }
    }
    internal class Class2
    {
        static void Main2(string[] args)
        {
            //BirdProcessor processor = new BirdProcessor();
            //processor.MakeBirdFly(new Sparrow());


            //violate LSP
            Bird bird = new Ostrich();
            bird.Eat();
        }
    }
}
