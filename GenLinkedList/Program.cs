using System;

namespace GenLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO LINKED LIST PROGRAM!");
            LinkedList<int> list = new LinkedList<int>();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("-*************************************-");
            list.InsertAtFirst(50);
            list.Display();

        }
    }
}
