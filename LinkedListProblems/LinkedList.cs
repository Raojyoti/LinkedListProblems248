using System;
using System.Collections.Generic;
using System.Data;
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
        public void InsertNewNodeInBetweenNode(Node prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Given previous node cannot be null {0}");
                return;
            }
            Node newNode = new Node(data);
            newNode.next = prevNode.next;//make next of newNode as next of prevNode
            prevNode.next = newNode;//make next of prevNode as newNode
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
                Console.WriteLine("\nNodes present in LinkedList:\n----------------------------");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
