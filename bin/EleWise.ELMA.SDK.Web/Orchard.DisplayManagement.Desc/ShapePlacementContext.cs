using Orchard.ContentManagement;

namespace Orchard.DisplayManagement.Descriptors;

public class ShapePlacementContext
{
	public IContent Content { get; set; }

	public string ContentType { get; set; }

	public string Stereotype { get; set; }

	public string DisplayType { get; set; }

	public string Differentiator { get; set; }

	public string Path { get; set; }

	public string Source { get; set; }
}
