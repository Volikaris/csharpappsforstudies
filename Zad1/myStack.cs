using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class myStack
    {
        Stack miStack = new Stack();
        int counter = 0, tCounter = 0;
        public void myStackMain()
        {
            NPush("0. Test");
            NPush("1. Test2");
            NPush("2. Some long text also to test");

            Console.WriteLine("miStack ");
            Console.WriteLine("\tCount: {0}", miStack.Count);
            Console.WriteLine("\tStack initialized.");
        }
        public String PrintValues(IEnumerable col)
        {
            String values = "";
            if (counter > 0)
            {
                foreach (Object obj in col)
                {
                    Console.Write("    \"{0}\"", obj);
                    values += obj.ToString() + ", ";
                }
                Console.WriteLine();
                return values;
            }
            else
            {
                values = "Stack is empty";
                Console.WriteLine(values);
                return values;
            }
        }
        public Stack getStack()
        {
            return miStack;
        }
        public void NPush(String input)
        {
            tCounter++;
            counter++;
            miStack.Push(input);
        }
        public String NPop()
        {
            counter--;
            try
            {
                miStack.Pop();
                return "";
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack is empty" + e.StackTrace);
                return "Stack is empty";
            }
        }
        public String Top()
        {
            try
            {
                Console.WriteLine("Top item from stack is: " + miStack.Peek());
                return miStack.Peek().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack is empty" + e.StackTrace);
                return "Stack is empty";
            }
        }
        public String NClear()
        {
            counter = 0;
            miStack.Clear();
            return "Stack cleared.";
        }
        public Boolean isEmpty()
        {
            if (miStack.Count > 0) return false;
            else return true;
        }
        public int getCount()
        { 
            return counter;
        }
        public int getTotalCount()
        {
            return tCounter;
        }
    }
}