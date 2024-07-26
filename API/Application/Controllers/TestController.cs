using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Application.Controllers;


[ApiController]
[Route("api")]
public class TestController : ControllerBase
{
    [Authorize]
    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok("Only testing.");
    }

    [HttpGet("test2")]
    public IActionResult Test2()
    {
        return Ok("Test 2.");
    }
}