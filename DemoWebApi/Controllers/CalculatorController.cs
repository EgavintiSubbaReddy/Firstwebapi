using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //api/calculator/Add?x=10 & y=20
        [HttpGet("/AddCalculator")]
        public int Add(int x, int y)
        { return x + y; }

        [HttpGet("/Sum")]
        public int Sum(int x, int y)
        { return x + y + 1000; }

        //api/calculator/Subtract?x=30 & y=20
        [HttpPost]
        public int Subtract(int x, int y)
        { return x - y; }
        
        //api/calculator/multiply?x=10 & y=20
        [HttpPut]
        public int Multiply(int x, int y)
        { return x * y; }
        //api/calculator/Divide?x=40 & y=20
        [HttpDelete]
        public int Divide(int x, int y)
        { return x / y; }
        
    }
}
