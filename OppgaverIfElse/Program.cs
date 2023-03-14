using System;

namespace Application
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine($"Oppgave1: 1 equals 2 is {Oppave1(1, 2)}");
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
  }
}