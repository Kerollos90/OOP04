using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal interface  INotificationService 
    {
        public void SendNotification(string recipient,string message);


    }

    public class EmailNotificationService() : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending Email to {recipient} :: message '{message}'");

        }
    }
    public class SmsNotificationService() : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient} :: message '{message}'");
        }



    }


    public class PushNotificationService() : INotificationService
    {

        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending Push   to {recipient} :: message '{message}'");
        }


    }







}
