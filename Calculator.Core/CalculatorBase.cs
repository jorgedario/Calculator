using Calculator.Core.Models;

namespace Calculator.Core
{
    public class CalculatorBase
    {
        protected Dictionary<int, decimal> VatTax =

            new Dictionary<int, decimal>() { { 0, 0.1m }, { 1, 0.13m }, { 2, 0.2m } };



        public CalculatorResponse GetResponse(decimal vat, decimal net, decimal gross)
        {
            return new CalculatorResponse
            {
                Vat = Math.Round(vat,2),
                Net =Math.Round( net,2),
                Gross = Math.Round(gross,2),
            };
        }
    }

}