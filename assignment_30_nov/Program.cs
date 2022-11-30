using System.Text.RegularExpressions;

namespace assignment_30_nov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the username:");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter the password:");
            string password = Console.ReadLine();
            User user = new User(username, password);
            Console.WriteLine("");
            Console.WriteLine("Username: " + user.Username);
            Console.WriteLine("Password: " + user.Password);
        }
    }
}