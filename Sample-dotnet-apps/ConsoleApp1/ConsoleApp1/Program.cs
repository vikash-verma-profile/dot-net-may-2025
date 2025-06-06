namespace ConsoleApp1
{
    class BankAccount
    {
        private double balance; //private
        public void deposit(double amount)
        {
            if (amount > 0) balance += amount;
        }
        public double getBalance() { return balance; } //read-only
    }

    public abstract class Shape
    {
        public abstract void Draw();
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("its a circle");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
