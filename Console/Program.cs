using System;
using Library_Classes;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Supermarket S = new Supermarket();
            S.MobileApp = Convert.ToInt32(Console.ReadLine());
            Console.Write(S.PrintInfo(S));
            Console.ReadKey();
        }
    }
}