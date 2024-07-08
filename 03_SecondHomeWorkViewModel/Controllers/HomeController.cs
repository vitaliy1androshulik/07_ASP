using _03_SecondHomeWorkViewModel.Data;
using _03_SecondHomeWorkViewModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _03_SecondHomeWorkViewModel.Controllers
{
    public class HomeController : Controller
    {
        private MercedesDbContext context = new MercedesDbContext();
        public IActionResult Index()
        {
            var mercedes = context.Mercedes.Include(x=>x.BrandOfCar).ToList();
            return View(mercedes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
