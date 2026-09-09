using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryMethodDemo.Factories;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Pattern - Notification System");
            Console.WriteLine("--------------------------------------------");

            NotificationFactory emailFactory = new EmailFactory();
            emailFactory.SendNotification("Hello! This is an Email notification.");

            Console.WriteLine();

            NotificationFactory smsFactory = new SMSFactory();
            smsFactory.SendNotification("Hello! This is an SMS notification.");

            Console.WriteLine();

            NotificationFactory pushFactory = new PushFactory();
            pushFactory.SendNotification("Hello! This is a Push notification.");

            Console.WriteLine();

            Console.WriteLine("All notifications sent successfully.");
            Console.ReadLine();
        }
    }
}
