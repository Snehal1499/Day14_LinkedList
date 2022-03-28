using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedList Program ");
            //LinkedList list = new LinkedList();
            //list.Add(56);
            //int a = list.Search(56);
            //list.InsertAtParticulatPosition(a+1,30);
            //int b = list.Search(30);
            //list.InsertAtParticulatPosition(b + 1, 70);
            //list.Display();
            //Console.WriteLine("Popping first Element in List");
            //list.PoP_First_element();
            //list.Display();
            //Console.WriteLine("Popping Last Element in List");
            //list.PoP_Last_element();
            //Console.WriteLine("Search Element and Adding 40 after 30");
            //int a = list.Search(30);
            //Console.WriteLine("index position of element 30 is :" + a);
            //list.InsertAtParticulatPosition(a + 1, 40);
            //list.Display();
            //Console.WriteLine("Popping element 40 in List");
            //int b = list.Search(40);
            //Console.WriteLine("index position of element 40 is :" + b);
            //list.PoP_Paricular_element(3);
            //list.Display();
            SortedLinkedList sl = new SortedLinkedList();
            sl.Add(56);
            sl.Add(30);
            sl.Add(40);
            sl.Add(70);
            sl.Display();
        }
    }
}
