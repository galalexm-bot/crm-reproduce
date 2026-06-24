// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.MetricsHelper`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Хелпер для работы с метриками</summary>
  public static class MetricsHelper<T>
  {
    /// <summary>Получить отображаемое имя метрики</summary>
    /// <param name="f">Выражение доступа</param>
    /// <returns></returns>
    public static string GetDisplayName<TValue>(Expression<Func<T, TValue>> f)
    {
      DisplayNameAttribute attribute = AttributeHelper<DisplayNameAttribute>.GetAttribute(LinqUtils.MemberOf<T, TValue>(f), true);
      return attribute == null ? LinqUtils.NameOf<T, TValue>(f) : attribute.Value;
    }

    /// <summary>Получить порядок метрики</summary>
    /// <param name="f">Выражение доступа</param>
    /// <returns></returns>
    public static long GetOrder<TValue>(Expression<Func<T, TValue>> f)
    {
      OrderAttribute attribute = AttributeHelper<OrderAttribute>.GetAttribute(LinqUtils.MemberOf<T, TValue>(f), true);
      return attribute != null ? (long) attribute.Order : 0L;
    }
  }
}
