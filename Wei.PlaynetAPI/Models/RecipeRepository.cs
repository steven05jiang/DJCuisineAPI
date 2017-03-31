using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wei.PlaynetAPI.Models
{
    public class RecipeRepository : IRecipeRepository
    {
        private List<Recipe> recipes = new List<Recipe>();
        private int _nextId = 1;
        public RecipeRepository() {
            Add(new Recipe { title = "Fish" });
            Add(new Recipe { title = "Beef" });
            Add(new Recipe { title = "Chicken" });
        }

        public Recipe Add(Recipe recipe)
        {
            if(recipes == null) { recipes = new List<Recipe>();  }
            recipe.id = this._nextId++;
            recipes.Add(recipe);
            return recipe;
        }

        public Recipe Get(int id)
        {
            return recipes.Find(r => r.id == id);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return recipes;
        }

        public void Remove(int id)
        {
            recipes.RemoveAll(r => r.id == id);
        }

        public bool Update(Recipe recipe)
        {
            if(recipe == null)
            {
                throw new ArgumentNullException("recipe");
            }
            int index = recipes.FindIndex(r => r.id == recipe.id);
            if(index == -1)
            {
                return false;
            }
            recipes.RemoveAt(index);
            recipes.Add(recipe);
            return true;
        }
    }
}