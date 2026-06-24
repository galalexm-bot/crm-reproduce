using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[Service]
public class BoundVariableService : IBoundVariableService
{
	private readonly IDictionary<string, object> dictionary;

	public BoundVariableService()
	{
		dictionary = (IDictionary<string, object>)(object)new Dictionary<string, object>();
	}

	public virtual bool Contains(string name)
	{
		return dictionary.ContainsKey(name);
	}

	public virtual T Get<T>(string name)
	{
		object obj = default(object);
		if (!dictionary.TryGetValue(name, ref obj))
		{
			return default(T);
		}
		return (T)obj;
	}

	public virtual bool TryGetValue<T>(string name, out T value)
	{
		object obj = default(object);
		if (dictionary.TryGetValue(name, ref obj))
		{
			value = (T)obj;
			return true;
		}
		value = default(T);
		return false;
	}

	public virtual void Set(string name, object value)
	{
		dictionary.set_Item(name, value);
	}

	public virtual void Remove(string key)
	{
		dictionary.Remove(key);
	}

	public virtual void Clear()
	{
		((System.Collections.Generic.ICollection<KeyValuePair<string, object>>)dictionary).Clear();
	}
}
