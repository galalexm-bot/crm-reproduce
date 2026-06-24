using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Messages.Web.Components;

[Component]
[ActionWizardItem(Order = 20, Image32 = "#send.svg")]
public class SendMessageActionProvider : LinkTypeProvider, ILinkTypeProvider
{
	public const string ProviderId = "SendMessageLinkTypeProvider";

	public ISecurityService SecurityService { get; set; }

	public string Id => "SendMessageLinkTypeProvider";

	public string Name => SR.M("Послать сообщение");

	public int? Order => 15;

	public override string Category => SR.M("Сообщения");

	public override string Image => "#send.svg";

	public override string ActionType => ContentAction.ActionTypeDialog;

	public IContentAction Get(string parameters)
	{
		string link = "AddChannelMessageWindowContent()";
		if (!string.IsNullOrEmpty(parameters))
		{
			try
			{
				SendMessageActionParameters sendMessageActionParameters = new JsonSerializer().Deserialize<SendMessageActionParameters>(parameters);
				link = string.Format("AddChannelMessageWindowContent([{0}],[{1}],'{2}')", string.Join(",", sendMessageActionParameters.Channels), string.Join(",", sendMessageActionParameters.Users), sendMessageActionParameters.Subject.Replace("\\", "\\\\").Replace("'", "\\'"));
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Невозможно разобрать параметры действия отправки сообщения"), exception);
			}
		}
		return new ContentAction
		{
			Id = parameters,
			NameForLocalization = SR.M("Послать сообщение"),
			DescriptionForLocalization = SR.M("Послать сообщение"),
			Image24 = "#send.svg",
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = (RequestContext target) => SecurityService.HasPermission(PermissionProvider.MessagesAccessPermission),
			LinkTemplate = (RequestContext cc) => link.PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("AddChannelMessageSelectorWindow", (dynamic d) => ChildActionExtensions.Action(html, "AddMessageSelectorWindow", "ChannelMessage", (object)new
				{
					area = "EleWise.ELMA.Messages.Web"
				}));
			}
		};
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		SendMessageHtmlElementModel sendMessageHtmlElementModel = new SendMessageHtmlElementModel();
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/SendMessageActionParameters", (object)sendMessageHtmlElementModel);
	}

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		return null;
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		return null;
	}

	public override MvcHtmlString GetSelectedScript(HtmlHelper htmlHelper)
	{
		return MvcHtmlString.Create("{var data = { Subject: '', Channels: [], Users: [] }; \r\nvar form = $('#messageParameters');\r\nif (form) {\r\n    var fields = form.serializeArray();\r\n    $.each(fields, function (i, field) {\r\n        if (/^GeneralChannels\\.Channels\\.Channels\\[\\d+\\]\\.Id$/.test(field.name)\r\n           || /^OverChannels\\.Channels\\.Channels\\[\\d+\\]\\.Id$/.test(field.name)\r\n           || /^LastChannels\\.Channels\\.Channels\\[\\d+\\]\\.Id$/.test(field.name)) {\r\n            data.Channels.push(parseInt(field.value));\r\n        }\r\n        else if (/^Recipients\\[\\d+\\]\\.Id$/.test(field.name)) {\r\n            data.Users.push(parseInt(field.value));\r\n        }\r\n        else if (field.name == 'Subject') { data.Subject = field.value; }\r\n    });    \r\n}\r\nif (form) {({ value: JSON.stringify(data), text: SR.T('Послать сообщение') })} else undefined}");
	}

	public override string GetActionName(IContentAction contentAction)
	{
		return SR.T("Послать сообщение");
	}

	public override MvcHtmlString RenderActionView(HtmlHelper htmlHelper, IContentAction contentAction)
	{
		SendMessageActionParameters sendMessageActionParameters = new JsonSerializer().Deserialize<SendMessageActionParameters>(contentAction.Id);
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/SendMessageActionView", (object)sendMessageActionParameters);
	}
}
