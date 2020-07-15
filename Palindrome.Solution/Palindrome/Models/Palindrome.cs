namespace PalindromeChecker.Palindrome
  {
    public class ArrayFunction
    {
      public string Input { get; set; }

      public void TestPalindrome(string input)
      {
        Input = input;
      } 
      public string RemoveCapitals(string input)
      {
        return input.ToLower();
      }

      public string ReverseString(string input)
      {
				string stringReversed = "";  
				int length;  

				length = input.Length - 1;  
          while (length >= 0)  
          {  
          stringReversed = stringReversed + input[length];  
          length--; 
          
          }  
			return stringReversed;
      }

      public bool PalindromeCheck(string reverseString, string input)
      {
        if (reverseString == input)
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