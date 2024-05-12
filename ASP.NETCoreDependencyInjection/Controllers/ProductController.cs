using ASP.NETCoreDependencyInjection.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreDependencyInjection.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) 
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.GetAllProduct());
        }
    }
}
