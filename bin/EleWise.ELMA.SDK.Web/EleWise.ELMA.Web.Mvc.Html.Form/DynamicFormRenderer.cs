using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class DynamicFormRenderer : IDisposable
{
	private readonly DynamicFormModel model;

	private readonly HtmlHelper html;

	public DynamicFormRenderer(DynamicFormModel model, HtmlHelper html)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		this.model = model;
		this.html = html;
	}

	public MvcHtmlString RenderStart()
	{
		return model.RenderStart(html);
	}

	public void WriteStart()
	{
		model.WriteStart(html.get_ViewContext().get_Writer());
	}

	public MvcHtmlString RenderEnd()
	{
		return model.RenderStart(html);
	}

	public void WriteEnd()
	{
		model.WriteEnd(html.get_ViewContext().get_Writer());
	}

	public void Dispose()
	{
		WriteEnd();
	}
}
