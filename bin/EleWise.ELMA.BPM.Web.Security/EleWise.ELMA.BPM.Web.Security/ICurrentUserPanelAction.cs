using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface ICurrentUserPanelAction
{
	string Id { get; }

	string CssClass { get; }

	string GetIconUrl(HtmlHelper html);

	string GetActionUrl(HtmlHelper html);

	bool IsVisible();

	bool NeedUpdateCount();

	MenuItemCount GetCount();
}
