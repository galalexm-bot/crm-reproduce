// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ContextCacheExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Extensions
{
  public static class ContextCacheExtensions
  {
    public static TValue GetCacheData<TKey1, TValue>(
      string cacheKey,
      TKey1 key1,
      Func<TValue> value)
    {
      return ContextVars.GetOrAdd<Dictionary<TKey1, TValue>>(cacheKey, (Func<Dictionary<TKey1, TValue>>) (() => new Dictionary<TKey1, TValue>())).AddIfNotContainsKey<TKey1, TValue>(key1, (Func<TKey1, TValue>) (k => value()));
    }

    public static TValue GetCacheData<TKey1, TKey2, TValue>(
      string cacheKey,
      TKey1 key1,
      TKey2 key2,
      Func<TValue> value)
    {
      return ContextCacheExtensions.GetCacheData<TKey1, Dictionary<TKey2, TValue>>(cacheKey, key1, (Func<Dictionary<TKey2, TValue>>) (() => new Dictionary<TKey2, TValue>())).AddIfNotContainsKey<TKey2, TValue>(key2, (Func<TKey2, TValue>) (k => value()));
    }

    public static TValue GetCacheData<TKey1, TKey2, TKey3, TValue>(
      string cacheKey,
      TKey1 key1,
      TKey2 key2,
      TKey3 key3,
      Func<TValue> value)
    {
      return ContextCacheExtensions.GetCacheData<TKey1, TKey2, Dictionary<TKey3, TValue>>(cacheKey, key1, key2, (Func<Dictionary<TKey3, TValue>>) (() => new Dictionary<TKey3, TValue>())).AddIfNotContainsKey<TKey3, TValue>(key3, (Func<TKey3, TValue>) (k => value()));
    }

    public static TValue GetCacheData<TKey1, TKey2, TKey3, TKey4, TValue>(
      string cacheKey,
      TKey1 key1,
      TKey2 key2,
      TKey3 key3,
      TKey4 key4,
      Func<TValue> value)
    {
      return ContextCacheExtensions.GetCacheData<TKey1, TKey2, TKey3, Dictionary<TKey4, TValue>>(cacheKey, key1, key2, key3, (Func<Dictionary<TKey4, TValue>>) (() => new Dictionary<TKey4, TValue>())).AddIfNotContainsKey<TKey4, TValue>(key4, (Func<TKey4, TValue>) (k => value()));
    }
  }
}
