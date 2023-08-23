using stringsearchtest;
using System;
using System.Net.Security;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            // Main application
            bool again = true;
            while (again) 
            {
                bool loop = true;
                int charNumb = Tools.AskForNumb();
                Tools.AskForChoice(charNumb);
                Console.WriteLine();
                while(loop)
                {
                    Console.Write("Generate again ? [y/n] : ");
                    string response = Console.ReadLine();
                    response = response.ToLower().Trim();
                    if(response == "y")
                    {
                        loop = false;
                    }
                    else if (response == "n")
                    {
                        loop = false;
                        again = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    Console.WriteLine();
                }
            }

            // Exite code
            Console.WriteLine("\npress any key to exit");
            Console.ReadLine();            
        }
    }
}