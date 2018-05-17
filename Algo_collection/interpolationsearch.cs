//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System;

// Java program to implement interpolation search

internal class Test
{
	// Array of items on which search will
	// be conducted.
	internal static int[] arr = new int[]{10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47};

	// If x is present in arr[0..n-1], then returns
	// index of it, else returns -1.
	internal static int interpolationSearch(int x)
	{
		// Find indexes of two corners
		int lo = 0, hi = (arr.Length - 1);

		// Since array is sorted, an element present
		// in array must be in range defined by corner
		while (lo <= hi && x >= arr[lo] && x <= arr[hi])
		{
			// Probing the position with keeping
			// uniform distribution in mind.
			int pos = lo + (((hi - lo) / (arr[hi] - arr[lo])) * (x - arr[lo]));

			// Condition of target found
			if (arr[pos] == x)
			{
				return pos;
			}

			// If x is larger, x is in upper part
			if (arr[pos] < x)
			{
				lo = pos + 1;
			}

			// If x is smaller, x is in lower part
			else
			{
				hi = pos - 1;
			}
		}
		return -1;
	}

	// Driver method 
	//public static void Main(string[] args)
	//{
	//	 int x = 18; // Element to be searched
	//	 int index = interpolationSearch(x);

	//	 // If element was found
	//	 if (index != -1)
	//	 {
	//		   Console.WriteLine("Element found at index " + index);
	//	 }
	//		else
	//		{
	//		   Console.WriteLine("Element not found.");
	//		}
	//}
}