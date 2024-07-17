using _03_SecondHomeWorkViewModel.Data;
using _03_SecondHomeWorkViewModel.Entities;
using _03_SecondHomeWorkViewModel.MapperProfiles;
using _03_SecondHomeWorkViewModel.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _03_SecondHomeWorkViewModel.Controllers
{
    public class CatalogController : Controller
    {
        public MercedesDbContext context;
        private readonly IMapper mapper;
        public CatalogController(IMapper mapper)
        {
            context = new MercedesDbContext();
            this.mapper = mapper;
        }
        public IActionResult Catalog()
        {
            // load data from database
            var mercedeses = context.Mercedes
                .Include(x=>x.BrandOfCar) // LEFT JOIN
                .ToList();

            return View(mapper.Map<List<MercedesModel>>(mercedeses));
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
        [HttpPost]
        public IActionResult Create(MercedesModel model2) // Open create View
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                ViewBag.CreateMode = true;
                return View("Upsert", model2);
            }
            var entity = mapper.Map<Mercedes>(model2);
            context.Mercedes.Add(entity);
            context.SaveChanges();

            return RedirectToAction("Catalog");
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var mercedes = context.Mercedes.Find(id);

            if (mercedes == null) return NotFound();

            LoadCategories();
            ViewBag.CreateMode = false;
            return View("Upsert", mapper.Map<MercedesModel>(mercedes));
        }
        [HttpPost]
        public IActionResult Edit(MercedesModel model2)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                ViewBag.CreateMode = false;
                return View("Upsert",model2);
            }

            context.Mercedes.Update(mapper.Map<Mercedes>(model2));
            context.SaveChanges();

            return RedirectToAction("Catalog");
        }

        //Post and add to database product
        
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
