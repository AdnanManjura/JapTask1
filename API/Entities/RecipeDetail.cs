using API.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class RecipeDetail
    {
        public float Quantity { get; set; }

        public MeasureUnitEnum MeasureUnit { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }

        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}