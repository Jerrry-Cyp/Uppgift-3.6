using System;

namespace Uppgift_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ditt namn:");
            string N = Console.ReadLine();
            string[] Namn = N.Split();
            string Förnamn = Namn[0];
            string Efternamn = Namn[1];
            Console.WriteLine(Förnamn + " " + Efternamn);
            if (Namn.Length > 2) Console.WriteLine("ERROR");
        }
    }
}