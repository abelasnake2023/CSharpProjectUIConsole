using System;



namespace CSharpProjectUIConsole
{
    public class SignUpPage
    {
        private static string accNum;

        public static void BuildMenu()
        {
            Console.WriteLine("\n\n\n");
            Console.Write("Account Number: ");
            accNum = Console.ReadLine();

            SignUpPage.SignUpBackEnd();
        }

        private static void SignUpBackEnd()
        {
            CheckAccountValidity();
        }
    }
}