using System.Web.Mvc;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

public abstract class CurrentUserPanelAction : ICurrentUserPanelAction
{
	public abstract string Id { get; }

	public virtual string CssClass => null;

	public abstract string GetIconUrl(HtmlHelper html);

	public abstract string GetActionUrl(HtmlHelper html);

	public virtual bool IsVisible()
	{
		return true;
	}

	public virtual bool NeedUpdateCount()
	{
		return false;
	}

	public virtual MenuItemCount GetCount()
	{
		return null;
	}
}
