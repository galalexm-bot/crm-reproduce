using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Content.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IUserAreaAction
{
	string Id { get; }

	string CssClass { get; }

	bool NeedUpdateCount();

	MenuItemCount GetCount();
}
