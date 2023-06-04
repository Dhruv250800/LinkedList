using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class UseCase7LinkedList : LinkedList<int>
    {
        public void CreateLinkedList()
        {
            AddLast(56);
            AddLast(30);
            AddLast(70);
            int searchValue = 30;
            Node<int> foundNode = null;
            Node<int> current = head;
            while (current != null)
            {
                if (current.data == searchValue)
                {
                    foundNode = current;
                    break;
                }
                current = current.next;
            }
            if (foundNode != null)
                Console.WriteLine("Found: " + foundNode.data);
            else
                Console.WriteLine("Not found");
        }
    }

}
