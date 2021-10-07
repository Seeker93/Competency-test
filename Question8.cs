using System;

public class Question8
{
	public void SubArraySum()
	{
		int[][] arrayToSum = new int[][] { new int[] { 2, 3, 1, 6 }, new int[] { 4, 8, 1, 2 }, new int[] { 9, 2 } }; // hardcoded as per question
		int[] outputArray = new int[arrayToSum.GetLength(0)];  // Resulting array length will be equal to number of subarrays in the original


		for (int i = 0; i < outputArray.Length; i++)
		{
			int sum = 0;
			for(int j = 0; j < arrayToSum[i].Length; j++)
            {
				sum += arrayToSum[i][j];
            }
			outputArray[i] = sum;
        }
		Console.WriteLine("[{0}]", string.Join(", ", outputArray));
	}

}
