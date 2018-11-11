using System;
using System.Collections;
using static System.Console;

public static class Calculator
{
    public static void Compute(char o, Stack input)
    {
        var result = 0m;
        try
        {

            switch (o)
            {
                case '+':
                    result = (decimal)input.Pop() + (decimal)input.Pop();
                    break;
                case '*':
                    result = (decimal)input.Pop() * (decimal)input.Pop();
                    break;
                case '/':
                    result = (decimal)input.Pop() / (decimal)input.Pop();
                    break;
                case '-':
                    result = (decimal)input.Pop() - (decimal)input.Pop();
                    break;
            }
        }
        catch (DivideByZeroException ex)
        {
            WriteLine($"{ex}, what are you doing?");
            throw new DivideByZeroException(ex.Message);
        }
        input.Push(result);

    }

}