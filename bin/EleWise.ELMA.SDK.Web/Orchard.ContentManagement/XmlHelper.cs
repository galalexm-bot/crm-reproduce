using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using Orchard.Utility;

namespace Orchard.ContentManagement;

public static class XmlHelper
{
	public class XElementWithContext<TContext>
	{
		public XElement Element { get; private set; }

		public TContext Context { get; private set; }

		public XElementWithContext(XElement element, TContext context)
		{
			Element = element;
			Context = context;
		}

		public static implicit operator XElement(XElementWithContext<TContext> elementWithContext)
		{
			return elementWithContext.Element;
		}

		public XElementWithContext<TNewContext> With<TNewContext>(TNewContext context)
		{
			return new XElementWithContext<TNewContext>(Element, context);
		}

		public XElementWithContext<TContext> ToAttr<TProperty>(Expression<Func<TContext, TProperty>> targetExpression)
		{
			Element.ToAttr(Context, targetExpression);
			return this;
		}

		public XElementWithContext<TContext> FromAttr<TProperty>(Expression<Func<TContext, TProperty>> targetExpression)
		{
			Element.FromAttr(Context, targetExpression);
			return this;
		}

		public TProperty Attr<TProperty>(Expression<Func<TContext, TProperty>> expression)
		{
			string name = ReflectionHelper<TContext>.GetPropertyInfo(expression).Name;
			return Element.Attr<TProperty>(name);
		}
	}

	public static XElement AddEl(this XElement el, params XElement[] children)
	{
		el.Add(children.Cast<object>());
		return el;
	}

	public static string Attr(this XElement el, string name)
	{
		return el.Attribute(name)?.Value;
	}

	public static T Attr<T>(this XElement el, string name)
	{
		XAttribute xAttribute = el.Attribute(name);
		if (xAttribute != null)
		{
			return Parse<T>(xAttribute.Value);
		}
		return default(T);
	}

	public static XElement Attr<T>(this XElement el, string name, T value)
	{
		el.SetAttributeValue(name, ToString(value));
		return el;
	}

	public static string El(this XElement el, string name)
	{
		return el.Element(name)?.Value;
	}

	public static XElement El<T>(this XElement el, string name, T value)
	{
		el.SetElementValue(name, value);
		return el;
	}

	public static XElement FromAttr<TTarget, TProperty>(this XElement el, TTarget target, Expression<Func<TTarget, TProperty>> targetExpression)
	{
		if (target == null)
		{
			return el;
		}
		PropertyInfo propertyInfo = ReflectionHelper<TTarget>.GetPropertyInfo(targetExpression);
		string name = propertyInfo.Name;
		if (el.Attribute(name) == null)
		{
			return el;
		}
		propertyInfo.SetValue(target, el.Attr<TProperty>(name), null);
		return el;
	}

	public static XElement ToAttr<TTarget, TProperty>(this XElement el, TTarget target, Expression<Func<TTarget, TProperty>> targetExpression)
	{
		if (target == null)
		{
			return el;
		}
		PropertyInfo propertyInfo = ReflectionHelper<TTarget>.GetPropertyInfo(targetExpression);
		string name = propertyInfo.Name;
		TProperty val = (TProperty)propertyInfo.GetValue(target, null);
		el.Attr(name, ToString(val));
		return el;
	}

	public static TValue Val<TValue>(this XElement el)
	{
		return Parse<TValue>(el.Value);
	}

	public static XElement Val<TValue>(this XElement el, TValue value)
	{
		el.SetValue(ToString(value));
		return el;
	}

	public static string ToString<T>(T value)
	{
		Type typeFromHandle = typeof(T);
		if (typeFromHandle == typeof(string) || typeFromHandle == typeof(char))
		{
			return Convert.ToString(value);
		}
		if ((!typeFromHandle.IsValueType || Nullable.GetUnderlyingType(typeFromHandle) != null) && value == null && typeFromHandle != typeof(string))
		{
			return "null";
		}
		if (typeFromHandle == typeof(DateTime) || typeFromHandle == typeof(DateTime?))
		{
			return XmlConvert.ToString(Convert.ToDateTime(value), XmlDateTimeSerializationMode.Utc);
		}
		if (typeFromHandle == typeof(bool) || typeFromHandle == typeof(bool?))
		{
			if (!Convert.ToBoolean(value))
			{
				return "false";
			}
			return "true";
		}
		if (typeFromHandle == typeof(int) || typeFromHandle == typeof(int?) || typeFromHandle == typeof(long) || typeFromHandle == typeof(long?))
		{
			return Convert.ToInt64(value).ToString(CultureInfo.InvariantCulture);
		}
		if (typeFromHandle == typeof(double) || typeFromHandle == typeof(double?))
		{
			double d = (double)(object)value;
			if (double.IsPositiveInfinity(d))
			{
				return "infinity";
			}
			if (double.IsNegativeInfinity(d))
			{
				return "-infinity";
			}
			return d.ToString(CultureInfo.InvariantCulture);
		}
		if (typeFromHandle == typeof(float) || typeFromHandle == typeof(float?))
		{
			float f = (float)(object)value;
			if (float.IsPositiveInfinity(f))
			{
				return "infinity";
			}
			if (float.IsNegativeInfinity(f))
			{
				return "-infinity";
			}
			return f.ToString(CultureInfo.InvariantCulture);
		}
		if (typeFromHandle == typeof(decimal) || typeFromHandle == typeof(decimal?))
		{
			return Convert.ToDecimal(value).ToString(CultureInfo.InvariantCulture);
		}
		if ((Nullable.GetUnderlyingType(typeFromHandle) ?? typeFromHandle).IsEnum)
		{
			return value.ToString();
		}
		throw new NotSupportedException($"Could not handle type {typeFromHandle.Name}");
	}

	public static T Parse<T>(string value)
	{
		Type typeFromHandle = typeof(T);
		if (typeFromHandle == typeof(string))
		{
			return (T)(object)value;
		}
		if (value == null || ("null".Equals(value, StringComparison.Ordinal) && (!typeFromHandle.IsValueType || Nullable.GetUnderlyingType(typeFromHandle) != null)))
		{
			return default(T);
		}
		if ("infinity".Equals(value, StringComparison.Ordinal))
		{
			if (typeFromHandle == typeof(float) || typeFromHandle == typeof(float?))
			{
				return (T)(object)float.PositiveInfinity;
			}
			if (typeFromHandle == typeof(double) || typeFromHandle == typeof(double?))
			{
				return (T)(object)double.PositiveInfinity;
			}
			throw new NotSupportedException($"Infinity not supported for type {typeFromHandle.Name}");
		}
		if ("-infinity".Equals(value, StringComparison.Ordinal))
		{
			if (typeFromHandle == typeof(float))
			{
				return (T)(object)float.NegativeInfinity;
			}
			if (typeFromHandle == typeof(double))
			{
				return (T)(object)double.NegativeInfinity;
			}
			throw new NotSupportedException($"Infinity not supported for type {typeFromHandle.Name}");
		}
		if (typeFromHandle == typeof(char) || typeFromHandle == typeof(char?))
		{
			return (T)(object)char.Parse(value);
		}
		if (typeFromHandle == typeof(int) || typeFromHandle == typeof(int?))
		{
			return (T)(object)int.Parse(value, CultureInfo.InvariantCulture);
		}
		if (typeFromHandle == typeof(long) || typeFromHandle == typeof(long?))
		{
			return (T)(object)long.Parse(value, CultureInfo.InvariantCulture);
		}
		if (typeFromHandle == typeof(bool) || typeFromHandle == typeof(bool?))
		{
			return (T)(object)value.Equals("true", StringComparison.Ordinal);
		}
		if (typeFromHandle == typeof(DateTime) || typeFromHandle == typeof(DateTime?))
		{
			return (T)(object)XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.Utc);
		}
		if (typeFromHandle == typeof(double) || typeFromHandle == typeof(double?))
		{
			return (T)(object)double.Parse(value, CultureInfo.InvariantCulture);
		}
		if (typeFromHandle == typeof(float) || typeFromHandle == typeof(float?))
		{
			return (T)(object)float.Parse(value, CultureInfo.InvariantCulture);
		}
		if (typeFromHandle == typeof(decimal) || typeFromHandle == typeof(decimal?))
		{
			return (T)(object)decimal.Parse(value, CultureInfo.InvariantCulture);
		}
		Type type = Nullable.GetUnderlyingType(typeFromHandle) ?? typeFromHandle;
		if (type.IsEnum)
		{
			return (T)Enum.Parse(type, value);
		}
		throw new NotSupportedException($"Could not handle type {typeFromHandle.Name}");
	}

	public static XElementWithContext<TContext> With<TContext>(this XElement el, TContext context)
	{
		return new XElementWithContext<TContext>(el, context);
	}
}
