using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterFastSaveExtendedFields
{
	bool CheckType(FilterModel model);

	MvcHtmlString Render(HtmlHelper html, FilterModel model);

	Dictionary<string, object> ExtendedDataFilter(HtmlHelper html, FilterModel model);

	string ClientValidateFunction(HtmlHelper html, FilterModel model);
}
