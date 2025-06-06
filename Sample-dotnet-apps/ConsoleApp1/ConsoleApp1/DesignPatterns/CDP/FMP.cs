using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns.CDP
{
    // fatctory Method pattern
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

    //Creator
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }

 
    public class EmailNotificationFactory: NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
    public class SMSNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
    internal class FMP
    {
        public static void Main()
        {
            NotificationFactory factory = new EmailNotificationFactory();
            INotification notification = factory.CreateNotification();
            notification.SendMessage("Factory method pattern with email");

            factory = new SMSNotificationFactory();
            notification=factory.CreateNotification();
            notification.SendMessage("Factory method pattern with sms");

        }
    }
}
