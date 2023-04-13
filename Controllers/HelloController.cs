using Microsoft.AspNetCore.Mvc;

namespace HelloWorldTestAzure.Controllers;

[ApiController] 
[Route("[controller]")]
public class HelloController : ControllerBase
{
  
    [HttpGet]
    public async Task<IActionResult> GetGreetings()
    {
        return Ok(new string[] { "Hello", "World" });
    }

}