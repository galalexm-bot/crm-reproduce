using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IHistoryPropertyRowDisplay
{
	bool CanDisplay(ModelMetadata oldMetadata, ModelMetadata newMetadata);

	MvcHtmlString DisplayChanges(HtmlHelper html, ModelMetadata oldMetadata, ModelMetadata newMetadata, PropertyChangesRow rowData);
}
