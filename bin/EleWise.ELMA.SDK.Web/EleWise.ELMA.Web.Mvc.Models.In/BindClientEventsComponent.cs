using System;
using System.IO;
using System.Web.Mvc;
using System.Web.UI;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public class BindClientEventsComponent
{
	private bool _isAjax;

	private const string OnPageLoadStart = "jQuery(document).ready(function(){";

	private const string OnPageLoadEnd = "});";

	public string Id { get; private set; }

	public ViewContext ViewContext { get; private set; }

	public string OnChange { get; set; }

	public string OnClick { get; set; }

	public BindClientEventsComponent(ViewContext viewContext, string id)
	{
		if (viewContext == null)
		{
			throw new ArgumentNullException("viewContext");
		}
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		ViewContext = viewContext;
		Id = id;
		_isAjax = AjaxRequestExtensions.IsAjaxRequest(((ControllerContext)ViewContext).get_HttpContext().Request);
	}

	public virtual void Render()
	{
		using HtmlTextWriter writer = new HtmlTextWriter(ViewContext.get_Writer());
		WriteHtml(writer);
	}

	public string ToHtmlString()
	{
		using StringWriter stringWriter = new StringWriter();
		WriteHtml(new HtmlTextWriter(stringWriter));
		return stringWriter.ToString();
	}

	public override string ToString()
	{
		return ToHtmlString();
	}

	public virtual void WriteInitializationScript(TextWriter writer)
	{
		writer.Write("$.telerik.bind($('");
		string text = ((ControllerContext)ViewContext).get_HttpContext().Items["InputContainerId"] as string;
		string text2 = (string.IsNullOrEmpty(text) ? string.Empty : ("#" + text + " "));
		text2 = text2 + "#" + Id;
		writer.Write(text2);
		writer.WriteLine("'), {");
		if (!string.IsNullOrEmpty(OnChange))
		{
			writer.Write("change: ");
			writer.Write("function(e){ $('" + text2 + "').focusout(); var onChangeFunc = ");
			writer.Write(OnChange);
			writer.Write("; onChangeFunc.call(this, e);}");
		}
		if (!string.IsNullOrEmpty(OnClick))
		{
			writer.Write(string.Format("{0}click: ", (!string.IsNullOrEmpty(OnChange)) ? "," : ""));
			writer.Write(OnClick);
		}
		writer.WriteLine("});");
	}

	protected virtual void WriteHtml(HtmlTextWriter writer)
	{
		writer.AddAttribute(HtmlTextWriterAttribute.Type, "text/javascript");
		writer.RenderBeginTag(HtmlTextWriterTag.Script);
		if (!_isAjax)
		{
			writer.WriteLine("jQuery(document).ready(function(){");
		}
		WriteInitializationScript(writer);
		if (!_isAjax)
		{
			writer.WriteLine("});");
		}
		writer.RenderEndTag();
	}
}
