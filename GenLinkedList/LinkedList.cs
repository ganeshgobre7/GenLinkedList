using System;
using System.Collections.Generic;
using System.Text;

namespace GenLinkedList
{
    class LinkedList<Gtype>
    {
        public Node <Gtype> head;
        /// <summary>
        /// Method to Adding Element in LL
        /// </summary>
        /// <param name="data"></param>
        public void Add(Gtype data)
        {
            Node<Gtype> node = new Node<Gtype>(data);//Creating object of Node class to getting new node
            if (this.head==null) //if list is empty
            {
                this.head = node;
            }
            else
            {
                Node<Gtype> temp = head;
                while(temp.next!=null) //iterating the while loop
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Insered Element in Linked list is :" + node.data);
        }
        /// <summary>
        /// Method to Add Element in First
        /// </summary>
        /// <param name="data"></param>
        public void InsertAtFirst(Gtype data)
        {
            Node<Gtype> node = new Node<Gtype>(data); //creating object to getting new node
            if (this.head == null) //if list is empty
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("After inserting Node at first Position :" + data);
        }
        /// <summary>
        /// Method to Add Element in Last Position in LL
        /// </summary>
        /// <param name="data"></param>
        public void InsertAtLast(Gtype data)
        {
            Node<Gtype> node = new Node<Gtype>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<Gtype> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("After inserting at last position : " + data);
        }
        /// <summary>
        /// Method to add element between two elements
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void InsertAtMiddle(int position, Gtype data)
        {
            Node<Gtype> node = new Node<Gtype>(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<Gtype> temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("After inserting at middle between 56 & 70 : " + data);
        }
        /// <summary>
        /// Method to delete the element at first position
        /// </summary>
        public void DeleteFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }
            head = head.next;
            Console.WriteLine("After deleting First node :");
        }
        /// <summary>
        /// Method to Display the Element in LL
        /// </summary>
        public void Display()
        {
            Node<Gtype> temp = this.head; 
            if(temp==null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
