using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipeSite.Models
{
    public class Repository: IRepository
    {
        ApplicationDbContext context;
        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;

        public void Add(Recipe recipe)
        {
            if (recipe.ID == 0)
            {
                context.Recipes.Add(recipe);
                context.SaveChanges();
            }else
            {
                Recipe updateRecipe = context.Recipes.FirstOrDefault(r => r.ID== recipe.ID);
                if (updateRecipe != null)
                {
                    updateRecipe.image = recipe.image;
                    updateRecipe.Direction = recipe.Direction;
                    updateRecipe.Ingredients = recipe.Ingredients;
                    updateRecipe.RecipeName = recipe.RecipeName;
                    updateRecipe.Suggestions = recipe.Suggestions;
                    context.SaveChanges(); 
                }

            }
        }

        public void Delete(int Id)
        {
            Recipe DeleteRecipe = context.Recipes.FirstOrDefault(r => r.ID == Id);
            if(DeleteRecipe != null)
            {
                context.Remove(DeleteRecipe);
                context.SaveChanges();
            }
        }

    }
}
