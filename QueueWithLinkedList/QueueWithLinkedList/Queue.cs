using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWithLinkedList
{
    public class Queue
    {
        public Node head;

        public void Enqueue(int value)
        {
            if (head == null)
            {
                Node newItem = new Node();
                newItem.value = value;
                head = newItem;
            }
            else
            {
                Node newItem = new Node();
                newItem.value = value;

                Node node = head;
                while(node.next != null)
                {
                    node = node.next;
                }

                node.next = newItem;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                Console.WriteLine(head.value);
                Node temp = head.next;
                head = null;
                head = temp;
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");

            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    Console.WriteLine(node.value);
                    node = node.next;
                }
            }
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
