using Microsoft.AspNetCore.Mvc;
using recipeSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipeSite.Controllers
{
    public class CRUDController : Controller
    {
        private IRepository Repository;
        private object repository;
        private object recipe;

        public CRUDController(IRepository repo)
        {
            Repository = repo;
        }

        public ViewResult AddRecipe()
        {
            return View(new Recipe());
        }

      
        [HttpPost]
        public IActionResult Update(int id)// load the selected recipe object, send it to the AddRecipe view ,
        {
            Recipe updateRecipe = new Recipe();
            updateRecipe = Repository.Recipes.FirstOrDefault(r=> r.ID == id);
            //return View("AddRecipe", updateRecipe);
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.RecipeName} has been saved!";
                return RedirectToAction("Index");
            }
            else
            {
                return View(recipe);
            }
        }
        //  i have to add update method add if statment

        public ActionResult Delete(int id)
        {
            Repository.Delete(id);
            return RedirectToAction ("RecipeList","Home");

        }
       
    }
}
