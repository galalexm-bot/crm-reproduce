using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Orchard.Data.Bags;

public class SConvert
{
	public static ISItem ToSettings(object o)
	{
		if (o is SValue)
		{
			return (ISItem)o;
		}
		if (o is Bag)
		{
			return (ISItem)o;
		}
		if (o is SArray)
		{
			return (ISItem)o;
		}
		if (o is Array)
		{
			return new SArray((Array)o);
		}
		if (IsAnonymousType(o.GetType()))
		{
			dynamic val = new Bag();
			PropertyInfo[] properties = o.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				val[propertyInfo.Name] = propertyInfo.GetValue(o, null);
			}
			return val;
		}
		return new SValue(o);
	}

	public static object ToObject(object s)
	{
		if (s is SValue)
		{
			return ((SValue)s).Value;
		}
		if (s is SArray)
		{
			SArray sArray = (SArray)s;
			object[] array = new object[sArray.Values.Length];
			for (int i = 0; i < sArray.Values.Length; i++)
			{
				array[i] = ToObject(sArray.Values[i]);
			}
			return array;
		}
		return s;
	}

	private static bool IsAnonymousType(Type type)
	{
		if (Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), inherit: false) && type.IsGenericType && type.Name.Contains("AnonymousType"))
		{
			return (type.Attributes & TypeAttributes.NotPublic) == 0;
		}
		return false;
	}

	public static string XmlEncode(object value)
	{
		switch (Type.GetTypeCode(value.GetType()))
		{
		case TypeCode.Boolean:
		case TypeCode.Char:
		case TypeCode.String:
			return value.ToString();
		case TypeCode.SByte:
		case TypeCode.Byte:
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Int64:
		case TypeCode.UInt64:
		case TypeCode.Single:
		case TypeCode.Double:
		case TypeCode.Decimal:
			return Convert.ToDecimal(value).ToString(CultureInfo.InvariantCulture);
		case TypeCode.DateTime:
			return XmlConvert.ToString((DateTime)value, XmlDateTimeSerializationMode.Utc);
		default:
			throw new NotSupportedException("Could not encode member");
		}
	}

	public static SValue XmlDecode(TypeCode typeCode, string value)
	{
		return typeCode switch
		{
			TypeCode.Boolean => new SValue(bool.Parse(value)), 
			TypeCode.Byte => new SValue(byte.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.Decimal => new SValue(decimal.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.Double => new SValue(double.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.Int16 => new SValue(short.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.Int32 => new SValue(int.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.Int64 => new SValue(long.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.SByte => new SValue(sbyte.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.Single => new SValue(float.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.UInt16 => new SValue(ushort.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.UInt32 => new SValue(uint.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.UInt64 => new SValue(ulong.Parse(value, CultureInfo.InvariantCulture)), 
			TypeCode.Char => new SValue(value[1]), 
			TypeCode.String => new SValue(value), 
			TypeCode.DateTime => new SValue(XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.Utc)), 
			_ => throw new NotSupportedException("Could not decode member"), 
		};
	}
}
