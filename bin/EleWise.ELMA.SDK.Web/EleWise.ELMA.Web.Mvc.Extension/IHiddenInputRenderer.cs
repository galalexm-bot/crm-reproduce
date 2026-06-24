using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IHiddenInputRenderer
{
	bool CanRender(HtmlHelper html, string expression, object value, IDictionary<string, object> additionalData);

	MvcHtmlString Hidden(HtmlHelper html, string expression, object value, IDictionary<string, object> additionalData);
}
