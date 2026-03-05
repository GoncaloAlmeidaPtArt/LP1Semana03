using System;
using System.Globalization;

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Qual sistema deseja atacar ?");
            string resposta1 = Console.ReadLine();

            Console.WriteLine("Qual ferramente de hack queres usar ?");
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

            }
            else if(resposta1 == "SmartCityCore")
            {

            }
            else if(resposta1 == "MilitaryAI")
            {

            }

        }
    }
}
