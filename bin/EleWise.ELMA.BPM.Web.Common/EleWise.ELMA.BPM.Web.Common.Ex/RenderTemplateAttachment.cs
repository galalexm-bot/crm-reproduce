using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = 100)]
internal class RenderTemplateAttachment : IRenderTemplateAttachment
{
	public bool CheckType(object obj)
	{
		return obj is AttachmentFileModel;
	}

	public MvcHtmlString GetTemplate(HtmlHelper htmlHelper, object obj)
	{
		return MvcHtmlString.Create(string.Format(string.Concat("<span>", htmlHelper.Image("#attachment.svg", SR.T("Файл"), new
		{
			@class = "metadata-icon"
		}), " {0}</span>"), ((AttachmentFileModel)obj).Name));
	}
}
