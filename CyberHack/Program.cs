using System;
using System.Globalization;

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string resposta1 = Console.ReadLine();

            string resposta2 = Console.ReadLine();

            // Define the character separator
            char separator = ' '; 
            string[] words = resposta2.Split(separator);

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            if(resposta1 == "CorporateServer")
            {
                if (words[0] == "Phishing" || words[0] == "Backdoor")
                {
                    Console.WriteLine("System Hacked");
                }
                else
                {
                    Console.WriteLine("System Secure");
                }

                foreach(string s in words)
                    {
                        if(s == "Phishing" || s == "Backdoor" )
                        {
                            a += 1;
                        }
                    }
            }
            else if(resposta1 == "BankDatabase")
            {
                if (words[0] == "ZeroDay" || words[0] == "AIOverride")
                {
                    Console.WriteLine("System Hacked");
                }
                else
                {
                    Console.WriteLine("System Secure");
                }

                foreach(string s in words)
                {
                    if(s == "Phishing" || s == "Backdoor" )
                    {
                        b += 1;
                    }
                }
            }
            else if(resposta1 == "SmartCityCore")
            {
                if (words[0] == "Backdoor" || words[0] == "Phishing")
                {
                    Console.WriteLine("System Hacked");
                }
                else
                {
                    Console.WriteLine("System Secure");
                }

                foreach(string s in words)
                {
                    if(s == "Phishing" || s == "Backdoor" )
                    {
                        c += 1;
                    }
                }
            }
            else if(resposta1 == "MilitaryAI")
            {
                if (words[0] == "BruteForce" || words[0] == "Phishing")
                {
                    Console.WriteLine("System Hacked");
                }
                else
                {
                    Console.WriteLine("System Secure");
                }

                foreach(string s in words)
                {
                    if(s == "Phishing" || s == "Backdoor" )
                    {
                        d += 1;
                    }
                }
            }

        }
    }
}
