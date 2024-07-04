using _02_FirstHomeWorkASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_FirstHomeWorkASP.Controllers
{
    public class CollectionController : Controller
    {
        List<CollectionWorks> collectionWorks;
        public CollectionController()
        {
            collectionWorks = new List<CollectionWorks>()
            {
                new CollectionWorks() { Id=1, Name="The Mystery of Cloomber", YearOfWritting=1888, Genre="Romance"},
                new CollectionWorks() { Id=2, Name="Narrative of John Smith", YearOfWritting=1883, Genre="Romance"},
                new CollectionWorks() { Id=3, Name="Sherlock Holmes: The Complete Novels and Stories", YearOfWritting=1927, Genre="Detective"},
                new CollectionWorks() { Id=4, Name="Sir Nigel", YearOfWritting=1906, Genre="Historical Romance"},
                new CollectionWorks() { Id=5, Name="The Lost World", YearOfWritting=1912, Genre="Science Fiction"},

            };
        }
        public IActionResult Collection()
        {
            return View(collectionWorks);
        }
    }
}
