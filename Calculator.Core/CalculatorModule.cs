using Calculator.Core.Contracts;
using Calculator.Core.Models;
using Calculator.Core.Resources;

namespace Calculator.Core
{
    public class CalculatorModule : ICalculatorModule
    {
        private readonly ICalculatorFactory _calculatorFactory;
        public CalculatorModule(ICalculatorFactory calculatorFactory)
        {
            _calculatorFactory = calculatorFactory;
        }
        public CalculatorResponse Execute(CalculatorRequest request)
        {
            if (request.Amount <= 0)
                throw new CalculatorArguemtException(Messages.InvalidAmount);
            switch (request.VatTax)
            {
                case VatTax.Vat10:
                case VatTax.Vat13:
                case VatTax.Vat20:
                    var calculator = _calculatorFactory.Create(request.type);
                    return calculator.ExecuteAsync(request);
                default:
                    throw new CalculatorArguemtException(Messages.InvalidVatTax);
            }


        }
    }
}
