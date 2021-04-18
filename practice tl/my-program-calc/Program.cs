using System;
using calculator;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            iCalculator calculator = new SimpleCalculator();
            Console.WriteLine("Введите первый операнд");
            string op1 = Console.ReadLine();
            Console.WriteLine("Введите второй операнд");
            string op2 = Console.ReadLine();
            Console.WriteLine("Введите операцию");
            string operation = Console.ReadLine();
            Calculator(op1, op2, operation);
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
