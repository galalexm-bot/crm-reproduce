using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Extensions;

public static class DictionaryExtensions
{
	public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
	{
		if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary)
		{
			return concurrentDictionary.AddOrUpdate(key, addValue, updateValueFactory);
		}
		if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
		{
			return concurrentDictionary2.AddOrUpdate(key, addValue, updateValueFactory);
		}
		TValue value = ((!dictionary.TryGetValue(key, out value)) ? addValue : updateValueFactory(key, value));
		return dictionary[key] = value;
	}

	public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
	{
		if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary)
		{
			return concurrentDictionary.AddOrUpdate(key, addValueFactory, updateValueFactory);
		}
		if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
		{
			return concurrentDictionary2.AddOrUpdate(key, addValueFactory, updateValueFactory);
		}
		TValue value = ((!dictionary.TryGetValue(key, out value)) ? addValueFactory(key) : updateValueFactory(key, value));
		return dictionary[key] = value;
	}

	public static TValue AddOrUpdate<TKey, TValue, TArg>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TArg, TValue> addValueFactory, Func<TKey, TValue, TArg, TValue> updateValueFactory, TArg factoryArgument)
	{
		if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary)
		{
			return concurrentDictionary.AddOrUpdate(key, addValueFactory, updateValueFactory, factoryArgument);
		}
		if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
		{
			return concurrentDictionary2.AddOrUpdate(key, addValueFactory, updateValueFactory, factoryArgument);
		}
		TValue value = ((!dictionary.TryGetValue(key, out value)) ? addValueFactory(key, factoryArgument) : updateValueFactory(key, value, factoryArgument));
		return dictionary[key] = value;
	}

	public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue newValue)
	{
		if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary)
		{
			return concurrentDictionary.GetOrAdd(key, newValue);
		}
		if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
		{
			return concurrentDictionary2.GetOrAdd(key, newValue);
		}
		if (!dictionary.TryGetValue(key, out var value))
		{
			value = (dictionary[key] = newValue);
		}
		return value;
	}

	public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> valueFactory)
	{
		if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary)
		{
			return concurrentDictionary.GetOrAdd(key, valueFactory);
		}
		if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
		{
			return concurrentDictionary2.GetOrAdd(key, valueFactory);
		}
		if (!dictionary.TryGetValue(key, out var value))
		{
			value = (dictionary[key] = valueFactory(key));
		}
		return value;
	}

	public static TValue GetOrAdd<TKey, TValue, TArg>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument)
	{
		if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary)
		{
			return concurrentDictionary.GetOrAdd(key, valueFactory, factoryArgument);
		}
		if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
		{
			return concurrentDictionary2.GetOrAdd(key, valueFactory, factoryArgument);
		}
		if (!dictionary.TryGetValue(key, out var value))
		{
			value = (dictionary[key] = valueFactory(key, factoryArgument));
		}
		return value;
	}

	public static bool TryUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue newValue, TValue comparisonValue)
	{
		if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary)
		{
			return concurrentDictionary.TryUpdate(key, newValue, comparisonValue);
		}
		if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
		{
			return concurrentDictionary2.TryUpdate(key, newValue, comparisonValue);
		}
		if (dictionary.TryGetValue(key, out var value) && ((object)comparisonValue == (object)value || (comparisonValue != null && comparisonValue.Equals(value))))
		{
			dictionary[key] = newValue;
			return true;
		}
		return false;
	}
}
