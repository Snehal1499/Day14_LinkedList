using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SortedLinkedList
    {
        internal class Node
        {
            public int data;
            public Node next;
            public Node prev;
            public Node(int data)
            {
                this.data = data;
            }
        }
        Node head;
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");

            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
        public void Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return;
            }
            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            n.prev = t;
            Node p = head, q = p.next;
            //Sorting
            for (Node i = head; i.next != null; i = i.next)
            {
                for (Node j = i.next; j != null; j = j.next)
                {
                    if (i.data > j.data)
                    {
                        int temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }
            }
        }
    }
}

