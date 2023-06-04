using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class UseCase5LinkedList : LinkedList<int>
    {
        public void CreateLinkedList()
        {
            AddLast(56);
            AddLast(30);
            AddLast(70);
            RemoveFirst();
            Display();  // Output: 30 70
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
    }
}
