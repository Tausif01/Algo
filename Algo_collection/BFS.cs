//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System;
using System.Collections.Generic;

//internal / Java program to print BFS traversal from a given source vertex.import java.io.*;
// BFS(int s) traverses vertices reachable from s.

// This class represents a directed graph using adjacency list
// representation
internal class Graph
{
	private int V; // No. of vertices
	private LinkedList<int>[] adj; //Adjacency Lists

	// Constructor
	internal Graph(int v)
	{
		V = v;
		adj = new LinkedList<int>[v];
		for (int i = 0; i < v; ++i)
		{
			adj[i] = new LinkedList<int>();
		}
	}

	// Function to add an edge into the graph
	internal virtual void addEdge(int v, int w)
	{
		adj[v].AddLast(w);
	}

	// prints BFS traversal from a given source s
	internal virtual void BFS(int s)
	{
		// Mark all the vertices as not visited(By default
		// set as false)
		bool[] visited = new bool[V];

		// Create a queue for BFS
		LinkedList<int> queue = new LinkedList<int>();

		// Mark the current node as visited and enqueue it
		visited[s] = true;
		queue.AddLast(s);

		while (queue.Count != 0)
		{
            // Dequeue a vertex from queue and print it
            s = queue.First.Value;
                queue.RemoveFirst();
            Console.Write(s + " ");

			// Get all adjacent vertices of the dequeued vertex s
			// If a adjacent has not been visited, then mark it
			// visited and enqueue it
//JAVA TO C# CONVERTER WARNING: Unlike Java's ListIterator, enumerators in .NET do not allow altering the collection:
			IEnumerator<int> i = adj[s].GetEnumerator();
			while (i.MoveNext())
			{
				int n = i.Current;
				if (!visited[n])
				{
					visited[n] = true;
					queue.AddLast(n);
				}
			}
		}
	}

	// Driver method to
	//public static void Main(string[] args)
	//{
	//	Graph g = new Graph(4);

	//	g.addEdge(0, 1);
	//	g.addEdge(0, 2);
	//	g.addEdge(1, 2);
	//	g.addEdge(2, 0);
	//	g.addEdge(2, 3);
	//	g.addEdge(3, 3);

	//	Console.WriteLine("Following is Breadth First Traversal " + "(starting from vertex 2)");

	//	g.BFS(2);
	//}
}