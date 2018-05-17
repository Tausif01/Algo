// Java Program to insert in a sorted list
using System;
internal class LinkedList
{
    internal Node head; // head of list

    /* Linked list Node*/
    internal class Node
    {
        private readonly LinkedList outerInstance;

        internal int data;
        internal Node next;
        internal Node(LinkedList outerInstance, int d)
        {
            this.outerInstance = outerInstance;
            data = d;
            next = null;
        }

        internal Node(int d)
        {
            data = d;
            next = null;
        }
    }

    /* function to insert a new_node in a list. */
    internal virtual void sortedInsert(Node new_node)
    {
        Node current;

        /* Special case for head node */
        if (head == null || head.data >= new_node.data)
        {
            new_node.next = head;
            head = new_node;
        }
        else
        {

            /* Locate the node before point of insertion. */
            current = head;

            while (current.next != null && current.next.data < new_node.data)
            {
                current = current.next;
            }

            new_node.next = current.next;
            current.next = new_node;
        }
    }

    /*Utility functions*/

    /* Function to create a node */
    internal virtual Node newNode(int data)
    {
        //Node x = new Node(this, data);
        Node x = new Node( data);
        return x;
    }

    /* Function to print linked list */
    internal virtual void printList()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }

    /* Drier function to test above methods */
    public static void Main(string[] args)
    {
        LinkedList llist = new LinkedList();
        Node new_node;
        new_node = llist.newNode(5);
        llist.sortedInsert(new_node);
        new_node = llist.newNode(10);
        llist.sortedInsert(new_node);
        new_node = llist.newNode(7);
        llist.sortedInsert(new_node);
        new_node = llist.newNode(3);
        llist.sortedInsert(new_node);
        new_node = llist.newNode(1);
        llist.sortedInsert(new_node);
        new_node = llist.newNode(9);
        llist.sortedInsert(new_node);
        Console.WriteLine("Created Linked List");
        llist.printList();
    }
}