using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Extensions;

[Component(Order = 5)]
internal class RenderTemplateDocument : IRenderTemplateAttachment
{
	public bool CheckType(object obj)
	{
		return obj is DocumentFileModel;
	}

	public MvcHtmlString GetTemplate(HtmlHelper htmlHelper, object obj)
	{
		return MvcHtmlString.Create(string.Format(string.Concat("<span>", htmlHelper.Image("#doc_draft.svg", SR.T("Документ"), new
		{
			@class = "metadata-icon"
		}), " {0}</span>"), ((DocumentFileModel)obj).Name));
	}
}
