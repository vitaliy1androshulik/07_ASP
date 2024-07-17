using Microsoft.AspNetCore.Mvc;

namespace _03_SecondHomeWorkViewModel.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }
    }
}
