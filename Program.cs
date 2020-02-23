using System;

namespace pingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gameLingo;

            gameLingo = new string["Ping","Pong","Ping-Pong"];

            Console.WriteLine("Hello user, enter a number!");
            string stringUserNumber = Console.ReadLine();
            int intUserNumber = int.Parse(stringUserNumber);

        }
    }
}
