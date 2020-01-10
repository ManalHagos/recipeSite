using Microsoft.AspNetCore.Mvc;
using recipeSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipeSite.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index()
        {
            return View();
        }

       
        public ViewResult Recipe(int id)
        {
            return View(repository.Recipes.FirstOrDefault(r => r.ID == id));

        }


        public ViewResult RecipeList()
        {
            return View(repository.Recipes);

        }

        public ViewResult AddRecipe()
        {
            return View(new Recipe());
        }

        [HttpPost]
        public IActionResult AddRecipe(Recipe recipes)
        {
            if (ModelState.IsValid)
            {
                repository.Add(recipes);
                return RedirectToAction("RecipeList");
            }
            return View(recipes);
        }

        public ViewResult ReviewRecipe()
        {
            return View();
        }

      

    }
}
