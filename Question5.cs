using System;

public class Question5
{
	public void isPalindrome(String s)
	{
		String cleanS = s.Replace(" ", "").ToLower();
		Boolean palindrome = true;
		int length = cleanS.Length;
		for(int i = 0; i < length / 2; i++) 
        {
			if(cleanS[i] != cleanS[(length -i) -1])
            {
				palindrome = false;
				break;
            }
        }

        if (palindrome)
        {
			Console.WriteLine(s + " is a palindrome");
        }
        else { Console.WriteLine(s + " is not a palindrome"); }
	}
}
