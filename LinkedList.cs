using System;
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
        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data+ " ");
                temp = temp.next;
            }
        }
        public void InsertNode(int position ,int data)
        {
            if (position < 1)
            {
                Console.WriteLine("invalid data");
            }
            if (position == 1)
            {
                var newnode= new Node(data);
                newnode.next = this.head;
                head= newnode;
            }
            else
            {
                while(position -- != 0)
                {
                    if(position == 1)
                    {
                        Node node1 = new Node(data);
                        node1.next = this.head.next;
                        head.next = node1;
                        break;
                    }
                    head= head.next;
                }
                if(position != 1)
                    Console.WriteLine("position out of range");
               
            }
        }
    }
}
