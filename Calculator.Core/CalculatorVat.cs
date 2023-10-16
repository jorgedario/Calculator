using Calculator.Core.Contracts;
using Calculator.Core.Models;

namespace Calculator.Core
{
    internal class CalculatorVat :CalculatorBase, ICalculator
    {
        public CalculatorResponse ExecuteAsync(CalculatorRequest request)
        {
            var tax =VatTax[(int)request.VatTax];
            var vat = request.Amount;
            var net = request.Amount / tax;
            var gross= net+ vat;

            return GetResponse(vat, net, gross);
        }
    }
}
