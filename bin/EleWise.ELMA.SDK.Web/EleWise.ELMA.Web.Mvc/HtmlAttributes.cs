using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Web.Mvc;

public class HtmlAttributes : Dictionary<string, object>
{
	public HtmlStyle style
	{
		get
		{
			return (HtmlStyle)base["style"];
		}
		set
		{
			if (value != null)
			{
				base["style"] = value;
			}
		}
	}

	public string inputType
	{
		get
		{
			if (!ContainsKey("inputType"))
			{
				return null;
			}
			return (string)base["inputType"];
		}
		set
		{
			if (value != null)
			{
				base["inputType"] = value;
			}
			else if (ContainsKey("inputType"))
			{
				Remove("inputType");
			}
		}
	}

	public int? decimalPrecision
	{
		get
		{
			if (!ContainsKey("decimalPrecision"))
			{
				return null;
			}
			return (int?)base["decimalPrecision"];
		}
		set
		{
			if (value.HasValue)
			{
				base["decimalPrecision"] = value;
			}
			else if (ContainsKey("decimalPrecision"))
			{
				Remove("decimalPrecision");
			}
		}
	}

	public string onclick
	{
		get
		{
			if (!ContainsKey("onclick"))
			{
				return null;
			}
			return (string)base["onclick"];
		}
		set
		{
			if (value != null)
			{
				base["onclick"] = value;
			}
			else if (ContainsKey("onclick"))
			{
				Remove("onclick");
			}
		}
	}

	public string onchange
	{
		get
		{
			if (!ContainsKey("onchange"))
			{
				return null;
			}
			return (string)base["onchange"];
		}
		set
		{
			if (value != null)
			{
				base["onchange"] = value;
			}
			else if (ContainsKey("onchange"))
			{
				Remove("onchange");
			}
		}
	}

	public int? rows
	{
		get
		{
			if (!ContainsKey("rows"))
			{
				return null;
			}
			return (int?)base["rows"];
		}
		set
		{
			if (value.HasValue)
			{
				base["rows"] = value;
			}
			else if (ContainsKey("rows"))
			{
				Remove("rows");
			}
		}
	}

	public bool? @readonly
	{
		get
		{
			if (!ContainsKey("readonly"))
			{
				return null;
			}
			return (bool?)base["readonly"];
		}
		set
		{
			if (value.HasValue && value.Value)
			{
				base["readonly"] = value;
			}
			else if (ContainsKey("readonly"))
			{
				Remove("readonly");
			}
		}
	}

	public string @class
	{
		get
		{
			if (!ContainsKey("class"))
			{
				return null;
			}
			return (string)base["class"];
		}
		set
		{
			if (value != null)
			{
				base["class"] = value;
			}
			else if (ContainsKey("class"))
			{
				Remove("class");
			}
		}
	}

	public HtmlAttributes()
	{
		style = new HtmlStyle();
	}

	public void AddClass(string @class)
	{
		_ = this.@class;
		this.@class = ((!string.IsNullOrEmpty(this.@class)) ? (this.@class + " ") : "") + @class;
	}

	public HtmlAttributes Default<TValue>(Expression<Func<HtmlAttributes, TValue>> expression, TValue defaultValue)
	{
		if (!(expression.Body is MemberExpression memberExpression))
		{
			return this;
		}
		if (!typeof(HtmlAttributes).IsAssignableFrom(memberExpression.Member.DeclaringType))
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

	public HtmlAttributes Set(Action<HtmlAttributes> action)
	{
		action?.Invoke(this);
		return this;
	}

	public HtmlAttributes Clone()
	{
		HtmlAttributes htmlAttributes = new HtmlAttributes();
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, object> current = enumerator.Current;
			if (current.Key == "style")
			{
				htmlAttributes["style"] = ((HtmlStyle)current.Value).Clone();
			}
			else
			{
				htmlAttributes[current.Key] = current.Value;
			}
		}
		return htmlAttributes;
	}
}
