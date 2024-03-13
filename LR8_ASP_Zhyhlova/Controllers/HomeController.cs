using Microsoft.AspNetCore.Mvc;
using LR8_ASP_Zhyhlova.Services;

namespace LR8_ASP_Zhyhlova.Controllers
{
    public class HomeController : Controller
    {
        private IProductsServices _productsServices;

        public HomeController(IProductsServices productsServices)
        {
            _productsServices = productsServices;
        }

        public IActionResult Index()
        {
            return View(_productsServices.GetProducts());
        }
    }
}
