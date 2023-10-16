using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Models
{
    public class CalculatorRequest
    {
        public CalculatorType type { get; set; }
        public decimal Amount { get; set; }
        public VatTax VatTax { get; set; }
    }
}
