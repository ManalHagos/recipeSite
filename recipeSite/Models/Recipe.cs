using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace recipeSite.Models
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public string Suggestions { get; set; }
        public string Direction { get; set; }
        public int ID { get; set; }
        public string image { get; set; }
    }
}
