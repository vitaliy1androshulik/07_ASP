using _03_SecondHomeWorkViewModel.Data;
using _03_SecondHomeWorkViewModel.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _03_SecondHomeWorkViewModel.Controllers
{
    public class CatalogController : Controller
    {
        public MercedesDbContext context;
        public CatalogController()
        {
            context = new MercedesDbContext();
        }
        public IActionResult Catalog()
        {
            var mercedeses = context.Mercedes.ToList();
            return View(mercedeses);
        }
        public IActionResult Delete(int id)
        {
            var mercedes = context.Mercedes.Find(id);
            if(mercedes == null)
            {
                return NotFound();
            }
            context.Mercedes.Remove(mercedes);
            context.SaveChanges();

            return RedirectToAction("Catalog");
        }
    }
}
