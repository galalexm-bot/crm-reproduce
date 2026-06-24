using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Selectors;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ITabProviderExtension
{
	IEnumerable<TabPanelItem> Items(HtmlHelper htmlHelper);

	string IdTabPanal(HtmlHelper htmlHelper);
}
