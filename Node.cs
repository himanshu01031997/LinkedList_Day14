using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;//value of node
        public Node next;//[pointer to next node]
        public Node(int data)//constructor
        {
            this.data = data;
        }
    }
}
