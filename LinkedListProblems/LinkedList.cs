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
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} node inserted into linked list", newNode.data);
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
