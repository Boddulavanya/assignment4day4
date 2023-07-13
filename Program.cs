using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_dat4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "lavanya";
            string password = "password";
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter username: ");
                string inputUsername = Console.ReadLine();

                Console.Write("Enter password: ");
                string inputPassword = Console.ReadLine();

                if (inputUsername == username && inputPassword == password)
                {
                    Console.WriteLine("Login successful.");
                    break;
                }
                else if (inputUsername == username && inputPassword != password)
                {
                    Console.WriteLine("Invalid password.");
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                }

                attempts++;
            }

            if (attempts == 3)
            {
                Console.WriteLine("Login failed.");
            }
            Console.ReadKey();
        }
    }
}
    
