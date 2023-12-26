using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class QueueArray
    {
        int Front, Rear;
        int[] Data;
        public QueueArray(int size)
        {
            Data = new int[size];
            Front = Rear = -1;
        }
        bool IsEmpty()
        {
            if (Front == -1||Front == Rear++)
            {
                return true;
            }
            else
                return false;
        }
        bool IsFull()
        {
            if (Rear == Data.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue over flow");
                return;
            }
            if(Front == -1)
            {
                Front = 0;
            }
            Rear++;
            Data[Rear] = item;
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("queue under flow");
                return 0;
            }
            int x = Data[Front];
            Front++;
            return x;
        }
        public int PeekFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            return Data[Front];
        }
        public int PeekEnd()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            return Data[Rear];
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            for(int i = Front; i <= Rear; i++)
            {
                Console.Write($"{Data[i]}  ");
            }
        }
    }
}
