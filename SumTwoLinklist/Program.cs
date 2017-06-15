using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoLinklist
{
    class Program
    {
        static LinkList firstLinkList = new LinkList();
        static LinkList secondLinkList = new LinkList();
        public static StringBuilder number= new StringBuilder();

        static void Main(string[] args)
        {
            Node node1 = new Node();
            node1.value = 6;
            node1.next = null;

            Node node2 = new Node();
            node2.value = 1;
            node2.next = node1;

            Node node3 = new Node();
            node3.value = 7;
            node3.next = node2;

            firstLinkList.head = node3;
            firstLinkList.current = node1;

            Node node4 = new Node();
            node4.value = 2;
            node4.next = null;

            Node node5 = new Node();
            node5.value = 9;
            node5.next = node4;

            Node node6 = new Node();
            node6.value = 5;
            node6.next = node5;

            secondLinkList.head = node6;
            secondLinkList.current = node4;

            SumLinkList();
            Console.ReadLine();

        }

        public static void SumLinkList()
        {
          var num=  getNumber(firstLinkList.head);
          Console.WriteLine(num);
        }

        public static int getNumber(Node next)
        {
            if (next == null)
                return 0;

            getNumber(next.next);
            number.Append(next.value);
            return Convert.ToInt32(number.ToString());
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
