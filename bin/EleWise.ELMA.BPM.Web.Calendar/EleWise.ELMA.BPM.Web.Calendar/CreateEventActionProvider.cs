using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component]
[ActionWizardItem(Order = 40, Image32 = "#add_event.svg")]
public class CreateEventActionProvider : LinkTypeProvider, ILinkTypeProvider
{
	public const string ProviderId = "CreateEventLinkTypeProvider";

	public ISecurityService SecurityService { get; set; }

	public string Id => "CreateEventLinkTypeProvider";

	public string Name => SR.M("Создать событие");

	public int? Order => 15;

	public override string Category => SR.M("Календарь");

	public override string Image => "#add.svg";

	public override string ActionType => ContentAction.ActionTypeDialog;

	public IContentAction Get(string parameters)
	{
		string link = "CreateEvent()";
		if (!string.IsNullOrEmpty(parameters))
		{
			try
			{
				CreateEventActionParameters createEventActionParameters = new JsonSerializer().Deserialize<CreateEventActionParameters>(parameters);
				link = string.Format("CreateEvent('{0}','{1}',[{2}],[{3}])", createEventActionParameters.Subject.Replace("\\", "\\\\").Replace("'", "\\'"), createEventActionParameters.Place.Replace("\\", "\\\\").Replace("'", "\\'"), string.Join(",", createEventActionParameters.Participants), string.Join(",", createEventActionParameters.Informers));
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Невозможно разобрать параметры действия создания события"), exception);
			}
		}
		return new ContentAction
		{
			Id = parameters,
			NameForLocalization = SR.M("Создать событие"),
			DescriptionForLocalization = SR.M("Создать событие"),
			Image24 = "#add.svg",
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = (RequestContext x) => true,
			LinkTemplate = (RequestContext cc) => link.PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("CreateEventSelectorContent", (dynamic d) => PartialExtensions.Partial(html, "ContentSelectors/CreateEventScript"));
			}
		};
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		CreateEventHtmlElementModel createEventHtmlElementModel = new CreateEventHtmlElementModel();
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/CreateEventActionParameters", (object)createEventHtmlElementModel);
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
		return MvcHtmlString.Create("{var data = { Subject: '', Place: '', Participants: [], Informers: [] }; \r\nvar form = $('#createEventParameters');\r\nif (form) {\r\n    var fields = form.serializeArray();\r\n    $.each(fields, function (i, field) {\r\n        if (/^Participants\\[\\d+\\]\\.Id$/.test(field.name)) {\r\n            data.Participants.push(parseInt(field.value));\r\n        }\r\n        else if (/^Informers\\[\\d+\\]\\.Id$/.test(field.name)) {\r\n            data.Informers.push(parseInt(field.value));\r\n        }\r\n        else if (field.name == 'Subject') { data.Subject = field.value; }\r\n        else if (field.name == 'Place') { data.Place = field.value; }\r\n    });    \r\n}\r\nif (form) {({ value: JSON.stringify(data), text: SR.T('Создать событие') })} else undefined}");
	}

	public override MvcHtmlString RenderActionView(HtmlHelper htmlHelper, IContentAction contentAction)
	{
		CreateEventActionParameters createEventActionParameters = new JsonSerializer().Deserialize<CreateEventActionParameters>(contentAction.Id);
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/CreateEventActionView", (object)createEventActionParameters);
	}
}
