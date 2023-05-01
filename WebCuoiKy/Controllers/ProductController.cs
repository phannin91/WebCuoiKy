using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebCuoiKy.Models;

namespace WebCuoiKy.Controllers
{

    public class ProductController : Controller
    {
        private readonly dbMarketsContext _context;
        public ProductController(dbMarketsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {

            var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
