using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Card;

public sealed class Card : IDisposable
{
	private HtmlHelper html;

	private TagBuilder containerTag;

	public object ContainerAttributes { get; set; }

	public CardSize PaddingSize { get; set; }

	public CardShadowType ShadowType { get; set; }

	public bool FullWidth { get; set; }

	public Card(HtmlHelper html)
	{
		this.html = html;
		PaddingSize = CardSize.Medium;
		ShadowType = CardShadowType.Large;
		FullWidth = false;
	}

	public MvcHtmlString RenderStart()
	{
		StringBuilder stringBuilder = new StringBuilder();
		using StringWriter writer = new StringWriter(stringBuilder);
		WriteStart(writer);
		return MvcHtmlString.Create(stringBuilder.ToString());
	}

	public MvcHtmlString RenderEnd()
	{
		StringBuilder stringBuilder = new StringBuilder();
		using StringWriter writer = new StringWriter(stringBuilder);
		WriteEnd(writer);
		return MvcHtmlString.Create(stringBuilder.ToString());
	}

	public void WriteStart(TextWriter writer)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		containerTag = new TagBuilder("div");
		containerTag.MergeAttributes<string, object>((IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(ContainerAttributes));
		containerTag.AddCssClass("card");
		switch (PaddingSize)
		{
		case CardSize.Small:
			containerTag.AddCssClass("small-padding");
			break;
		case CardSize.Medium:
			containerTag.AddCssClass("medium-padding");
			break;
		case CardSize.Large:
			containerTag.AddCssClass("large-padding");
			break;
		}
		switch (ShadowType)
		{
		case CardShadowType.Small:
			containerTag.AddCssClass("small-shadow");
			break;
		case CardShadowType.Large:
			containerTag.AddCssClass("large-shadow");
			break;
		}
		if (FullWidth)
		{
			containerTag.AddCssClass("card-full-width");
		}
		writer.Write(containerTag.ToString((TagRenderMode)1));
	}

	public void WriteEnd(TextWriter writer)
	{
		writer.Write(containerTag.ToString((TagRenderMode)2));
	}

	public Card Render()
	{
		WriteStart(html.get_ViewContext().get_Writer());
		return this;
	}

	public void Dispose()
	{
		WriteEnd(html.get_ViewContext().get_Writer());
	}
}
