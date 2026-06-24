using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IActionItemProvider
{
	void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper);

	[Obsolete("Method is not used")]
	IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper);
}
