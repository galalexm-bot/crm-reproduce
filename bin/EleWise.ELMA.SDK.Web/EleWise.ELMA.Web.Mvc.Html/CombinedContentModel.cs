using System;
using System.Linq.Expressions;
using System.Web.WebPages;

namespace EleWise.ELMA.Web.Mvc.Html;

public sealed class CombinedContentModel<TModel>
{
	public Expression<Func<TModel, dynamic>> Expression { get; set; }

	public string ExpressionText { get; set; }

	public Action<WebViewAttributes> ViewAttributesAction { get; set; }

	public Func<dynamic, HelperResult> EditorTemplate { get; set; }

	public Func<dynamic, HelperResult> СustomMarkup { get; set; }
}
