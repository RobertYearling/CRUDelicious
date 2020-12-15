using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using CRUDelicious.Context;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private HomeContext _context { get; set; } 

        public HomeController(HomeContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = _context.Dishes.ToList();
            return View(AllDishes);
        }


        [HttpGet("/new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpGet("edit/{ID}")]
        public IActionResult Edit(int ID)
        {
            Dish ThisDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == ID);
            return View(ThisDish);
        }

        [HttpPost("update/{ID}")]
        public IActionResult Update(int ID, Dish ThisDish)
        {
            if(ModelState.IsValid)
            {
                Dish DBDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == ID);
                DBDish.Calories = ThisDish.Calories;
                DBDish.Comments = ThisDish.Comments;
                DBDish.Tastiness = ThisDish.Tastiness;
                DBDish.ChefName = ThisDish.ChefName;
                DBDish.DishName = ThisDish.DishName;
                DBDish.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                // _context.Entry(ThisDish).State = EntityState.Modified;
                return View("ThisItem",ThisDish);
            }
            else
            {
                return View("Edit",ThisDish);
            }
        }

        public IActionResult CreateDish(Dish NewDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(NewDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("new",NewDish);
            }
        }

        [HttpGet("delete/{ID}")]
        public IActionResult Delete(int ID)
        {

            Dish ThisDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == ID);
            _context.Dishes.Remove(ThisDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
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
