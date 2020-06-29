using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestWithDotNetCore.Utils;

namespace RestWithDotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
    
        private readonly Utils.Utils _utils; 
        public CalculatorController()
        {
             _utils = new Utils.Utils();
        }

        // GET api/values/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public ActionResult<string> Sum(string firstNumber, string secondNumber)
        {
            if (_utils.IsNumeric(firstNumber) && _utils.IsNumeric(secondNumber))
            {
                var sum = _utils.ConvertToDecimal(firstNumber) + _utils.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/5
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public ActionResult<string> Subtraction(string firstNumber, string secondNumber)
        {
            if (_utils.IsNumeric(firstNumber) && _utils.IsNumeric(secondNumber))
            {
                var sum = _utils.ConvertToDecimal(firstNumber) - _utils.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/5
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public ActionResult<string> Division(string firstNumber, string secondNumber)
        {
            if (_utils.IsNumeric(firstNumber) && _utils.IsNumeric(secondNumber))
            {
                var sum = _utils.ConvertToDecimal(firstNumber) / _utils.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/5
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public ActionResult<string> Multiplication(string firstNumber, string secondNumber)
        {
            if (_utils.IsNumeric(firstNumber) && _utils.IsNumeric(secondNumber))
            {
                var sum = _utils.ConvertToDecimal(firstNumber) * _utils.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/5
        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public ActionResult<string> Mean(string firstNumber, string secondNumber)
        {
            if (_utils.IsNumeric(firstNumber) && _utils.IsNumeric(secondNumber))
            {
                var sum = (_utils.ConvertToDecimal(firstNumber) * _utils.ConvertToDecimal(secondNumber)) / 2;
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }
    }
}
