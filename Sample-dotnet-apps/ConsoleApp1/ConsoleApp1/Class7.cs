using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Factory Pattern
    public interface INotification
    {
        void SendMessage(string message);
    }
    public class SmsNotification : INotification
    {
        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
    public class EmailNotification : INotification
    {
        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
    public static class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                _ => throw new Exception(),
            };
        }
    }
    internal class Class7
    {
        public static void Main7()
        {
            INotification notification = NotificationFactory.CreateNotification("email");
            notification.SendMessage("I am coming from main and i am email caller");

        }
    }
}
