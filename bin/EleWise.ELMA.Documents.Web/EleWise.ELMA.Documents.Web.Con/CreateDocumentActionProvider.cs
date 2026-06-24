using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.ContentLinkTypeProviders;

[Component]
[ActionWizardItem(Order = 50, Image32 = "#add_doc.svg")]
public class CreateDocumentActionProvider : LinkTypeProvider, ILinkTypeProvider
{
	public const string ProviderId = "CreateDocumentLinkTypeProvider";

	public string Id => "CreateDocumentLinkTypeProvider";

	public string Name => SR.M("Создать документ");

	public int? Order => 15;

	public override string Category => SR.M("Документы");

	public override string Image => "#add.svg";

	public override string ActionType => ContentAction.ActionTypeDialog;

	public IContentAction Get(string parameters)
	{
		string link = "CreateDocument()";
		if (!string.IsNullOrEmpty(parameters))
		{
			try
			{
				CreateDocumentActionParameters createDocumentActionParameters = new JsonSerializer().Deserialize<CreateDocumentActionParameters>(parameters);
				link = string.Format("CreateDocument('{0}','{1}')", createDocumentActionParameters.DocumentTypeUid, createDocumentActionParameters.Parameters.Replace("\\", "\\\\").Replace("'", "\\'"));
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Невозможно разобрать параметры действия создания документа"), exception);
			}
		}
		return new ContentAction
		{
			Id = parameters,
			NameForLocalization = SR.M("Создать документ"),
			DescriptionForLocalization = SR.M("Создать документ"),
			Image24 = "#add.svg",
			ActionType = ContentAction.ActionTypeDialog,
			LinkTemplate = (RequestContext cc) => link.PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("CreateDocumentSelectorContent", (dynamic d) => PartialExtensions.Partial(html, "ContentSelectors/CreateDocumentScript"));
			}
		};
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		CreateDocumentActionParameters createDocumentActionParameters = new CreateDocumentActionParameters();
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/CreateDocumentActionParameters", (object)createDocumentActionParameters);
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
		string fullHtmlFieldId = htmlHelper.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId("DocumentTypeUid");
		string fullHtmlFieldId2 = htmlHelper.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId("DocumentTypeName");
		return MvcHtmlString.Create("{var data = { };\r\ndata.DocumentTypeUid = $('#" + fullHtmlFieldId + "').val();\r\nvar form = $('#documentParameters');\r\nif (form) {\r\n    var fields = form.serializeArray();\r\n    var entity = {};\r\n    $.each(fields, function (i, field) {\r\n        if (field.value && field.name.substring(0,7) == 'Entity.' \r\n                && field.name.substring(field.name.length - 9) != '_validate' \r\n                && field.name.substring(field.name.length - 6) != '-input') {\r\n                var fieldForm = $('[name=\"' + field.name + '\"]');\r\n                if (fieldForm && fieldForm.data('tDatePicker')){\r\n                    field.value = $.telerik.datetime.format(fieldForm.data('tDatePicker').value(), 'u')\r\n                }\r\n                if (fieldForm && fieldForm.attr('inputtype') == 'DateTimeRepository'){\r\n                    field.value = $.telerik.datetime.format(Date.parse(fieldForm.val()), 'u')\r\n                }\r\n                entity[field.name.substring(7)] = field.value;\r\n        }\r\n    });\r\n    data.Parameters = JSON.stringify($.extend({}, entity));\r\n}\r\nif (data.DocumentTypeUid) {({ value: JSON.stringify(data), text: $('#" + fullHtmlFieldId2 + "').val() })} else undefined}");
	}

	public override string GetActionName(IContentAction contentAction)
	{
		return SR.T("Создать документ");
	}

	public override MvcHtmlString RenderActionView(HtmlHelper htmlHelper, IContentAction contentAction)
	{
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(new JsonSerializer().Deserialize<CreateDocumentActionParameters>(contentAction.Id).DocumentTypeUid);
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/CreateDocumentActionView", (object)classMetadata);
	}
}
