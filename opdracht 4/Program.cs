using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello. Please state your name.");
            string name = Console.ReadLine();
            string password = "SHARPSOUND";
            int amountOfTries = 1;

            logIn();
            void logIn()
            {
                if (amountOfTries == 1)
                {
                    Console.WriteLine("what is the password ?");
                }

                if (amountOfTries == 2)
                {
                    Console.WriteLine("try " + amountOfTries + " of 3");
                    Console.WriteLine("what is the password ?");
                }

                if (amountOfTries == 3)
                {
                    Console.WriteLine("try " + amountOfTries + " of 3");
                    Console.WriteLine("NOTE: Last attempt");
                    Console.WriteLine("wat is the password ?");
                }

                string passwordCheck = Console.ReadLine();
                if (passwordCheck == password)
                {
                    Console.WriteLine("Welcome by SoundSharp {0}", name);
                    DisplayMenu();
                    void DisplayMenu()
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine();
                        Console.WriteLine("1. Overzicht mp3 spelers");
                        Console.WriteLine("2.");
                        Console.WriteLine("3. ");
                        Console.WriteLine("4. ");
                        Console.WriteLine("5. ");
                        Console.WriteLine("6. ");
                        Console.WriteLine("7. ");
                        Console.WriteLine("8. ");
                        Console.WriteLine("9. Exit");
                        

                        
                    }
            

                }
                else
                {
                    amountOfTries++;
                    Console.WriteLine("password is incorrect");
                    if (amountOfTries == 4)
                    {
                        Environment.Exit(0);
                    }
                    logIn();
                }
            }
        }
    }
}
