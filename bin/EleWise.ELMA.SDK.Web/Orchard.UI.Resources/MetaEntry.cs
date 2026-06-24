using System.Collections.Generic;
using System.Web.Mvc;

namespace Orchard.UI.Resources;

public class MetaEntry
{
	private readonly TagBuilder _builder = new TagBuilder("meta");

	public string Name
	{
		get
		{
			_builder.get_Attributes().TryGetValue("name", out var value);
			return value;
		}
		set
		{
			SetAttribute("name", value);
		}
	}

	public string Content
	{
		get
		{
			_builder.get_Attributes().TryGetValue("content", out var value);
			return value;
		}
		set
		{
			SetAttribute("content", value);
		}
	}

	public string HttpEquiv
	{
		get
		{
			_builder.get_Attributes().TryGetValue("http-equiv", out var value);
			return value;
		}
		set
		{
			SetAttribute("http-equiv", value);
		}
	}

	public string Charset
	{
		get
		{
			_builder.get_Attributes().TryGetValue("charset", out var value);
			return value;
		}
		set
		{
			SetAttribute("charset", value);
		}
	}

	public MetaEntry()
	{
	}//IL_0006: Unknown result type (might be due to invalid IL or missing references)
	//IL_0010: Expected O, but got Unknown


	public MetaEntry(string name = null, string content = null, string httpEquiv = null, string charset = null)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(name))
		{
			Name = name;
		}
		if (!string.IsNullOrEmpty(content))
		{
			Content = content;
		}
		if (!string.IsNullOrEmpty(httpEquiv))
		{
			HttpEquiv = httpEquiv;
		}
		if (!string.IsNullOrEmpty(charset))
		{
			Charset = charset;
		}
	}

	public static MetaEntry Combine(MetaEntry meta1, MetaEntry meta2, string contentSeparator)
	{
		MetaEntry metaEntry = new MetaEntry();
		Merge(metaEntry._builder.get_Attributes(), meta1._builder.get_Attributes(), meta2._builder.get_Attributes());
		if (!string.IsNullOrEmpty(meta1.Content) && !string.IsNullOrEmpty(meta2.Content))
		{
			metaEntry.Content = meta1.Content + contentSeparator + meta2.Content;
		}
		return metaEntry;
	}

	private static void Merge(IDictionary<string, string> d1, params IDictionary<string, string>[] sources)
	{
		for (int i = 0; i < sources.Length; i++)
		{
			foreach (KeyValuePair<string, string> item in sources[i])
			{
				d1[item.Key] = item.Value;
			}
		}
	}

	public MetaEntry AddAttribute(string name, string value)
	{
		_builder.MergeAttribute(name, value);
		return this;
	}

	public MetaEntry SetAttribute(string name, string value)
	{
		_builder.MergeAttribute(name, value, true);
		return this;
	}

	public string GetTag()
	{
		return _builder.ToString((TagRenderMode)3);
	}
}
