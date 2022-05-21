using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpclassrevew
{
    internal class genericseg
    {
        public void generic()
        {
            LinkedList<int> list = new LinkedList<int>(); // creating a object of in built LinkedList generic class 
            list.AddFirst(90); //  Linked List generic class to add 90 at first
            list.AddLast(80); //  Linked List generic class to add 80 at last
            list.AddLast(70); //  Linked List generic class to add 70 at last
            foreach (int element in list)
            {
                Console.WriteLine(element); // Printing all the element of linked list
            }
            Console.ReadLine();
        }
    }
}
