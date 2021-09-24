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
            Console.WriteLine("-*********************************-");
            list.InsertAtFirst(45);
            list.Display();
            Console.WriteLine("-*********************************-");
            list.InsertAtLast(90);
            list.Display();
            Console.WriteLine("-*********************************-");
            list.InsertAtMiddle(4,40);
            list.Display();
            Console.WriteLine("-*********************************-");
            list.DeleteFirst();
            list.Display();
            Console.WriteLine("-*********************************-");
            list.DeleteLast();
            list.Display();
            Console.WriteLine("-*********************************-");
            list.SearchElement(30);
            Console.WriteLine("-*********************************-");
            Console.WriteLine("Inserting any position");
            list.InsertAtMiddle(2, 65);
            list.Display();
           



        }
    }
}
