using System;

namespace Application
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine($"Oppgave1: 1 equals 2 is {Oppave1(1, 2)}");

        Console.WriteLine($"Oppgave2: Return value with arguments 5 and 6 is {Oppgave2(5,6)}");
        Console.WriteLine($"Oppgave2: Return value with arguments 5 and 5 is {Oppgave2(5, 5)}");

        Console.WriteLine($"Oppgave3: 5, 10 or the sum of 5 + 10 is 30 = {Oppgave3(5,10)}");
        Console.WriteLine($"Oppgave3: 30, 10 or the sum of 30 + 10 is 30 = {Oppgave3(30, 10)}");
        Console.WriteLine($"Oppgave3: 10, 20 or the sum of 10 + 20 is 30 = {Oppgave3(10, 20)}");

    }
    static bool Oppave1(int x, int y)
    {
        if (x == y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static int Oppgave2(int x, int y)
    {
      if (x == y)
      {
          return x * y;
      }
      else
      {
          return x + y;
      }
    }
    static bool Oppgave3(int x, int y)
    {
      if ((x == 30) | (y == 30) | (x + y == 30))
      {
          return true;
      }
      else
      {
          return false;
      }
    }
  }
}