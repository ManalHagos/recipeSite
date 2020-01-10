using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipeSite.Models
{
    public interface IRepository
    {
        IQueryable<Recipe> Recipes { get; }
        void Add(Recipe recipe);
        void Delete(int Id);
    }
}
