using System.IO;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class DynamicFormModel
{
	private class RenderContext
	{
		public TagBuilder ContainerTag { get; private set; }

		public RenderContext(DynamicFormModel model)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			ContainerTag = new TagBuilder("div");
			ContainerTag.get_Attributes()["type"] = "dynamicForm";
			ContainerTag.get_Attributes()["id"] = model.Id;
		}
	}

	public ViewType ViewType { get; set; }

	public string Id { get; set; }

	public HtmlAttributes ContainerAttributes { get; private set; }

	public DynamicFormModel()
	{
		ViewType = ViewType.Display;
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
		writer.Write(renderContext.ContainerTag.ToString((TagRenderMode)2));
	}
}
