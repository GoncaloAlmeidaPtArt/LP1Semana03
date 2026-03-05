using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Length > 3)
                {
                    if(s.Length >= 8)
                    {
                        break;
                    }

                    Console.WriteLine(s);
                }
            }
        }
    }
}
