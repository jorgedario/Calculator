using Calculator.Core;
using Calculator.Core.Contracts;
using Calculator.Core.Models;
using Calculator.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        ICalculatorModule _calculatorModule;

        public CalculatorController(ICalculatorModule calculatorModule)
        {
            _calculatorModule = calculatorModule;
        }

        [HttpPost]

        [ProducesResponseType(typeof(Response<CalculatorResponse>), 200)]
     
        public IActionResult Post(CalculatorRequest request)
        {
            return  Ok(new Response<CalculatorResponse> { Sucess=true,Obj=_calculatorModule.Execute(request)});
           
        }
    }
}