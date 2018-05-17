﻿//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System;

// A Java program for Dijkstra's single source shortest path algorithm.
// The program is for adjacency matrix representation of the graph

internal class ShortestPath
{
	// A utility function to find the vertex with minimum distance value,
	// from the set of vertices not yet included in shortest path tree
	internal const int V = 9;
	internal virtual int minDistance(int[] dist, bool[] sptSet)
	{
		// Initialize min value
		int min = int.MaxValue, min_index = -1;

		for (int v = 0; v < V; v++)
		{
			if (sptSet[v] == false && dist[v] <= min)
			{
				min = dist[v];
				min_index = v;
			}
		}

		return min_index;
	}

	// A utility function to print the constructed distance array
	internal virtual void printSolution(int[] dist, int n)
	{
		Console.WriteLine("Vertex   Distance from Source");
		for (int i = 0; i < V; i++)
		{
			Console.WriteLine(i + " tt " + dist[i]);
		}
	}

	// Funtion that implements Dijkstra's single source shortest path
	// algorithm for a graph represented using adjacency matrix
	// representation
	internal virtual void dijkstra(int[][] graph, int src)
	{
		int[] dist = new int[V]; // The output array. dist[i] will hold
								 // the shortest distance from src to i

		// sptSet[i] will true if vertex i is included in shortest
		// path tree or shortest distance from src to i is finalized
		bool[] sptSet = new bool[V];

		// Initialize all distances as INFINITE and stpSet[] as false
		for (int i = 0; i < V; i++)
		{
			dist[i] = int.MaxValue;
			sptSet[i] = false;
		}

		// Distance of source vertex from itself is always 0
		dist[src] = 0;

		// Find shortest path for all vertices
		for (int count = 0; count < V - 1; count++)
		{
			// Pick the minimum distance vertex from the set of vertices
			// not yet processed. u is always equal to src in first
			// iteration.
			int u = minDistance(dist, sptSet);

			// Mark the picked vertex as processed
			sptSet[u] = true;

			// Update dist value of the adjacent vertices of the
			// picked vertex.
			for (int v = 0; v < V; v++)
			{

				// Update dist[v] only if is not in sptSet, there is an
				// edge from u to v, and total weight of path from src to
				// v through u is smaller than current value of dist[v]
				if (!sptSet[v] && graph[u][v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u][v] < dist[v])
				{
					dist[v] = dist[u] + graph[u][v];
				}
			}
		}

		// print the constructed distance array
		printSolution(dist, V);
	}

	// Driver method
	//public static void Main(string[] args)
	//{
	//	/* Let us create the example graph discussed above */
	//   int[][] graph = new int[][]
	//   {
	//	   new int[] {0, 4, 0, 0, 0, 0, 0, 8, 0},
	//	   new int[] {4, 0, 8, 0, 0, 0, 0, 11, 0},
	//	   new int[] {0, 8, 0, 7, 0, 4, 0, 0, 2},
	//	   new int[] {0, 0, 7, 0, 9, 14, 0, 0, 0},
	//	   new int[] {0, 0, 0, 9, 0, 10, 0, 0, 0},
	//	   new int[] {0, 0, 4, 14, 10, 0, 2, 0, 0},
	//	   new int[] {0, 0, 0, 0, 0, 2, 0, 1, 6},
	//	   new int[] {8, 11, 0, 0, 0, 0, 1, 0, 7},
	//	   new int[] {0, 0, 2, 0, 0, 0, 6, 7, 0}
	//   };
	//	ShortestPath t = new ShortestPath();
	//	t.dijkstra(graph, 0);
	//}
}
//This code is contributed by Aakash Hasija