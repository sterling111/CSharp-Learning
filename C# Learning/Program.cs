
namespace Dami_C_Universe
{
     class Day1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int myInt = 10;
            int myInt1 = 10;

            string myString = "10";
            string myString1 = "10";

            Console.WriteLine(myInt + myInt1);

            Console.WriteLine(myString + myString1);

            string convertedInt = Convert.ToString(myInt);

            Console.WriteLine(convertedInt + myInt);         
        }
    }
    class Day2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To DamiC Universe");
            Console.WriteLine("--------------------------");

            string userName = "DamiC";
            string phoneNumber = "09037740965";
            string emailAddress = "Damic@gmail.com";

            Console.WriteLine("Username : " + userName);
            Console.WriteLine("Phonenumber : " + phoneNumber);
            Console.WriteLine("Emailaddress : " + emailAddress);
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            // Collect user input
            Console.Write("Enter your Name: ");
            string? Name = Console.ReadLine();

            Console.Write("Enter your Phone: ");
            string? Phone = Console.ReadLine();

            Console.Write("Enter your Email: ");
            string? Email = Console.ReadLine();

            Console.WriteLine($"Welcome to, {Name} universe");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");

            // Console.ReadLine();
        }
    }

    /* So far i learnt about the c# syntax which are: using system, namespace, curly-braces, class, main-method and cnsole which is a class of the system namespace. 
     c# output which is the WriteLine() method and also 
    the types of variables which are: int, double, char, string, and bool. declaring and creating variables and c# constants */
}
