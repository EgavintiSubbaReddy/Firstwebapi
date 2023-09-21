using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        //api/calculator/Add?x=10 & y=20
        [HttpGet("/DemoAdd")]
        public int DemoAdd(int x, int y)
        { return x + y; }
    }
}
