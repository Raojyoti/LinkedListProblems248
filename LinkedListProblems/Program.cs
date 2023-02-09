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
            Console.WriteLine("1.InsertNodeBetweenNodesInLinkedList\n2.Exit\n");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            { 
                case 1:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(70);
                    linkedList.InsertAtParticularPosition(1, 30);
                    linkedList.Display();
                    break; 
                case 2:
                    Console.Clear();
                    linkedList.Display();
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