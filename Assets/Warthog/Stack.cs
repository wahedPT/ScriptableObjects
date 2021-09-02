
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


namespace Stacks
{


    public class Stack<T>
    {
        List<T> contents = new List<T>();
        //constructor
        public Stack()
        {

        }

        public int count

        {
            get { return contents.Count; }

        }
        public void Push(T item)
        {
            contents.Add(item);
        }

        public T Pop()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Cant pop from stack");
            }
            else
            {
                T item = contents[contents.Count - 1];
                contents.RemoveAt(contents.Count - 1);
                return item;
            }
        }

        public T Peek()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Cant peek from stack");

            }
            else
            {
                return contents[contents.Count - 1];
            }
        }

    }
}