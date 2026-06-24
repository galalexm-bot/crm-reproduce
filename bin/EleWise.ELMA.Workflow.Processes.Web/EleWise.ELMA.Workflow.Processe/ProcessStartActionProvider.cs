using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Menu;

[Component]
[ActionWizardItem(Order = 10, Image32 = "#play_outline.svg")]
public class ProcessStartActionProvider : LinkTypeProvider, ILinkTypeProvider
{
	public const string ProviderId = "StartProcessLinkTypeProvider";

	public string Id => "StartProcessLinkTypeProvider";

	public string Name => SR.M("Запустить процесс");

	public int? Order => 15;

	public override string Category => SR.M("Управление бизнес-процессами");

	public override string Image => "#process.svg";

	public override string ActionType => ContentAction.ActionTypeDialog;

	public IContentAction Get(string parameters)
	{
		string link = "AddChannelMessageWindowContent()";
		if (!string.IsNullOrEmpty(parameters))
		{
			try
			{
				StartProcessActionParameters startProcessActionParameters = new JsonSerializer().Deserialize<StartProcessActionParameters>(parameters);
				string text = startProcessActionParameters.Id;
				int num = text.IndexOf('-');
				if (num > 0)
				{
					text = text.Substring(num + 1);
				}
				link = string.Format("RunProcess({0},'{1}')", text, startProcessActionParameters.Context.Replace("\\", "\\\\").Replace("'", "\\'"));
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Невозможно разобрать параметры действия отправки сообщения"), exception);
			}
		}
		return new ContentAction
		{
			Id = parameters,
			NameForLocalization = SR.M("Запустить процесс"),
			DescriptionForLocalization = SR.M("Запустить процесс"),
			Image24 = "#process.svg",
			ActionType = ContentAction.ActionTypeDialog,
			LinkTemplate = (RequestContext cc) => link.PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("StartProcessOneWindow", (dynamic d) => ChildActionExtensions.Action(html, "StartProcessDialog", "ProcessHeader", (object)new
				{
					area = "EleWise.ELMA.Workflow.Processes.Web",
					treeId = "StartProcess_runpopup"
				}));
			}
		};
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/StartWorkflowSelector");
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
		string fullHtmlFieldId = htmlHelper.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId("ProcessValue");
		string fullHtmlFieldId2 = htmlHelper.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId("ProcessDisplayName");
		return MvcHtmlString.Create("{var data = { };\r\ndata.Id = $('#" + fullHtmlFieldId + "').val();\r\nvar form = $('#processParameters');\r\nif (form) {\r\n    var fields = form.serializeArray();\r\n    var context = {};\r\n    $.each(fields, function (i, field) {\r\n        if (field.value && field.name.substring(0,12) == 'ContextDict.' \r\n                && field.name.substring(field.name.length - 9) != '_validate' \r\n                && field.name.substring(field.name.length - 6) != '-input') {\r\n            context[field.name.substring(12)] = field.value;\r\n        }\r\n    });\r\n    data.Context = JSON.stringify($.extend({}, context));\r\n}\r\nif (form && data.Id) {({ value: JSON.stringify(data), text: $('#" + fullHtmlFieldId2 + "').val() })} else undefined}");
	}

	public override string GetActionName(IContentAction contentAction)
	{
		return SR.M("Запуск поцесса");
	}

	public override MvcHtmlString RenderActionView(HtmlHelper htmlHelper, IContentAction contentAction)
	{
		string text = new JsonSerializer().Deserialize<StartProcessActionParameters>(contentAction.Id).Id;
		int num = text.IndexOf('-');
		if (num > 0)
		{
			text = text.Substring(num + 1);
		}
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(Convert.ToInt64(text));
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/StartWorkflowActionView", (object)processHeader);
	}
}
