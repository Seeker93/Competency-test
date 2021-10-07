using System;

public class Question4
{
	public void getFactors(int n)
	{
        System.Console.WriteLine("The factors of " + n + " are:");

		for(int i = 1; i <= n; i++)
        {
            if (n % i == 0) // If it divides without a remainder it's a factor
            {
                System.Console.Write(i + ", ");
            }
        }
	}
}
