//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System;

// Java program for implementation of Heap Sort
public class HeapSort
{
	public virtual void sort(int[] arr)
	{
		int n = arr.Length;

		// Build heap (rearrange array)
		for (int i = n / 2 - 1; i >= 0; i--)
		{
			heapify(arr, n, i);
		}

		// One by one extract an element from heap
		for (int i = n - 1; i >= 0; i--)
		{
			// Move current root to end
			int temp = arr[0];
			arr[0] = arr[i];
			arr[i] = temp;

			// call max heapify on the reduced heap
			heapify(arr, i, 0);
		}
	}

	// To heapify a subtree rooted with node i which is
	// an index in arr[]. n is size of heap
	internal virtual void heapify(int[] arr, int n, int i)
	{
		int largest = i; // Initialize largest as root
		int l = 2 * i + 1; // left = 2*i + 1
		int r = 2 * i + 2; // right = 2*i + 2

		// If left child is larger than root
		if (l < n && arr[l] > arr[largest])
		{
			largest = l;
		}

		// If right child is larger than largest so far
		if (r < n && arr[r] > arr[largest])
		{
			largest = r;
		}

		// If largest is not root
		if (largest != i)
		{
			int swap = arr[i];
			arr[i] = arr[largest];
			arr[largest] = swap;

			// Recursively heapify the affected sub-tree
			heapify(arr, n, largest);
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

	// Driver program
	//public static void Main(string[] args)
	//{
	//	int[] arr = new int[] {12, 11, 13, 5, 6, 7};
	//	int n = arr.Length;

	//	HeapSort ob = new HeapSort();
	//	ob.sort(arr);

	//	Console.WriteLine("Sorted array is");
	//	printArray(arr);
	//}
}