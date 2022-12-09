using System;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number from 0 to 9999: \n[end] to end program");
      string userInput = Console.ReadLine();
      if (userInput.ToLower() != "end")
      {
      Console.WriteLine("\n" + ConvertToWords.NumToString(ConvertToWords.Reverse(userInput.ToLower())) + "\n");
      Main();
      }
    }
  }
}