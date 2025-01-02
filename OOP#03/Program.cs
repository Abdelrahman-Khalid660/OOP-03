using System;
class Program  {

    // Part 1: Choose

    // 1 b) To define a blueprint for a class
    // 2 a) private
    // 3 b) No
    // 4 b) Yes, interfaces can inherit from multiple interfaces
    // 5 d) implements
    // 6 a) Yes
    // 7 b) No, all members are implicitly public
    // 8 b) To provide a clear separation between interface and class members
    // 9 b) No, interfaces cannot have constructors
    //10 a) By using the "implements" keyword




    // 1)

    interface IShape
    {
    double Area { get; }
    void DisplayShapeInfo();
    }

interface ICircle : IShape
    {
    }

interface IRectangle : IShape
    {
    }

class Circle : ICircle
    {
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area
    {
        get { return Math.PI * radius * radius; }
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Circle with radius {radius}: Area = {Area:F2}");
    }
  }

class Rectangle : IRectangle
    {
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Area
    {
        get { return width * height; }
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Rectangle with width {width} and height {height}: Area = {Area:F2}");
    }
}


    // 2)



    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (username == "user" && password == "password")
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == "admin" && role == "administrator")
            {
                return true;
            }
            return false;
        }
    }


    // 3)

    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending push notification to {recipient}: {message}");
        }
    }



    static void Main(string[] args)
    {
        // 1) 

        //ICircle circle = new Circle(5);
        //IRectangle rectangle = new Rectangle(4, 3);

        //circle.DisplayShapeInfo(); 
        //rectangle.DisplayShapeInfo(); 

        // 2)

        //IAuthenticationService authService = new BasicAuthenticationService();

        //if (authService.AuthenticateUser("user", "password"))
        //{
        //    Console.WriteLine("User authenticated successfully.");

        //    if (authService.AuthorizeUser("admin", "administrator"))
        //    {
        //        Console.WriteLine("User authorized for administrator role.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("User not authorized for administrator role.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Authentication failed.");
        //}

        // 3)

        INotificationService emailService = new EmailNotificationService();
        INotificationService smsService = new SmsNotificationService();
        INotificationService pushService = new PushNotificationService();

        emailService.SendNotification("abdelrahmankhalid02@gmail.com", "Hello from email!");
        smsService.SendNotification("01120100399", "Hello from SMS!");
        pushService.SendNotification("22510191", "Hello from push notification!");




    }
}
