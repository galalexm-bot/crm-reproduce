using System.Linq;

namespace Orchard.DisplayManagement.Shapes;

public class TagBuilderFactory : ITagBuilderFactory, IDependency
{
	public OrchardTagBuilder Create(dynamic shape, string tagName)
	{
		OrchardTagBuilder orchardTagBuilder = new OrchardTagBuilder(tagName);
		orchardTagBuilder.MergeAttributes(shape.Attributes, false);
		foreach (dynamic item in shape.Classes ?? Enumerable.Empty<string>())
		{
			orchardTagBuilder.AddCssClass(item);
		}
		if ((!string.IsNullOrEmpty(shape.Id)))
		{
			orchardTagBuilder.GenerateId(shape.Id);
		}
		return orchardTagBuilder;
	}
}
