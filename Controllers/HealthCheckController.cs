using Microsoft.AspNetCore.Mvc;
using snk.Models;
namespace snk.Controllers;

[ApiController]
[Route("/HC")]
public class HealthCheckController : ControllerBase
{
    [HttpGet("healthCheck")]
    public ActionResult HealthCheck()
    {
        return Ok("Works");
    }
}
