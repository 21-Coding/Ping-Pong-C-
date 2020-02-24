using System;
class  PingPong
{
  static void Main()
  {
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Hello! Welcome to Ping Pong, please enter a number:");
    int userInput = int.Parse(Console.ReadLine());
    for (int i = 1; i <= userInput; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ping-Pong");
      }
      else if (i % 3 == 0)
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Ping");
      }
      else if (i % 5 == 0)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Pong");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}
