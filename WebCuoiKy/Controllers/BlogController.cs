using Microsoft.AspNetCore.Mvc;

namespace WebCuoiKy.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
