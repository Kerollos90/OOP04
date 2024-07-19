using OOP04.@interface;

namespace OOP04
{



    public class Program
    {
       public static void Main(string[] args)
        {


            #region Part 1


            /*
            Q1  = b: To define a blueprint for a class
            Q2  = a) private
            Q3  = b) No
            Q4  = b) Yes, interfaces can inherit from multiple interfaces
            Q5  = d) implements
            Q6  = a) Yes
            Q7  = b) No, all members are implicitly public
            Q8  = b) To provide a clear separation between interface and class members
            Q9  = b) No, interfaces cannot have constructors
            Q10 = c) By separating interface names with commas



            */




            #endregion




            #region Part 2

            #region Q1
            //Circle circle = new Circle();
            //Console.WriteLine("input radius");
            //circle.Radius = double.Parse(Console.ReadLine());
            //circle.DisplayAreaInfo();

            //Console.WriteLine("========");

            //Rectangle rectangle = new Rectangle();
            //Console.WriteLine("input Width");
            //rectangle.Width = double.Parse(Console.ReadLine());
            //Console.WriteLine("input Height");
            //rectangle.Height = double.Parse(Console.ReadLine());
            //rectangle.DisplayAreaInfo();
            #endregion

            #region Q2

            //IAuthenticationService authenticated = new BasicAuthenticationService();




            //Console.WriteLine("inputb name and password");
            //string x = Console.ReadLine();
            //int y = int.Parse(Console.ReadLine());

            //bool IsAuthenticated = authenticated.AuthenticateUser(x, y);
            //if (IsAuthenticated == true)
            //{
            //    Console.WriteLine($"is user ' {x} ' have authenticated ? {IsAuthenticated}");


            //    Console.WriteLine("input IsAuthorize role ");
            //    string z = Console.ReadLine();
            //    Console.WriteLine(  );
            //    bool IsAuthorize = authenticated.AuthorizeUser(x, z);
            //    Console.WriteLine($"is user ' {x} ' have Authorize role {z} ? {IsAuthorize}");

            //}

            //else
            //{ 
            //    Console.WriteLine();

            //    Console.WriteLine("try again");




            //}
















            #endregion

            #region Q3


            //INotificationService email = new EmailNotificationService();  
            //INotificationService sms = new SmsNotificationService();  
            //INotificationService push = new PushNotificationService();

            //string Email = "Email";
            //string Sms = "SMS";
            //string Push = "Push";

            //Console.WriteLine("if you send message with email  press 1");
            //Console.WriteLine("if you send message with sms  press 2");
            //Console.WriteLine("if you send message with push  press 3");
            //int x = int.Parse(Console.ReadLine());
            //if (x == 1)
            //{
            //    Console.WriteLine("input your email");
            //    string kk = Console.ReadLine();
            //    Console.WriteLine("Write your message");
            //    string message = Console.ReadLine();
            //    email.SendNotification(kk, message);


            //}
            //else if (x == 2)
            //{
            //    Console.WriteLine("input your sms");
            //    string kk = Console.ReadLine();
            //    Console.WriteLine("Write your message");
            //    string message = Console.ReadLine();
            //    sms.SendNotification(kk, message);


            //}
            //else if (x == 3)
            //{
            //    Console.WriteLine("input your push");
            //    string kk = Console.ReadLine();
            //    Console.WriteLine("Write your message");
            //    string message = Console.ReadLine();
            //    push.SendNotification(kk, message);




            //}
            //else
            //{
            //    Console.WriteLine("try again");
            //}


            #endregion
            #endregion

            Console.ReadKey();

        }



       
    }
}
