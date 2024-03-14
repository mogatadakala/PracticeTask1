using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeTask1.Models;

namespace PracticeTask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(new Response { Name = "test",Phone="test" });;
        }
    }
}
