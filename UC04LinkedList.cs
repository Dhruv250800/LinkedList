using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class UseCase4LinkedList : LinkedList<int>
    {
        public void CreateLinkedList()
        {
            AddLast(56);
            InsertAfter(56, 30);
            AddLast(70);
            Display();  // Output: 56 30 70
        }

        public void InsertAfter(int existingValue, int value)
        {
            Node<int> current = head;
            while (current != null)
            {
                if (current.data == existingValue)
                {
                    Node<int> newNode = new Node<int>(value);
                    newNode.next = current.next;
                    current.next = newNode;
                    if (current == tail)
                        tail = newNode;
                    count++;
                    break;
                }
                current = current.next;
            }
        }
    }
}
