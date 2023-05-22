using CalculatorTest.Lib;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorTest.API.Controllers {

    [Route("simplecalculator")]
    [ApiController]
    public class SimpleCalculatorController : ControllerBase {

        private readonly ISimpleCalculator simpleCalculator;

        public SimpleCalculatorController(ISimpleCalculator simpleCalculator) {
            this.simpleCalculator = simpleCalculator;
        }

        [EnableCors("Calculator")]
        [HttpGet]
        [Route("add/{start:int}/{amount:int}")]
        public IActionResult Add(int start, int amount) {
            try {
                return Ok(simpleCalculator.Add(start, amount));
            }
            catch(Exception exception) {
                return NotFound(exception.Message);
            }
        }

        [EnableCors("Calculator")]
        [HttpGet]
        [Route("subtract/{start:int}/{amount:int}")]
        public IActionResult Subtract(int start, int amount) {
            try {
                return Ok(simpleCalculator.Subtract(start, amount));
            }
            catch(Exception exception) {
                return NotFound(exception.Message);
            }
        }

    }

}