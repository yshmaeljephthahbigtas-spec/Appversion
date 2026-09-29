using Microsoft.AspNetCore.Mvc;
using lol.Data;
using lol.Models;

namespace lol.Controllers
{
    public class ProductsController(ApplicationDbContext db) : Controller
    {
        private readonly ApplicationDbContext _db = db;

       
        public IActionResult Index()
        {
            var product = _db.Product.ToList();
            return View(product);
        }

       
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _db.Product.Add(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // EDIT - show the edit form
        public IActionResult Edit(int id)
        {
            var product = _db.Product.Find(id);

            if (product == null)
                return RedirectToAction("Index");

            return View(product);
        }

        // EDIT - save the changes
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _db.Product.Update(product);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // DELETE - remove the product
        public IActionResult Delete(int id)
        {
            var product = _db.Product.Find(id);

            if (product != null)
            {
                _db.Product.Remove(product);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}