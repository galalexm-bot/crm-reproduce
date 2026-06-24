using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.Web.Content.Menu;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IMenuItemRenderer
{
	bool HasCustomRender(MenuItemNode item);

	MvcHtmlString Render(HtmlHelper htmlHelper, MenuItemNode item);
}
