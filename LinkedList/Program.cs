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
            int a = list.Search(56);
            list.InsertAtParticulatPosition(a + 1, 30);
            int b = list.Search(30);
            list.InsertAtParticulatPosition(b + 1, 70);
            list.Display();
        }
    }
}
