using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.Web.Content.Menu;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IMenuItemCountEvaluator
{
	bool HasCountEvaluator(MenuItemNode item);

	bool NeedUpdate(MenuItemNode item);

	MenuItemCount Evaluate(MenuItemNode item);
}
