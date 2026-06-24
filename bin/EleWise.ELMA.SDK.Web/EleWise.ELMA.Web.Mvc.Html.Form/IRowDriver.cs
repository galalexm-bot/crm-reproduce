using System.Reflection;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public interface IRowDriver
{
	string PropertyName { get; }

	MvcHtmlString Caption(HtmlHelper html, object model, bool forDisplay);

	MvcHtmlString Value(HtmlHelper html, object model);

	MvcHtmlString Editor(HtmlHelper html, object model);

	PropertyInfo GetPropertyInfo();
}
