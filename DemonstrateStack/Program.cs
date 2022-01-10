using System;
using System.Collections;

namespace DemonstrateStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            //adding elements to the stack 
            st.Push(10);
            st.Push(25);
            st.Push(40);
            st.Push(29);
            st.Push(48);

            Console.WriteLine("Elements of Stack");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            //adding additional elements to the stack
            st.Push(90);
            st.Push(5);
            Console.WriteLine("\nElements of Stack After Re-adding");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            //It will delete recently added element
            st.Pop();
            Console.WriteLine("\nElements of Stack After deleting");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("\nRetriving First element of stack : "+ st.Peek());
            Console.WriteLine("Number of elements in the stack : " + st.Count);
            

        }
    }
}
