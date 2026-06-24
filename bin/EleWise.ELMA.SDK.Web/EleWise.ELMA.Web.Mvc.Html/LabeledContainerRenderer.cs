using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html;

public sealed class LabeledContainerRenderer : IDisposable
{
	private const string LabelContainerCls = "labeled-container";

	private const string HiddenLabelCls = "labeled-contrainer-hide-label";

	private const string LabelElementCls = "label-element";

	private readonly LabeledContainerModel model;

	private readonly HtmlHelper htmlHelper;

	public LabeledContainerRenderer(LabeledContainerModel model, HtmlHelper htmlHelper)
	{
		Contract.NotNull(model, "model");
		Contract.NotNull(htmlHelper, "htmlHelper");
		this.model = model;
		this.htmlHelper = htmlHelper;
		if (MvcHtmlString.IsNullOrEmpty(model.Label))
		{
			model.Label = htmlHelper.RenderForZone("LabeledContainerHeaderTag");
		}
	}

	public void RenderStart()
	{
		GetWriter().Write(GetLabelWrapper((TagRenderMode)1));
		GetWriter().Write(GetLabel());
		GetWriter().Write(GetHeaderLabel());
	}

	public void Dispose()
	{
		GetWriter().Write(GetLabelWrapper((TagRenderMode)2));
	}

	private MvcHtmlString GetLabelWrapper(TagRenderMode mode)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("div");
		val.MergeAttributes<string, object>((IDictionary<string, object>)model.Attributes);
		if (MvcHtmlString.IsNullOrEmpty(model.Label))
		{
			val.AddCssClass("labeled-contrainer-hide-label");
		}
		val.AddCssClass("labeled-container");
		return new MvcHtmlString(val.ToString(mode));
	}

	private MvcHtmlString GetLabel()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		if (MvcHtmlString.IsNullOrEmpty(model.Label))
		{
			return MvcHtmlString.Empty;
		}
		TagBuilder val = new TagBuilder("div");
		val.AddCssClass("label-element");
		val.set_InnerHtml(((object)model.Label).ToString());
		return new MvcHtmlString(((object)val).ToString());
	}

	private MvcHtmlString GetHeaderLabel()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		string text = ((object)htmlHelper.RenderForZone("LabeledContainerHeader")).ToString();
		if (string.IsNullOrWhiteSpace(text))
		{
			return MvcHtmlString.Empty;
		}
		TagBuilder val = new TagBuilder("div");
		val.AddCssClass("form-header");
		TagBuilder val2 = new TagBuilder("span");
		val2.AddCssClass("page_header_title");
		val2.set_InnerHtml(text);
		val.set_InnerHtml(((object)val2).ToString());
		return new MvcHtmlString(((object)val).ToString());
	}

	private TextWriter GetWriter()
	{
		return htmlHelper.get_ViewContext().get_Writer();
	}
}
