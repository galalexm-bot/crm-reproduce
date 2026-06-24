using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EleWise.ELMA.Core.Serialization;

public static class SerializationHelper
{
	public static string SerializeObjectByJson(object obj)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return SerializationHelper.SerializeObjectByJson(obj, new JsonSerializerSettings());
	}

	public static string SerializeObjectByJson(object obj, Formatting formatting)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return SerializeObjectByJson(obj, formatting, new JsonSerializerSettings());
	}

	public static string SerializeObjectByJson(object obj, JsonSerializerSettings settings)
	{
		return SerializeObjectByJson(obj, (Formatting)0, settings);
	}

	public static string SerializeObjectByJson(object obj, Formatting formatting, JsonSerializerSettings settings)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (settings == null)
		{
			settings = new JsonSerializerSettings();
		}
		return JsonConvert.SerializeObject(obj, formatting, settings);
	}

	public static T DeserializeObjectFromJson<T>(string obj)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return DeserializeObjectFromJson<T>(obj, new JsonSerializerSettings());
	}

	public static T DeserializeObjectFromJson<T>(string obj, JsonSerializerSettings settings)
	{
		return (T)DeserializeObjectFromJson(obj, typeof(T), settings);
	}

	public static object DeserializeObjectFromJson(string obj, System.Type type)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return DeserializeObjectFromJson(obj, type, new JsonSerializerSettings());
	}

	public static object DeserializeObjectFromJson(string obj, System.Type type, JsonSerializerSettings settings)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		if (settings == null)
		{
			settings = new JsonSerializerSettings();
		}
		return JsonConvert.DeserializeObject(obj, type, settings);
	}

	public static object CloneObject(object obj)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		JsonSerializerSettings val = new JsonSerializerSettings();
		val.set_TypeNameHandling((TypeNameHandling)1);
		val.set_SerializationBinder((ISerializationBinder)(object)new KnownTypesBinder());
		JsonSerializerSettings settings = val;
		if (obj != null)
		{
			return DeserializeObjectFromJson(SerializeObjectByJson(obj, settings), obj.GetType(), settings);
		}
		return null;
	}

	public static T CloneObject<T>(T obj)
	{
		if (object.Equals((object)obj, (object)default(T)))
		{
			return default(T);
		}
		return (T)CloneObject((object)obj);
	}

	internal static object TryDeserializeSimpleType(System.Type simpleType, string json)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		System.Type type = simpleType;
		if (type.IsNullableType())
		{
			type = type.GetGenericArguments()[0];
			if (json == "null")
			{
				return null;
			}
		}
		object obj = null;
		if (type == typeof(Guid))
		{
			obj = Guid.Parse(json);
		}
		else if (type == typeof(bool))
		{
			obj = bool.Parse(json);
		}
		else if (type == typeof(short))
		{
			obj = short.Parse(json);
		}
		else if (type == typeof(int))
		{
			obj = int.Parse(json);
		}
		else if (type == typeof(long))
		{
			obj = long.Parse(json);
		}
		else if (type == typeof(float))
		{
			obj = float.Parse(json);
		}
		else if (type == typeof(double))
		{
			obj = double.Parse(json);
		}
		else if (type == typeof(decimal))
		{
			obj = decimal.Parse(json);
		}
		else if (type == typeof(char))
		{
			obj = char.Parse(json);
		}
		else if (type == typeof(byte))
		{
			obj = byte.Parse(json);
		}
		else if (type == typeof(string))
		{
			obj = json;
		}
		throw new SerializationException();
	}
}
