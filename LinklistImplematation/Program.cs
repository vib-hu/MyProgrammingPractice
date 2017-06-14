using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinklistImplematation
{
    class Program
    {
       static LinkList link = new LinkList();
        static void Main(string[] args)
        {
            Node node1 = new Node();
            node1.value = 1;
            node1.next = null;

            Node node2 = new Node();
            node2.value = 2;
            node2.next = node1;

            link.head = node2;
            link.current = node1;

            AddAtTail(5);

            Node head=link.head;

            while (head != null)
            {
                Console.Write(head.value+" ->");
                head = head.next;
            }
            Console.ReadLine();
        }

        public static void AddAtTail(int number)
        {
            Node node = new Node();
            node.value = number;
         
            link.current.next = node;
            link.current = link.current.next;
        }
    }


    public class Node
    {
        public int value;
        public Node next;
    }

    public class LinkList
    {
        public Node head;
        public Node current;
    }
}
