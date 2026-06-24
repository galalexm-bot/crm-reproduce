using System;
using System.Globalization;
using System.Xml;

namespace Orchard.ContentManagement.FieldStorage;

public class SimpleFieldStorage : IFieldStorage
{
	public Func<string, Type, string> Getter { get; set; }

	public Action<string, Type, string> Setter { get; set; }

	public SimpleFieldStorage(Func<string, Type, string> getter, Action<string, Type, string> setter)
	{
		Getter = getter;
		Setter = setter;
	}

	public T Get<T>(string name)
	{
		string text = Getter(name, typeof(T));
		if (string.IsNullOrEmpty(text))
		{
			return default(T);
		}
		Type type = typeof(T);
		if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			type = Nullable.GetUnderlyingType(type);
		}
		if (typeof(T) == typeof(DateTime))
		{
			return (T)(object)XmlConvert.ToDateTime(text, XmlDateTimeSerializationMode.Utc);
		}
		return (T)Convert.ChangeType(text, type, CultureInfo.InvariantCulture);
	}

	public void Set<T>(string name, T value)
	{
		if (typeof(T) == typeof(DateTime))
		{
			string arg = ((DateTime)(object)value).ToString("o", CultureInfo.InvariantCulture);
			Setter(name, typeof(T), arg);
		}
		else
		{
			Setter(name, typeof(T), Convert.ToString(value, CultureInfo.InvariantCulture));
		}
	}
}
