using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using Autofac;
using Autofac.Core;

namespace Orchard.Environment;

public class HostComponentsConfigModule : Module
{
	public static class XNames
	{
		public const string Xmlns = "";

		public static readonly XName HostComponents = XName.Get("HostComponents", "");

		public static readonly XName Components = XName.Get("Components", "");

		public static readonly XName Component = XName.Get("Component", "");

		public static readonly XName Properties = XName.Get("Properties", "");

		public static readonly XName Property = XName.Get("Property", "");

		public static readonly XName Type = XName.Get("Type");

		public static readonly XName Name = XName.Get("Name");

		public static readonly XName Value = XName.Get("Value");
	}

	public class PropertyEntry
	{
		public string Name { get; set; }

		public string Value { get; set; }
	}

	public static readonly IDictionary<string, IEnumerable<PropertyEntry>> _config = new Dictionary<string, IEnumerable<PropertyEntry>>();

	public HostComponentsConfigModule()
	{
	}

	public HostComponentsConfigModule(string fileName)
	{
		foreach (XElement item in XDocument.Load(fileName).Elements(XNames.HostComponents).Elements(XNames.Components)
			.Elements(XNames.Component))
		{
			string text = Attr(item, XNames.Type);
			if (text != null)
			{
				List<PropertyEntry> list = (from property in item.Elements(XNames.Properties).Elements(XNames.Property)
					select new PropertyEntry
					{
						Name = Attr(property, XNames.Name),
						Value = Attr(property, XNames.Value)
					} into t
					where !string.IsNullOrEmpty(t.Name) && !string.IsNullOrEmpty(t.Value)
					select t).ToList();
				if (list.Any())
				{
					_config[text] = list;
				}
			}
		}
	}

	private string Attr(XElement component, XName name)
	{
		return component.Attribute(name)?.Value;
	}

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		Type limitType = registration.get_Activator().get_LimitType();
		if (!_config.TryGetValue(limitType.FullName, out var value))
		{
			return;
		}
		Action<IComponentContext, object>[] injectors = BuildPropertiesInjectors(limitType, value).ToArray();
		if (!injectors.Any())
		{
			return;
		}
		registration.add_Activated((EventHandler<ActivatedEventArgs<object>>)delegate(object s, ActivatedEventArgs<object> e)
		{
			Action<IComponentContext, object>[] array = injectors;
			for (int i = 0; i < array.Length; i++)
			{
				array[i](e.get_Context(), e.get_Instance());
			}
		});
	}

	private IEnumerable<Action<IComponentContext, object>> BuildPropertiesInjectors(Type componentType, IEnumerable<PropertyEntry> properties)
	{
		var enumerable = from p in componentType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty)
			select new
			{
				PropertyInfo = p,
				IndexParameters = p.GetIndexParameters(),
				Accessors = p.GetAccessors(nonPublic: false),
				PropertyEntry = properties.FirstOrDefault((PropertyEntry t) => t.Name == p.Name)
			} into x
			where x.PropertyEntry != null
			where !x.IndexParameters.Any()
			where x.Accessors.Length != 1 || x.Accessors[0].ReturnType == typeof(void)
			select x;
		foreach (var item in enumerable)
		{
			PropertyInfo propertyInfo = item.PropertyInfo;
			PropertyEntry propertyEntry = item.PropertyEntry;
			yield return delegate(IComponentContext ctx, object instance)
			{
				if (ChangeToCompatibleType(propertyEntry.Value, propertyInfo.PropertyType, out var result))
				{
					propertyInfo.SetValue(instance, result, null);
				}
			};
		}
	}

	public static bool ChangeToCompatibleType(string value, Type destinationType, out object result)
	{
		if (string.IsNullOrEmpty(value))
		{
			result = null;
			return false;
		}
		if (destinationType.IsInstanceOfType(value))
		{
			result = value;
			return true;
		}
		try
		{
			result = TypeDescriptor.GetConverter(destinationType).ConvertFrom(value);
			return true;
		}
		catch
		{
			result = null;
			return false;
		}
	}
}
