﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list",node.data);

        }
        public void AddInReverseOrder(int data)            // To Display Add Elements In Reverse Order
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted into linked list  ",newNode.data);
        }
        public int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while(node!= null)
            {
                if (node.data == value)
                    return count;
                node=node.next;
                count++;
            }
            return count;
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
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
        }
        public void InsertNode(int position ,int data)
        {
            var newnode = new Node(data);
            newnode.data = data;
            newnode.next = this.head;
            if (position < 1)
            {
                Console.WriteLine("invalid data");
            }
            if (position == 1)
            {
               newnode.next = this.head;
                head = newnode;
            }
            else
            {
                Node node1 = new Node(data);
                node1= this.head;
                
                while (position>2)
                {
                    node1= node1.next;
                    position--;
                }
                newnode.next = node1.next;
                node1.next = newnode;
               
            }
        }
        public Node Pop()                                   // Pop Method - To Delete First number 
        {
            Node node = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                head = head.next;
            }
            return node;
        }
        public Node PopLast()                               // PopLast Method - To Delete Last Element in Linked List 
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
                return null;
            }
            else
            {
                Node n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }
                n.next = null;
                return n;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list Is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
