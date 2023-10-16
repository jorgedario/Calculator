using Calculator.Core.Contracts;
using Calculator.Core.Models;
using Calculator.Core.Resources;

namespace Calculator.Core
{
    public class CalculatorFactory : ICalculatorFactory
    {
        public ICalculator Create(CalculatorType type)
        {
            switch (type)
            {
                case CalculatorType.VAt:
                    return new CalculatorVat();
                case CalculatorType.Gross:
                    return new CalculatorGross();
                case CalculatorType.Net:
                    return new CalCulatorNet();
                default:
                    throw new CalculatorArguemtException(Messages.InvalidTypeOfCalculation);
            }
        }
    }
}
