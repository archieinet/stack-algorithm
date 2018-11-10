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
            ArrayList listOfArray = new ArrayList { '*', '+', '+', '*', 2.5, 3.5, 10, 12, 2 };
            Stack numStack = new Stack();

            foreach (var item in listOfArray)
                s.Push(item);

            foreach (var item in s)
            {
                //WriteLine($"Stack {item}");
                if (item is int || item is float || item is long || item is float || item is decimal || item is double)
                {
                    numStack.Push(Convert.ToDecimal(item));
                    Write($"{item} ");
                }
                else
                    Calculator((char)item);
            }
            s.Clear();
            WriteLine($"Total is: {numStack.Peek()}");
            ReadLine();

            void Calculator(char o)
            {
                var result = 0m;
                try
                {

                    switch (o)
                    {
                        case '+':
                            result = (decimal)numStack.Pop() + (decimal)numStack.Pop();
                            break;
                        case '*':
                            ;
                            result = (decimal)numStack.Pop() * (decimal)numStack.Pop();
                            break;
                        case '/':
                            result = (decimal)numStack.Pop() / (decimal)numStack.Pop();
                            break;
                        case '-':
                            result = (decimal)numStack.Pop() - (decimal)numStack.Pop();
                            break;
                    }
                }
                catch (DivideByZeroException ex)
                {
                    WriteLine($"{ex}, what are you doing?");
                    throw new DivideByZeroException(ex.Message);
                }


                numStack.Push(result);

            }



        }

    }
}
