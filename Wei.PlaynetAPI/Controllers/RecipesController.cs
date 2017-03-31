using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wei.PlaynetAPI.Models;

namespace Wei.PlaynetAPI.Controllers
{ 
    public class RecipesController : ApiController
    {
        static readonly IRecipeRepository respository = new RecipeRepository();

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return respository.GetAll();
        }

        public Recipe GetRecipe(int id)
        {
            Recipe recipe = respository.Get(id);
            if(recipe == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return recipe;
        }

        public HttpResponseMessage PostRecipe(Recipe recipe)
        {
            recipe = respository.Add(recipe);
            var response = Request.CreateResponse<Recipe>(HttpStatusCode.Created, recipe);
            string uri = Url.Link("DefaultApi", new { id = recipe.id });
            response.Headers.Location = new Uri(uri);
            return response;
        }


    }
}
