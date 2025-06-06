using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns.CDP
{
    //Abstract factory pattern


    public interface INotificationAFP
    {
        void Notify(string message);
    }
    public interface ILogger
    {
        void Log(string message);
    }
    public class EmailLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Email LOG] {message}");
        }
    }
    public class EmailNotificationAFP : INotificationAFP
    {
        public void Notify(string message)
        {
            Console.WriteLine($"[Email] {message}");
        }
    }
    public class SmsNotificationAFP : INotificationAFP
    {
        public void Notify(string message)
        {
            Console.WriteLine($"[SMS] {message}");
        }
    }

    public interface INotificationFactoryAFB
    {
        INotificationAFP CreateNotification();
        ILogger CreateLogger();
    }
    public class SmsLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Email LOG] {message}");
        }
    }

    public class EmailNotificationFactoryAFP : INotificationFactoryAFB
    {
        public ILogger CreateLogger() => new EmailLogger();

        public INotificationAFP CreateNotification() => new EmailNotificationAFP();
    }
    public class SMSNotificationFactoryAFP : INotificationFactoryAFB
    {
        public ILogger CreateLogger() => new SmsLogger();

        public INotificationAFP CreateNotification() => new SmsNotificationAFP();
    }
    internal class AFP
    {
        public static void Main()
        {
            INotificationFactoryAFB factory = new EmailNotificationFactoryAFP();
            var notifier = factory.CreateNotification();
            var logger=factory.CreateLogger();

            notifier.Notify("Hello vs abstract factory");
            logger.Log("Email notifction sent");

            factory = new SMSNotificationFactoryAFP();
            notifier=factory.CreateNotification();
            logger=factory.CreateLogger();

            notifier.Notify("Hello vs sms");
            logger.Log("SMS notifction sent");
        }
    }
}
