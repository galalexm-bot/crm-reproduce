using Orchard.Recipes.Models;

namespace Orchard.Recipes.Services;

public interface IRecipeResultAccessor : IDependency
{
	RecipeResult GetResult(string executionId);
}
