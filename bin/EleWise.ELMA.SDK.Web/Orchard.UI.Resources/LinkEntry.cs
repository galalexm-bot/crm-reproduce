using System.Web.Mvc;

namespace Orchard.UI.Resources;

public class LinkEntry
{
	private readonly TagBuilder _builder = new TagBuilder("link");

	public string Condition { get; set; }

	public string Rel
	{
		get
		{
			_builder.get_Attributes().TryGetValue("rel", out var value);
			return value;
		}
		set
		{
			SetAttribute("rel", value);
		}
	}

	public string Type
	{
		get
		{
			_builder.get_Attributes().TryGetValue("type", out var value);
			return value;
		}
		set
		{
			SetAttribute("type", value);
		}
	}

	public string Title
	{
		get
		{
			_builder.get_Attributes().TryGetValue("title", out var value);
			return value;
		}
		set
		{
			SetAttribute("title", value);
		}
	}

	public string Href
	{
		get
		{
			_builder.get_Attributes().TryGetValue("href", out var value);
			return value;
		}
		set
		{
			SetAttribute("href", value);
		}
	}

	public string GetTag()
	{
		string text = _builder.ToString((TagRenderMode)3);
		if (!string.IsNullOrEmpty(Condition))
		{
			return "<!--[if " + Condition + "]>" + text + "<![endif]-->";
		}
		return text;
	}

	public LinkEntry AddAttribute(string name, string value)
	{
		_builder.MergeAttribute(name, value);
		return this;
	}

	public LinkEntry SetAttribute(string name, string value)
	{
		_builder.MergeAttribute(name, value, true);
		return this;
	}
}
