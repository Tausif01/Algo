//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System;

internal class MergeSort
{
	// Merges two subarrays of arr[].
	// First subarray is arr[l..m]
	// Second subarray is arr[m+1..r]
	internal virtual void merge(int[] arr, int l, int m, int r)
	{
		// Find sizes of two subarrays to be merged
		int n1 = m - l + 1;
		int n2 = r - m;

		/* Create temp arrays */
		int[] L = new int [n1];
		int[] R = new int [n2];

		/*Copy data to temp arrays*/
		for (int x = 0; x < n1; ++x)
		{
			L[x] = arr[l + x];
		}
		for (int y = 0; y < n2; ++y)
		{
			R[y] = arr[m + 1 + y];
		}


		/* Merge the temp arrays */

		// Initial indexes of first and second subarrays
		int i = 0, j = 0;

		// Initial index of merged subarry array
		int k = l;
		while (i < n1 && j < n2)
		{
			if (L[i] <= R[j])
			{
				arr[k] = L[i];
				i++;
			}
			else
			{
				arr[k] = R[j];
				j++;
			}
			k++;
		}

		/* Copy remaining elements of L[] if any */
		while (i < n1)
		{
			arr[k] = L[i];
			i++;
			k++;
		}

		/* Copy remaining elements of R[] if any */
		while (j < n2)
		{
			arr[k] = R[j];
			j++;
			k++;
		}
	}

	// Main function that sorts arr[l..r] using
	// merge()
	internal virtual void sort(int[] arr, int l, int r)
	{
		if (l < r)
		{
			// Find the middle point
			int m = (l + r) / 2;

			// Sort first and second halves
			sort(arr, l, m);
			sort(arr, m + 1, r);

			// Merge the sorted halves
			merge(arr, l, m, r);
		}
	}

	/* A utility function to print array of size n */
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
	//	int[] arr = new int[] {12, 11, 13, 5, 6, 7};

	//	Console.WriteLine("Given Array");
	//	printArray(arr);

	//	MergeSort ob = new MergeSort();
	//	ob.sort(arr, 0, arr.Length - 1);

	//	Console.WriteLine("\nSorted array");
	//	printArray(arr);
	//}
}