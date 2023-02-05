using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int usernameLenght = username.Length - 1;
            string password = string.Empty;

            for (int i = usernameLenght; i >= 0; i--)
            {
                password += username[i];
                
            }
            int loginAttemptsCount = 0;
            string inputPassword = Console.ReadLine();

            while (inputPassword != password)
            {
                loginAttemptsCount++;
                
                if (loginAttemptsCount > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }
            if (inputPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
           
            
        }
    }
}
