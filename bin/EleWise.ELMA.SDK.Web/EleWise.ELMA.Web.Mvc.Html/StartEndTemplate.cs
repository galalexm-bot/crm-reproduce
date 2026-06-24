using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html;

public class StartEndTemplate : IDisposable
{
	protected ViewContext viewContext;

	protected string footer;

	public ViewContext ViewContext => viewContext;

	public StartEndTemplate(ViewContext viewContext, string header, string footer)
	{
		this.viewContext = viewContext;
		this.footer = footer;
		viewContext.get_Writer().Write(header);
	}

	public StartEndTemplate(ViewContext viewContext, MvcHtmlString header, MvcHtmlString footer)
	{
		this.viewContext = viewContext;
		this.footer = ((object)footer).ToString();
		viewContext.get_Writer().Write(header);
	}

	public virtual void Dispose()
	{
		viewContext.get_Writer().Write(footer);
	}
}
