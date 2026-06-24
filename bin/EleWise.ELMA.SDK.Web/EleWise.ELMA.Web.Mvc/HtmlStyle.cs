using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Web.Mvc;

public class HtmlStyle : Dictionary<string, object>
{
	public string width
	{
		get
		{
			if (!ContainsKey("width"))
			{
				return null;
			}
			return (string)base["width"];
		}
		set
		{
			if (value != null)
			{
				base["width"] = value;
			}
			else if (ContainsKey("width"))
			{
				Remove("width");
			}
		}
	}

	public string height
	{
		get
		{
			if (!ContainsKey("height"))
			{
				return null;
			}
			return (string)base["height"];
		}
		set
		{
			if (value != null)
			{
				base["height"] = value;
			}
			else if (ContainsKey("height"))
			{
				Remove("height");
			}
		}
	}

	public string color
	{
		get
		{
			if (!ContainsKey("color"))
			{
				return null;
			}
			return (string)base["color"];
		}
		set
		{
			if (value != null)
			{
				base["color"] = value;
			}
			else if (ContainsKey("color"))
			{
				Remove("color");
			}
		}
	}

	public HtmlStyle Add(string key, string value)
	{
		base[key] = value;
		return this;
	}

	public HtmlStyle Default<TValue>(Expression<Func<HtmlStyle, TValue>> expression, TValue defaultValue)
	{
		if (!(expression.Body is MemberExpression memberExpression))
		{
			return this;
		}
		if (!typeof(HtmlStyle).IsAssignableFrom(memberExpression.Member.DeclaringType))
		{
			return this;
		}
		PropertyInfo propertyInfo = memberExpression.Member as PropertyInfo;
		if (propertyInfo != null && propertyInfo.GetValue(this, null) == null)
		{
			propertyInfo.SetValue(this, defaultValue, null);
		}
		return this;
	}

	public override string ToString()
	{
		return string.Concat((from pair in this
			where pair.Value != null
			select string.Concat(pair.Key, ":", pair.Value, ";")).ToArray());
	}

	public HtmlStyle Clone()
	{
		HtmlStyle htmlStyle = new HtmlStyle();
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, object> current = enumerator.Current;
			htmlStyle[current.Key] = current.Value;
		}
		return htmlStyle;
	}
}
