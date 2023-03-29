using Microsoft.AspNetCore.Mvc;

namespace LoadBalancingSandbox.Controllers;

[ApiController]
public class LivenessController : Controller
{
    [HttpGet("ping")]
    public IActionResult Ping()
    {
        return Ok("pong");
    }
}