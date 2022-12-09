using System;

namespace NumbersToWords.Models
{
  public class ConvertToWords
  {
    private static Dictionary<char, string> ones = new Dictionary<char, string>()
    {
      {'0', "zero"},
      {'1', "one"},
      {'2', "two"}, 
      {'3', "three"},
      {'4', "four"},
      {'5', "five"},
      {'6', "six"},
      {'7', "seven"},
      {'8', "eight"},
      {'9', "nine"}
    };

    private static Dictionary<char, string> teens = new Dictionary<char, string>()
    {
      {'0', "ten"},
      {'1', "eleven"},
      {'2', "twelve"}, 
      {'3', "thirteen"},
      {'4', "fourteen"},
      {'5', "fifteen"},
      {'6', "sixteen"},
      {'7', "seventeen"},
      {'8', "eighteen"},
      {'9', "nineteen"}
    };

    private static Dictionary<char, string> tenths = new Dictionary<char, string>()
    {
      {'2', "twenty"}, 
      {'3', "thirty"},
      {'4', "fourty"},
      {'5', "fifty"},
      {'6', "sixty"},
      {'7', "seventy"},
      {'8', "eighty"},
      {'9', "ninety"}
    };
  
    public static string Reverse(string input)
    {
      char[] charArray = input.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
    
    public static string NumToString(string input)
    {
      string output = "";
      for (int i = 0; i < input.Length; i++)
      {
        if (i == 0)
        {
          output = ones[input[i]];
        }
        else if (i == 1)
        {
          if (input[i] == '1')
          {
            output = teens[input[i - 1]];
          }
          else
          {
            output = tenths[input[i]] + " " + output;
          }
        }
        else if (i == 2)
        {
          output = ones[input[i]] + " hundred " + output;
        }
        else if (i == 3)
        {
          output = ones[input[i]] + " thousand " + output;
        }
      }
      return output;
    }
  }
}