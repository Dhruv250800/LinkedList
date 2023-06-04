using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class UseCase9LinkedList : LinkedList<int>
    {
        public void CreateLinkedList()
        {
            AddLast(56);
            AddLast(30);
            AddLast(40);
            AddLast(70);
            Remove(40);
            Display();  // Output: 56 30 70
            Console.WriteLine("Linked List Size: " + Size());  // Output: Linked List Size: 3
        }

        public void Remove(int value)
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty. No element to remove.");
                return;
            }

            if (head.data.Equals(value))
            {
                head = head.next;
                count--;
                if (head == null)
                    tail = null;
                return;
            }

            Node<int> current = head;
            while (current.next != null)
            {
                if (current.next.data.Equals(value))
                {
                    current.next = current.next.next;
                    count--;
                    if (current.next == null)
                        tail = current;
                    return;
                }
                current = current.next;
            }

            Console.WriteLine(value + " not found in the linked list.");
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty. No element to remove.");
                return;
            }

            head = head.next;
            count--;

            if (head == null)
                tail = null;
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty. No element to remove.");
                return;
            }

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                Node<int> current = head;
                while (current.next != tail)
                {
                    current = current.next;
                }
                current.next = null;
                tail = current;
            }
            count--;
        }

        public int Size()
        {
            return count;
        }
    }
}
