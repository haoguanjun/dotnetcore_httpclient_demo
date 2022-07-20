using Microsoft.AspNetCore.Mvc;
using MyApp;

namespace dempApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    private readonly ILogger<DemoController> _logger;
    private readonly FakeApiClient _apiClient;
    // 构造函数注入
    public DemoController(
        FakeApiClient apiClient,
        ILogger<DemoController> logger)
    {
        _logger = logger;
        _apiClient = apiClient;
    }

    [HttpGet("{id}", Name = "GetWeatherForecast")]
    public  Task<User> Get(int id)
    {
        var user = _apiClient.GetUser(id);
        return user;
    }
}
