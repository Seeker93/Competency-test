using System;

public class Question6
{
	public void BubbleSort()
	{
		int[] arrayToSort = new int[] { 64, 34, 25, 12, 22, 11, 90 }; // Array hardcoded as per question
		Boolean sorted = false;
		while (!sorted) // Compare adjacent values, swap them, and repeat until the whole list is sorted
		{
			sorted = true;
			for (int i = 0; i < arrayToSort.Length - 2; i++)
			{
				if (arrayToSort[i] > arrayToSort[i + 1])
				{
					sorted = false; // If we are swapping, it means the list is not sorted yet
					int temp = arrayToSort[i];
					arrayToSort[i] = arrayToSort[i + 1];
					arrayToSort[i + 1] = temp;
					
				}
			}
		}
		Console.WriteLine("[{0}]", string.Join(", ", arrayToSort));
	}
}
