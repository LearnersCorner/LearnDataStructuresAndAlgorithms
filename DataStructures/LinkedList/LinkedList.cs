using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public record LinkedListNode<T>(T Value, LinkedListNode<T> Next = null, LinkedListNode<T> Prev = null);
    {

    }


    public class LinkedList<T>
    {

        private DataStructures.LinkedList.LinkedListNode<T> Head = null;
        private DataStructures.LinkedList.LinkedListNode<T> Tail = null;

    


}
}
