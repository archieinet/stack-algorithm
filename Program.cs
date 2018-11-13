using System;
using System.Collections;
using static System.Console;

namespace StackConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Stack Algorithm 101");
            Stack s = new Stack();
            //add collection to the stack
            ArrayList listOfArray = new ArrayList { '*', '+', '+', '*', 2.0, 3.0, 10, 4, 2 };
            Stack numStack = new Stack();

            // foreach (var item in listOfArray)
            //     s.Push(item);

            Array.ForEach(listOfArray.ToArray(), s.Push);

            foreach (var item in s)
            {
                //WriteLine($"Stack {item}");
                if (item is int || item is float || item is long || item is float || item is decimal || item is double)
                {
                    numStack.Push(Convert.ToDecimal(item));
                    Write($"{item} ");
                }
                else
                    Calculator.Compute((char)item, numStack);

            }
            s.Clear();
            WriteLine($"Total is: {numStack.Peek()}");
            ReadLine();
        }

    }
}
