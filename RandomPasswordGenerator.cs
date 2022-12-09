using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passwordLength = 0;
            string charakter;
            bool boolCharakter = true;
            string charCharakter;

            string specialCharacter;
            bool boolSpecialCharacter = true;
            string charSpecialCharacter;

            string number;
            bool boolNumber = true;
            string charNumber;

            bool Input = true;
            string finaleOutput = "";
            string password = "";


            Console.WriteLine("Hello, to my Random Password Generator!");

            do
            {
                Console.WriteLine("How long should the password be?");
                passwordLength = Convert.ToInt32(Console.ReadLine());
                if (passwordLength > 1 && passwordLength < 100)
                {
                    Input = true;
                }
                else
                {
                    Console.WriteLine("Wrong Input! Number must be between 1 and 100.");
                    Input = false;
                }
            } while (Input == false);

            do
            {
                do
                {
                    Console.WriteLine("Should the password contain charakters? (y/n)");
                    charakter = Console.ReadLine().ToLower();
                    if (charakter == "y")
                    {
                        boolCharakter = true;
                        Input = true;
                    }
                    else if (charakter == "n")
                    {
                        boolCharakter = false;
                        Input = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input! Try again...Remember just 'y' for yes or 'n' for no");
                        Input = false;
                    }
                } while (Input == false);


                do
                {
                    Console.WriteLine("Should the password contain special characters? (y/n)");
                    specialCharacter = Console.ReadLine().ToLower();
                    if (specialCharacter == "y")
                    {
                        boolSpecialCharacter = true;
                        Input = true;
                    }
                    else if (specialCharacter == "n")
                    {
                        boolSpecialCharacter = false;
                        Input = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input! Try again...Remember just 'y' for yes or 'n' for no");
                        Input = false;
                    }
                } while (Input == false);


                do
                {
                    Console.WriteLine("Should the password contain numbers? (y/n)");
                    number = Console.ReadLine().ToLower();
                    if (number == "y")
                    {
                        boolNumber = true;
                        Input = true;
                    }
                    else if (number == "n")
                    {
                        boolNumber = false;
                        Input = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input! Try again...Remember just 'y' for yes or 'n' for no");
                        Input = false;
                    }
                } while (Input == false);

                charCharakter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                charSpecialCharacter = "!?$%&()=+-*/<>-_";
                charNumber = "1234567890";

                if (boolCharakter == true && boolSpecialCharacter == true && boolNumber == true)
                {
                    finaleOutput = charCharakter + charSpecialCharacter + charNumber;
                }
                else if (boolCharakter == true && boolSpecialCharacter == true && boolNumber == false)
                {
                    finaleOutput = charCharakter + charSpecialCharacter;
                }
                else if (boolCharakter == true && boolSpecialCharacter == false && boolNumber == true)
                {
                    finaleOutput = charCharakter + charNumber;
                }
                else if (boolCharakter == false && boolSpecialCharacter == true && boolNumber == true)
                {
                    finaleOutput = charSpecialCharacter + charNumber;
                }
                else if (boolCharakter == true && boolSpecialCharacter == false && boolNumber == false)
                {
                    finaleOutput = charCharakter;
                }
                else if (boolCharakter == false && boolSpecialCharacter == true && boolNumber == false)
                {
                    finaleOutput = charSpecialCharacter;
                }
                else if (boolCharakter == false && boolSpecialCharacter == false && boolNumber == true)
                {
                    finaleOutput = charNumber;
                }
                else
                {
                    Console.WriteLine("Wrong Input! Must choose at least one option.");
                    Input = false;
                }
            } while (Input == false);
            

            Random random = new Random();
            for (int i = 1; i <= passwordLength; i++)
            {
                password += finaleOutput[random.Next(0, finaleOutput.Length)];
            }

            Console.WriteLine("Password: " + password);





            Console.ReadKey();
        }
    }
}
