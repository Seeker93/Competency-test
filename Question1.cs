using System;
using System.Linq;

class Question1
{
    public void CountVowelsConsonants(string word)
    {
        String cleanWord = word.Replace(" ", "").ToLower(); // Remove whitespace which is useless for this question and put everything in lowercase
        int vowelCount = 0;
        int consonantCount = 0;
        char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };


        foreach (char c in cleanWord)
        {
            if (vowelArray.Contains(c))
            {
                vowelCount++;
            }
            else
            {
                consonantCount++;
            }
        }
        String vowelString = "The number of vowels in " + word + " is " + vowelCount;
        String consonantString = "The number of consonants in " + word + " is " + consonantCount;
        Console.WriteLine(vowelString + "\n" + consonantString);

    }

}
