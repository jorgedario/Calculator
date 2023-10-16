using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Contracts
{
    public   interface ICalculatorModule
    {
      CalculatorResponse     Execute (CalculatorRequest request);
    }
}
