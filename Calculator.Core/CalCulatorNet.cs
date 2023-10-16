using Calculator.Core.Contracts;
using Calculator.Core.Models;

namespace Calculator.Core
{
    internal class CalCulatorNet : CalculatorBase, ICalculator
    {
        public CalculatorResponse ExecuteAsync(CalculatorRequest request)
        {
            var tax = VatTax[(int)request.VatTax];
            var net = request.Amount;
            var vat = net * tax;
            var gross = net + vat;

            return GetResponse(vat, net, gross);
        }
    }   
}
