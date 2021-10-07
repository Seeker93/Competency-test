using System;
using System.Collections.Generic;

class Question2
{
    public void CountIntances(string word)
    {
        word = word.Replace(" ", "").ToLower();
        IDictionary<Char, int> charCount = new Dictionary<Char, int>();
        int currentCount;

        foreach (char c in word)
        {
            // If the char is found, add it to dictionary with a count of one. Otherwise, increment the value by 1

            charCount.TryGetValue(c, out currentCount);
            charCount[c] = currentCount + 1;
        }

        foreach (KeyValuePair<Char, int> kvp in charCount)
        {

            Console.WriteLine(kvp.Key + " = " + kvp.Value);
        }

    }
}
