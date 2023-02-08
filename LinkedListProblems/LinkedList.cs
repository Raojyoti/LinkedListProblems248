using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class LinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newnode = new Node(data);
            if(head == null)
            {
                head = newnode;
                Console.WriteLine("{0} node inserted into LinkedList", newnode.data);
            }
            else
            {
                Node temp=head;
                while(temp.next != null)
                {
                    temp= temp.next;
                }
                temp.next = newnode;
                Console.WriteLine("{0} node inserted into LinkedList", newnode.data);
            }
        }
        public void Display()
        {
            if(head== null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node temp =head;
                Console.WriteLine("\nNodes present in LinkedList:\n----------------------------");
                while (temp != null)
                {
                    Console.Write(temp.data+" ");
                    temp =temp.next;
                }
            }
        }
    }
}
