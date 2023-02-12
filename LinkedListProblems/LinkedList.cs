using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListProblems
{
    public class LinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted into linkedlist", newNode.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is inserted into linkedlist", newNode.data);
            }
        }
        public void DeleteInBetweenelement(int node)
        {
            if(head==null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }
            if(head.data==node)
            {
                head=head.next;
                return;
            }
            Node temp= head;
            while(temp.next!= null)
            {
                if(temp.next.data==node)
                {
                    break;
                }
                temp = temp.next;
            }
            if (temp.next == null)
            {
                Console.WriteLine("Element" + node + "not present in linked list");
            }
            else
            {
                temp.next = temp.next.next;
            }
        }
        public void GetSize()
        {
            int count = 0;
            Node temp= head;
            while(temp!=null)
            {
                count++;
                temp= temp.next;
            }
            Console.WriteLine("\n\nNumber of node in linkedlist: {0}",count);
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node temp = head;
                Console.WriteLine("\nLinkedList Sequence are:\n----------------------------");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
