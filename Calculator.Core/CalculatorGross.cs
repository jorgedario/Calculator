using Calculator.Core.Contracts;
using Calculator.Core.Models;

namespace Calculator.Core
{
    internal class CalculatorGross : CalculatorBase, ICalculator
    {
        public CalculatorResponse ExecuteAsync(CalculatorRequest request)
        {
            var tax = VatTax[(int)request.VatTax];
            var gross = request.Amount; 
            var net = gross / (1 + tax);
            var vat = net * tax;

           return GetResponse(vat, net, gross);
           
        }
    }
}
