using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class TableFormRenderer : IDisposable
{
	private TableFormModel _model;

	private HtmlHelper _html;

	public TableFormRenderer(TableFormModel model, HtmlHelper html)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		_model = model;
		_html = html;
	}

	public MvcHtmlString RenderStart()
	{
		return _model.RenderStart(_html);
	}

	public void WriteStart()
	{
		_model.WriteStart(_html.get_ViewContext().get_Writer());
	}

	public MvcHtmlString RenderEnd()
	{
		return _model.RenderStart(_html);
	}

	public void WriteEnd()
	{
		_model.WriteEnd(_html.get_ViewContext().get_Writer());
	}

	public void Dispose()
	{
		WriteEnd();
	}
}
