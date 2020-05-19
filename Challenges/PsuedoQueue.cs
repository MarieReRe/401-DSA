using DataStructures;
using System;
using System.Collections;
using System.Text;


namespace Challenges
{
    public class PsuedoQueue<T>
    {
        public Stack<T> stack1 = new Stack<T>();

        public Stack<T> stack2 = new Stack<T>();


        public void Enqueue(T value)
        {
            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);


            while (stack2 != null)
            {
                stack1.Push(stack2.Pop());
            }
     


        }


        public T Dequeue()
        {
            if (stack1.IsEmpty())
                throw new Exception();
            T result = (T) stack1.Peek();
            stack1.Pop();
            return result;

        }

      





    }
}
