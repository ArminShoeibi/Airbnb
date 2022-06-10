using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Airbnb.API.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        this._logger = logger;
    }
    public IActionResult Index()
    {
        // creating a scope because of readability for when having multiple instances of this app with "docker compose up"
        string hostName = Dns.GetHostName();
        using (_logger.BeginScope("HostName: {HostName}", hostName))
        {
            _logger.LogInformation("Handling request");
            return Content($"HostName: {hostName}{Environment.NewLine}Timestamp: {DateTimeOffset.Now}");
        }
    }
}