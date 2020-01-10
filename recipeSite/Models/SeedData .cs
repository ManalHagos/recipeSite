using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace recipeSite.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();
            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                      new Recipe
                      {
                          RecipeName = "Pizza",
                          Direction = "baking the pizza",
                          Ingredients = " 1/4 cup of oil ,1 tea spoon of backing powder ,1 cup of water" +
                "Mozerrial cheese , olive,grean paper",
                          Suggestions = "Add hotdog",
                          image = "/Images/1.jpg"
                      },
            new Recipe { RecipeName = "Kabsa", Direction = "boil the rice and then add chicken to it", Ingredients = "tomato, onion, oil, rice,chicken", Suggestions = "add carrot", image = "/Images/rice.jpg" },
            new Recipe
            {
                RecipeName = "Nuddle",
                Direction = "",
                Ingredients = "2 to 2-1/4 cups all-purpose flour" + "1/2 teaspoon salt, 2 egg yolks and 1 whole egg, lightly beaten, 1/3 cup water." + "1 teaspoon vegetable oil or olive oil,All-purpose flour.",
                Suggestions = "add hot sause",
                image = "/Images/China.jpg"
            },
            new Recipe { RecipeName = "Zegny", Direction = "fried onion with oil and tomato and hot sause", Ingredients = "onion, tomato, spices", Suggestions = "add eggs", image = "/Images/Sahly.jpg" },
            new Recipe { RecipeName = "Rice with beans", Direction = "boil the rice with beans and spices", Ingredients = "rice ,onion, tomato,salt,beans", Suggestions = "add fried banana", image = "/Images/Rice with beens.jpg" }
             );

                context.SaveChanges();

            }
        }
    }
}

      
    


