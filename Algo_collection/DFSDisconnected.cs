//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System;
using System.Collections.Generic;

// Java program to print DFS traversal from a given given graph

// This class represents a directed graph using adjacency list
// representation
internal class GraphDFSDisconnected
{
	private int V; // No. of vertices

	// Array  of lists for Adjacency List Representation
	private LinkedList<int>[] adj;

	// Constructor
	internal GraphDFSDisconnected(int v)
	{
		V = v;
		adj = new LinkedList<int>[v];
		for (int i = 0; i < v; ++i)
		{
			adj[i] = new LinkedList<int>();
		}
	}

	//Function to add an edge into the graph
	internal virtual void addEdge(int v, int w)
	{
		adj[v].AddLast(w); // Add w to v's list.
	}

	// A function used by DFS
	internal virtual void DFSUtil(int v, bool[] visited)
	{
		// Mark the current node as visited and print it
		visited[v] = true;
		Console.Write(v + " ");

		// Recur for all the vertices adjacent to this vertex
//JAVA TO C# CONVERTER WARNING: Unlike Java's ListIterator, enumerators in .NET do not allow altering the collection:
		IEnumerator<int> i = adj[v].GetEnumerator();
		while (i.MoveNext())
		{
			int n = i.Current;
			if (!visited[n])
			{
				DFSUtil(n,visited);
			}
		}
	}

	// The function to do DFS traversal. It uses recursive DFSUtil()
	internal virtual void DFS()
	{
		// Mark all the vertices as not visited(set as
		// false by default in java)
		bool[] visited = new bool[V];

		// Call the recursive helper function to print DFS traversal
		// starting from all vertices one by one
		for (int i = 0; i < V; ++i)
		{
			if (visited[i] == false)
			{
				DFSUtil(i, visited);
			}
		}
	}

    //public static void Main(string[] args)
    //{
    //    GraphDFSDisconnected g = new GraphDFSDisconnected(4);

    //    g.addEdge(0, 1);
    //    g.addEdge(0, 2);
    //    g.addEdge(1, 2);
    //    g.addEdge(2, 0);
    //    g.addEdge(2, 3);
    //    g.addEdge(3, 3);

    //    Console.WriteLine("Following is Depth First Traversal");

    //    g.DFS();
    //}
}