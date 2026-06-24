using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Content.Menu;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IMenuItemsProvider
{
	[Obsolete("Используйте SR.M для локализации")]
	List<string> LocalizedItemsNames { get; }

	[Obsolete("Используйте SR.M для локализации")]
	List<string> LocalizedItemsDescriptions { get; }

	void Items(MenuItemFactory factory);
}
