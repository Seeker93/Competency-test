using System;

public class Question3
{
	// Recursion seems like a good option for this, but I don't like using recursion for recursions sake when a sequential answer is usually simpler to understand
	public void generateFibo()
	{
		int numTerms = 10; // As per question
		int firstNum = 0;
		int secondNum = 1; // Start of fibonacci sequence
		int nextNum = 0;
		System.Console.WriteLine("The first 10 Fibonacci numbers are: ");
		for(int i=0; i<numTerms; i++)
        {
			System.Console.Write(firstNum + ", ");
			nextNum = firstNum + secondNum;
			firstNum = secondNum;
			secondNum = nextNum;
        }
	}
}
