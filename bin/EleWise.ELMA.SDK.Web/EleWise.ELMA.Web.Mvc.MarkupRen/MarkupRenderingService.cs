using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.MarkupRendering;

[Service(Scope = ServiceScope.Shell)]
public class MarkupRenderingService : IMarkupRenderingService
{
	public MvcHtmlString Render(HtmlHelper htmlHelper, string markup, string language, object model)
	{
		if (markup == null)
		{
			throw new ArgumentNullException("markup");
		}
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		if (language == "razor")
		{
			string pathFormMarkup = OnTheFlyVirtualPathProvider.GetPathFormMarkup(markup, "cshtml");
			if (model != null)
			{
				return PartialExtensions.Partial(htmlHelper, pathFormMarkup, model);
			}
			return PartialExtensions.Partial(htmlHelper, pathFormMarkup);
		}
		throw new ArgumentException(SR.T("Неподдерживаемый язык разметки {0}", language));
	}
}
