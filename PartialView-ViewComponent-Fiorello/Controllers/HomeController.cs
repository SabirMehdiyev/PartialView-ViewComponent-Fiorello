using Microsoft.AspNetCore.Mvc;
using PartialView_ViewComponent_Fiorello.DataAccessLayer;

namespace PartialView_ViewComponent_Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly int _productCount;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _productCount = _dbContext.Products.Count();
        }
        public IActionResult Index()
        {
            ViewBag.ProductCount = _productCount;
            var products = _dbContext.Products.Take(4).ToList();

            return View(products);
        }
        public IActionResult LoadProducts(int skip)
        {
            if (skip >= _productCount) return BadRequest(); 
            var products = _dbContext.Products.Skip(skip).Take(4).ToList();

            return PartialView("_ProductPartial" , products);
        }
    }
}
