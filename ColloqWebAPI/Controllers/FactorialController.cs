using ColloqWebAPI.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ColloqWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactorialController : ControllerBase
    {
        private readonly IFactorialCalculatorService _calcService;

        public FactorialController(IFactorialCalculatorService calcService)
        {
            _calcService = calcService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFactorial(int n)
        {
            var result = _calcService.CalculateFactorial(n);
            return Ok(result.ToString());
        }
    }
}
