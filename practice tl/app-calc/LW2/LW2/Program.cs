using CalculatorLib;
using System;
using System.Collections.Generic;

namespace LW2
{
    class Program
    {
        static void Main(string[] args)
        {
            if ( args.Length < 1)
            {
                Console.WriteLine("Please specify calсulation string");
                return;
            }
            List<IOperation> operations = new List<IOperation>
            {
                new AdditionOpreation()
            };
            ICalculator calculator = new SimpleCalculator(operations);
            calculator.Calculate( args[0] );
        }

        static void Calculator(string op1, string op2, string operation)
        {
            int op1Conv = int.Parse(op1);
            int op2Conv = int.Parse(op2);
            switch (operation)
            {
                case "+":
                    Console.WriteLine(op1Conv + op2Conv);
                    break;
                case "-":
                    Console.WriteLine(op1Conv - op2Conv);
                    break;
                case "/":
                    Console.WriteLine(op1Conv / op2Conv);
                    break;
                case "*":
                    Console.WriteLine(op1Conv * op2Conv);
                    break;
                case "%":
                    Console.WriteLine(op1Conv % op2Conv);
                    break;
                default:
                    Console.WriteLine("Я не знаю такую операцию");
                    break;
            }
        }
    }
}
