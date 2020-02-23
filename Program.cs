using System;

namespace pingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gameLingo;

            gameLingo = new string[3]{"Ping","Pong","Ping-Pong"};

            Console.WriteLine("Hello and welcome to Ping-Pong, enter a number!");
            string stringUserNumber = Console.ReadLine();
            int intUserNumber = int.Parse(stringUserNumber);

        }
    }
}
