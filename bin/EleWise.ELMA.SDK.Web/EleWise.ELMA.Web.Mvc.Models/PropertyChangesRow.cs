using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models;

public class PropertyChangesRow
{
	public MvcHtmlString Caption { get; set; }

	public MvcHtmlString OldValue { get; set; }

	public MvcHtmlString NewValue { get; set; }

	public string PropertyExpression { get; set; }

	public object OldState { get; set; }

	public object NewState { get; set; }
}
