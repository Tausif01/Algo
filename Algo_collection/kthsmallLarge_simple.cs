//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System;

//internal / Java code for kth smallest element import java.util.Arrays;
// in an array

internal class GFGKthSmallest
{
	// Function to return k'th smallest 
	// element in a given array
	public static int kthSmallest(int?[] arr, int k)
	{
		// Sort the given array
		Array.Sort(arr);

		// Return k'th element in 
		// the sorted array
		return arr[k - 1].Value;
	}

	// driver program
	//public static void Main(string[] args)
	//{
	//	int?[] arr = new int?[]{12, 3, 5, 7, 19};
	//	int k = 2;
	//	Console.Write("K'th smallest element is " + kthSmallest(arr, k));
	//}
}