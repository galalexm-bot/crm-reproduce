using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.Web.Content.Menu;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IMenuCustomItems
{
	bool HasCustomItems(MenuItemNode item);

	void Items(HtmlHelper htmlHelper, MenuItemNode item);
}
