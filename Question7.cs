using System;

public class Question7
{
	// I'm assuming difference as in mathematical difference
	public void getArrayDifference(int[] array1, int[] array2)
	{
		int[] differenceArray = new int[array1.Length]; //Assuming the two input arrays are the same length
		for (int i = 0; i < array1.Length; i++)
        {
			differenceArray[i] = array2[i] - array1[i];
        }
		Console.WriteLine("[{0}]", string.Join(", ", differenceArray));
	}
}
