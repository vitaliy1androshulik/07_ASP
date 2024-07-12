using _03_SecondHomeWorkViewModel.Data;
using _03_SecondHomeWorkViewModel.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            // load data from database
            var mercedeses = context.Mercedes
                .Include(x=>x.BrandOfCar) // LEFT JOIN
                .ToList();

            return View(mercedeses);
        }
        //Open create View
        [HttpGet]
        public IActionResult Create() // Open create View
        {
            // ViewBag - collection of properties that is accessible in View
            LoadCategories();
            ViewBag.CreateMode = true;
            return View("Upsert");
        }
        [HttpGet]
        public IActionResult Edit(int Id) 
        {
            var mercedes = context.Mercedes.Find(Id);

            if (mercedes == null) return NotFound();
            LoadCategories();
            ViewBag.CreateMode = false;
            return View("Catalog",mercedes);
        }
        [HttpPost]
        public IActionResult Edit(Mercedes model2)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                ViewBag.CreateMode = false;
                return View("Upsert",model2);
            }

            context.Mercedes.Update(model2);
            context.SaveChanges();

            return RedirectToAction("Catalog");
        }

        //Post and add to database product
        [HttpPost]
        public IActionResult Create(Mercedes model2) // Open create View
        {
            if(!ModelState.IsValid) 
            {
                LoadCategories();
                ViewBag.CreateMode = true;
                return View("Upsert",model2);
            }
            context.Mercedes.Add(model2);
            context.SaveChanges();

            return RedirectToAction("Catalog");
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
        private void LoadCategories()
        {
            ViewBag.Brands = new SelectList(context.BrandOfCars.ToList(), "Id", "Name");
        }
    }
}
