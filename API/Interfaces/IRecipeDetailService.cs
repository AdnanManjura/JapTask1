using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Interfaces
{
    public interface IRecipeDetailService
    {
        Task<ActionResult<IEnumerable<RecipeDetails>>> GetRecipeDetails();
    }
}