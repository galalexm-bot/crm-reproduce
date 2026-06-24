using System.Xml.Linq;
using Orchard.Recipes.Models;

namespace Orchard.Recipes.Services;

public static class RecipeParserExtensions
{
	public static Recipe ParseRecipe(this IRecipeParser recipeParser, string recipeText)
	{
		XDocument recipeDocument = XDocument.Parse(recipeText, LoadOptions.PreserveWhitespace);
		return recipeParser.ParseRecipe(recipeDocument);
	}
}
