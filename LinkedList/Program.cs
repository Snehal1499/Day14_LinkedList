using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedList Program ");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.Display();
            Console.WriteLine("Adding 30 between 50 and 70");
            list.InsertAtParticulatPosition(2, 30);
            list.Display();
            Console.WriteLine("Popping first Element in List");
            list.PoP_First_element();
            list.Display();
        }
    }
}
