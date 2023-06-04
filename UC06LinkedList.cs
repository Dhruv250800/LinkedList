using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class UseCase6LinkedList : LinkedList<int>
    {
        public void CreateLinkedList()
        {
            AddLast(56);
            AddLast(30);
            AddLast(70);
            RemoveLast();
            Display();  // Output: 56 30
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
    }
}
