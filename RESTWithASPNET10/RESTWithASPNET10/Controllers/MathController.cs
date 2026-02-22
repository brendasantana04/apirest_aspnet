using Microsoft.AspNetCore.Mvc;
using RESTWithASPNET10.Helper;
using RESTWithASPNET10.Service;

namespace RESTWithASPNET10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly CalculatorService _service;
        public MathController (CalculatorService calculatorService)
        {
            _service = calculatorService;
        }
        
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (ConvertHelper.IsNumeric(firstNumber) && ConvertHelper.IsNumeric(secondNumber))
            {
                var sum = _service.Sum(
                    ConvertHelper.ConvertToDecimal(firstNumber),
                    ConvertHelper.ConvertToDecimal(secondNumber)
                );
                return Ok(sum);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Subtracao(string firstNumber, string secondNumber)
        {
            if (ConvertHelper.IsNumeric(firstNumber) && ConvertHelper.IsNumeric(secondNumber))
            {
                var sub = _service.Subtracao(
                    ConvertHelper.ConvertToDecimal(firstNumber),
                    ConvertHelper.ConvertToDecimal(secondNumber)
                );
                return Ok(sub);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("mul/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplicacao(string firstNumber, string secondNumber)
        {
            if (ConvertHelper.IsNumeric(firstNumber) && ConvertHelper.IsNumeric(secondNumber))
            {
                var mul = _service.Multiplicacao(
                    ConvertHelper.ConvertToDecimal(firstNumber),
                    ConvertHelper.ConvertToDecimal(secondNumber)
                );
                return Ok(mul);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Divisao(string firstNumber, string secondNumber)
        {
            if (ConvertHelper.IsNumeric(firstNumber) && ConvertHelper.IsNumeric(secondNumber))
            {
                var div = _service.Divisao(
                    ConvertHelper.ConvertToDecimal(firstNumber),
                    ConvertHelper.ConvertToDecimal(secondNumber)
                );
                return Ok(div);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("med/{firstNumber}/{secondNumber}")]
        public IActionResult Media(string firstNumber, string secondNumber)
        {
            if (ConvertHelper.IsNumeric(firstNumber) && ConvertHelper.IsNumeric(secondNumber))
            {
                var med = _service.Media(
                    ConvertHelper.ConvertToDecimal(firstNumber),
                    ConvertHelper.ConvertToDecimal(secondNumber)/2
                );
                return Ok(med);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("raiz/{firstNumber}")]
        public IActionResult Raiz(string firstNumber)
        {
            if (ConvertHelper.IsNumeric(firstNumber))
            {
                var med = _service.Raiz(
                    ConvertHelper.ConvertToDecimal(firstNumber)
                );
                return Ok(med);
            }
            return BadRequest("Invalid input!");
        }
    }
}
