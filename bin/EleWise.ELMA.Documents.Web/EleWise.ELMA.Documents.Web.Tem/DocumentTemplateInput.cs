using System.Web;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.Documents.Web.TemplateInputs;

public class DocumentTemplateInput : EntityTemplateInput<IDocument>
{
	private const string Template = "<a href='{{#BaseUrl#}}Documents/Document/View/{0}' style='white-space:nowrap;'>{1}</a> ({2})";

	public override string GetListSeparator(TemplateRenderMode renderMode)
	{
		if (renderMode != TemplateRenderMode.HTML)
		{
			return ", ";
		}
		return "<br/>\r\n";
	}

	public override string FormatValue(object value, TemplateRenderMode renderMode)
	{
		if (!(value is IDocument document))
		{
			return string.Empty;
		}
		return renderMode switch
		{
			TemplateRenderMode.Default => document.Name, 
			TemplateRenderMode.HTML => string.Format("<a href='{{#BaseUrl#}}Documents/Document/View/{0}' style='white-space:nowrap;'>{1}</a> ({2})", document.Id, HttpUtility.HtmlEncode(document.Name), document.CreationDate.HasValue ? document.CreationDate.Value.ToString("g") : ""), 
			_ => string.Empty, 
		};
	}
}
