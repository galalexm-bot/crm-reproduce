using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Orchard.Services;

namespace Orchard.Recipes.Services;

public class RecipeBuilder : Component, IRecipeBuilder, IDependency
{
	private readonly IClock _clock;

	public RecipeBuilder(IClock clock)
	{
		_clock = clock;
	}

	public XDocument Build(IEnumerable<IRecipeBuilderStep> steps)
	{
		BuildContext buildContext = new BuildContext
		{
			RecipeDocument = CreateRecipeRoot()
		};
		foreach (IRecipeBuilderStep item in steps.OrderByDescending((IRecipeBuilderStep x) => x.Priority))
		{
			item.Build(buildContext);
		}
		return buildContext.RecipeDocument;
	}

	private XDocument CreateRecipeRoot()
	{
		return new XDocument(new XDeclaration("1.0", "", "yes"), new XComment(base.T("Exported from Orchard").ToString()), new XElement("Orchard", new XElement("Recipe", new XElement("ExportUtc", _clock.UtcNow))));
	}
}
