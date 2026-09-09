using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryMethodDemo.Notifications;

namespace FactoryMethodDemo.Factories
{
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();

        public void SendNotification(string message)
        {
            INotification notification = CreateNotification();
            notification.Send(message);
        }
    }
}
