using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using Orchard.ContentManagement.FieldStorage.InfosetStorage;
using Orchard.ContentManagement.Records;
using Orchard.Utility;

namespace Orchard.ContentManagement;

public static class InfosetHelper
{
	public static TProperty Retrieve<TPart, TProperty>(this TPart contentPart, Expression<Func<TPart, TProperty>> targetExpression, Func<TProperty> defaultValue, bool versioned = false) where TPart : ContentPart
	{
		string name = ReflectionHelper<TPart>.GetPropertyInfo(targetExpression).Name;
		InfosetPart infosetPart = contentPart.As<InfosetPart>();
		XAttribute xAttribute = ((infosetPart == null) ? null : (versioned ? infosetPart.VersionInfoset.Element : infosetPart.Infoset.Element).Element(contentPart.GetType().Name))?.Attribute(name);
		if (xAttribute != null)
		{
			return XmlHelper.Parse<TProperty>(xAttribute.Value);
		}
		if (defaultValue == null)
		{
			return default(TProperty);
		}
		return defaultValue();
	}

	public static TProperty Retrieve<TPart, TProperty>(this TPart contentPart, Expression<Func<TPart, TProperty>> targetExpression, TProperty defaultValue = default(TProperty), bool versioned = false) where TPart : ContentPart
	{
		return contentPart.Retrieve(targetExpression, () => defaultValue, versioned);
	}

	public static TProperty Retrieve<TProperty>(this ContentPart contentPart, string name, bool versioned = false)
	{
		InfosetPart infosetPart = contentPart.As<InfosetPart>();
		XElement xElement = ((infosetPart == null) ? null : (versioned ? infosetPart.VersionInfoset.Element : infosetPart.Infoset.Element).Element(contentPart.GetType().Name));
		if (xElement != null)
		{
			return xElement.Attr<TProperty>(name);
		}
		return default(TProperty);
	}

	public static TProperty Retrieve<TPart, TRecord, TProperty>(this TPart contentPart, Expression<Func<TRecord, TProperty>> targetExpression) where TPart : ContentPart<TRecord>
	{
		ReflectionHelper<TRecord>.PropertyGetterDelegate<TProperty> getter = ReflectionHelper<TRecord>.GetGetter(targetExpression);
		return contentPart.Retrieve(targetExpression, getter);
	}

	public static TProperty Retrieve<TPart, TRecord, TProperty>(this TPart contentPart, Expression<Func<TRecord, TProperty>> targetExpression, Delegate defaultExpression) where TPart : ContentPart<TRecord>
	{
		string name = ReflectionHelper<TRecord>.GetPropertyInfo(targetExpression).Name;
		InfosetPart infosetPart = contentPart.As<InfosetPart>();
		bool flag = typeof(ContentPartVersionRecord).IsAssignableFrom(typeof(TRecord));
		if (infosetPart == null)
		{
			TProperty val = (((object)defaultExpression == null) ? default(TProperty) : ((TProperty)defaultExpression.DynamicInvoke(contentPart.Record)));
			contentPart.Store(name, val, flag);
			return val;
		}
		XElement xElement = (flag ? infosetPart.VersionInfoset.Element : infosetPart.Infoset.Element).Element(contentPart.GetType().Name);
		if (xElement == null || xElement.Attribute(name) == null)
		{
			TProperty val2 = (((object)defaultExpression == null) ? default(TProperty) : ((TProperty)defaultExpression.DynamicInvoke(contentPart.Record)));
			contentPart.Store(name, val2, flag);
			return val2;
		}
		return xElement.Attr<TProperty>(name);
	}

	public static void Store<TPart, TProperty>(this TPart contentPart, Expression<Func<TPart, TProperty>> targetExpression, TProperty value, bool versioned = false) where TPart : ContentPart
	{
		string name = contentPart.GetType().Name;
		InfosetPart infosetPart = contentPart.As<InfosetPart>();
		string name2 = ReflectionHelper<TPart>.GetPropertyInfo(targetExpression).Name;
		infosetPart.Store(name, name2, value, versioned);
	}

	public static void Store<TProperty>(this ContentPart contentPart, string name, TProperty value, bool versioned = false)
	{
		string name2 = contentPart.GetType().Name;
		contentPart.As<InfosetPart>().Store(name2, name, value, versioned);
	}

	public static void Store<TProperty>(this InfosetPart infosetPart, string partName, string name, TProperty value, bool versioned = false)
	{
		Infoset infoset = (versioned ? infosetPart.VersionInfoset : infosetPart.Infoset);
		XElement xElement = infoset.Element.Element(partName);
		if (xElement == null)
		{
			xElement = new XElement(partName);
			infoset.Element.Add(xElement);
		}
		xElement.Attr(name, value);
	}

	public static void Store<TPart, TRecord, TProperty>(this TPart contentPart, Expression<Func<TRecord, TProperty>> targetExpression, TProperty value) where TPart : ContentPart<TRecord>
	{
		PropertyInfo propertyInfo = ReflectionHelper<TRecord>.GetPropertyInfo(targetExpression);
		string name = propertyInfo.Name;
		bool versioned = typeof(ContentPartVersionRecord).IsAssignableFrom(typeof(TRecord));
		propertyInfo.SetValue(contentPart.Record, value, null);
		contentPart.Store(name, value, versioned);
	}
}
