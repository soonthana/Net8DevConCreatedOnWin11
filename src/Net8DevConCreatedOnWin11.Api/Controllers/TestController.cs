using Microsoft.AspNetCore.Mvc;

namespace Net8DevConCreatedOnWin11.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        var result = "Hello Test .NET 8, project created on Windows 11 Pro.";

        return Ok(result);
    }
}