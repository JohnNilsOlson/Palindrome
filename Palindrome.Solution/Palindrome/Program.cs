using System;
using Palindrome;

namespace PalindromeChecker
{
  public class Program {
    public static void Main()
    {
      Console.WriteLine("please Enter a word");
      string input = Console.ReadLine();

      TestPalindrome test = new TestPalindrome(input);

      test.RemoveCapitals();
      test.ReverseString();
      Console.WriteLine((test.PalindromeCheck()).ToString());
      
    }
  }
}