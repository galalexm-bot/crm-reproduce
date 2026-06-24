using System;
using System.Collections.Generic;
using System.Linq;
using Orchard.Recipes.Models;

namespace Orchard.Recipes.Services;

public static class RecipeHarvesterExtensions
{
	public static Recipe GetRecipeByName(this IEnumerable<Recipe> recipes, string recipeName)
	{
		return recipes.FirstOrDefault((Recipe r) => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));
	}
}
