using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    public interface IOperation
    {
        string OperatorCode { get; }
        int Apply(int operand1, int operand2);
    }
}
