using System.Collections.Generic;

namespace LinkedListProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Welcome to the LinkedList Problems\n-----------------------------");
            Console.WriteLine("First please select options");
            Console.WriteLine("1.SearchElementInLinkedList\n2.Exit\n");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    Console.WriteLine("Enter element to be inserted");
                    int addNode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter element after which to insert");
                    int givenNode = Convert.ToInt32(Console.ReadLine());
                    linkedList.InsertAfterSpecifiedNode(addNode,givenNode);
                    linkedList.Display();
                    linkedList.Search(30);
                    break; 
                case 2:
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select only given options");
                    break;
            }
            Console.ReadLine();
        }
    }
}