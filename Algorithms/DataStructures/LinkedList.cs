using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
    public class LinkedList<T>
    {
        private T data;
        private LinkedList<T> next;

        public LinkedList(T value)
        {
            data = value;
        }

        public LinkedList<T> Next() { return next; }
        public T value() { return data; }
        public void setNext(LinkedList<T> elem) { next = elem; }
        public void setValue(T value) { data = value; }
    }
}
