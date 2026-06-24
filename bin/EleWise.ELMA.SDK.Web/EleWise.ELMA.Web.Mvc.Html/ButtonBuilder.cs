using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html;

public static class ButtonBuilder
{
	public static TagBuilder SubmitButton(string name, string buttonText, IDictionary<string, object> htmlAttributes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("input");
		val.MergeAttribute("type", "submit");
		if (!val.get_Attributes().ContainsKey("id") && name != null)
		{
			val.GenerateId(name);
		}
		if (!string.IsNullOrEmpty(name))
		{
			val.MergeAttribute("name", name);
		}
		if (!string.IsNullOrEmpty(buttonText))
		{
			val.MergeAttribute("value", buttonText);
		}
		val.MergeAttributes<string, object>(htmlAttributes, true);
		return val;
	}

	public static TagBuilder SubmitImage(string name, string sourceUrl, IDictionary<string, object> htmlAttributes)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("input");
		val.MergeAttribute("type", "image");
		if (!val.get_Attributes().ContainsKey("id"))
		{
			val.GenerateId(name);
		}
		if (!string.IsNullOrEmpty(name))
		{
			val.MergeAttribute("name", name);
		}
		if (!string.IsNullOrEmpty(sourceUrl))
		{
			val.MergeAttribute("src", sourceUrl);
		}
		val.MergeAttributes<string, object>(htmlAttributes, true);
		return val;
	}

	public static TagBuilder Button(string name, string buttonText, HtmlButtonType type, string onClickMethod, IDictionary<string, object> htmlAttributes)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		TagBuilder val = new TagBuilder("button");
		if (!string.IsNullOrEmpty(name))
		{
			val.MergeAttribute("name", name);
		}
		val.MergeAttribute("type", type.ToString().ToLowerInvariant());
		val.set_InnerHtml(buttonText);
		if (!string.IsNullOrEmpty(onClickMethod))
		{
			val.MergeAttribute("onclick", onClickMethod);
		}
		val.MergeAttributes<string, object>(htmlAttributes, true);
		return val;
	}
}
