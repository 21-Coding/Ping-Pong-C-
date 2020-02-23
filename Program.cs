using System;

namespace pingPong
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello and welcome to Ping-Pong, enter a number!");
            for (int index = 1; index < gameLingo.length; index++)
            {
              Console.WriteLine(gameLingo[index]);
            }


            string stringUserNumber = Console.ReadLine();
            int intUserNumber = int.Parse(stringUserNumber);

        }
    }
}
