using System;
using System.Text.RegularExpressions;


namespace TextBasedRPGGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Action gameStart = new Action();

            gameStart.Start();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}