using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class TableFormModel
{
	private class RenderContext
	{
		public TagBuilder ContainerTag { get; private set; }

		public TagBuilder TableTag { get; private set; }

		public RenderContext(TableFormModel model)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			ContainerTag = new TagBuilder("div");
			ContainerTag.MergeAttributes<string, object>((IDictionary<string, object>)model.ContainerAttributes, true);
			ContainerTag.AddCssClass("table-form-container");
			TableTag = new TagBuilder("table");
			TableTag.MergeAttributes<string, object>((IDictionary<string, object>)model.Attributes, true);
			TableTag.AddCssClass("table-form");
			if ((model.ShowLines.HasValue && model.ShowLines.Value) || (model.ViewType != ViewType.Create && model.ViewType != ViewType.Edit))
			{
				TableTag.AddCssClass("show-lines");
			}
		}
	}

	public ViewType ViewType { get; set; }

	public bool? ShowLines { get; set; }

	public HtmlAttributes Attributes { get; private set; }

	public string Id
	{
		get
		{
			return (Attributes.ContainsKey("id") ? Attributes["id"] : null)?.ToString();
		}
		set
		{
			Attributes["id"] = value;
		}
	}

	public HtmlAttributes ContainerAttributes { get; private set; }

	public TableFormModel()
	{
		ViewType = ViewType.Display;
		Attributes = new HtmlAttributes();
		ContainerAttributes = new HtmlAttributes();
	}

	public MvcHtmlString RenderStart(HtmlHelper html)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using StringWriter writer = new StringWriter(stringBuilder);
		WriteStart(writer);
		return MvcHtmlString.Create(stringBuilder.ToString());
	}

	public void WriteStart(TextWriter writer)
	{
		RenderContext renderContext = new RenderContext(this);
		writer.Write(renderContext.ContainerTag.ToString((TagRenderMode)1));
		writer.Write(renderContext.TableTag.ToString((TagRenderMode)1));
	}

	public MvcHtmlString RenderEnd(HtmlHelper html)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using StringWriter writer = new StringWriter(stringBuilder);
		WriteEnd(writer);
		return MvcHtmlString.Create(stringBuilder.ToString());
	}

	public void WriteEnd(TextWriter writer)
	{
		RenderContext renderContext = new RenderContext(this);
		writer.Write(renderContext.TableTag.ToString((TagRenderMode)2));
		writer.Write(renderContext.ContainerTag.ToString((TagRenderMode)2));
	}
}
