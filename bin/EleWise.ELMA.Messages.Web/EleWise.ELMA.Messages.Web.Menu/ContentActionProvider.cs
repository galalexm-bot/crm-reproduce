using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Messages.Web.Menu;

[Component]
public class ContentActionProvider : ControllerActionProviderBase
{
	public const string CREATE_MESSAGES = "EleWise.ELMA.Messagess.Web-Module-CreateMessages";

	public const string MessagesPage = "MessagesPage";

	public static readonly string AREA = "EleWise.ELMA.Messages.Web";

	private readonly ContentAction _createMessage;

	private readonly ContentAction feed;

	public ISecurityService SecurityService { get; set; }

	public ContentActionProvider()
	{
		_createMessage = new ContentAction
		{
			Id = "EleWise.ELMA.Messagess.Web-Module-CreateMessages",
			Image24 = "#send.svg",
			NameForLocalization = SR.M("Послать сообщение"),
			DescriptionForLocalization = SR.M("Послать сообщение"),
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = (RequestContext target) => SecurityService.HasPermission(PermissionProvider.MessagesAccessPermission),
			LinkTemplate = (RequestContext cc) => "AddChannelMessageWindowContent(null)".PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("AddChannelMessageSelectorWindow", (dynamic d) => ChildActionExtensions.Action(html, "AddMessageSelectorWindow", "ChannelMessage", (object)new
				{
					area = AREA
				}));
			},
			Order = 10
		};
		feed = new ContentAction
		{
			Id = "MessagesPage",
			NameForLocalization = SR.M("Сообщения"),
			Image24 = "#message_outline.svg",
			Routes = new ActionRoute("List", "Feed", new
			{
				area = "EleWise.ELMA.Messages.Web"
			})
		};
	}

	protected override IEnumerable<ContentAction> GetAction()
	{
		return new ContentAction[2] { _createMessage, feed };
	}
}
