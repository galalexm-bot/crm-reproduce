using System;
using System.Collections.Generic;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Extensions;

public static class ContextCacheExtensions
{
	public static TValue GetCacheData<TKey1, TValue>(string cacheKey, TKey1 key1, Func<TValue> value)
	{
		_003C_003Ec__DisplayClass0_0<TKey1, TValue> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0<TKey1, TValue>();
		CS_0024_003C_003E8__locals0.value = value;
		return ContextVars.GetOrAdd(cacheKey, () => new Dictionary<TKey1, TValue>()).AddIfNotContainsKey(key1, (TKey1 k) => CS_0024_003C_003E8__locals0.value());
	}

	public static TValue GetCacheData<TKey1, TKey2, TValue>(string cacheKey, TKey1 key1, TKey2 key2, Func<TValue> value)
	{
		_003C_003Ec__DisplayClass1_0<TKey1, TKey2, TValue> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0<TKey1, TKey2, TValue>();
		CS_0024_003C_003E8__locals0.value = value;
		return GetCacheData(cacheKey, key1, () => new Dictionary<TKey2, TValue>()).AddIfNotContainsKey(key2, (TKey2 k) => CS_0024_003C_003E8__locals0.value());
	}

	public static TValue GetCacheData<TKey1, TKey2, TKey3, TValue>(string cacheKey, TKey1 key1, TKey2 key2, TKey3 key3, Func<TValue> value)
	{
		_003C_003Ec__DisplayClass2_0<TKey1, TKey2, TKey3, TValue> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0<TKey1, TKey2, TKey3, TValue>();
		CS_0024_003C_003E8__locals0.value = value;
		return GetCacheData(cacheKey, key1, key2, () => new Dictionary<TKey3, TValue>()).AddIfNotContainsKey(key3, (TKey3 k) => CS_0024_003C_003E8__locals0.value());
	}

	public static TValue GetCacheData<TKey1, TKey2, TKey3, TKey4, TValue>(string cacheKey, TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, Func<TValue> value)
	{
		_003C_003Ec__DisplayClass3_0<TKey1, TKey2, TKey3, TKey4, TValue> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0<TKey1, TKey2, TKey3, TKey4, TValue>();
		CS_0024_003C_003E8__locals0.value = value;
		return GetCacheData(cacheKey, key1, key2, key3, () => new Dictionary<TKey4, TValue>()).AddIfNotContainsKey(key4, (TKey4 k) => CS_0024_003C_003E8__locals0.value());
	}
}
