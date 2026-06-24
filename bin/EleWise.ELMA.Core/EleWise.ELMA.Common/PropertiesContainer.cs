using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;
using Newtonsoft.Json;

namespace EleWise.ELMA.Common;

public class PropertiesContainer
{
	private readonly IReactiveDictionary<string, object> container = new ReactiveDictionary<string, object>();

	public System.Collections.Generic.IEnumerable<string> GetProperties()
	{
		return (System.Collections.Generic.IEnumerable<string>)((IDictionary<string, object>)container).get_Keys();
	}

	public object GetPropValue(string propertyName)
	{
		object result = default(object);
		((IDictionary<string, object>)container).TryGetValue(propertyName, ref result);
		return result;
	}

	public void SetPropValue(string propertyName, object value)
	{
		((IDictionary<string, object>)container).set_Item(propertyName, value);
	}

	public void RemoveProperty(string propertyName)
	{
		if (((IDictionary<string, object>)container).ContainsKey(propertyName))
		{
			((IDictionary<string, object>)container).Remove(propertyName);
		}
	}

	public bool IsEmpty()
	{
		return ((System.Collections.Generic.ICollection<KeyValuePair<string, object>>)container).get_Count() == 0;
	}

	public bool TryGetValue<T>(string key, out T value)
	{
		object obj = default(object);
		if (((IDictionary<string, object>)container).TryGetValue(key, ref obj) && ((obj == null && default(T) == null) || obj is T))
		{
			value = (T)obj;
			return true;
		}
		value = default(T);
		return false;
	}

	[OnSerialized]
	public void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		raw.Value.SetAndCreatePlainPropertyValue("$type", base.GetType().get_FullName());
		System.Collections.Generic.IEnumerator<KeyValuePair<string, object>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, object>>)container).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				KeyValuePair<string, object> current = enumerator.get_Current();
				object obj = new object();
				obj.SetAndCreatePlainPropertyValue("$type", KnownTypesBinder.GetFullName(current.get_Value().GetType()));
				obj.SetAndCreatePlainPropertyValue("value", JsonConvert.SerializeObject(current.get_Value()));
				raw.Value.SetAndCreatePlainPropertyValue(current.get_Key(), obj);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	[OnDeserialized]
	public void OnDeserializedMethod(object raw)
	{
		string[] ownPropertyNames = object.GetOwnPropertyNames(raw);
		foreach (string text in ownPropertyNames)
		{
			if (!text.StartsWith("$"))
			{
				object plainPropertyValue = raw.GetPlainPropertyValue(text);
				System.Type type = System.Type.GetType(plainPropertyValue.GetPlainPropertyValue<string>("$type"));
				string plainPropertyValue2 = plainPropertyValue.GetPlainPropertyValue<string>("value");
				object obj = null;
				obj = ((!type.IsSimpleType() && (!type.IsNullableType() || !type.GetGenericArguments()[0].IsSimpleType())) ? JsonConvert.DeserializeObject(plainPropertyValue.GetPlainPropertyValue<string>("value"), type) : SerializationHelper.TryDeserializeSimpleType(type, plainPropertyValue2));
				((IDictionary<string, object>)container).Add(text, obj);
			}
		}
	}
}
