using Microsoft.AspNetCore.Mvc;

namespace EmailNotificationSystem.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SawliqController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Server is jogging");
    }
}