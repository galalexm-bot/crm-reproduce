// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.FuncExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Concurrent;
using System.Threading;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Утилитные методы для оперирования нал функциями</summary>
  public static class FuncExtensions
  {
    /// <summary>Мемоизация функции однйо переменной</summary>
    /// <typeparam name="A"></typeparam>
    /// <typeparam name="R"></typeparam>
    /// <param name="f"></param>
    /// <returns></returns>
    public static Func<A, R> Memoize<A, R>(this Func<A, R> f)
    {
      ConcurrentDictionary<A, Lazy<R>> map = new ConcurrentDictionary<A, Lazy<R>>();
      return (Func<A, R>) (a =>
      {
        Lazy<R> lazy = new Lazy<R>((Func<R>) (() => f(a)), LazyThreadSafetyMode.ExecutionAndPublication);
        return !map.TryAdd(a, lazy) ? map[a].Value : lazy.Value;
      });
    }
  }
}
