using System.Web;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.DisplayManagement.Implementation;

public class ShapeDisplayedContext
{
	public dynamic Shape { get; set; }

	public ShapeMetadata ShapeMetadata { get; set; }

	public IHtmlString ChildContent { get; set; }
}
