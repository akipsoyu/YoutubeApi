using Microsoft.AspNetCore.Mvc;

namespace YoutubeApi.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
