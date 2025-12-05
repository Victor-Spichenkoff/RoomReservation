using EventPilot.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventPilot.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController(TestService testService)
{
    private readonly TestService _testService = testService;
    
    [HttpGet]
    public string Get() => "Hello World!";
    
    [HttpGet("/test2")]
    public string Get2() => _testService.GetTestString();
}