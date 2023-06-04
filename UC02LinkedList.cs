using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class UseCase2LinkedList : LinkedList<int>
    {
        public void CreateLinkedList()
        {
            AddLast(70);
            AddLast(30);
            AddLast(56);
            Display();  // Output: 70 30 56
        }
    }
}
