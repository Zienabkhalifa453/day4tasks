using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class program
    {
        public class Stack
        {
            private readonly List<object> itemList = new List<object>();
            
            public void Push(object obj)
            {
                itemList.Add(obj);
            }
            public object Pop()
            {
                var last = itemList.Last();
                itemList.Remove(last);
                return last;

            }
            public void Clear()
            {
                itemList.Clear();
            }
        }

            static void Main(string[] args)
            {
            var stack = new Stack();
            try
            {
                stack.Pop();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error ", e.Message);
            }
            finally
            {
                Console.WriteLine("The Stack elements are ");
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                Console.WriteLine();
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());









            }
            }
        }
}