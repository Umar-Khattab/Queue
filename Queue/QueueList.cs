using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class QueueList
    {
        class Node
        {
            public int Data;
            public Node Next;
        }
        Node Front, Rear;
        public QueueList() {
            Front = Rear = null;
        }
        public bool IsEmpty()
        {
            if (Front == null) return true;
            else return false;
        }
        public void EnQueue(int Value)
        {
            Node temp = new Node();
            temp.Data = Value;
            if (IsEmpty())
            {
                Front = temp;
            }
            else
            {
                Rear.Next = temp;
            }
            Rear = temp;
        }
        public int DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue under flow");
                return int.MinValue;
            }
            int Value = Front.Data;
            Front = Front.Next;
            return Value;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return int.MinValue;
            }
            return Front.Data;
        }
        public void Display()
        {
            Node p = Front;
            while( p != null )
            {
                Console.Write($"{p.Data}  ");
                p = p.Next;
            }
            Console.WriteLine();
        }
    }
}
