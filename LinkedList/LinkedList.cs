using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
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
        internal Node InsertAtParticulatPosition(int pos, int data)
        {
            if (pos < 1)
                Console.WriteLine("invalid Position");
            if (pos == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (pos-- != null)
                {
                    if (pos == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (pos != 1)
                {
                    Console.WriteLine("Position out of range");
                }
            }
            return head;
        }
        internal Node PoP_First_element()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node PoP_Last_element()
        {
            if (this.head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        internal void PoP_Paricular_element(int pos)
        {
            Node temp = head;
            for (int i = 2; i < pos; i++)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
        }
        internal int Search(int value)
        {
            Node node = this.head;
            int count = 1;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;

            }
            return count;

        }
    }
}