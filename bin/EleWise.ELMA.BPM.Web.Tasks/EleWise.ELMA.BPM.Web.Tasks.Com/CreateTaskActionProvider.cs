using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
[ActionWizardItem(Order = 30, Image32 = "#add_poruch.svg")]
public class CreateTaskActionProvider : LinkTypeProvider, ILinkTypeProvider
{
	public const string ProviderId = "CreateTaskLinkTypeProvider";

	public ISecurityService SecurityService { get; set; }

	public string Id => "CreateTaskLinkTypeProvider";

	public string Name => SR.M("Создать задачу");

	public int? Order => 15;

	public override string Category => SR.M("Задачи");

	public override string Image => "#add.svg";

	public override string ActionType => ContentAction.ActionTypeDialog;

	public IContentAction Get(string parameters)
	{
		string link = "CreateTask()";
		if (!string.IsNullOrEmpty(parameters))
		{
			try
			{
				link = string.Format("CreateTask('{0}')", parameters.Replace("\\", "\\\\").Replace("'", "\\'"));
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Невозможно разобрать параметры действия создания задачи"), exception);
			}
		}
		return new ContentAction
		{
			Id = parameters,
			NameForLocalization = SR.M("Создать задачу"),
			DescriptionForLocalization = SR.M("Создать задачу"),
			Image24 = "#add.svg",
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = (RequestContext x) => true,
			LinkTemplate = (RequestContext cc) => link.PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("CreateTaskSelectorContent", (dynamic d) => PartialExtensions.Partial(html, "ContentSelectors/CreateTaskScript"));
			}
		};
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		TaskModel taskModel = new TaskModel();
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/CreateTaskActionParameters", (object)taskModel);
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
		return MvcHtmlString.Create("{var entity = {};\r\nvar form = $('#createTaskParameters');\r\nif (form) {\r\n    var fields = form.serializeArray();\r\n    $.each(fields, function (i, field) {\r\n        if (field.value && field.name.substring(0,7) == 'Entity.' \r\n                && field.name.substring(field.name.length - 9) != '_validate' \r\n                && field.name.substring(field.name.length - 6) != '-input'\r\n                && field.name.substring(field.name.length - 5) != '_date'\r\n                && field.name.substring(field.name.length - 5) != '_time') {\r\n            entity[field.name.substring(7)] = field.value;\r\n        }\r\n    });\r\n}\r\nif (form) {({ value: JSON.stringify($.extend({}, entity)), text: SR.T('Создать задачу') })} else undefined}");
	}

	public override MvcHtmlString RenderActionView(HtmlHelper htmlHelper, IContentAction contentAction)
	{
		return MvcHtmlString.Create(string.Format("{0}<span><u class=\"display-string\">{1}</u></span>", HtmlExtensions.Image(htmlHelper.Url(), Image, "", "", new
		{
			@class = "svg-16-size"
		}), Name));
	}
}
