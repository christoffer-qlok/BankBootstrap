﻿namespace BankBootstrap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank!");
            Console.WriteLine("Please log in");

            Console.Write("Enter user name:");
            string userName = Console.ReadLine();

            Console.Write("Enter pin code:");
            string pin = Console.ReadLine();

            if(userName == "admin")
            {
                if(pin != "1234")
                {
                    Console.WriteLine("Wrong password!");
                    return;
                }

                AdminFunctions.DoAdminTasks();
                return;
            }

            // Code here for user login *****
        }
    }
}