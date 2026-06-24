using System.Web;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.Documents.Web.TemplateInputs;

public class DocumentAttachmentTemplateInput : EntityTemplateInput<IDocumentAttachment>
{
	private const string template = "<span {4}='{5}'><a href='{{#BaseUrl#}}Documents/Document/View/{0}' tooltiptext='{3}'>{1}</a> ({2})</span>";

	public override string GetListSeparator(TemplateRenderMode renderMode)
	{
		if (renderMode != TemplateRenderMode.HTML)
		{
			return "\r\n";
		}
		return "<br/>\r\n";
	}

	public override string FormatValue(object value, TemplateRenderMode renderMode)
	{
		if (!(value is IDocumentAttachment documentAttachment) || documentAttachment.Document == null)
		{
			return string.Empty;
		}
		switch (renderMode)
		{
		case TemplateRenderMode.Default:
			return $"{documentAttachment.Document.Name}: {{#BaseUrl#}}Documents/Document/View/{documentAttachment.Document.Id}";
		case TemplateRenderMode.HTML:
		{
			string text = documentAttachment.Document.Name;
			int num = 50;
			int num2 = 12;
			if (text.Length > num)
			{
				text = $"{text.Substring(0, 20)}...{text.Substring(text.Length - num2, num2)}";
			}
			return string.Format("<span {4}='{5}'><a href='{{#BaseUrl#}}Documents/Document/View/{0}' tooltiptext='{3}'>{1}</a> ({2})</span>", documentAttachment.Document.Id, HttpUtility.HtmlEncode(text), documentAttachment.CreationDate.ToString("g"), documentAttachment.Document.Name, DocumentAttachmentTemplateInputExtension.HtmlAttributeString, documentAttachment.Id);
		}
		default:
			return string.Empty;
		}
	}
}
