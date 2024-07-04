using _03_SecondHomeWorkViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_SecondHomeWorkViewModel.Controllers
{
    public class CatalogController : Controller
    {
        List<Mercedes> mercedeses;
        public CatalogController()
        {
            mercedeses = new List<Mercedes>()
            {
                new Mercedes() {Id=1, BrandOfCar="Mercedes-Benz", Model="E450 4MATIC", Class="E-Class",
                Price=3735256, Discount=2, HorsePower=375, Volume=3.0, Year=2024},
                new Mercedes() {Id=2, BrandOfCar="Mercedes-Benz", Model="E 220 d", Class="E-Class",
                Price=2823744, Discount=5, HorsePower=194, Volume=2.0, Year=2024},
                new Mercedes() {Id=3, BrandOfCar="Mercedes-Benz", Model="A 180", Class="A-Class",
                Price=1998166, Discount=2, HorsePower=136, Volume=1.95, Year=2024},
                new Mercedes() {Id=4, BrandOfCar="Mercedes-AMG", Model="A 35 AMG 4MATIC", Class="A-Class",
                Price=2794320, Discount=0, HorsePower=306, Volume=2.0, Year=2024},
                new Mercedes() {Id=5, BrandOfCar="Mercedes-Benz", Model="C 180", Class="C-Class",
                Price=2148646, Discount=15, HorsePower=168, Volume=1.5, Year=2024},
            };
        }
        public IActionResult Catalog()
        {
            return View(mercedeses);
        }
    }
}
