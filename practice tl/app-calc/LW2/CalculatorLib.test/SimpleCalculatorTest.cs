using System;
using System.Collections.Generic;
using Xunit;

namespace CalculatorLib.test
{
    public class SimpleCalculatorTest
    {
        [Fact]
        public void SimpleCalculator_Calculate_AdditionOperation_Calculated()
        {
            //Arrange
            List<IOperation> operations = new List<IOperation>
            {
                new AdditionOpreation()
            };

            SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

            //Act
            int result = simpleCalculator.Calculate("2+2");

            //Assert
            Assert.Equal(4, result);
        }
    }
}
