using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class UseCase10SortedLinkedList : LinkedList<int>
    {
        public new void AddLast(int value)
        {
            Node<int> newNode = new Node<int>(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else if (value.CompareTo(head.data) <= 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node<int> current = head;
                while (current.next != null && value.CompareTo(current.next.data) > 0)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
                if (current == tail)
                    tail = newNode;
            }
            count++;
        }

        public void CreateSortedLinkedList()
        {
            AddLast(56);
            AddLast(30);
            AddLast(40);
            AddLast(70);
            Display();  // Output: 30 40 56 70
        }
    }
}
