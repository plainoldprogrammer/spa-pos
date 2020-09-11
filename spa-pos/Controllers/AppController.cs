using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace spa_pos.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AppController : ControllerBase
    {
        [HttpGet("hello")]
        public async Task<ActionResult<string>> SayHello() {
            Console.WriteLine("[API Controller] reached 'hello' end point");
            return "Hello from the server!";
        }
    }
}
