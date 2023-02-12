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
        public void InsertAfterSpecifiedNode(int addNode, int givenNode)
        {
            Node temp = head;
            while(temp!=null)
            {
                if(temp.data==givenNode)
                {
                    break;
                }
                temp=temp.next;
            }
            if(temp==null)
            {
                Console.WriteLine(givenNode +" not present in linked list");
            }
            else
            {
                Node newNode = new Node(addNode);
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }
        public bool Search(int node)
        {
            int position = 1;
            Node temp = head;
            while(temp!= null)
            {
                if (temp.data == node)
                {
                    break;
                }
                position++;
                temp = temp.next;
            }
            if(temp== null)
            {
                Console.WriteLine("\n"+ node + "not present in linkedlist");
                return false;
            }
            else
            {
                Console.WriteLine("\n"+ node + " present at " + position + " position in linkedlist");
                return true;
            }
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
