using LinkedListProgram;
using System;

program.cs
using System;
using System.Collections.Generic;

namespace LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program");

            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1. Add element at last position \n2. Add element at first position");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Add elements into Linkedlist using AddLast Method:");
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    break;
                case 2:
                    Console.WriteLine("Add elements into Linkedlist using AddFirst Method:");
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Please enter the correct option");
                    break;
            }

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
Linklist.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    internal class LinkedList
    {
        internal Node head;
        internal void AddLast(int data)
        {
            Node Node = new Node(data);
            if (this.head == null)
            {
                this.head = Node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = Node;
            }
            Console.WriteLine("{0} is inserted into LinkedList", Node.data);
        }
        internal void AddFirst(int data)
        {
            Node Node = new Node(data);
            Node.next = this.head;
            this.head = Node;
            Console.WriteLine("{0} is inserted into LinkedList", Node.data);
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes:");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
