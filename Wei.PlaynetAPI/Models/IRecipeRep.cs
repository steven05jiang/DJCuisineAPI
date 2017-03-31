using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wei.PlaynetAPI.Models
{
    interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAll();
        Recipe Get(int id);
        Recipe Add(Recipe recipe);
        void Remove(int id);
        bool Update(Recipe recipe);
    }
}
