//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System;

// Java program for implementation of Insertion Sort
internal class InsertionSort
{
	/*Function to sort array using insertion sort*/
	internal virtual void sort(int[] arr)
	{
		int n = arr.Length;
		for (int i = 1; i < n; ++i)
		{
			int key = arr[i];
			int j = i - 1;

			/* Move elements of arr[0..i-1], that are
			   greater than key, to one position ahead
			   of their current position */
			while (j >= 0 && arr[j] > key)
			{
				arr[j + 1] = arr[j];
				j = j - 1;
			}
			arr[j + 1] = key;
		}
	}

	/* A utility function to print array of size n*/
	internal static void printArray(int[] arr)
	{
		int n = arr.Length;
		for (int i = 0; i < n; ++i)
		{
			Console.Write(arr[i] + " ");
		}

		Console.WriteLine();
	}

	// Driver method
	//public static void Main(string[] args)
	//{
	//	int[] arr = new int[] {12, 11, 13, 5, 6};

	//	InsertionSort ob = new InsertionSort();
	//	ob.sort(arr);

	//	printArray(arr);
	//}
}