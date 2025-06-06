using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //STartegy pattern
    public interface INotificationStratergy
    {
        void SendMessage(string message);
    }
    public class SmsNotificationStratergy : INotificationStratergy
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class EmailNotificationStratergy : INotificationStratergy
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class NotificationContext
    {
        private INotificationStratergy _strategy;

        public NotificationContext(INotificationStratergy strategy)
        {
            _strategy=strategy;
        }
        public void setStrategy(INotificationStratergy strategy)
        {
            _strategy = strategy;
        }
        public void SendNotification(string message)
        {
            _strategy.SendMessage(message);
        }
    }
    internal class Class8
    {

        public static void Main8()
        {

            INotificationStratergy str = "email" switch
            {
                "email" => new EmailNotificationStratergy(),
                "sms" => new SmsNotificationStratergy(),
                _ => throw new Exception(),
            };
            var context=new NotificationContext(str);
            context.SendNotification("Sending email ");
        }
    }
}
