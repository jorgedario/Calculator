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
   

        public static void  UseCalculator(this IServiceCollection services)
        {
            services.AddScoped<ICalculatorModule, CalculatorModule>();
            services.AddScoped<ICalculatorFactory, CalculatorFactory>();

        }
    }
}
