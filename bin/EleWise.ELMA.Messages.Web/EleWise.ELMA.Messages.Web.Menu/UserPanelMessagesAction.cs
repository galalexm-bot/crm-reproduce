using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Templates.Content.IconPack;

namespace EleWise.ELMA.Messages.Web.Menu;

[Component(Order = 100)]
public class UserPanelMessagesAction : CurrentUserPanelAction, ICurrentUserPanelActionDisable, ICurrentUserPanelAction
{
	public override string Id => "UserPanelAction_Messages";

	public string PropertyName => "UserPanelMessages";

	public override string GetIconUrl(HtmlHelper html)
	{
		return html.Url().GetIcon("#message_outline.svg");
	}

	public override string GetActionUrl(HtmlHelper html)
	{
		return html.Url().Action("List", "Feed", (object)new
		{
			area = "EleWise.ELMA.Messages.Web"
		});
	}

	public override bool NeedUpdateCount()
	{
		return true;
	}

	public override MenuItemCount GetCount()
	{
		return MessagesMenuItemCountEvaluator.Evaluate(useClientUpdateFunction: false);
	}

	public override bool IsVisible()
	{
		if (!Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.MessagesAccessPermission))
		{
			return false;
		}
		return IsEnabled(WorkPlaceExtensions.GetCurrentWorkPlace(loadDefaultWorkPlace: true));
	}

	public bool IsEnabled(IWorkPlace workPlace)
	{
		return ((IWorkPlaceMessages)workPlace).UserPanelMessages ?? true;
	}
}
