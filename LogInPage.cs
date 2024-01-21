using System;
using System.Linq;

namespace CSharpProjectUIConsole
{
    public class LogInPage
    {
        private static string username;
        private static string password;
        private static char choice;


        public static void BuildMenu()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("1) Login");
            Console.WriteLine("2) Sign up");
            Console.WriteLine("3) Exit");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ElementAt(0);

            RespondChoice();
        }

        private static void RespondChoice()
        {
            if (choice == '1')
            {
                Console.WriteLine("1) Username");
                LogInPage.username = Console.ReadLine();
                Console.WriteLine("2) Password");
                LogInPage.password = Console.ReadLine();

                LogInPage.LogInBackEnd();
            }
            else if (choice == '2')
            {
                SignUpPage.BuildMenu();
            }
            else if (choice == '3')
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Choice!");
                Console.Write("Enter any key: ");
                Console.ReadKey();
                Console.Clear();
                BuildMenu();
            }
        }

        private static void LogInBackEnd()
        {

        }
    }
}