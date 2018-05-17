using System;

// Java program to delete a given node in linked list under given constraints

internal class LinkedLst_Delete
{

    internal static Node head;

    internal class Node
    {

        internal int data;
        internal Node next;

        internal Node(int d)
        {
            data = d;
            next = null;
        }
    }
    //n =node to delete
    internal virtual void deleteNode(Node node, Node n)
    {

        // When node to be deleted is head node
        if (node == n)
        {
            if (node.next == null)
            {
                Console.WriteLine("There is only one node. The list " + "can't be made empty ");
                return;
            }

            /* Copy the data of next node to head */
            node.data = node.next.data;

            // store address of next node
            n = node.next;

            // Remove the link of next node
            node.next = node.next.next;

            // free memory
            System.GC.Collect();

            return;
        }

        // When not first node, follow the normal deletion process
        // find the previous node
        Node prev = node;
        while (prev.next != null && prev.next != n)
        {
            prev = prev.next;
        }

        // Check if node really exists in Linked List
        if (prev.next == null)
        {
            Console.WriteLine("Given node is not present in Linked List");
            return;
        }

        // Remove node from Linked List
        prev.next = prev.next.next;

        // Free memory
        System.GC.Collect();

        return;
    }

    /* Utility function to print a linked list */
    internal virtual void printList(Node head)
    {
        while (head != null)
        {
            Console.Write(head.data + " ");
            head = head.next;
        }
        Console.WriteLine("");
    }

    //public static void Main(string[] args)
    //{
    //    LinkedLst_Delete list = new LinkedLst_Delete();
    //    LinkedLst_Delete.head = new Node(12);
    //    LinkedLst_Delete.head.next = new Node(15);
    //    LinkedLst_Delete.head.next.next = new Node(10);
    //    LinkedLst_Delete.head.next.next.next = new Node(11);
    //    LinkedLst_Delete.head.next.next.next.next = new Node(5);
    //    LinkedLst_Delete.head.next.next.next.next.next = new Node(6);
    //    LinkedLst_Delete.head.next.next.next.next.next.next = new Node(2);
    //    LinkedLst_Delete.head.next.next.next.next.next.next.next = new Node(3);

    //    Console.WriteLine("Given Linked List :");
    //    list.printList(head);
    //    Console.WriteLine("");

    //    // Let us delete the node with value 10
    //    Console.WriteLine("Deleting node :" + head.next.next.data);
    //    list.deleteNode(head, head.next.next);

    //    Console.WriteLine("Modified Linked list :");
    //    list.printList(head);
    //    Console.WriteLine("");

    //    // Lets delete the first node
    //    Console.WriteLine("Deleting first Node");
    //    list.deleteNode(head, head);
    //    Console.WriteLine("Modified Linked List");
    //    list.printList(head);

    //}
}

// this code has been contributed by Mayank Jaiswal
