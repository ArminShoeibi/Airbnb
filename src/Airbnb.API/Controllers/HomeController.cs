using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Airbnb.API.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => Content($"{Dns.GetHostName()}{Environment.NewLine}{DateTimeOffset.Now}");
}
