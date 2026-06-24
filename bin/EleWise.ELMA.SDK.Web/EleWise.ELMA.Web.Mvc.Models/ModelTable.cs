using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models;

public class ModelTable : IDisposable
{
	private ViewContext viewContext;

	public string Id { get; set; }

	public string Class { get; set; }

	public string Width { get; set; }

	public bool FixedLayout { get; set; }

	public int Columns { get; set; }

	public string CaptionColumnWidth { get; set; }

	public string ValueColumnWidth { get; set; }

	public HtmlStyle Style { get; set; }

	internal ModelTable(ViewContext viewContext)
	{
		this.viewContext = viewContext;
		Width = "100%";
		FixedLayout = true;
		Style = new HtmlStyle();
		Columns = 1;
		CaptionColumnWidth = "200px";
		ValueColumnWidth = "auto";
	}

	internal void RenderStart()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("table");
		if (!string.IsNullOrEmpty(Id))
		{
			val.get_Attributes()["id"] = Id;
		}
		if (Class != null)
		{
			val.get_Attributes()["class"] = Class;
		}
		if (!string.IsNullOrEmpty(Width))
		{
			val.get_Attributes()["width"] = Width;
		}
		HtmlStyle htmlStyle = ((Style != null) ? Style.Clone() : new HtmlStyle());
		if (FixedLayout)
		{
			htmlStyle["table-layout"] = "fixed";
		}
		string value = htmlStyle.ToString();
		if (!string.IsNullOrEmpty(value))
		{
			val.get_Attributes()["style"] = value;
		}
		viewContext.get_Writer().WriteLine(val.ToString((TagRenderMode)1));
		viewContext.get_Writer().WriteLine("<colgroup>");
		for (int i = 0; i < Columns; i++)
		{
			viewContext.get_Writer().WriteLine(GetColumnDef(CaptionColumnWidth));
			viewContext.get_Writer().WriteLine(GetColumnDef(ValueColumnWidth));
		}
		viewContext.get_Writer().WriteLine("</colgroup>");
		viewContext.get_Writer().WriteLine("<tbody>");
	}

	void IDisposable.Dispose()
	{
		viewContext.get_Writer().WriteLine("</tbody>");
		viewContext.get_Writer().WriteLine("</table>");
	}

	private static string GetColumnDef(string width)
	{
		return "<col" + ((!string.IsNullOrEmpty(width)) ? (" style=\"width:" + width + "\"") : "") + ">";
	}
}
