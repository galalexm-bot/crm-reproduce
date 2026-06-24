using System.Collections.Generic;
using System.Linq;

namespace Orchard.Recipes.Models;

public class RecipeResult
{
	public string ExecutionId { get; set; }

	public IEnumerable<RecipeStepResult> Steps { get; set; }

	public bool IsCompleted => Steps.All((RecipeStepResult s) => s.IsCompleted);

	public bool IsSuccessful
	{
		get
		{
			if (IsCompleted)
			{
				return Steps.All((RecipeStepResult s) => s.IsSuccessful);
			}
			return false;
		}
	}
}
