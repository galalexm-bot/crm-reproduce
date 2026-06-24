using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public abstract class AbstractRowStyles : ITaskRowStyles
{
	public abstract string GetClass(ITaskBase task);

	public abstract MvcHtmlString GetIcon(HtmlHelper htmlHelper, ITaskBase task);

	public abstract bool IsValid(ITaskBase task);

	protected MvcHtmlString GetMetadataIcon(HtmlHelper htmlHelper, Guid typeUid, string icon, object htmlAttributes)
	{
		MvcHtmlString val = htmlHelper.MetadataMarkupImage(typeUid, htmlAttributes);
		if (((object)val).ToString().IsNullOrEmpty())
		{
			return htmlHelper.SvgImage(icon, htmlAttributes);
		}
		return val;
	}
}
