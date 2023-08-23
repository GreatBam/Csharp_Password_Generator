using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsearchtest
{
    internal class Tools
    {
        public static int AskForNumb()
        {
            bool charNumbSelection = true;
            string charNumbStr = "";
            int charNumb = 0;
            while (charNumbSelection)
            {
                Console.Write("How many charachters [6-14] : ");
                charNumbStr = Console.ReadLine();
                try
                {
                    charNumb = int.Parse(charNumbStr);
                    if (charNumb >= 6 && charNumb < 15)
                    {
                        charNumbSelection = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                }
            }
            return charNumb;
        }
        public static void AskForChoice(int charNumb)
        {
            bool optionSelection = true;
            string password = "";
            while (optionSelection)
            {
                Console.WriteLine("Choose an option :");
                Console.WriteLine("1 - Generate password only with lowercase");
                Console.WriteLine("2 - Generate password only with uppercase");
                Console.WriteLine("3 - Generate password with lowercase, uppercase and number");
                Console.WriteLine("4 - Generate password with all type of character");
                Console.Write("Your choice : ");
                string choiceStr = Console.ReadLine();
                Console.WriteLine();
                try
                {
                    int choice = int.Parse(choiceStr);
                    if (choice > 0 && choice < 5)
                    {
                        password = Tools.AlphabetSelection(choice, charNumb);
                        optionSelection = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
        public static string AlphabetSelection(int choice, int charNumb)
        {
            string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
            string alphabetUpper = alphabetLower.ToUpper();
            string alphabetAndNumbers = alphabetLower + alphabetUpper + "1234567890";
            string allCharachters = alphabetAndNumbers + "!$@#%&?_";
            string password = "";
            switch (choice)
            {
                case 1:
                    password = Tools.FinalPassword(alphabetLower, charNumb);
                    break;
                case 2:
                    password = Tools.FinalPassword(alphabetUpper, charNumb);
                    break;
                case 3:
                    password = Tools.FinalPassword(alphabetAndNumbers, charNumb);
                    break;
                case 4:
                    password = Tools.FinalPassword(allCharachters, charNumb);
                    break;
            }
            return password;
        }
        public static string FinalPassword(string dictonnary, int charNumb)
        {
            Random rnd = new();
            string password = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < charNumb; j++)
                {
                    char letter = dictonnary[rnd.Next(1, dictonnary.Length)];
                    password += letter;
                }
                Console.WriteLine($"Random password {i + 1} : {password}");
                password = "";
            }
            return password;
        }
    }
}
