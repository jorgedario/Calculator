using Calculator.Core.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public  static  class CalculatorStartUp
    {
   

        public static void  InitCalculator(this IServiceCollection services)
        {
            services.AddScoped<ICalculatorModule, CalculatorModule>();
            services.AddScoped<ICalculatorFactory, CalculatorFactory>();

        }
    }
}
