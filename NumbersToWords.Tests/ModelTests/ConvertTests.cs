using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumbersToWords.Models;

namespace NumbersToWords.TestTools
{
  [TestClass]
  public class CovertToWordsTests
  {
    [TestMethod]
    public void Reverse_ReverseStringInput_CharArray()
    {
      string expected = "tset";
      Assert.AreEqual(expected, ConvertToWords.Reverse("test"));
    }

    [TestMethod]
    public void NumToString_ConvertsSingleDigitToString_String()
    {
      string expected = "three";
      Assert.AreEqual(expected, ConvertToWords.NumToString("3"));
    }

    [TestMethod]
    public void NumToString_ConvertTeenNumToString_String()
    {
      string expected = "thirteen";
      string test = ConvertToWords.Reverse("13");
      Assert.AreEqual(expected, ConvertToWords.NumToString(test));
    }

    [TestMethod]
    public void NumToString_ConvertDoubleDigitToString_String()
    {
      string expected = "twenty two";
      string test = ConvertToWords.Reverse("22");
      Assert.AreEqual(expected, ConvertToWords.NumToString(test));
    }

    [TestMethod]
    public void NumToString_ConvertTripleDigitToString_String()
    {
      string expected = "three hundred thirty three";
      string test = ConvertToWords.Reverse("333");
      Assert.AreEqual(expected, ConvertToWords.NumToString(test));
    }

    [TestMethod]
    public void NumToString_Convert4DigitsToString_String()
    {
      string expected = "three thousand four hundred fifty six";
      string test = ConvertToWords.Reverse("3456");
      Assert.AreEqual(expected, ConvertToWords.NumToString(test));
    }

    // [TestMethod]
    // public void NumToString_Convert5DigitsToString_String()
    // {
    //   string expected = "thirteen thousand four hundred fifteen";
    //   string test = ConvertToWords.Reverse("13415");
    //   Assert.AreEqual(expected, ConvertToWords.NumToString(test));
    // }
  }
}