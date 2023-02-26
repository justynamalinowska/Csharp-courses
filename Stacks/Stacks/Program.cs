using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining a new stack
            Stack<int> stack = new Stack<int>();
            //adding elements to the stack
            stack.Push(1);
            stack.Push(2);
            //return a elementat the top of the stack without removing it
            Console.WriteLine("on the top is: " + stack.Peek());
            //removing item on the top
            Console.WriteLine("Pooped item: " + stack.Pop());
            Console.WriteLine("on the top is: " + stack.Peek());
            stack.Push(3);
            stack.Push(4);

            while (stack.Count > 0)
            {
                stack.Pop();
                Console.WriteLine(stack.Count);
            }




            int[] numbers = new int[] { 8,2,3,4,7,6,2};
            //defining a stack of int
            Stack<int> myStack = new Stack<int>();

            for (int i = numbers.Length -1 ; i > -1 ; i--)
            {
                myStack.Push(numbers[i]);
                Console.WriteLine("num: " + myStack.Pop());
            }

        } 
    }
}